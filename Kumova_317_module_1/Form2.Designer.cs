namespace Kumova_317_module_1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.babushka_picture = new System.Windows.Forms.PictureBox();
            this.babushka_label = new System.Windows.Forms.Label();
            this.rejection_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.babushka_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // babushka_picture
            // 
            this.babushka_picture.Image = global::Kumova_317_module_1.Properties.Resources.maxresdefault;
            this.babushka_picture.Location = new System.Drawing.Point(42, -1);
            this.babushka_picture.Name = "babushka_picture";
            this.babushka_picture.Size = new System.Drawing.Size(390, 290);
            this.babushka_picture.TabIndex = 0;
            this.babushka_picture.TabStop = false;
            // 
            // babushka_label
            // 
            this.babushka_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.babushka_label.AutoSize = true;
            this.babushka_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.babushka_label.Location = new System.Drawing.Point(124, 281);
            this.babushka_label.Name = "babushka_label";
            this.babushka_label.Size = new System.Drawing.Size(232, 25);
            this.babushka_label.TabIndex = 1;
            this.babushka_label.Text = "Хочешь сказку, милок?";
            // 
            // rejection_btn
            // 
            this.rejection_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rejection_btn.Location = new System.Drawing.Point(168, 318);
            this.rejection_btn.Name = "rejection_btn";
            this.rejection_btn.Size = new System.Drawing.Size(155, 32);
            this.rejection_btn.TabIndex = 2;
            this.rejection_btn.Text = "Нет, пирожков хочу";
            this.rejection_btn.UseVisualStyleBackColor = true;
            this.rejection_btn.Click += new System.EventHandler(this.rejection_btn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.rejection_btn);
            this.Controls.Add(this.babushka_label);
            this.Controls.Add(this.babushka_picture);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Неожиданная встреча";
            ((System.ComponentModel.ISupportInitialize)(this.babushka_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox babushka_picture;
        private System.Windows.Forms.Label babushka_label;
        private System.Windows.Forms.Button rejection_btn;
    }
}