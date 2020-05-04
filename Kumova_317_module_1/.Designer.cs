namespace Kumova_317_module_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.test_btn = new System.Windows.Forms.Button();
            this.compliment_btn = new System.Windows.Forms.Button();
            this.lucky_btn = new System.Windows.Forms.Button();
            this.compliment_text = new System.Windows.Forms.Label();
            this.test_label = new System.Windows.Forms.Label();
            this.labelContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.describtion_label = new System.Windows.Forms.Label();
            this.test_picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.test_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // test_btn
            // 
            this.test_btn.BackColor = System.Drawing.Color.Goldenrod;
            this.test_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.test_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.test_btn.Location = new System.Drawing.Point(294, 87);
            this.test_btn.Name = "test_btn";
            this.test_btn.Size = new System.Drawing.Size(212, 49);
            this.test_btn.TabIndex = 0;
            this.test_btn.Text = "Тест на определение вашей внутренней личности";
            this.test_btn.UseVisualStyleBackColor = false;
            this.test_btn.Click += new System.EventHandler(this.test_btn_Click);
            // 
            // compliment_btn
            // 
            this.compliment_btn.BackColor = System.Drawing.Color.Goldenrod;
            this.compliment_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.compliment_btn.Location = new System.Drawing.Point(62, 87);
            this.compliment_btn.Name = "compliment_btn";
            this.compliment_btn.Size = new System.Drawing.Size(186, 49);
            this.compliment_btn.TabIndex = 1;
            this.compliment_btn.Text = "Получить комплимент";
            this.compliment_btn.UseVisualStyleBackColor = false;
            this.compliment_btn.Click += new System.EventHandler(this.compliment_btn_Click);
            // 
            // lucky_btn
            // 
            this.lucky_btn.BackColor = System.Drawing.Color.Goldenrod;
            this.lucky_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lucky_btn.Location = new System.Drawing.Point(552, 87);
            this.lucky_btn.Name = "lucky_btn";
            this.lucky_btn.Size = new System.Drawing.Size(194, 49);
            this.lucky_btn.TabIndex = 2;
            this.lucky_btn.Text = "Испытать удачу";
            this.lucky_btn.UseVisualStyleBackColor = false;
            this.lucky_btn.Click += new System.EventHandler(this.lucky_btn_Click);
            // 
            // compliment_text
            // 
            this.compliment_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.compliment_text.AutoSize = true;
            this.compliment_text.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.compliment_text.Location = new System.Drawing.Point(198, 27);
            this.compliment_text.Name = "compliment_text";
            this.compliment_text.Size = new System.Drawing.Size(454, 33);
            this.compliment_text.TabIndex = 3;
            this.compliment_text.Text = "Вы выглядите просто восхитительно!";
            this.compliment_text.Visible = false;
            // 
            // test_label
            // 
            this.test_label.AutoSize = true;
            this.test_label.ContextMenuStrip = this.labelContextMenu;
            this.test_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.test_label.Location = new System.Drawing.Point(164, 164);
            this.test_label.Name = "test_label";
            this.test_label.Size = new System.Drawing.Size(488, 17);
            this.test_label.TabIndex = 4;
            this.test_label.Text = "Щелкните здесь правой кнопкой мыши и выберете подходящий вариант";
            this.test_label.Visible = false;
            // 
            // labelContextMenu
            // 
            this.labelContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.labelContextMenu.Name = "labelContextMenu";
            this.labelContextMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // describtion_label
            // 
            this.describtion_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.describtion_label.AutoSize = true;
            this.describtion_label.Location = new System.Drawing.Point(354, 415);
            this.describtion_label.Name = "describtion_label";
            this.describtion_label.Size = new System.Drawing.Size(68, 17);
            this.describtion_label.TabIndex = 6;
            this.describtion_label.Text = "some text";
            this.describtion_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.describtion_label.Visible = false;
            // 
            // test_picture
            // 
            this.test_picture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.test_picture.Location = new System.Drawing.Point(248, 201);
            this.test_picture.Name = "test_picture";
            this.test_picture.Size = new System.Drawing.Size(300, 200);
            this.test_picture.TabIndex = 7;
            this.test_picture.TabStop = false;
            this.test_picture.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.test_picture);
            this.Controls.Add(this.describtion_label);
            this.Controls.Add(this.test_label);
            this.Controls.Add(this.compliment_text);
            this.Controls.Add(this.lucky_btn);
            this.Controls.Add(this.compliment_btn);
            this.Controls.Add(this.test_btn);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Артхаусное творчество нового поколения";
            ((System.ComponentModel.ISupportInitialize)(this.test_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button test_btn;
        private System.Windows.Forms.Button compliment_btn;
        private System.Windows.Forms.Button lucky_btn;
        private System.Windows.Forms.Label compliment_text;
        private System.Windows.Forms.Label test_label;
        private System.Windows.Forms.ContextMenuStrip labelContextMenu;
        private System.Windows.Forms.Label describtion_label;
        private System.Windows.Forms.PictureBox test_picture;
    }
}

