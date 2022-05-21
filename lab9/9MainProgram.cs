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
    public partial class MainProgram : Form
    {
        public MainProgram()
        {
            InitializeComponent();
            ButDelDub.Enabled = false;
        }
        string path { get; set; }

        private void ButPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();


            if (fbd.ShowDialog() == DialogResult.OK)
            {
                path = fbd.SelectedPath;
                TBPath.Text = fbd.SelectedPath;
            }
            ButDelDub.Enabled = true;


        }
        List<ClassFiles> classFiles = new List<ClassFiles>();
        private void AutoButPath_Click(object sender, EventArgs e)
        {
            path = @"C:\1";
            TBPath.Text = @"C:\1";
            ButDelDub.Enabled = true;

            DirectoryInfo dir = new DirectoryInfo($"{path}");

           
            foreach (DirectoryInfo dirName in dir.GetDirectories())
            {
                DirectoryInfo dir2 = new DirectoryInfo($"{dirName.FullName}");
                foreach (FileInfo file in dir2.GetFiles())
                {
                    classFiles.Add(new ClassFiles(file.Length * 8, Path.GetFileNameWithoutExtension(file.Name), file.FullName, file.LastWriteTime.Day, file.Name, file.Extension));
                }
            }
            int i = 0;
            //for (int i = 0; i < dir.GetDirectories().Count(); i++)
            //foreach (FileInfo file in dir.GetFiles())
            //{
            //    classFiles.Add(new ClassFiles(file.Length * 8, Path.GetFileNameWithoutExtension(file.Name), file.FullName, file.LastWriteTime.Day, file.Name, file.Extension));
            //}
        }
        private void ButDelDub_Click(object sender, EventArgs e)
        {
      
            for (int i = 0; i < classFiles.Count; i++)
            {
                string fileName = Path.GetFileNameWithoutExtension(classFiles[i].filename);
                Regex check = new Regex(@"(?<Name>.+) (?<Num>\([0-9]+\))");
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

        private void ButSortDay_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < classFiles.Count; i++)
            {
                string newpath = Path.Combine (path, $"{ classFiles[i].day}");
                if(!Directory.Exists(newpath))
                {
                    DirectoryInfo newdir = new DirectoryInfo(newpath);
                    newdir.Create();
                }
                newpath = Path.Combine(newpath, classFiles[i].filename_); 
           
                // listbox1

                File.Move(classFiles[i].path, newpath);
               
            }


        }
    }
}
