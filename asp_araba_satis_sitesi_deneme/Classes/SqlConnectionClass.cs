using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace asp_araba_satis_sitesi_deneme.Classes
{
    public class SqlConnectionClass
    {
        public static SqlConnection connection = new SqlConnection("Data Source=ABBD01606;Initial Catalog=car_sell;Integrated Security=True;MultipleActiveResultSets=True");
        public static void CheckConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            else { }
        }

    }
}