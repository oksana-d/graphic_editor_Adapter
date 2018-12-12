namespace graphics_editor
{
    partial class CircleForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.цветПераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размерПераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьРисунокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.text_button = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цветПераToolStripMenuItem,
            this.размерПераToolStripMenuItem,
            this.очиститьToolStripMenuItem,
            this.сохранитьРисунокToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(526, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // цветПераToolStripMenuItem
            // 
            this.цветПераToolStripMenuItem.Name = "цветПераToolStripMenuItem";
            this.цветПераToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.цветПераToolStripMenuItem.Text = "Цвет пера";
            this.цветПераToolStripMenuItem.Click += new System.EventHandler(this.цветПераToolStripMenuItem_Click);
            // 
            // размерПераToolStripMenuItem
            // 
            this.размерПераToolStripMenuItem.Name = "размерПераToolStripMenuItem";
            this.размерПераToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.размерПераToolStripMenuItem.Text = "Размер пера";
            this.размерПераToolStripMenuItem.Click += new System.EventHandler(this.размерПераToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // сохранитьРисунокToolStripMenuItem
            // 
            this.сохранитьРисунокToolStripMenuItem.Name = "сохранитьРисунокToolStripMenuItem";
            this.сохранитьРисунокToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.сохранитьРисунокToolStripMenuItem.Text = "Сохранить рисунок";
            this.сохранитьРисунокToolStripMenuItem.Click += new System.EventHandler(this.сохранитьРисунокToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 401);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // text_button
            // 
            this.text_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.text_button.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_button.Location = new System.Drawing.Point(429, 46);
            this.text_button.Name = "text_button";
            this.text_button.Size = new System.Drawing.Size(75, 23);
            this.text_button.TabIndex = 2;
            this.text_button.Text = "Текст";
            this.text_button.UseVisualStyleBackColor = true;
            this.text_button.Click += new System.EventHandler(this.text_button_Click);
            // 
            // CircleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(526, 430);
            this.Controls.Add(this.text_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CircleForm";
            this.Text = "Круглый холст";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem цветПераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размерПераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьРисунокToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button text_button;
    }
}