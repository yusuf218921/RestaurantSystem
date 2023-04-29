using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class DBHelper
    {
        SqlConnection conn;
        public DBHelper()
        {
            conn = new SqlConnection(@"Data Source=127.0.0.1\SQLEXPRESS,1433;Network Library=DBMSSOCN;Initial Catalog=RestaurantSystem;User ID=SA;Password=218921aa");
        }

        public SqlConnection SqlConnection { get { return conn; } }
    }
}
