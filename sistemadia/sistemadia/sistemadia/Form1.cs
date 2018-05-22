using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conexion2;
using System.Data;
using System.Data.SqlClient;

namespace sistemadia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection cnd = new SqlConnection("workstation id=mercado.mssql.somee.com;packet size=4096;user id=alexislacour08_SQLLogin_1;pwd=a8xfdvtj7z;data source=mercado.mssql.somee.com;persist security info=False;initial catalog=mercado");

        public static string codigo = "";

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                string cmd = string.Format("select * from USUARIO  where USERI ='{0}'AND CONTRASEÑA='{1}'", textBox1.Text.Trim(), textBox2.Text.Trim());
                DataSet ds = Class1.Ejecutar(cmd);
                codigo = ds.Tables[0].Rows[0]["IDUSUARIO"].ToString().Trim();
                string cuenta = ds.Tables[0].Rows[0]["USERI"].ToString().Trim();
                string conta = ds.Tables[0].Rows[0]["CONTRASEÑA"].ToString().Trim();


                if (cuenta == textBox1.Text.Trim() && conta == textBox2.Text.Trim())
                {
                
                menu men = new menu();
                    men.Show();
                    this.Hide();
                }
            }
            catch (Exception ERR)
            {
                MessageBox.Show("error" + ERR);

            }

        }
    }
}
