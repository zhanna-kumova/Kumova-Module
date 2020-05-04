using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kumova_317_module_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            babushka_label.Left = (Width - babushka_label.PreferredWidth) / 2;
            babushka_picture.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void rejection_btn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Dispose();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.global_FormClosed);
            this.Close();
            form1.ShowDialog();           
        }
        public void global_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
