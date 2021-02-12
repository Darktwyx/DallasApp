using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs
{
    public partial class PregledMaterijala : Form
    {
        public PregledMaterijala()
        {
            InitializeComponent();
        }

        private void PregledMaterijala_Load(object sender, EventArgs e)
        {
            KontrolerKI.PretraziMaterijale(dgvMaterijal, txtUslov);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.odaberiMaterijal(dgvMaterijal)) 
            {
                this.Hide();
                new IzmenaMaterijala().ShowDialog();
                KontrolerKI.PretraziMaterijale(dgvMaterijal, txtUslov);
                this.Show();
            }
        }

        private void txtUslov_TextChanged(object sender, EventArgs e)
        {
            KontrolerKI.PretraziMaterijale(dgvMaterijal, txtUslov);
        }
    }
}
