using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proje.Models;

namespace Proje
{
    public partial class YonetimFormu : Form
    {
        ProjeConnectionOkulDbEntities db = new ProjeConnectionOkulDbEntities();
        public YonetimFormu()
        {
            InitializeComponent();
        }

        private void YonetimFormu_Load(object sender, EventArgs e)
        {
            dataGridViewYonetim.DataSource = db.OkulYonetim.ToList();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Anasayfa syf = new Anasayfa();
            syf.ShowDialog();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            OkulYonetim yoneticiekle = new OkulYonetim();
            yoneticiekle.AdSoyad = txtAdSoyad.Text;
            yoneticiekle.Gorevi = txtGorevi.Text;
            db.OkulYonetim.Add(yoneticiekle);
            db.SaveChanges();
            dataGridViewYonetim.DataSource = db.OkulYonetim.ToList();

            MessageBox.Show("Ekleme İşlemi Başarılı");
            foreach(Control item in Controls)
            {
                if (item is TextBox) item.Text = "";
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridViewYonetim.CurrentRow.Cells[0].Value.ToString());

            OkulYonetim yoneticiguncelle = db.OkulYonetim.FirstOrDefault(x => x.OkulYonetimID == id);
            yoneticiguncelle.AdSoyad = txtAdSoyad.Text;
            yoneticiguncelle.Gorevi = txtGorevi.Text;
            db.SaveChanges();

            dataGridViewYonetim.DataSource = db.OkulYonetim.ToList();

            MessageBox.Show("Güncelleme İşlemi Başarılı");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridViewYonetim.CurrentRow.Cells[0].Value.ToString());
            OkulYonetim sil = db.OkulYonetim.FirstOrDefault(x => x.OkulYonetimID == id);

            DialogResult sor = new DialogResult();
            sor = MessageBox.Show($@"{sil.AdSoyad} Yöneticisi Silinecek. Yöneticiyi silmek istediğinize emin misiniz?", " Kalıcı Olarak Silinecek",  
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sor == DialogResult.Yes)
            {
                db.OkulYonetim.Remove(sil);
                db.SaveChanges();
                dataGridViewYonetim.DataSource = db.OkulYonetim.ToList();
                txtAdSoyad.Text = txtGorevi.Text = null;
            }
        }

        private void dataGridViewYonetim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAdSoyad.Text = dataGridViewYonetim.CurrentRow.Cells[1].Value.ToString();
            txtGorevi.Text = dataGridViewYonetim.CurrentRow.Cells[2].Value.ToString();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            var ara = from x in db.OkulYonetim
                      where x.AdSoyad.Contains(txtAra.Text)
                      select new
                      {
                          x.OkulYonetimID,
                          x.AdSoyad,
                          x.Gorevi
                      };
            dataGridViewYonetim.DataSource = ara.ToList();
        }
    }
}
