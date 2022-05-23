using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9
{
    public partial class MetaDatas : Form
    {
        public List<ClassFiles> classFiles { get; set; }
        public MetaDatas()
        {
            InitializeComponent();
            for (int i = 0; i < classFiles.Count; i++)
            {
                ListFiles.Items.Add(classFiles[i].filename);
            }  // Я пока что отложил это задание, тк оно слишком сложное для моего сознания
        }

    }
}
