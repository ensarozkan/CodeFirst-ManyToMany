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
    public partial class FormIliskilendirme : Form
    {
        public FormIliskilendirme()
        {
            InitializeComponent();
        }
        Universite ctx = new Universite();
        private void FormIliskilendirme_Load(object sender, EventArgs e)
        {
            comboDoldur();
            listboxDoldur();
        }

        private void comboDoldur()
        {
            cmbEgitmen.ValueMember = "EgitmenId";
            cmbEgitmen.DisplayMember = "Name";
            cmbEgitmen.DataSource = ctx.Egitmenler.Select(x => new
            {
                x.EgitmenId,
                Name=x.Ad+" "+x.Soyad
            }).ToList();
        }
        private void listboxDoldur()
        {
            listBox1.DataSource = ctx.Ogrenciler.Select(x => new MyEntry
            {
                Name = x.Ad + " " + x.Soyad,
                OgrenciId = x.OgrenciId
            }).ToList();


            listBox1.ValueMember = "OgrenciId";
            listBox1.DisplayMember = "Name";
            listBox1.SelectedIndex = -1;
        }

        private void btnIliski_Click(object sender, EventArgs e)
        {
            int seciliEgitmenId = Convert.ToInt32(cmbEgitmen.SelectedValue);
            Egitmen egitmen = ctx.Egitmenler.Find(seciliEgitmenId);

            foreach (MyEntry item in listBox1.SelectedItems)
            {
                Ogrenci ogrSelected = ctx.Ogrenciler.Find(item.OgrenciId);
                egitmen.Ogrenciler.Add(ogrSelected);
            }

            ctx.SaveChanges();
            listBox1.SelectedItems.Clear();
            dataGridView1.DataSource = egitmen.Ogrenciler.ToList();

        }

        private void cmbEgitmen_SelectedIndexChanged(object sender, EventArgs e)
        {
            int seciliEgitmenId = Convert.ToInt32(cmbEgitmen.SelectedValue);
            Egitmen egitmen = ctx.Egitmenler.Find(seciliEgitmenId);
            dataGridView1.DataSource = egitmen.Ogrenciler.ToList();

        }
    }
}
