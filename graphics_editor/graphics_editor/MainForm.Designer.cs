namespace graphics_editor
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.создатьКруглыйХолстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьПрямоугольныйХолстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьКруглыйХолстToolStripMenuItem,
            this.создатьПрямоугольныйХолстToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1604, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // создатьКруглыйХолстToolStripMenuItem
            // 
            this.создатьКруглыйХолстToolStripMenuItem.Name = "создатьКруглыйХолстToolStripMenuItem";
            this.создатьКруглыйХолстToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.создатьКруглыйХолстToolStripMenuItem.Text = "Создать круглый холст";
            this.создатьКруглыйХолстToolStripMenuItem.Click += new System.EventHandler(this.создатьКруглыйХолстToolStripMenuItem_Click);
            // 
            // создатьПрямоугольныйХолстToolStripMenuItem
            // 
            this.создатьПрямоугольныйХолстToolStripMenuItem.Name = "создатьПрямоугольныйХолстToolStripMenuItem";
            this.создатьПрямоугольныйХолстToolStripMenuItem.Size = new System.Drawing.Size(188, 20);
            this.создатьПрямоугольныйХолстToolStripMenuItem.Text = "Создать прямоугольный холст";
            this.создатьПрямоугольныйХолстToolStripMenuItem.Click += new System.EventHandler(this.создатьПрямоугольныйХолстToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 881);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Графический редактор";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem создатьКруглыйХолстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьПрямоугольныйХолстToolStripMenuItem;
    }
}

