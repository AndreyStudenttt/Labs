using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class DopQuest : Form
    {
        public DopQuest()
        {
            InitializeComponent();
        }
        public static double Convertor(string inp)
        {
            IFormatProvider provider = new NumberFormatInfo { NumberDecimalSeparator = "," };
            inp = inp.Replace('.', ',');
            return double.Parse(inp, provider);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string pattern = @"(?<nKG>\d.\d|\d+)\sкг\.\s(?<Product>[А-Яа-я]+)\W+(?<Money>\d+)\sруб.";
            Regex regex = new Regex(pattern);
            string text = label1.Text;
            Match match = regex.Match(text);

            if (regex.IsMatch(text))
            {
                for (int i = 0; i < Regex.Matches(text, pattern).Count; i++)
                {
                    int money = Convert.ToInt32($"{Regex.Matches(text, pattern)[i].Groups["Money"]}");
                    double kg = Convertor($"{Regex.Matches(text, pattern)[i].Groups["nKG"]}");
                    listBox1.Items.Add($"{Regex.Matches(text, pattern)[i].Groups["Product"]} - {money / kg} руб/кг");
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pattern = @"(http:\/\/|https:\/\/|ftp:\/\/)?(www\.)?([\w\-]+(?:\.[\w\-]+){1,4})";
            Regex regex = new Regex(pattern);
            string text = textBox1.Text;
            for (int i = 0; i < Regex.Matches(text, pattern).Count; i++)
            {
                int index = Regex.Matches(text, pattern)[i].Index;
                int lenght = Regex.Matches(text, pattern)[i].Length;
                listBox2.Items.Add($"( {Regex.Matches(text, pattern)[i]} ) | Cмещение: {index}-{index+lenght} |");

            }
        }
        public string filename { get; set; }
        private void refresh (bool num)
        {
            if (num == true)
            {
                OpenFileDialog op = new OpenFileDialog();

                if (op.ShowDialog() == DialogResult.OK)
                {



                }
                else
                {
                    MessageBox.Show("Провал");

                }
                filename = op.FileName;
                string text = File.ReadAllText(op.FileName);
                textBox1.Clear();
                textBox1.Text = text;
            }
            else
            {
                string text = File.ReadAllText(filename);
                textBox1.Clear();
                textBox1.Text = text;
            }
        }
        private void LoadBut_Click(object sender, EventArgs e)
        {
            refresh (true);
        }

    }
}
