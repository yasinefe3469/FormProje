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
    public partial class DersFormu : Form
    {
        ProjeConnectionOkulDbEntities db = new ProjeConnectionOkulDbEntities();

        public DersFormu()
        {
            InitializeComponent();
        }

        private void Ders_Load(object sender, EventArgs e)
        {
            dgvDers.DataSource = db.Ders.ToList();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Anasayfa asyf = new Anasayfa();
            asyf.ShowDialog();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ders dersekle = new Ders();
            dersekle.DersAdi = txtAd.Text;
            dersekle.DersKredisi = int.Parse(txtKredi.Text);
            dersekle.OkulYonetimID = int.Parse(txtYonetimID.Text);

            db.Ders.Add(dersekle);

            db.SaveChanges();
            dgvDers.DataSource = db.Ders.ToList();

            MessageBox.Show("Ekleme İşlemi Başarılı");
            foreach(Control item in Controls)
            {
                if (item is TextBox) item.Text = "";
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvDers.CurrentRow.Cells[0].Value.ToString());

            Ders dersekle = db.Ders.FirstOrDefault(x => x.DersID == id);

            dersekle.DersAdi = txtAd.Text;
            dersekle.DersKredisi = int.Parse(txtKredi.Text);
            dersekle.OkulYonetimID = int.Parse(txtYonetimID.Text);

            db.SaveChanges();

            dgvDers.DataSource = db.Ders.ToList();
            MessageBox.Show("Güncelleme İşlemi Başarılı");
        }

        private void dgvDers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAd.Text = dgvDers.CurrentRow.Cells[1].Value.ToString();
            txtKredi.Text = dgvDers.CurrentRow.Cells[2].Value.ToString();
            txtYonetimID.Text = dgvDers.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvDers.CurrentRow.Cells[0].Value.ToString());
            Ders sil = db.Ders.FirstOrDefault(x => x.DersID == id);
            DialogResult sor = new DialogResult();
            sor = MessageBox.Show($@"{sil.DersAdi} Dersi Silinecek Dersi Kalıcı olarak silmek istediğinize emin misiniz?","Kalıcı Olarak Silinecek", MessageBoxButtons.YesNo ,MessageBoxIcon.Question);
            
            if(sor==DialogResult.Yes)
            {
                db.Ders.Remove(sil);
                db.SaveChanges();
                dgvDers.DataSource = db.Ders.ToList();
                txtAd.Text = txtKredi.Text = txtYonetimID.Text = null;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var ara = from x in db.Ders
                       where x.DersAdi.Contains(textBox1.Text)
                       select new
                       {
                           x.DersID,
                           x.DersAdi,
                           x.DersKredisi,
                           x.OkulYonetimID
                       };
            dgvDers.DataSource = ara.ToList();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {

        }
    }
}
