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
    public partial class Magaza : Form
    {
        public Magaza()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BakiyeEkle ekle = new BakiyeEkle();
            ekle.ShowDialog();
        }
    }
}
