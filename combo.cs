using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDnevnik2024A
{
    public partial class combo : Form
    {
        DataTable podaci;
        public combo()
        {
            InitializeComponent();
        }

        private void combo_Load(object sender, EventArgs e)
        {
            SqlConnection veza = Veza.konekcija();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT id, ime+' '+prezime as naziv FROM osoba", veza);
            podaci = new DataTable();
            adapter.Fill(podaci);
            comboBox1.DataSource = podaci;
            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember = "naziv";
            comboBox1.SelectedIndex = -1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Indeks:" + comboBox1.SelectedIndex+" Value:"+comboBox1.SelectedValue);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedValue = 11;
        }
    }
}
