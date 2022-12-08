using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void btnDers_Click(object sender, EventArgs e)
        {
            DersFormu drs = new DersFormu();
            drs.ShowDialog();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            OgrenciFormu ogrf = new OgrenciFormu();
            ogrf.ShowDialog();
        }

        private void btnOkulYonetim_Click(object sender, EventArgs e)
        {
            YonetimFormu yonet = new YonetimFormu();
            yonet.ShowDialog();
        }

        private void btnOgrenciDers_Click(object sender, EventArgs e)
        {
            OgrDers ogrf = new OgrDers();
            ogrf.ShowDialog();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
