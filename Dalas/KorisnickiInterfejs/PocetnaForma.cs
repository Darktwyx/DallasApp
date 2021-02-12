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
    public partial class PocetnaForma : Form
    {
        public PocetnaForma()
        {
            InitializeComponent();
        }

        private void pROIZVODIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PregledProizvoda().ShowDialog();
            this.Show();
        }

        private void mATERIJAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PregledMaterijala().ShowDialog();
            this.Show();
        }

        private void tIPMATERIJALAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PregledTipovaMaterijala().ShowDialog();
            this.Show();
        }

        private void tIPPROIZVODAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PregledTipovaProizvoda().ShowDialog();
            this.Show();
        }

        private void PocetnaForma_Load(object sender, EventArgs e)
        {

        }
    }
}
