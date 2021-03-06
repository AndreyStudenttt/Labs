using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab6
{
    public partial class MainProgram : Form
    {
        public MainProgram()
        {
            InitializeComponent();

        }
        void DrawFunction(double x1, double x2, Series series, Equation equation)
        {
            if (x1 >= x2)
            {
                throw new ArgumentException("Правая граница интегирования должны быть больше левой!");
            }
            for (int i = (int)x1; i < (int)x2; i++)
            {
                double y = equation.GetValue(i);
                chart1.Series[0].Points.AddXY(i, (int)y);
            }

        }

        private void MainProgram_Load(object sender, EventArgs e)
        {
            CBEqua.Items.Add(new QuadEquation(0, 0, 0));
            CBEqua.Items.Add(new MonoEquation(0, 0));
            CBEqua.Items.Add(new SinEquation(0));
            CBIntegr.Items.Add(new IntegrateRectangle());
            CBIntegr.Items.Add(new IntegrateSimpson());
            CBEqua.SelectedIndex = 0;
            CBIntegr.SelectedIndex = 0;
            TBa.Text = "1";
            TBb.Text = "1";
            TBc.Text = "1";
            TBLeft.Text = "-10";
            TBRight.Text = "10";
        }

        private void DrawFunBut_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            Equation eq = CBEqua.SelectedItem as Equation;
            Integrator integr = CBIntegr.SelectedItem as Integrator;
            if (integr.BlockButton == null) integr.BlockButton += OnBlockButton;
            if (integr.OnStep == null) integr.OnStep += OnIntegratorStep;
            if (integr.OnFinish == null) integr.OnFinish += OnIntegratorFinish;
            if (integr.ThreadCount == null) integr.ThreadCount += OnThreadFinishCount;
            if (eq != null)
            {
                if (eq is QuadEquation quad)
                {
                    quad.a = Convert.ToDouble(TBa.Text);
                    quad.b = Convert.ToDouble(TBb.Text);
                    quad.c = Convert.ToDouble(TBc.Text);
                }
                else if (eq is MonoEquation mono)
                {
                    mono.a = Convert.ToDouble(TBa.Text);
                    mono.b = Convert.ToDouble(TBb.Text);
                }
                else if (eq is SinEquation sin)
                {
                    sin.a = Convert.ToDouble(TBa.Text);
                }
                chart1.Series[0].ChartType = SeriesChartType.Spline;
                chart1.ChartAreas[0].AxisX.Minimum = Convert.ToInt32(TBLeft.Text);
                chart1.ChartAreas[0].AxisX.Maximum = Convert.ToInt32(TBRight.Text);
                
                DrawFunction(Convert.ToDouble(TBLeft.Text), Convert.ToDouble(TBRight.Text), chart1.Series[0], eq);
                int N;
                if (TBN.Text != string.Empty )
                {
                    if (Int32.TryParse(TBN.Text, out N))
                    {
                        double summ = integr.Integrate(Convert.ToDouble(TBLeft.Text), Convert.ToDouble(TBRight.Text), eq, N);
                        TBSumm.Text = $"{summ}";
                    }
                    else { throw new ArgumentException("Неверно вписано значение разбиения"); };
                }
            }
        }


        private void TBa_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).TextLength == 0)
            {
                ((TextBox)sender).Text = "0";
            }

        }

        private void CBEqua_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CBEqua.SelectedIndex)
            {
                case 0:
                    label1.Enabled = true;
                    label2.Enabled = true;
                    label3.Enabled = true;
                    TBa.Enabled = true;
                    TBb.Enabled = true;
                    TBc.Enabled = true;
                    break;
                case 1:
                    label1.Enabled = true;
                    label2.Enabled = true;
                    label3.Enabled = false;
                    TBa.Enabled = true;
                    TBb.Enabled = true;
                    TBc.Enabled = false;
                    break;
                case 2:
                    label1.Enabled = true;
                    label2.Enabled = false;
                    label3.Enabled = false;
                    TBa.Enabled = true;
                    TBb.Enabled = false;
                    TBc.Enabled = false;
                    break;
                default: break;
            }
        }
        void OnBlockButton(object sender, ButtonEventArgs args)
        {
            DrawFunBut.Enabled = args.sw;
        }
        static void PrintFile(double x, double f, double sum)
        {
            File.AppendAllText("OnStep.txt", x + " " + f + " " + sum + "\n");
        }
        static void PrintBinaryFile(double x, double f, double sum)
        {
            using (BinaryWriter bw = new BinaryWriter(File.Open("bw.dat", FileMode.OpenOrCreate)))
            {
                bw.Seek(0, SeekOrigin.End);
                bw.Write(x + " " + f + " " + sum + "\n");
                bw.Close();
            }

        }
        void OnThreadFinishCount(object sender, ThreadEventArgs args)
        {
            MessageBox.Show($"Кол. тредов интегрирования {args.CalcTime}");
        }
        void OnIntegratorFinish(object sender, IntegratorEventArgs args)
        {
            DrawFunBut.Enabled = true;
        }
        private void OnIntegratorStep(object sender, IntegratorEventArgs args)
        {
            PrintFile(args.X, args.F, args.Integr);
            PrintBinaryFile(args.X, args.F, args.Integr);
        }
    }
}
