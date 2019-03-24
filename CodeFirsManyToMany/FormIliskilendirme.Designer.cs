namespace nt_codeFirsManyToMany
{
    partial class FormIliskilendirme
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
            this.cmbEgitmen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnIliski = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEgitmen
            // 
            this.cmbEgitmen.FormattingEnabled = true;
            this.cmbEgitmen.Location = new System.Drawing.Point(15, 25);
            this.cmbEgitmen.Name = "cmbEgitmen";
            this.cmbEgitmen.Size = new System.Drawing.Size(121, 21);
            this.cmbEgitmen.TabIndex = 0;
            this.cmbEgitmen.SelectedIndexChanged += new System.EventHandler(this.cmbEgitmen_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eğitmen";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(411, 234);
            this.dataGridView1.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(247, 10);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(166, 121);
            this.listBox1.TabIndex = 3;
            // 
            // btnIliski
            // 
            this.btnIliski.Location = new System.Drawing.Point(12, 84);
            this.btnIliski.Name = "btnIliski";
            this.btnIliski.Size = new System.Drawing.Size(119, 41);
            this.btnIliski.TabIndex = 4;
            this.btnIliski.Text = "İlişkilendir";
            this.btnIliski.UseVisualStyleBackColor = true;
            this.btnIliski.Click += new System.EventHandler(this.btnIliski_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Öğrenci";
            // 
            // FormIliskilendirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 367);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIliski);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEgitmen);
            this.Name = "FormIliskilendirme";
            this.Text = "FormIliskilendirme";
            this.Load += new System.EventHandler(this.FormIliskilendirme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEgitmen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnIliski;
        private System.Windows.Forms.Label label2;
    }
}