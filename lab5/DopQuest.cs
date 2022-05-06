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
        public bool HaveText { get; set; }
        public DopQuest()
        {
            InitializeComponent();
            HaveText = false;
        }
        public static double Convertor(string inp)
        {
            IFormatProvider provider = new NumberFormatInfo { NumberDecimalSeparator = "," };
            inp = inp.Replace('.', ',');
            return double.Parse(inp, provider);
        }
        private void buttonDopQ1_Click(object sender, EventArgs e)
        {
            string pattern = @"(?<nKG>\d.\d|\d+)\sкг\.(\s)?(?<Product>[А-Яа-я]+)\W+(?<Money>\d+)\sруб.";
            Regex regex = new Regex(pattern);
            string text = textBoxDopQ.Text;
            Match match = regex.Match(text);
            listBox1.Items.Clear();

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

        private void buttonDopQ2_Click(object sender, EventArgs e)
        {
            if ( HaveText == true )
            {
                string pattern = @"(http:\/\/|https:\/\/|ftp:\/\/)?(www\.)?([\w\-]+(?:\.[\w\-]+){1,4})";
                Regex regex = new Regex(pattern);
                string text = textBox1.Text;
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Text documents (.txt)|*.txt";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter w = new StreamWriter(save.FileName);

                    for (int i = 0; i < Regex.Matches(text, pattern).Count; i++)
                    {
                        int index = Regex.Matches(text, pattern)[i].Index;
                        int lenght = Regex.Matches(text, pattern)[i].Length;
                        w.WriteLine($"( {Regex.Matches(text, pattern)[i]} ) | Cмещение: {index}-{index + lenght} |");
                    }

                    w.Close();
                }
            }
        }
        private void buttonDopQ2End_Click(object sender, EventArgs e)
        {
            if (HaveText == true)
            {
                string pattern = @"(http:\/\/|https:\/\/|ftp:\/\/)?(www\.)?([\w\-]+(?:\.[\w\-]+){1,4})";
                Regex regex = new Regex(pattern);
                string text = textBox1.Text;

                StreamWriter w = new StreamWriter(@"DopQEnd.txt");

                for (int i = 0; i < Regex.Matches(text, pattern).Count; i++)
                {
                    int index = Regex.Matches(text, pattern)[i].Index;
                    int lenght = Regex.Matches(text, pattern)[i].Length;
                    w.WriteLine($"( {Regex.Matches(text, pattern)[i]} ) | Cмещение: {index}-{index + lenght} |");
                }

                w.Close();
            }
        }
        private void LoadBut_Click(object sender, EventArgs e)
        {
            string text = File.ReadAllText($"DopQ.txt");
            textBox1.Clear();
            textBox1.Text = text;
            HaveText = true;
        }
        private void LoadOtherBut_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();

            if (op.ShowDialog() == DialogResult.OK)
            {
                string text = File.ReadAllText(op.FileName);
                textBox1.Clear();
                textBox1.Text = text;
                HaveText = true;
            }
            else
            {
                MessageBox.Show("Провал");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = $" Добро пожаловать в наш магазин, вот наши цены: 1 кг. яблоки - 90 руб., 2 кг. апельсины - 130 руб. Также в ассортименте орехи в следующей фасовке: 0.5 кг.миндаль - 500 руб.";
            textBoxDopQ.Text = text;
        }
    }
}
