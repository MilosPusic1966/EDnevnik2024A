using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EDnevnik2024A
{
    public partial class predmeti : Form
    {
        DataTable podaci;
        SqlDataAdapter adapter;
        public predmeti()
        {
            InitializeComponent();
        }

        private void predmeti_Load(object sender, EventArgs e)
        {
            podaci = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM predmet",Veza.konekcija() );
            adapter.Fill(podaci);
            dataGridView1.DataSource = podaci;
            dataGridView1.Columns["id"].ReadOnly= true;
            //dataGridView1.Columns["id"].Visible=false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable menjano = podaci.GetChanges();
            adapter.UpdateCommand = new SqlCommandBuilder(adapter).GetUpdateCommand();
            adapter.Update(podaci);
        }
    }
}
