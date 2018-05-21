using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Conexion
{
    public class Class1
    {
        public static DataSet Ejecutar(string cmd)
        {
            SqlConnection cnd = new SqlConnection("Data Source=TCL;Initial Catalog=dia;Integrated Security=True");
            cnd.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter dp = new SqlDataAdapter(cmd, cnd);
            dp.Fill(ds);
            cnd.Close();
            return ds;

        }

    }
}
