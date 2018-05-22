using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Conexion2
{
    public class Class1
    {
        public static DataSet Ejecutar(string cmd)
        {
            SqlConnection cnd = new SqlConnection("Data Source = TCL; Initial Catalog = sistemadia; Integrated Security = True");
            cnd.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter dp = new SqlDataAdapter(cmd, cnd);
            dp.Fill(ds);
            cnd.Close();
            return ds;

        }
        public static Boolean Validarformulario(Control Objeto, ErrorProvider ErrorProvider)
        {

            Boolean HayErrores = false;
            foreach (Control Item in Objeto.Controls)
            {
                if (Item is ErrortextBox)
                {

                    ErrortextBox Obj = (ErrortextBox)Item;

                    if (Obj.Validar == true)
                    {
                        if (string.IsNullOrEmpty(Obj.Text.Trim()))
                        {
                            ErrorProvider.SetError(Obj, "NO PUEDE ESTAR VACIO");
                            HayErrores = true;
                        }
                    }
                    else
                    {
                        ErrorProvider.SetError(Obj, "");
                    }
                }

            }
            return HayErrores;
        }
    }
}
