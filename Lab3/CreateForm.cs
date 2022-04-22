using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
        }
       public string FileName
        {
            get
            {
                string text = NameBox.Text;
                return text;
            }
        }
        public int W
        {
            get
            {
                string text = WidthBox.Text;
                int value = Convert.ToInt32(text);
                return value;
            }
        }
        public int H
        {
            get
            {
                string text = HeightBox.Text;
                int value = Convert.ToInt32(text);
                return value;
            }
        }
        bool _canceled = false;
        public bool Canceled
        {
            get { return _canceled; }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            _canceled = true;
            this.Close();
            
        }
        bool _ok = false;
        private void buttonOk_Click_1(object sender, EventArgs e)
        {
            this.Close();
            _ok = true;
        }

        private void CreateForm_Load(object sender, EventArgs e)
        {

        }

        private void CreateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(_ok == true)
            {
                this.Close();
            }
            else
            {
                _canceled = true;
                this.Close();
            }
            
        }

        
    }
}
