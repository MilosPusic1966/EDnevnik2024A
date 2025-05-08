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
    public partial class Form1 : Form
    {
        int broj_reda;
        DataTable podaci;
        public Form1()
        {
            InitializeComponent();
        }
        void popuni_txt()
        {
            if (broj_reda == podaci.Rows.Count - 1)
            {
                button6.Enabled = false;
                button7.Enabled = false;
            }
            else
            {
                button6.Enabled = true;
                button7.Enabled = true;
            }
            if (broj_reda == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
            textBox1.Text = podaci.Rows[broj_reda][0].ToString();
            textBox2.Text = podaci.Rows[broj_reda][1].ToString();
            textBox3.Text = podaci.Rows[broj_reda][2].ToString();
            textBox4.Text = podaci.Rows[broj_reda][3].ToString();
            textBox5.Text = podaci.Rows[broj_reda][3].ToString();
            textBox6.Text = podaci.Rows[broj_reda][3].ToString();
            textBox7.Text = podaci.Rows[broj_reda][3].ToString();
            textBox8.Text = podaci.Rows[broj_reda][3].ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            broj_reda = 0;
            string CS = "Data source=DESKTOP-6LPEK0P\\SQLEXPRESS;Initial catalog=ednevnik;Integrated security=true";
            SqlConnection veza = new SqlConnection(CS);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM osoba", veza);
            podaci = new DataTable();
            adapter.Fill(podaci);
            popuni_txt();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            broj_reda++;
            popuni_txt();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            broj_reda--;
            popuni_txt();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            broj_reda = 0; popuni_txt();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            broj_reda = podaci.Rows.Count - 1;
            popuni_txt();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // INSERT
            string naredba = "INSERT INTO osoba (ime,prezime,adresa,jmbg,email,pass,uloga)";
            naredba = naredba + "VALUES ('" + textBox2.Text + "','";
            naredba = naredba + textBox3.Text + "','";
            naredba = naredba + textBox4.Text + "','";
            naredba = naredba + textBox5.Text + "','";
            naredba = naredba + textBox6.Text + "','";
            naredba = naredba + textBox7.Text + "',";
            naredba = naredba + textBox8.Text + ")";
            string CS = "Data source=DESKTOP-6LPEK0P\\SQLEXPRESS;Initial catalog=ednevnik;Integrated security=true";
            SqlConnection veza = new SqlConnection(CS);
            SqlCommand komanda = new SqlCommand(naredba, veza);
            veza.Open();
            komanda.ExecuteNonQuery();
            veza.Close();
            //INSERT INTO osoba VALUES ('Nikola','Maricic','adresa')
            
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM osoba", veza);
            podaci = new DataTable();
            adapter.Fill(podaci);
            popuni_txt();
        }
    }
}
