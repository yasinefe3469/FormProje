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
    public partial class OgrenciFormu : Form
    {
        ProjeConnectionOkulDbEntities db = new ProjeConnectionOkulDbEntities();

        public OgrenciFormu()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Anasayfa asyf = new Anasayfa();
            asyf.ShowDialog();
        }

        private void OgrenciFormu_Load(object sender, EventArgs e)
        {
            dgvOgrenci.DataSource = db.Ogrenci.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenciekle = new Ogrenci();
            ogrenciekle.OgrenciAdiSoyadi = txtAdSoyad.Text;
            ogrenciekle.OgrenciNo = int.Parse(txtNumara.Text);
            ogrenciekle.OgrenciDogumTarihi = DateTime.Parse(txtDogumTarihi.Text);
            ogrenciekle.OgrenciKayitTarihi = DateTime.Parse(txtKayitTarihi.Text);
            ogrenciekle.OgrenciBolumu = txtBolum.Text;

            db.Ogrenci.Add(ogrenciekle);
            db.SaveChanges();
            dgvOgrenci.DataSource = db.Ogrenci.ToList();

            MessageBox.Show("Ekleme İşlemi Başarılı");
            foreach(Control item in Controls)
            {
                if (item is TextBox) item.Text = "";
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvOgrenci.CurrentRow.Cells[0].Value.ToString());

            Ogrenci ogrenciekle = db.Ogrenci.FirstOrDefault(x => x.OgrenciID == id);

            ogrenciekle.OgrenciAdiSoyadi = txtAdSoyad.Text;
            ogrenciekle.OgrenciNo = int.Parse(txtNumara.Text);
            ogrenciekle.OgrenciDogumTarihi = DateTime.Parse(txtDogumTarihi.Text);
            ogrenciekle.OgrenciKayitTarihi = DateTime.Parse(txtKayitTarihi.Text);
            ogrenciekle.OgrenciBolumu = txtBolum.Text;

            db.SaveChanges();

            dgvOgrenci.DataSource = db.Ogrenci.ToList();
            MessageBox.Show("Güncelleme İşlemi Başarılı");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvOgrenci.CurrentRow.Cells[0].Value.ToString());
            Ogrenci sil = db.Ogrenci.FirstOrDefault(x => x.OgrenciID == id);

            DialogResult sor = new DialogResult();
            sor = MessageBox.Show($@"{sil.OgrenciAdiSoyadi} Öğrencisi Silinecek. Öğrenciyi silmek istediğinize emin misiniz?", "Kalıcı olarak silinecek.",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(sor==DialogResult.Yes)
            {
                db.Ogrenci.Remove(sil);
                db.SaveChanges();
                dgvOgrenci.DataSource = db.Ogrenci.ToList();
                txtAdSoyad.Text = txtNumara.Text = txtDogumTarihi.Text = txtKayitTarihi.Text = txtBolum.Text = null;
            }
        }

        private void dgvOgrenci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAdSoyad.Text = dgvOgrenci.CurrentRow.Cells[1].Value.ToString();
            txtNumara.Text = dgvOgrenci.CurrentRow.Cells[2].Value.ToString();
            txtDogumTarihi.Text = dgvOgrenci.CurrentRow.Cells[3].Value.ToString();
            txtKayitTarihi.Text = dgvOgrenci.CurrentRow.Cells[4].Value.ToString();
            txtBolum.Text = dgvOgrenci.CurrentRow.Cells[5].Value.ToString();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            var ara = from x in db.Ogrenci
                      where x.OgrenciAdiSoyadi.Contains(txtAra.Text)
                      select new
                      {
                          x.OgrenciID,
                          x.OgrenciAdiSoyadi,
                          x.OgrenciNo,
                          x.OgrenciDogumTarihi,
                          x.OgrenciKayitTarihi,
                          x.OgrenciBolumu
                      };
            dgvOgrenci.DataSource = ara.ToList();
        }
    }
}
