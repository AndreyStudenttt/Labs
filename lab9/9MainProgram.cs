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
    public partial class TBWater : Form
    {
        public TBWater()
        {
            InitializeComponent();
            ButDelDub.Enabled = false;
            ButSortDay.Enabled = false;
            comboBox1.Enabled = false;
            comboBox2.Enabled= false;
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
            pathauto1.SetToolTip(AutoButPath, "Последний использованый путь");
            pathauto2.SetToolTip(ButPathAutoPic, "Последний использованый путь");
            pathauto3.SetToolTip(ButAutoPathWater, "Последний использованый путь");
        }
        string path { get; set; }
        string pathpic { get; set; }
        string pathsavepic { get; set; }
        string pathwater { get; set; }
        List<string> lines = File.ReadAllLines(@"save.txt").ToList(); // для сохр последнего пути, находится в lab9/bin/debug

        private void ButPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();


            if (fbd.ShowDialog() == DialogResult.OK)
            {
                path = fbd.SelectedPath;
                TBPath.Text = fbd.SelectedPath;

                lines.RemoveRange(1,1);
                lines.Insert(1, fbd.SelectedPath);
                File.WriteAllLines(@"save.txt",lines);
                Zaponitel();
                DeleteZeroFolder(path);
                ButDelDub.Enabled = true;
                ButSortDay.Enabled = true;
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
            }
            

        }
        List<ClassFiles> classFiles = new List<ClassFiles>();
        public void Zaponitel ()
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

        public void DelDubByNameAndSize ()
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
        public void DelDubByNameAndDate ()
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
        public void DelDubByBytes ()
        {
            for (int i = 0; i < classFiles.Count; i++)
            {
                byte[] bytearr = new byte[classFiles[i].bytearr.Length];
                bytearr = classFiles[i].bytearr;
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

                    // доделать проверку found
            }
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
            this.Height = 672;
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
        private void ButPathPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();

            if (op.ShowDialog() == DialogResult.OK)
            {
                pathpic = op.FileName;

              //  int sizepic = op.SafeFileName.Length;
              //  pathsavepic = pathpic.Remove(pathpic.Length-sizepic,sizepic);

                TBPathPic.Text = op.FileName;
                lines.RemoveRange(2, 1);
                lines.Insert(2, op.FileName);
                File.WriteAllLines(@"save.txt", lines);
            }
        }
        private void ButPathAutoPic_Click(object sender, EventArgs e)
        {

            pathpic = lines[2];
            TBPathPic.Text = pathpic;
        }

        

        private void ButPicWater_Click(object sender, EventArgs e)
        {
            using (Image image = Image.FromFile(pathpic))
            using (Image watermarkImage = Image.FromFile(pathwater))
            using (Graphics imageGraphics = Graphics.FromImage(image))
            using (Brush watermarkBrush = new TextureBrush(watermarkImage))
            {
                imageGraphics.FillRectangle(watermarkBrush, new Rectangle(new Point(0, 0), image.Size));
                image.Save(Path.Combine(Path.GetDirectoryName(pathpic), Path.GetFileNameWithoutExtension(pathpic)+"new.png" ));
            }
        }

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
            }
        }

        private void ButAutoPathWater_Click(object sender, EventArgs e)
        {
             pathwater = lines[3];
            TBPathWater.Text = pathwater;
        }

        private void ButSave_Click(object sender, EventArgs e)
        {
            using (Image image = Image.FromFile(pathpic))
            using (Image watermarkImage = Image.FromFile(pathwater))
            using (Graphics imageGraphics = Graphics.FromImage(image))
            using (Brush watermarkBrush = new TextureBrush(watermarkImage))
            {
                imageGraphics.FillRectangle(watermarkBrush, new Rectangle(new Point(0, 0), image.Size));
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Text documents (.png)|*.png";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    image.Save(save.FileName);
                }
                    
            }
        }
    }
}
