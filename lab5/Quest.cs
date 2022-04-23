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

namespace lab5
{
    public partial class Quest : Form
    {
        public Quest()
        {
            InitializeComponent();
            HaveFN = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        public string Filename { get; set; }
        public bool HaveFN { get; set; }
        
        private void Refresh(bool num)
        {
            if (num == true)
            {
                OpenFileDialog op = new OpenFileDialog();

                if (op.ShowDialog() == DialogResult.OK)
                {
                    HaveFN = true;
                }
                else
                {
                    MessageBox.Show("Провал");

                }
                Filename = op.FileName;
                string[] lines = File.ReadAllLines(op.FileName);
                listBox1.Items.Clear();
                foreach (string line in lines)
                {

                    listBox1.Items.Add(line);
                }
            }
            else
            {
                if(HaveFN == false)
                {
                    MessageBox.Show($"Выберите файл");
                }
                else
                {
                    string[] lines = File.ReadAllLines(Filename);
                    listBox1.Items.Clear();
                    foreach (string line in lines)
                    {

                        listBox1.Items.Add(line);
                    }
                }
            }

        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {

            Refresh(true);
        }
        private void buttonZad1_Click(object sender, EventArgs e)
        {
            Refresh(false);
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string text = listBox1.Items[i].ToString();
                Regex regex = new Regex(@"(aaaaaa|a aa a|a)");
                if (regex.IsMatch(text))
                {
                    listBox1.Items[i] = $"{listBox1.Items[i]}  +";
                }
            }
        }
        private void buttonZad2_Click(object sender, EventArgs e)
        {
            Refresh(false);
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string text = listBox1.Items[i].ToString();
                Regex regex = new Regex(@"^.{1,5}$");
                if (regex.IsMatch(text))
                {
                    listBox1.Items[i] = $"{listBox1.Items[i]}  +";
                }
            }
        }
        private void buttonZad3_Click(object sender, EventArgs e)
        {
            Refresh(false);
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string text = listBox1.Items[i].ToString();
                Regex regex = new Regex(@"(.{1,}[@][a-zA-Z]+[.][a-zA-Z]+)");
                if (regex.IsMatch(text))
                {
                    listBox1.Items[i] = $"{listBox1.Items[i]}  +";
                }
            }
        }

        private void buttonZad4_Click(object sender, EventArgs e)
        {
            Refresh(false);
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string text = listBox1.Items[i].ToString();
                Regex regex = new Regex(@"((ул\.)\ )?(?<Name>[А-Яа-я]+)\ ((д\.)\ )?(?<Dom>(\d+[\/]\d+|\d+))");
                
                if (regex.IsMatch(text))
                {
                    Match match = regex.Match(text);
                    listBox1.Items[i] = $"{listBox1.Items[i]}  ({match.Groups["Name"]} {match.Groups["Dom"]})";
                }
                else
                {
                    listBox1.Items[i] = $"{listBox1.Items[i]}  Не найдено";
                }
            }
        }

        private void button5Zad_Click(object sender, EventArgs e)
        {
            Refresh(false);
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string text = listBox1.Items[i].ToString();
                // b
                Regex regex = new Regex(@"\d+[.](?<String>[^\s{1,}]?.+)");

                if (regex.IsMatch(text))
                {
                    Match match = regex.Match(text);
                    listBox1.Items[i] = $"{match.Groups["String"]}";
                }
                /*
                 5 задание:
                 "^\d+[.]" на ""
                 "\s+<node1>" на "  <node1>"
                
                 */
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DopQuest f2 = new DopQuest();
            f2.ShowDialog();
        }
    }
}
