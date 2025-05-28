using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDnevnik2024A
{
    public partial class Glavna : Form
    {
        public Glavna()
        {
            InitializeComponent();
        }

        private void osobaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 prva = new Form1();
            prva.Show();
        }

        private void comboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            combo druga = new combo();
            druga.ShowDialog();
        }

        private void nestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sifarnik treca = new sifarnik();
            treca.ShowDialog();
        }

        private void predmetiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            predmeti cetvrta = new predmeti("predmet");
            cetvrta.ShowDialog();
        }

        private void smeroviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            predmeti nova = new predmeti("smer");
            nova.ShowDialog();
        }

        private void godineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            predmeti vuk = new predmeti("Skolska_godina");
            vuk.ShowDialog();
        }
    }
}
