using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9
{
    public partial class Program9lab : Form
    {
        public List<ClassFiles> classFiles = new List<ClassFiles>();

        public Program9lab()
        {
            InitializeComponent();
            ButDelDub.Enabled = false;
            ButSortDay.Enabled = false;
            ButPathWater.Enabled = false;
            ButAutoPathWater.Enabled = false;
            ButPicWater.Enabled = false;
            ButSave.Enabled = false;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox1.Items.Add("По дням");
            comboBox1.Items.Add("По неделям");
            comboBox1.Items.Add("По месяцам");
            comboBox2.Items.Add("Наименование файла + размер файла");
            comboBox2.Items.Add("Наименование файла + дата создания");
            comboBox2.Items.Add("По содержимому (побайтовое сравнение)");
            comboBox2.Items.Add("По хэшу рассчитанному от их содержания");
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            ToolTip pathauto1 = new ToolTip();
            ToolTip pathauto2 = new ToolTip();
            ToolTip pathauto3 = new ToolTip();
            ToolTip pathauto4 = new ToolTip();
            ToolTip pathauto5 = new ToolTip();
            pathauto1.SetToolTip(AutoButPath, "Последний использованый путь");
            pathauto2.SetToolTip(ButPathAutoPic, "Последний использованый путь");
            pathauto3.SetToolTip(ButAutoPathWater, "Последний использованый путь");
            pathauto4.SetToolTip(ButFont, "Выбор FONT(Шрифта) для Watermark");
            pathauto5.SetToolTip(ButColor, "Выбор COLOR(Цвета шрифта) для Watermark");
        }
        string path { get; set; }
        string pathpic { get; set; }
        string pathwater { get; set; }
        List<string> lines = File.ReadAllLines(@"save.txt").ToList(); // для сохр последнего пути, находится в lab9/bin/debug

        private void ButPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();


            if (fbd.ShowDialog() == DialogResult.OK)
            {
                path = fbd.SelectedPath;
                TBPath.Text = fbd.SelectedPath;

                lines.RemoveRange(1, 1);
                lines.Insert(1, fbd.SelectedPath);
                File.WriteAllLines(@"save.txt", lines);
                Zaponitel();
                DeleteZeroFolder(path);
                ButDelDub.Enabled = true;
                ButSortDay.Enabled = true;
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
            }


        }


        public void Zaponitel()
        {
            DirectoryInfo dir = new DirectoryInfo($"{path}");
            classFiles.Clear();

            foreach (FileInfo file in dir.GetFiles("*.*", SearchOption.AllDirectories))
            {
                // Правильная по заданию версия classFiles.Add(new ClassFiles(file.Length * 8, Path.GetFileNameWithoutExtension(file.Name), file.FullName, file.CreationTime.Day, file.Name, file.Extension,$"{file.CreationTime.DayOfWeek}",file.CreationTime.Month,file.CreationTime));
                classFiles.Add(new ClassFiles(file.Length * 8,
                    Path.GetFileNameWithoutExtension(file.Name),
                    file.FullName,
                    file.LastWriteTime.Day,
                    file.Name,
                    file.Extension,
                    $"{file.LastWriteTime.DayOfWeek}",
                    file.LastWriteTime.Month,
                    file.LastWriteTime
                    ));
                // удобная для тестов
            }
            TBInfo.Text = $" Количество файлов: {classFiles.Count}";
        }
        private void AutoButPath_Click(object sender, EventArgs e)
        {

            path = lines[1];
            TBPath.Text = path;
            ButDelDub.Enabled = true;
            ButSortDay.Enabled = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;

            Zaponitel();
            DeleteZeroFolder(path);

        }

        public void DelDubByNameAndSize()
        {
            for (int i = 0; i < classFiles.Count; i++)
            {
                string fileName = classFiles[i].filename;
                Regex check = new Regex(@"(?<Name>.+) (?<Num>\([0-9]+\))");
                List<ClassFiles> found1 = classFiles.FindAll(file => file.filename == fileName);
                for (int j = 0; j < found1.Count; j++)
                {
                    if (found1[j].path != classFiles[i].path)
                    {
                        if (found1[j].lenght == classFiles[i].lenght)
                        {
                            listBox1.Items.Add($"Файл с названием: {classFiles[i].filename} и размеров: {classFiles[i].lenght} был удален");
                            File.Delete(classFiles[i].path);
                            classFiles.Remove(classFiles[i]);
                            i = -1;
                        }
                    }
                }

                if (check.IsMatch(fileName))
                {
                    Match checkm = check.Match(fileName);
                    ClassFiles found = classFiles.Find(file => file.filename == $"{checkm.Groups["Name"]}");
                    if (found != null)
                    {
                        if (found.lenght == classFiles[i].lenght)
                        {
                            listBox1.Items.Add($"Файл с названием: {classFiles[i].filename} и размеров: {classFiles[i].lenght} был удален");
                            File.Delete(classFiles[i].path);
                            classFiles.Remove(classFiles[i]);
                            i = -1;
                        }
                    }
                }
            }
        }
        public void DelDubByNameAndDate()
        {
            for (int i = 0; i < classFiles.Count; i++)
            {
                string fileName = classFiles[i].filename;
                Regex check = new Regex(@"(?<Name>.+) (?<Num>\([0-9]+\))");
                List<ClassFiles> found1 = classFiles.FindAll(file => file.filename == fileName);
                for (int j = 0; j < found1.Count; j++)
                {
                    if (found1[j].path != classFiles[i].path)
                    {
                        string f = found1[j].fulldate.ToShortDateString();
                        string c = classFiles[i].fulldate.ToShortDateString();
                        if (f == c)
                        {
                            listBox1.Items.Add($"Файл с названием: {classFiles[i].filename} и датой: {c} был удален");
                            File.Delete(classFiles[i].path);
                            classFiles.Remove(classFiles[i]);
                            i = -1;
                        }
                    }
                }

                if (check.IsMatch(fileName))
                {
                    Match checkm = check.Match(fileName);
                    ClassFiles found = classFiles.Find(file => file.filename == $"{checkm.Groups["Name"]}");
                    if (found != null)
                    {
                        string f = found.fulldate.ToShortDateString();
                        string c = classFiles[i].fulldate.ToShortDateString();
                        if (f == c)
                        {
                            listBox1.Items.Add($"Файл с названием: {classFiles[i].filename} и датой: {c} был удален");
                            File.Delete(classFiles[i].path);
                            classFiles.Remove(classFiles[i]);
                            i = -1;
                        }
                    }
                }
            }
        }
        public void DelDubByBytes()
        {
           
            for (int i = 0; i < classFiles.Count; i++)
            {
                byte[] bytearr = new byte[classFiles[i].bytearr.Length];
                bytearr = classFiles[i].bytearr;
                //classFiles.Add(classFiles[i]);
                List<ClassFiles> found = classFiles.FindAll(file => file.bytearr == bytearr);
                for (int j = 0; j < found.Count; j++)
                {
                    
                    if (found[j].path != classFiles[i].path)
                    {
                        listBox1.Items.Add($"Файл с названием: {classFiles[i].filename} был удален");
                        File.Delete(classFiles[i].path);
                        classFiles.Remove(classFiles[i]);
                        i = -1;
                    }
                }
            }
                // Почему то переменная found всегда 1, хотя когда есть копия то дожен быть 2. Такая же лямбда исп. в 2 предыдущих методах
                // и там почему то всё работает, проверял даже с файлами где массив битов имеет лишь 1 элемент и даже при условии что они индентичны, всё равно 
                // found = 1. Он в листе classFiles находит только сам себя, а точную копию не видет, если бы он и себя не находил, то я бы понял в чём дело...

            }
        private void ButDelDub_Click(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    DelDubByNameAndSize();
                    break;
                case 1:
                    DelDubByNameAndDate();
                    break;
                case 2:
                    DelDubByBytes();
                    break;
                default:
                    MessageBox.Show("Не выбран метод удаления дупликатов");
                    break;
            }

        }
        public static string CreateNewPathAndFolder(string path, string filtr, ListBox listBox1)
        {
            string newpath = Path.Combine(path, $"{ filtr}");
            if (!Directory.Exists(newpath))
            {
                DirectoryInfo newdir = new DirectoryInfo(newpath);
                newdir.Create();
                listBox1.Items.Add($"Былла солздана папка с названием {filtr}");
            }
            return newpath;
        }
        public static void DeleteZeroFolder(string path)
        {
            string[] dirs = Directory.EnumerateDirectories(path, "*", SearchOption.AllDirectories).ToArray();

            for (int i = dirs.Length - 1; i >= 0; i--)
            {
                if (Directory.EnumerateFileSystemEntries(dirs[i]).Count() == 0)
                    Directory.Delete(dirs[i]);
            }
        }
        //Кнопка сортировки
        private void ButSortDay_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < classFiles.Count; i++)
            {
                string newpath = "";
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        newpath = CreateNewPathAndFolder(path, $"{classFiles[i].day}", listBox1);
                        break;
                    case 1:
                        newpath = CreateNewPathAndFolder(path, classFiles[i].week, listBox1);
                        break;
                    case 2:
                        newpath = CreateNewPathAndFolder(path, $"{classFiles[i].month}", listBox1);
                        break;
                }


                try
                {
                    File.Move(classFiles[i].path, Path.Combine(newpath, classFiles[i].filename_));
                    classFiles[i].path = Path.Combine(newpath, classFiles[i].filename_);
                    listBox1.Items.Add($"Был перенесен файл с названием: {classFiles[i].filename} в папку {classFiles[i].day}");
                }
                catch (Exception)
                {
                    File.Move(classFiles[i].path, $"{Path.Combine(newpath, classFiles[i].filename)}{i}{classFiles[i].extension}");
                    classFiles[i].path = $"{Path.Combine(newpath, classFiles[i].filename)}{i}{classFiles[i].extension}";
                    listBox1.Items.Add($"Был перенесен файл с названием: {classFiles[i].filename} + 1 в папку {classFiles[i].day}");
                }
                DeleteZeroFolder(path);

            }


        }

        private void MainProgram_Load(object sender, EventArgs e)
        {
            this.Width = 739; // 739; 672
            this.Height = 758;
            panel1.Visible = false;
        }

        private void ButWMM_Click(object sender, EventArgs e)
        {
            switch (this.Size.Width)
            {
                case 739:
                    this.Width = 1234;
                    panel1.Visible = true;
                    break;
                case 1234:
                    this.Width = 739;
                    panel1.Visible = false;
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MetaDatas meta = new MetaDatas();
            meta.classFiles = classFiles;
            meta.ShowDialog();
        }
        // Метод кнопки выбора пути до картинки
        private void ButPathPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();

            if (op.ShowDialog() == DialogResult.OK)
            {
                pathpic = op.FileName;

                TBPathPic.Text = op.FileName;
                lines.RemoveRange(2, 1);
                lines.Insert(2, op.FileName);
                File.WriteAllLines(@"save.txt", lines);
                Image image = Image.FromFile(pathpic);
                pictureBox1.Image = image;
               // ButPathWater.Enabled = true;
               // ButAutoPathWater.Enabled = true;
                RadioWaterPic.Enabled = true;
                RadioWaterText.Enabled = true;
            }
        }
        // Метод выбора картинки по сохр. пути в save.txt
        private void ButPathAutoPic_Click(object sender, EventArgs e)
        {

            pathpic = lines[2];
            TBPathPic.Text = pathpic;
            Image image = Image.FromFile(pathpic);
            pictureBox1.Image = image;
          //  ButPathWater.Enabled = true;
          //  ButAutoPathWater.Enabled = true;
            RadioWaterPic.Enabled = true;
            RadioWaterText.Enabled = true;

        }
        // Метод кнопки выбора пути до Watermark
        private void ButPathWater_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();

            if (op.ShowDialog() == DialogResult.OK)
            {
                pathwater = op.FileName;
                TBPathWater.Text = op.FileName;
                lines.RemoveRange(3, 1);
                lines.Insert(3, op.FileName);
                File.WriteAllLines(@"save.txt", lines);
                ButPicWater.Enabled = true;
                ButSave.Enabled = true;
                Image image = Image.FromFile(pathpic);
                Graphics imageGraphics = Graphics.FromImage(image);
                Image watermarkImage = Image.FromFile(pathwater);
                Brush watermarkBrush = new TextureBrush(watermarkImage);

                imageGraphics.FillRectangle(watermarkBrush, new Rectangle(new Point(0, 0), image.Size));
                pictureBox1.Image = image;


            }
        }
        // Метод выбора Watermark по сохр. пути в save.txt
        private void ButAutoPathWater_Click(object sender, EventArgs e)
        {
            pathwater = lines[3];
            TBPathWater.Text = pathwater;
            ButPicWater.Enabled = true;
            ButSave.Enabled = true;
            Image image = Image.FromFile(pathpic);
            Image watermarkImage = Image.FromFile(pathwater);
            Graphics imageGraphics = Graphics.FromImage(image);
            Brush watermarkBrush = new TextureBrush(watermarkImage);

            imageGraphics.FillRectangle(watermarkBrush, new Rectangle(new Point(0, 0), image.Size));

            pictureBox1.Image = image;

        }
        // Метод кнопки для сохранения в опр. папку итога
        private void ButSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text documents (.png)|*.png";

            if (save.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(save.FileName);
            }


        }
        // Метод кнопки сохр. итога в папку где была картинка
        private void ButPicWater_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Save(Path.Combine(Path.GetDirectoryName(pathpic), Path.GetFileNameWithoutExtension(pathpic) + "new.png"));
        }
        // этот метод взял из интернета, но суть  его работы я в принципе понимаю
        private Image DrawText(String text, Font font, Color textColor)
        {
            //first, create a dummy bitmap just to get a graphics object
            Image img = new Bitmap(1, 1);
            Graphics drawing = Graphics.FromImage(img);

            //measure the string to see how big the image needs to be
            SizeF textSize = drawing.MeasureString(text, font);

            //free up the dummy image and old graphics object
            img.Dispose();
            drawing.Dispose();

            //create a new image of the right size
            img = new Bitmap((int)textSize.Width, (int)textSize.Height);

            drawing = Graphics.FromImage(img);

            //paint the background
            drawing.Clear(Color.FromArgb(0, Color.Black));

            //create a brush for the text
            Brush textBrush = new SolidBrush(textColor);

            drawing.DrawString(text, font, textBrush, 0, 0);

            drawing.Save();

            textBrush.Dispose();
            drawing.Dispose();

            return img;

        }
        public Font selectfont = new Font("Arial", 100);
        public Color selectfontcolor = Color.Black;
        private void TBWaterText_TextChanged(object sender, EventArgs e)
        {
            ButPicWater.Enabled = true;
            ButSave.Enabled = true;
           
            if (TBWaterText.Text != string.Empty)
            {
                Image image = Image.FromFile(pathpic);
                Image watermarkImage = DrawText(((TextBox)sender).Text, selectfont, selectfontcolor);
                Graphics imageGraphics = Graphics.FromImage(image);
                Brush watermarkBrush = new TextureBrush(watermarkImage);

                imageGraphics.FillRectangle(watermarkBrush, new Rectangle(new Point(0, 0), image.Size));
                pictureBox1.Image = image;
            }
            else 
            {
                Image image = Image.FromFile(pathpic);
                pictureBox1.Image = image;
            }
            
        }

        private void RadioWaterPic_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioWaterPic.Checked == true)
            {
                TBPathWater.Enabled = true;
                ButPathWater.Enabled = true;
                ButAutoPathWater.Enabled = true;
                TBWaterText.Enabled = false;
                ButFont.Enabled = false;
                ButColor.Enabled = false;
                Image image = Image.FromFile(pathpic);
                TBWaterText.Text = "";
                pictureBox1.Image = image;
                
            }
        }

        private void RadioWaterText_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioWaterText.Checked == true)
            {
                TBWaterText.Enabled = true;
                ButFont.Enabled = true;
                ButColor.Enabled = true;
                TBPathWater.Enabled = false;
                ButPathWater.Enabled = false;
                ButAutoPathWater.Enabled = false;
                TBPathWater.Text = string.Empty;
                Image image = Image.FromFile(pathpic);
                pictureBox1.Image = image;
            }
        }

        private void ButFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            selectfont = fontDialog1.Font;
            if (TBWaterText.Text != string.Empty)
            {
                Image image = Image.FromFile(pathpic);
                Image watermarkImage = DrawText(TBWaterText.Text, selectfont, selectfontcolor);
                Graphics imageGraphics = Graphics.FromImage(image);
                Brush watermarkBrush = new TextureBrush(watermarkImage);

                imageGraphics.FillRectangle(watermarkBrush, new Rectangle(new Point(0, 0), image.Size));

                pictureBox1.Image = image;
            }
            else
            {
                Image image = Image.FromFile(pathpic);
                pictureBox1.Image = image;
            }
        }

        private void ButColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            selectfontcolor = colorDialog1.Color;
            if (TBWaterText.Text != string.Empty)
            {
                Image image = Image.FromFile(pathpic);
                Image watermarkImage = DrawText(TBWaterText.Text, selectfont, selectfontcolor);
                Graphics imageGraphics = Graphics.FromImage(image);
                Brush watermarkBrush = new TextureBrush(watermarkImage);

                imageGraphics.FillRectangle(watermarkBrush, new Rectangle(new Point(0, 0), image.Size));

                pictureBox1.Image = image;
            }
            else
            {
                Image image = Image.FromFile(pathpic);
                pictureBox1.Image = image;
            }
        }

        private void ButLogs_Click(object sender, EventArgs e)
        {
            foreach ( string stroka in listBox1.Items)
            {
                File.AppendAllText("log.txt", stroka + "\n");
            }
        }
    }
}
