using Kumova_317_module_1.Properties;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            compliment_btn.FlatStyle = FlatStyle.Flat;
            compliment_btn.FlatAppearance.BorderSize = 0;

            test_btn.FlatStyle = FlatStyle.Flat;
            test_btn.FlatAppearance.BorderSize = 0;

            lucky_btn.FlatStyle = FlatStyle.Flat;
            lucky_btn.FlatAppearance.BorderSize = 0;

            compliment_text.Left = (Width - compliment_text.PreferredWidth) / 2;

            test_label.ContextMenuStrip = labelContextMenu;

            ToolStripMenuItem teacherStripItem = new ToolStripMenuItem("Верите в то, что будущее за молодыми инноваторами");
            ToolStripMenuItem zeStripItem = new ToolStripMenuItem("Не прочь попробовать себя в новом амплуа");
            ToolStripMenuItem bestStripItem = new ToolStripMenuItem("Помогаете людям разобраться в себе");
            ToolStripMenuItem comicStripItem = new ToolStripMenuItem("Любитель остросюжетных анекдотов");
            ToolStripMenuItem signerStripItem = new ToolStripMenuItem("Душевный душевой оперный певец");

            labelContextMenu.Items.AddRange(new[] { teacherStripItem, zeStripItem, bestStripItem, comicStripItem, signerStripItem });

            teacherStripItem.Click += TeacherStripItem_Click;
            zeStripItem.Click += ZeStripItem_Click;
            bestStripItem.Click += BestStripItem_Click;
            comicStripItem.Click += ComicStripItem_Click;
            signerStripItem.Click += SignerStripItem_Click;

            test_picture.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void SignerStripItem_Click(object sender, EventArgs e)
        {
            visibilityHandler("Вы - Эдит Пиаф комнатного разлива");
            test_picture.Image = Resources.singer;
        }

        private void ComicStripItem_Click(object sender, EventArgs e)
        {
            visibilityHandler("Вы - бывалый юморист Игорь Маменко");
            test_picture.Image = Resources.fac69312d797746397cd2b88e69d7d29;
        }

        private void BestStripItem_Click(object sender, EventArgs e)
        {
            visibilityHandler("Вы - \"лудший\" мер Харькова Геннадий Кернес");
            test_picture.Image = Resources.button;
        }

        private void ZeStripItem_Click(object sender, EventArgs e)
        {
            visibilityHandler("Вы - действующий президент Украины Владимир Зеленский");
            test_picture.Image = Resources.ze;
        }

        private void TeacherStripItem_Click(object sender, EventArgs e)
        {
            visibilityHandler("Вы - предподаватель Андрей Вячеславович Попов");
            test_picture.Image = Resources.art;
        }

        private void compliment_btn_Click(object sender, EventArgs e)
        {
            visibilityHandler(compliment_text);
        }

        private void test_btn_Click(object sender, EventArgs e)
        {
            visibilityHandler(test_label);
        }

        private void visibilityHandler(Control control) {
            if (control.Visible == false)
            {
                control.Visible = true;
            }
            else
            {
                control.Visible = false;
            }
        }
        private void visibilityHandler(string str)
        {
            if (test_label.Visible == true)
            {
                describtion_label.Visible = true;
                describtion_label.Text = str;
                describtion_label.Left = (Width - describtion_label.PreferredWidth) / 2;
                test_picture.Visible = true;
            }
            else
            {
                describtion_label.Visible = false;
                test_picture.Visible = false;
            }
        }

        private void lucky_btn_Click(object sender, EventArgs e)
        {
            Form2 secondForm = new Form2();
            secondForm.Show();
            this.Hide();
        }
    }
}
