using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var buttons = panel1.Controls.OfType<Button>().ToArray();
            foreach (var button in buttons)
            {
                button.Click += button4_Click;
            }
            CreateBlank(2000, 1000);
        }
        public Color DefaultColor
        {
            get
            {
                return Color.White;
            }
        }
        public Color GtDC()
        {
            return DefaultColor;
        }
        void CreateBlank(int width, int height)
        {

            var oldImage = pictureBox1.Image;
            var bmp = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    bmp.SetPixel(i, j, DefaultColor);
                }
            }
            pictureBox1.Image = bmp;
            if (oldImage != null)
            {
                oldImage.Dispose();
            }
        }
        int _x;
        int _y;
        bool _mouseClicked = false;

        Color SelectedColor
        {
            get
            {
                return colorDialog1.Color;
            }
            set
            {
                colorDialog1.Color = value;
            }
        }

        Brush _selectedBrush;
      


        int SelectedSize
        {
            get { return trackBar1.Value; }
            
        }
        private void BoxButton_Click(object sender, EventArgs e)
        {
                _selectedBrush = new QuadBrush(SelectedColor, SelectedSize);
            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
            
            if (_selectedBrush == null)
            {
                MessageBox.Show("Выберите кисть");
            }
            else
            {
                _selectedBrush.BrushColor = SelectedColor;
                _selectedBrush.Size = SelectedSize;
                _selectedBrush.Draw(pictureBox1.Image as Bitmap, _x, _y);
                pictureBox1.Refresh();
                _mouseClicked = true;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseClicked = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            _x = e.X > 0 ? e.X : 0;
            _y = e.Y > 0 ? e.Y : 0;
            if (_mouseClicked)
            {
                try
                {
                    _selectedBrush.Draw(pictureBox1.Image as Bitmap, _x, _y);
                    pictureBox1.Refresh();
                }
                catch
                {

                }
            }
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateForm cf = new CreateForm();
            cf.ShowDialog();
            if (cf.Canceled == false)
            {
                CreateBlank(cf.H, cf.W);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _selectedBrush = new Spray(SelectedColor, SelectedSize);
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SelectedColor = ((Button)sender).BackColor;
            buttonColor.BackColor = SelectedColor;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            _selectedBrush = new Erase(SelectedColor, SelectedSize);
        }

        private void buttonStick_Click(object sender, EventArgs e)
        {
            _selectedBrush = new Stick(SelectedColor, SelectedSize);
        }

        private void buttonStick2_Click(object sender, EventArgs e)
        {
            _selectedBrush = new Stick2(SelectedColor, SelectedSize);
        }

        private void buttonSnow_Click(object sender, EventArgs e)
        {
            _selectedBrush = new Snow(SelectedColor, SelectedSize);
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            _selectedBrush = new Circle(SelectedColor, SelectedSize);
        }
    }
}
