using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
            
        }

        public Usuario cl_usuario = new Usuario();

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string str_nombreusuario, str_contrasena;
            str_nombreusuario = txbNombreUsuario.Text;
            str_contrasena = txbContraseña.Text;
            if (!String.IsNullOrEmpty(str_nombreusuario) && !String.IsNullOrEmpty(str_contrasena))
            {
                
                if (cl_usuario.login(str_nombreusuario,str_contrasena))
                {
                    
                  
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("Los datos son incorrectos");
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos para ingresar");
            }
        }
    }
}
