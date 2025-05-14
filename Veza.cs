using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EDnevnik2024A
{
    static class Veza
    {
        public static SqlConnection konekcija()
        {
            string CS = "Data source=DESKTOP-6LPEK0P\\SQLEXPRESS;Initial catalog=ednevnik;Integrated security=true";
            return new SqlConnection(CS);
        }
    }
}
