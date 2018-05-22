using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Conexion2;

namespace sistemadia
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Abrirformhija(object formhijo)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(fh);
            this.panel3.Tag = fh;
            fh.Show();

        }
        private void privilegiogerente()
        {
            string cmd = "select USERI, TIPO FROM USUARIO WHERE IDUSUARIO=" + Form1.codigo;

            DataSet ds = Class1.Ejecutar(cmd);
            string TIPO = ds.Tables[0].Rows[0]["TIPO"].ToString();



            if (TIPO == "Gerente")
            {
                button2.Visible = false;
                button5.Visible = false;
                button3.Visible = false;
                button1.Visible = false;

                button4.Visible = false;

            }
        }
        private void privilegio()
        {
            string cmd = "select USERI, TIPO FROM USUARIO WHERE IDUSUARIO=" + Form1.codigo;

            DataSet ds = Class1.Ejecutar(cmd);
            string TIPO = ds.Tables[0].Rows[0]["TIPO"].ToString();



            if (TIPO == "Vendedor")
            {
                button2.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button1.Visible = false;
               
                button4.Visible = false;

            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void menu_Load(object sender, EventArgs e)
        {
            privilegio();
            privilegiogerente();
            string cmd = "select USERI, TIPO FROM USUARIO WHERE IDUSUARIO=" + Form1.codigo;

            DataSet ds = Class1.Ejecutar(cmd);
            label1.Text = ds.Tables[0].Rows[0]["USERI"].ToString();
            label2.Text = ds.Tables[0].Rows[0]["TIPO"].ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Abrirformhija(new empleados());
        }
    }
}
