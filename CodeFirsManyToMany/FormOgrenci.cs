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
    public partial class FormOgrenci : Form
    {
        public FormOgrenci()
        {
            InitializeComponent();
        }
        Universite ctx = new Universite();
        private void FormOgrenci_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void Doldur()
        {
            dataGridView1.DataSource = ctx.Ogrenciler.Select(x => new
            {
                x.OgrenciId,
                x.Ad,
                x.Soyad
            }).ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Ad = txtOgrAd.Text;
            ogr.Soyad = txtOgrSoyad.Text;
            ctx.Ogrenciler.Add(ogr);
            ctx.SaveChanges();
            Doldur();
        }
    }
}
