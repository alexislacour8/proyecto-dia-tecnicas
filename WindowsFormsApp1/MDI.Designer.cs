namespace WindowsFormsApp1
{
    partial class MDI
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI));
            this.menusript_main = new System.Windows.Forms.MenuStrip();
            this.toolmain_sesion = new System.Windows.Forms.ToolStripMenuItem();
            this.sesionsec_iniciarsesion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolmain_ventas = new System.Windows.Forms.ToolStripMenuItem();
            this.ventassec_vender = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_proveedor = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorsec_crear = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorsec_ver = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorsec_modificar = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorsec_eliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolmain_clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesec_crear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolmain_productos = new System.Windows.Forms.ToolStripMenuItem();
            this.productosec_crear = new System.Windows.Forms.ToolStripMenuItem();
            this.productosec_ver = new System.Windows.Forms.ToolStripMenuItem();
            this.productosec_modificar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolmain_ordendecompra = new System.Windows.Forms.ToolStripMenuItem();
            this.ordencomprasec_crear = new System.Windows.Forms.ToolStripMenuItem();
            this.ordencomprasec_cancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.ordencomprasec_controlar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolmain_usuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosec_crear = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosec_ver = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosec_modificar = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosec_eliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolmain_reportes = new System.Windows.Forms.ToolStripMenuItem();
            this.ventassec_verreporteventa = new System.Windows.Forms.ToolStripMenuItem();
            this.toolmain_cerrarsesion = new System.Windows.Forms.ToolStripMenuItem();
            this.menusript_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // menusript_main
            // 
            this.menusript_main.Dock = System.Windows.Forms.DockStyle.Left;
            this.menusript_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolmain_sesion,
            this.toolmain_ventas,
            this.tool_proveedor,
            this.toolmain_clientes,
            this.toolmain_productos,
            this.toolmain_ordendecompra,
            this.toolmain_usuarios,
            this.toolmain_reportes,
            this.toolmain_cerrarsesion});
            this.menusript_main.Location = new System.Drawing.Point(0, 0);
            this.menusript_main.Name = "menusript_main";
            this.menusript_main.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menusript_main.Size = new System.Drawing.Size(145, 453);
            this.menusript_main.TabIndex = 4;
            this.menusript_main.Text = "menuStrip1";
            // 
            // toolmain_sesion
            // 
            this.toolmain_sesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolmain_sesion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sesionsec_iniciarsesion});
            this.toolmain_sesion.Image = global::WindowsFormsApp1.Recursos._207_rohos_logon_key_v3_2;
            this.toolmain_sesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolmain_sesion.ImageTransparentColor = System.Drawing.SystemColors.Control;
            this.toolmain_sesion.Name = "toolmain_sesion";
            this.toolmain_sesion.Size = new System.Drawing.Size(132, 20);
            this.toolmain_sesion.Text = "Sesion";
            // 
            // sesionsec_iniciarsesion
            // 
            this.sesionsec_iniciarsesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sesionsec_iniciarsesion.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.sesionsec_iniciarsesion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sesionsec_iniciarsesion.Name = "sesionsec_iniciarsesion";
            this.sesionsec_iniciarsesion.Size = new System.Drawing.Size(143, 22);
            this.sesionsec_iniciarsesion.Text = "Iniciar Sesion";
            this.sesionsec_iniciarsesion.Click += new System.EventHandler(this.sesionsec_iniciarsesion_Click);
            // 
            // toolmain_ventas
            // 
            this.toolmain_ventas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventassec_vender});
            this.toolmain_ventas.Image = global::WindowsFormsApp1.Recursos._2000px_Emoji_u1f6d2_svg;
            this.toolmain_ventas.Name = "toolmain_ventas";
            this.toolmain_ventas.Size = new System.Drawing.Size(132, 20);
            this.toolmain_ventas.Text = "Ventas";
            this.toolmain_ventas.Visible = false;
            // 
            // ventassec_vender
            // 
            this.ventassec_vender.Name = "ventassec_vender";
            this.ventassec_vender.Size = new System.Drawing.Size(111, 22);
            this.ventassec_vender.Text = "Vender";
            // 
            // tool_proveedor
            // 
            this.tool_proveedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedorsec_crear,
            this.proveedorsec_ver,
            this.proveedorsec_modificar,
            this.proveedorsec_eliminar});
            this.tool_proveedor.Image = global::WindowsFormsApp1.Recursos._315296;
            this.tool_proveedor.Name = "tool_proveedor";
            this.tool_proveedor.Size = new System.Drawing.Size(132, 20);
            this.tool_proveedor.Text = "Proveedores";
            this.tool_proveedor.Visible = false;
            // 
            // proveedorsec_crear
            // 
            this.proveedorsec_crear.Name = "proveedorsec_crear";
            this.proveedorsec_crear.Size = new System.Drawing.Size(185, 22);
            this.proveedorsec_crear.Text = "Nuevo Proveedor";
            // 
            // proveedorsec_ver
            // 
            this.proveedorsec_ver.Name = "proveedorsec_ver";
            this.proveedorsec_ver.Size = new System.Drawing.Size(185, 22);
            this.proveedorsec_ver.Text = "Ver Proveedores";
            // 
            // proveedorsec_modificar
            // 
            this.proveedorsec_modificar.Name = "proveedorsec_modificar";
            this.proveedorsec_modificar.Size = new System.Drawing.Size(185, 22);
            this.proveedorsec_modificar.Text = "Modificar Proveedor";
            // 
            // proveedorsec_eliminar
            // 
            this.proveedorsec_eliminar.Name = "proveedorsec_eliminar";
            this.proveedorsec_eliminar.Size = new System.Drawing.Size(185, 22);
            this.proveedorsec_eliminar.Text = "Eliminar Proveedores";
            // 
            // toolmain_clientes
            // 
            this.toolmain_clientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesec_crear});
            this.toolmain_clientes.Image = global::WindowsFormsApp1.Recursos.Office_Client_Male_Dark_icon;
            this.toolmain_clientes.Name = "toolmain_clientes";
            this.toolmain_clientes.Size = new System.Drawing.Size(132, 20);
            this.toolmain_clientes.Text = "Clientes";
            this.toolmain_clientes.Visible = false;
            // 
            // clientesec_crear
            // 
            this.clientesec_crear.Name = "clientesec_crear";
            this.clientesec_crear.Size = new System.Drawing.Size(169, 22);
            this.clientesec_crear.Text = "Gestionar Clientes";
            // 
            // toolmain_productos
            // 
            this.toolmain_productos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosec_crear,
            this.productosec_ver,
            this.productosec_modificar});
            this.toolmain_productos.Image = global::WindowsFormsApp1.Recursos.icon_packaging;
            this.toolmain_productos.Name = "toolmain_productos";
            this.toolmain_productos.Size = new System.Drawing.Size(132, 20);
            this.toolmain_productos.Text = "Productos";
            this.toolmain_productos.Visible = false;
            // 
            // productosec_crear
            // 
            this.productosec_crear.Name = "productosec_crear";
            this.productosec_crear.Size = new System.Drawing.Size(177, 22);
            this.productosec_crear.Text = "Nuevo Producto";
            // 
            // productosec_ver
            // 
            this.productosec_ver.Name = "productosec_ver";
            this.productosec_ver.Size = new System.Drawing.Size(177, 22);
            this.productosec_ver.Text = "Ver Productos";
            // 
            // productosec_modificar
            // 
            this.productosec_modificar.Name = "productosec_modificar";
            this.productosec_modificar.Size = new System.Drawing.Size(177, 22);
            this.productosec_modificar.Text = "Modificar Producto";
            // 
            // toolmain_ordendecompra
            // 
            this.toolmain_ordendecompra.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordencomprasec_crear,
            this.ordencomprasec_cancelar,
            this.ordencomprasec_controlar});
            this.toolmain_ordendecompra.Image = global::WindowsFormsApp1.Recursos.accessories_clipboard;
            this.toolmain_ordendecompra.Name = "toolmain_ordendecompra";
            this.toolmain_ordendecompra.Size = new System.Drawing.Size(132, 20);
            this.toolmain_ordendecompra.Text = "Ordenes de compra";
            this.toolmain_ordendecompra.Visible = false;
            // 
            // ordencomprasec_crear
            // 
            this.ordencomprasec_crear.Name = "ordencomprasec_crear";
            this.ordencomprasec_crear.Size = new System.Drawing.Size(233, 22);
            this.ordencomprasec_crear.Text = "Nueva Orden de Compra";
            // 
            // ordencomprasec_cancelar
            // 
            this.ordencomprasec_cancelar.Name = "ordencomprasec_cancelar";
            this.ordencomprasec_cancelar.Size = new System.Drawing.Size(233, 22);
            this.ordencomprasec_cancelar.Text = "Cancelar Orden de Compra";
            // 
            // ordencomprasec_controlar
            // 
            this.ordencomprasec_controlar.Name = "ordencomprasec_controlar";
            this.ordencomprasec_controlar.Size = new System.Drawing.Size(233, 22);
            this.ordencomprasec_controlar.Text = "Controlar Ordenes de Compra";
            // 
            // toolmain_usuarios
            // 
            this.toolmain_usuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosec_crear,
            this.usuariosec_ver,
            this.usuariosec_modificar,
            this.usuariosec_eliminar});
            this.toolmain_usuarios.Image = global::WindowsFormsApp1.Recursos.users_17;
            this.toolmain_usuarios.Name = "toolmain_usuarios";
            this.toolmain_usuarios.Size = new System.Drawing.Size(132, 20);
            this.toolmain_usuarios.Text = "Usuarios";
            this.toolmain_usuarios.Visible = false;
            // 
            // usuariosec_crear
            // 
            this.usuariosec_crear.Name = "usuariosec_crear";
            this.usuariosec_crear.Size = new System.Drawing.Size(181, 22);
            this.usuariosec_crear.Text = "Crear nuevo Usuario";
            // 
            // usuariosec_ver
            // 
            this.usuariosec_ver.Name = "usuariosec_ver";
            this.usuariosec_ver.Size = new System.Drawing.Size(181, 22);
            this.usuariosec_ver.Text = "Ver Usuarios";
            // 
            // usuariosec_modificar
            // 
            this.usuariosec_modificar.Name = "usuariosec_modificar";
            this.usuariosec_modificar.Size = new System.Drawing.Size(181, 22);
            this.usuariosec_modificar.Text = "Modificar Usuario";
            // 
            // usuariosec_eliminar
            // 
            this.usuariosec_eliminar.Name = "usuariosec_eliminar";
            this.usuariosec_eliminar.Size = new System.Drawing.Size(181, 22);
            this.usuariosec_eliminar.Text = "Eliminar Usuario";
            // 
            // toolmain_reportes
            // 
            this.toolmain_reportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventassec_verreporteventa});
            this.toolmain_reportes.Image = global::WindowsFormsApp1.Recursos.reports;
            this.toolmain_reportes.Name = "toolmain_reportes";
            this.toolmain_reportes.Size = new System.Drawing.Size(132, 20);
            this.toolmain_reportes.Text = "Reportes";
            this.toolmain_reportes.Visible = false;
            // 
            // ventassec_verreporteventa
            // 
            this.ventassec_verreporteventa.Name = "ventassec_verreporteventa";
            this.ventassec_verreporteventa.Size = new System.Drawing.Size(194, 22);
            this.ventassec_verreporteventa.Text = "Ver Reportes de Ventas";
            // 
            // toolmain_cerrarsesion
            // 
            this.toolmain_cerrarsesion.Image = global::WindowsFormsApp1.Recursos.close_window;
            this.toolmain_cerrarsesion.Name = "toolmain_cerrarsesion";
            this.toolmain_cerrarsesion.Size = new System.Drawing.Size(132, 20);
            this.toolmain_cerrarsesion.Text = "Cerrar Sesion";
            this.toolmain_cerrarsesion.Visible = false;
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 453);
            this.Controls.Add(this.menusript_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MDI";
            this.Text = "Sistemas Dia%";
            this.menusript_main.ResumeLayout(false);
            this.menusript_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menusript_main;
        private System.Windows.Forms.ToolStripMenuItem toolmain_sesion;
        private System.Windows.Forms.ToolStripMenuItem toolmain_ventas;
        private System.Windows.Forms.ToolStripMenuItem tool_proveedor;
        private System.Windows.Forms.ToolStripMenuItem toolmain_clientes;
        private System.Windows.Forms.ToolStripMenuItem toolmain_productos;
        private System.Windows.Forms.ToolStripMenuItem toolmain_ordendecompra;
        private System.Windows.Forms.ToolStripMenuItem toolmain_usuarios;
        private System.Windows.Forms.ToolStripMenuItem sesionsec_iniciarsesion;
        private System.Windows.Forms.ToolStripMenuItem ventassec_vender;
        private System.Windows.Forms.ToolStripMenuItem proveedorsec_crear;
        private System.Windows.Forms.ToolStripMenuItem proveedorsec_ver;
        private System.Windows.Forms.ToolStripMenuItem proveedorsec_modificar;
        private System.Windows.Forms.ToolStripMenuItem proveedorsec_eliminar;
        private System.Windows.Forms.ToolStripMenuItem clientesec_crear;
        private System.Windows.Forms.ToolStripMenuItem productosec_crear;
        private System.Windows.Forms.ToolStripMenuItem productosec_ver;
        private System.Windows.Forms.ToolStripMenuItem productosec_modificar;
        private System.Windows.Forms.ToolStripMenuItem ordencomprasec_crear;
        private System.Windows.Forms.ToolStripMenuItem ordencomprasec_cancelar;
        private System.Windows.Forms.ToolStripMenuItem ordencomprasec_controlar;
        private System.Windows.Forms.ToolStripMenuItem usuariosec_crear;
        private System.Windows.Forms.ToolStripMenuItem usuariosec_ver;
        private System.Windows.Forms.ToolStripMenuItem toolmain_reportes;
        private System.Windows.Forms.ToolStripMenuItem ventassec_verreporteventa;
        private System.Windows.Forms.ToolStripMenuItem usuariosec_modificar;
        private System.Windows.Forms.ToolStripMenuItem usuariosec_eliminar;
        private System.Windows.Forms.ToolStripMenuItem toolmain_cerrarsesion;
    }
}



