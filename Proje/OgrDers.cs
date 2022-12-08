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
    public partial class OgrDers : Form
    {
        ProjeConnectionOkulDbEntities DB = new ProjeConnectionOkulDbEntities();

        public OgrDers()
        {
            InitializeComponent();
        }

        private void OgrDers_Load(object sender, EventArgs e)
        {
            dataGridViewOgrenciDers.DataSource = DB.OgrenciDers.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            OgrenciDers ogdekle = new OgrenciDers();
            ogdekle.DersID = int.Parse(txtDersID.Text);
            ogdekle.OgrenciID = int.Parse(txtOgrenciID.Text);
            DB.OgrenciDers.Add(ogdekle);
            DB.SaveChanges();
            dataGridViewOgrenciDers.DataSource = DB.OgrenciDers.ToList();

            MessageBox.Show("Ekleme İşlemi Başarılı");
            foreach(Control item in Controls)
            {
                if (item is TextBox) item.Text = "";
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridViewOgrenciDers.CurrentRow.Cells[0].Value.ToString());
            OgrenciDers ogdguncelle = DB.OgrenciDers.FirstOrDefault(x => x.ID == id);

            ogdguncelle.DersID = int.Parse(txtDersID.Text);
            ogdguncelle.OgrenciID = int.Parse(txtOgrenciID.Text);
            DB.SaveChanges();

            dataGridViewOgrenciDers.DataSource = DB.OgrenciDers.ToList();

            MessageBox.Show("Güncelleme İşlemi Başarılı");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridViewOgrenciDers.CurrentRow.Cells[0].Value.ToString());
            OgrenciDers ogdsil = DB.OgrenciDers.FirstOrDefault(x => x.ID == id);

            DialogResult sor = new DialogResult();
            sor = MessageBox.Show($@"{ogdsil.DersID} Dersi Silinecek. Dersi silmek istediğinize emin misiniz?", "Kalıcı olarak silinecek.",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(sor==DialogResult.Yes)
            {
                DB.OgrenciDers.Remove(ogdsil);
                DB.SaveChanges();
                dataGridViewOgrenciDers.DataSource = DB.OgrenciDers.ToList();
                txtDersID.Text = txtOgrenciID.Text = null;
            }
        }

        private void dataGridViewOgrenciDers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDersID.Text = dataGridViewOgrenciDers.CurrentRow.Cells[1].Value.ToString();
            txtOgrenciID.Text = dataGridViewOgrenciDers.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Anasayfa geridon = new Anasayfa();
            geridon.ShowDialog();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (txtAra.Text.Trim()==string.Empty)
            {
                return;
            }
            var id = int.Parse(txtAra.Text.Trim());
            var ddd = DB.OgrenciDers.Where(x => x.ID == id)
                      .Select(x => new
                      {
                          x.ID,
                          x.DersID,
                          x.OgrenciID
                      }
                        );
            dataGridViewOgrenciDers.DataSource = ddd.ToList();
        }
    }
}
