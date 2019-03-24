using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nt_codeFirsManyToMany
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void öğrenciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOgrenci frm = new FormOgrenci();
            frm.Show();
        }

        private void eğitmenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEgitmen frm = new FormEgitmen();
            frm.Show();
        }

        private void öğrenciEğitmenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIliskilendirme frm = new FormIliskilendirme();
            frm.Show();
        }
    }
}
