namespace nt_codeFirsManyToMany
{
    partial class Form1
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
            this.seçeneklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eğitmenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciEğitmenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seçeneklerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(403, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // seçeneklerToolStripMenuItem
            // 
            this.seçeneklerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciToolStripMenuItem,
            this.eğitmenToolStripMenuItem,
            this.öğrenciEğitmenToolStripMenuItem});
            this.seçeneklerToolStripMenuItem.Name = "seçeneklerToolStripMenuItem";
            this.seçeneklerToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.seçeneklerToolStripMenuItem.Text = "Seçenekler";
            // 
            // öğrenciToolStripMenuItem
            // 
            this.öğrenciToolStripMenuItem.Name = "öğrenciToolStripMenuItem";
            this.öğrenciToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.öğrenciToolStripMenuItem.Text = "Öğrenci";
            this.öğrenciToolStripMenuItem.Click += new System.EventHandler(this.öğrenciToolStripMenuItem_Click);
            // 
            // eğitmenToolStripMenuItem
            // 
            this.eğitmenToolStripMenuItem.Name = "eğitmenToolStripMenuItem";
            this.eğitmenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eğitmenToolStripMenuItem.Text = "Eğitmen";
            this.eğitmenToolStripMenuItem.Click += new System.EventHandler(this.eğitmenToolStripMenuItem_Click);
            // 
            // öğrenciEğitmenToolStripMenuItem
            // 
            this.öğrenciEğitmenToolStripMenuItem.Name = "öğrenciEğitmenToolStripMenuItem";
            this.öğrenciEğitmenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.öğrenciEğitmenToolStripMenuItem.Text = "Öğrenci-Eğitmen";
            this.öğrenciEğitmenToolStripMenuItem.Click += new System.EventHandler(this.öğrenciEğitmenToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 310);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seçeneklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eğitmenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciEğitmenToolStripMenuItem;
    }
}

