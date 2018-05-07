using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Usuario
    {
        private string str_usernombre,str_userpermiso,str_tipodepermiso;
        private int int_iduser;
        public bool login(string nombreusuario,string contrasena)
        {
            string dbContrasena, dbSalt;
            string conection = "workstation id=sistemasdia.mssql.somee.com;packet size=4096;user id=sebastianzatko;pwd=Tetogaita336;data source=sistemasdia.mssql.somee.com;persist security info=False;initial catalog=sistemasdia";
            string querycontrasena = string.Format("SELECT TOP 1 CONTRASENA,SALT FROM USUARIO WHERE NOMBREUSUARIO='{0}'", nombreusuario);
            SqlConnection con = new SqlConnection(conection);
            SqlDataAdapter adaptador = new SqlDataAdapter(querycontrasena ,con);
            DataTable tablaingreso = new DataTable();
            adaptador.Fill(tablaingreso);
            if (tablaingreso!=null)
            {
                
                dbContrasena = tablaingreso.Rows[0][0].ToString();
                dbSalt = tablaingreso.Rows[0][1].ToString();
                var md5 = new MD5CryptoServiceProvider();
                var md5data = md5.ComputeHash(Encoding.ASCII.GetBytes(contrasena+dbSalt));
                string md5encodificando= BitConverter.ToString(md5data).Replace("-", "").ToLower();
                if (md5encodificando == dbContrasena)
                {
                    this.str_usernombre = nombreusuario;
                    string querypermiso = string.Format("SELECT TOP 1 TIPO_USUARIO.DESCRIPCIONTIPO,TIPO_USUARIO.TIPOPERMISO FROM USUARIO,TIPO_USUARIO WHERE USUARIO.NOMBREUSUARIO='{0}' AND USUARIO.ID_TIPOUSUARIO=TIPO_USUARIO.ID_TIPOUSUARIO",this.str_usernombre);
                    SqlDataAdapter adaptadorpermiso = new SqlDataAdapter(querypermiso,con);
                    DataTable tablapermiso = new DataTable();
                    adaptadorpermiso.Fill(tablapermiso);
                    this.str_tipodepermiso = tablapermiso.Rows[0][1].ToString();
                    this.str_userpermiso = tablapermiso.Rows[0][0].ToString();
                    return true;
                }
                else {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public int conseguirnroidentificacion()
        {
            return this.int_iduser;
        }
        public string conseguirnombre()
        {
            return this.str_usernombre;
        }
        public string conseguirpermiso()
        {
            return this.str_tipodepermiso;
        }
        public string conseguirnombrepermiso()
        {
            return this.str_userpermiso;
        }
    }
}
