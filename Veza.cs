using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace EDnevnik2024A
{
    static class Veza
    {
        public static SqlConnection konekcija()
        {
            string CS = ConfigurationManager.ConnectionStrings["skola"].ConnectionString;
            return new SqlConnection(CS);
        }
    }
}
