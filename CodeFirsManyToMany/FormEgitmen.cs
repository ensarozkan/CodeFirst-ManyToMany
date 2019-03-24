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
    public partial class FormEgitmen : Form
    {
        public FormEgitmen()
        {
            InitializeComponent();
        }
        Universite ctx = new Universite();
        private void FormEgitmen_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void Doldur()
        {
            dataGridView1.DataSource = ctx.Egitmenler.Select(x => new
            {
                x.EgitmenId,
                x.Ad,
                x.Soyad
            }).ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Egitmen egt = new Egitmen();
            egt.Ad = txtEgitmenAd.Text;
            egt.Soyad = txtEgitmenSoyad.Text;
            ctx.Egitmenler.Add(egt);
            ctx.SaveChanges();
            Doldur();
        }
    }
}
