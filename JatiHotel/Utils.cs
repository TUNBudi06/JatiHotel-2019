using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JatiHotel
{
    internal class Utils
    {
        private string sqlserver = "Data Source=TUNBUDI06\\SQLEXPRESS;Initial Catalog=JatiHotel;Integrated Security=True;Encrypt=False";
        public SqlConnection koneksi()
        {
            return new SqlConnection(sqlserver);
        }
    }
}
