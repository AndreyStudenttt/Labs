using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            for (int i = (int)x1; i < (int)x2; i++)
            {
                double y = equation.GetValue(i);
                chart1.Series[0].Points.AddXY(i,(int)y);
            }
            
        }

        private void MainProgram_Load(object sender, EventArgs e)
        {
           
        }

        private void DrawFunBut_Click(object sender, EventArgs e)
        {
            var equation = new QuadEquation(0, 0, 0);


            DrawFunction(Convert.ToDouble(TBa.Text), Convert.ToDouble(TBb.Text), chart1.Series[0],equation);
        }
    }
}
