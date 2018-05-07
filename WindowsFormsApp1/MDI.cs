using System;
using System.Collections;
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
    public partial class MDI : Form
    {
        private int childFormNumber = 0;

        public MDI()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }


        Frm_Login Frm_login = new Frm_Login();
        Usuario user = new Usuario();
        private void sesionsec_iniciarsesion_Click(object sender, EventArgs e)
        {
            if (Frm_login != null)
            {
                Frm_login.MdiParent = this;
                Frm_login.FormClosing += new FormClosingEventHandler(frm_login_FormClosing); 

                Frm_login.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                Frm_login.Show();
            }
            else {
                Frm_login.Activate();
            }
        }
        void frm_login_FormClosing(object sender, FormClosingEventArgs e) {

            this.user = Frm_login.cl_usuario;
            string str_perimisosusuario = user.conseguirpermiso();
            string str_nombrepermisousuario = user.conseguirnombrepermiso();
            if (str_nombrepermisousuario == "CONTROLADOR STOCK")
            {
                ordencomprasec_cancelar.Visible = false;
                ordencomprasec_crear.Visible = false;
            }else if (str_nombrepermisousuario == "ENCARGADO INVENTARIO")
            {
                ordencomprasec_controlar.Visible = false;
            }

            IList<ToolStripItem> array_controlmenu = menusript_main.Items.OfType<ToolStripItem>().ToList();
            Frm_login.Dispose();
            for (int i = 0; i <= array_controlmenu.Count ; i++)
            {
                
                if (str_perimisosusuario[i]=='1')
                {
                    
                    array_controlmenu[i].Visible = true;
                    array_controlmenu[i].Enabled = true;
                }
                else
                {
                    array_controlmenu[i].Visible = false;
                    array_controlmenu[i].Enabled = false;
                }
            }
            
            
            
            
            
        }
    }
}
