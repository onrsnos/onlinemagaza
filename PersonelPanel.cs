using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineAlisverisSistemi
{
    public partial class PersonelPanel : Form
    {
        public int kullaniciid;
        public PersonelPanel()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UyeIslemleri uye = new UyeIslemleri();
            uye.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UrunIslemler urun = new UrunIslemler();
            urun.ShowDialog();
        }

        private void PersonelPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
