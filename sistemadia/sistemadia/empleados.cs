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

namespace sistemadia
{
    public partial class empleados : Form
    {
        public empleados()
        {
            InitializeComponent();
            comboBox1.Items.Add("Administrativo");
            comboBox1.Items.Add("Vendedor");
            comboBox1.Items.Add("Gerente");
            comboBox1.Items.Add("Control Stock");
            comboBox1.Items.Add("Cargado de productos");
        }

        private void empleados_Load(object sender, EventArgs e)
        {
            DataSet ds;
            string cmd = "select * from USUARIO  ";
            ds = Class1.Ejecutar(cmd);
            dataGridView1.DataSource = ds.Tables[0];
        }

        public virtual Boolean guardar()
        {
            if (Class1.Validarformulario(this, errorProvider1) == false)
            {
                try
                {
                    string cmd = string.Format("exec GUARDAR '{0}','{1}','{2}','{3}','{4}'", textBox1.Text.Trim(), textBox2.Text.Trim(),comboBox1.Text.Trim(), textBox3.Text.Trim(), textBox4.Text.Trim());
                    Class1.Ejecutar(cmd);
                    MessageBox.Show("se ha guardado correctamente");
                    return true;
                }
                catch (Exception error)
                {
                    MessageBox.Show("se ha producido un error" + error.Message);
                    return false;
                }

            }
            else
            {
                return false;
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            guardar();
            DataSet ds;
            string cmd = "select * from USUARIO  ";
            ds = Class1.Ejecutar(cmd);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
