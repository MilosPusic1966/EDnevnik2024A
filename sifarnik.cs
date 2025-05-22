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
    public partial class sifarnik : Form
    {
        DataTable podaci;
        SqlDataAdapter DA;

        public sifarnik()
        {
            InitializeComponent();
        }

        private void sifarnik_Load(object sender, EventArgs e)
        {
            DA= new SqlDataAdapter("SELECT * FROM predmet", Veza.konekcija());
            podaci = new DataTable();
            DA.Fill(podaci);
            dataGridView1.DataSource= podaci;
            dataGridView1.Columns["id"].ReadOnly= true; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable menjano = podaci.GetChanges();
            DA.UpdateCommand = new SqlCommandBuilder(DA).GetUpdateCommand();
            DA.Update(menjano);
        }
    }
}
