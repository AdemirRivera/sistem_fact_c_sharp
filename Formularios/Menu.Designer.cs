namespace Formularios
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnImageMinimize = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnImageClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReporte = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTelProveedor = new Guna.UI2.WinForms.Guna2Button();
            this.btnTelSucursal = new Guna.UI2.WinForms.Guna2Button();
            this.btnCategoriaProd = new Guna.UI2.WinForms.Guna2Button();
            this.btnProductos = new Guna.UI2.WinForms.Guna2Button();
            this.btnCiudad = new Guna.UI2.WinForms.Guna2Button();
            this.btnSucursal = new Guna.UI2.WinForms.Guna2Button();
            this.btnCliente = new Guna.UI2.WinForms.Guna2Button();
            this.btnNewUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnProveedor = new Guna.UI2.WinForms.Guna2Button();
            this.btnVentas = new Guna.UI2.WinForms.Guna2Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.HoraFecha = new System.Windows.Forms.Timer(this.components);
            this.formPanel = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.panelTop.Controls.Add(this.btnImageMinimize);
            this.panelTop.Controls.Add(this.btnImageClose);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1209, 72);
            this.panelTop.TabIndex = 1;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_Paint);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            // 
            // btnImageMinimize
            // 
            this.btnImageMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnImageMinimize.CheckedState.Parent = this.btnImageMinimize;
            this.btnImageMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImageMinimize.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnImageMinimize.HoverState.Parent = this.btnImageMinimize;
            this.btnImageMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnImageMinimize.Image")));
            this.btnImageMinimize.ImageSize = new System.Drawing.Size(30, 30);
            this.btnImageMinimize.Location = new System.Drawing.Point(1126, 22);
            this.btnImageMinimize.Name = "btnImageMinimize";
            this.btnImageMinimize.PressedState.ImageSize = new System.Drawing.Size(26, 26);
            this.btnImageMinimize.PressedState.Parent = this.btnImageMinimize;
            this.btnImageMinimize.Size = new System.Drawing.Size(26, 26);
            this.btnImageMinimize.TabIndex = 6;
            this.btnImageMinimize.UseTransparentBackground = true;
            this.btnImageMinimize.Click += new System.EventHandler(this.btnImageMinimize_Click);
            // 
            // btnImageClose
            // 
            this.btnImageClose.BackColor = System.Drawing.Color.Transparent;
            this.btnImageClose.CheckedState.Parent = this.btnImageClose;
            this.btnImageClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImageClose.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnImageClose.HoverState.Parent = this.btnImageClose;
            this.btnImageClose.Image = ((System.Drawing.Image)(resources.GetObject("btnImageClose.Image")));
            this.btnImageClose.ImageSize = new System.Drawing.Size(25, 25);
            this.btnImageClose.Location = new System.Drawing.Point(1164, 23);
            this.btnImageClose.Name = "btnImageClose";
            this.btnImageClose.PressedState.ImageSize = new System.Drawing.Size(22, 22);
            this.btnImageClose.PressedState.Parent = this.btnImageClose;
            this.btnImageClose.Size = new System.Drawing.Size(25, 25);
            this.btnImageClose.TabIndex = 3;
            this.btnImageClose.UseTransparentBackground = true;
            this.btnImageClose.Click += new System.EventHandler(this.btnImageClose_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(86, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sistema de Facturacion";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.panel2.Controls.Add(this.btnReporte);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btnTelProveedor);
            this.panel2.Controls.Add(this.btnTelSucursal);
            this.panel2.Controls.Add(this.btnCategoriaProd);
            this.panel2.Controls.Add(this.btnProductos);
            this.panel2.Controls.Add(this.btnCiudad);
            this.panel2.Controls.Add(this.btnSucursal);
            this.panel2.Controls.Add(this.btnCliente);
            this.panel2.Controls.Add(this.btnNewUser);
            this.panel2.Controls.Add(this.btnLogOut);
            this.panel2.Controls.Add(this.lblHora);
            this.panel2.Controls.Add(this.lblFecha);
            this.panel2.Controls.Add(this.btnProveedor);
            this.panel2.Controls.Add(this.btnVentas);
            this.panel2.Controls.Add(this.sidePanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 677);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnReporte
            // 
            this.btnReporte.CheckedState.Parent = this.btnReporte;
            this.btnReporte.CustomImages.Parent = this.btnReporte;
            this.btnReporte.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.HoverState.Parent = this.btnReporte;
            this.btnReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte.Image")));
            this.btnReporte.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReporte.ImageSize = new System.Drawing.Size(36, 36);
            this.btnReporte.Location = new System.Drawing.Point(6, 480);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.PressedDepth = 20;
            this.btnReporte.ShadowDecoration.Parent = this.btnReporte;
            this.btnReporte.Size = new System.Drawing.Size(222, 47);
            this.btnReporte.TabIndex = 20;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(15, 624);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(0, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 1);
            this.panel3.TabIndex = 1;
            // 
            // btnTelProveedor
            // 
            this.btnTelProveedor.Animated = true;
            this.btnTelProveedor.CheckedState.Parent = this.btnTelProveedor;
            this.btnTelProveedor.CustomImages.Parent = this.btnTelProveedor;
            this.btnTelProveedor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.btnTelProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelProveedor.ForeColor = System.Drawing.Color.White;
            this.btnTelProveedor.HoverState.Parent = this.btnTelProveedor;
            this.btnTelProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnTelProveedor.Image")));
            this.btnTelProveedor.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTelProveedor.ImageSize = new System.Drawing.Size(36, 36);
            this.btnTelProveedor.Location = new System.Drawing.Point(6, 430);
            this.btnTelProveedor.Name = "btnTelProveedor";
            this.btnTelProveedor.PressedDepth = 20;
            this.btnTelProveedor.ShadowDecoration.Parent = this.btnTelProveedor;
            this.btnTelProveedor.Size = new System.Drawing.Size(222, 47);
            this.btnTelProveedor.TabIndex = 19;
            this.btnTelProveedor.Text = "Telefono Proveedor";
            this.btnTelProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTelProveedor.Click += new System.EventHandler(this.btnTelProveedor_Click);
            // 
            // btnTelSucursal
            // 
            this.btnTelSucursal.Animated = true;
            this.btnTelSucursal.CheckedState.Parent = this.btnTelSucursal;
            this.btnTelSucursal.CustomImages.Parent = this.btnTelSucursal;
            this.btnTelSucursal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.btnTelSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelSucursal.ForeColor = System.Drawing.Color.White;
            this.btnTelSucursal.HoverState.Parent = this.btnTelSucursal;
            this.btnTelSucursal.Image = ((System.Drawing.Image)(resources.GetObject("btnTelSucursal.Image")));
            this.btnTelSucursal.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTelSucursal.ImageSize = new System.Drawing.Size(36, 36);
            this.btnTelSucursal.Location = new System.Drawing.Point(6, 380);
            this.btnTelSucursal.Name = "btnTelSucursal";
            this.btnTelSucursal.PressedDepth = 20;
            this.btnTelSucursal.ShadowDecoration.Parent = this.btnTelSucursal;
            this.btnTelSucursal.Size = new System.Drawing.Size(222, 47);
            this.btnTelSucursal.TabIndex = 18;
            this.btnTelSucursal.Text = "Telefono Sucursal";
            this.btnTelSucursal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTelSucursal.Click += new System.EventHandler(this.btnTelSucursal_Click);
            // 
            // btnCategoriaProd
            // 
            this.btnCategoriaProd.Animated = true;
            this.btnCategoriaProd.CheckedState.Parent = this.btnCategoriaProd;
            this.btnCategoriaProd.CustomImages.Parent = this.btnCategoriaProd;
            this.btnCategoriaProd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.btnCategoriaProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoriaProd.ForeColor = System.Drawing.Color.White;
            this.btnCategoriaProd.HoverState.Parent = this.btnCategoriaProd;
            this.btnCategoriaProd.Image = ((System.Drawing.Image)(resources.GetObject("btnCategoriaProd.Image")));
            this.btnCategoriaProd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCategoriaProd.ImageSize = new System.Drawing.Size(36, 36);
            this.btnCategoriaProd.Location = new System.Drawing.Point(6, 330);
            this.btnCategoriaProd.Name = "btnCategoriaProd";
            this.btnCategoriaProd.PressedDepth = 20;
            this.btnCategoriaProd.ShadowDecoration.Parent = this.btnCategoriaProd;
            this.btnCategoriaProd.Size = new System.Drawing.Size(222, 47);
            this.btnCategoriaProd.TabIndex = 10;
            this.btnCategoriaProd.Text = "Categoria Producto";
            this.btnCategoriaProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCategoriaProd.Click += new System.EventHandler(this.btnCategoriaProd_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Animated = true;
            this.btnProductos.CheckedState.Parent = this.btnProductos;
            this.btnProductos.CustomImages.Parent = this.btnProductos;
            this.btnProductos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.HoverState.Parent = this.btnProductos;
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProductos.ImageSize = new System.Drawing.Size(36, 36);
            this.btnProductos.Location = new System.Drawing.Point(6, 230);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.PressedDepth = 20;
            this.btnProductos.ShadowDecoration.Parent = this.btnProductos;
            this.btnProductos.Size = new System.Drawing.Size(222, 47);
            this.btnProductos.TabIndex = 3;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProductos.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnCiudad
            // 
            this.btnCiudad.Animated = true;
            this.btnCiudad.CheckedState.Parent = this.btnCiudad;
            this.btnCiudad.CustomImages.Parent = this.btnCiudad;
            this.btnCiudad.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.btnCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCiudad.ForeColor = System.Drawing.Color.White;
            this.btnCiudad.HoverState.Parent = this.btnCiudad;
            this.btnCiudad.Image = ((System.Drawing.Image)(resources.GetObject("btnCiudad.Image")));
            this.btnCiudad.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCiudad.ImageSize = new System.Drawing.Size(36, 36);
            this.btnCiudad.Location = new System.Drawing.Point(6, 180);
            this.btnCiudad.Name = "btnCiudad";
            this.btnCiudad.PressedDepth = 20;
            this.btnCiudad.ShadowDecoration.Parent = this.btnCiudad;
            this.btnCiudad.Size = new System.Drawing.Size(222, 47);
            this.btnCiudad.TabIndex = 7;
            this.btnCiudad.Text = "Ciudad";
            this.btnCiudad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCiudad.Click += new System.EventHandler(this.btnCiudad_Click);
            // 
            // btnSucursal
            // 
            this.btnSucursal.Animated = true;
            this.btnSucursal.CheckedState.Parent = this.btnSucursal;
            this.btnSucursal.CustomImages.Parent = this.btnSucursal;
            this.btnSucursal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.btnSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSucursal.ForeColor = System.Drawing.Color.White;
            this.btnSucursal.HoverState.Parent = this.btnSucursal;
            this.btnSucursal.Image = ((System.Drawing.Image)(resources.GetObject("btnSucursal.Image")));
            this.btnSucursal.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSucursal.ImageSize = new System.Drawing.Size(36, 36);
            this.btnSucursal.Location = new System.Drawing.Point(6, 80);
            this.btnSucursal.Name = "btnSucursal";
            this.btnSucursal.PressedDepth = 20;
            this.btnSucursal.ShadowDecoration.Parent = this.btnSucursal;
            this.btnSucursal.Size = new System.Drawing.Size(222, 47);
            this.btnSucursal.TabIndex = 17;
            this.btnSucursal.Text = "Sucursal";
            this.btnSucursal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSucursal.Click += new System.EventHandler(this.btnSucursal_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Animated = true;
            this.btnCliente.CheckedState.Parent = this.btnCliente;
            this.btnCliente.CustomImages.Parent = this.btnCliente;
            this.btnCliente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.White;
            this.btnCliente.HoverState.Parent = this.btnCliente;
            this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            this.btnCliente.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCliente.ImageSize = new System.Drawing.Size(36, 36);
            this.btnCliente.Location = new System.Drawing.Point(6, 30);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.PressedDepth = 20;
            this.btnCliente.ShadowDecoration.Parent = this.btnCliente;
            this.btnCliente.Size = new System.Drawing.Size(222, 47);
            this.btnCliente.TabIndex = 16;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnNewUser
            // 
            this.btnNewUser.Animated = true;
            this.btnNewUser.CheckedState.Parent = this.btnNewUser;
            this.btnNewUser.CustomImages.Parent = this.btnNewUser;
            this.btnNewUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.btnNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewUser.ForeColor = System.Drawing.Color.White;
            this.btnNewUser.HoverState.Parent = this.btnNewUser;
            this.btnNewUser.Image = ((System.Drawing.Image)(resources.GetObject("btnNewUser.Image")));
            this.btnNewUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNewUser.ImageSize = new System.Drawing.Size(36, 36);
            this.btnNewUser.Location = new System.Drawing.Point(6, 650);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.PressedDepth = 20;
            this.btnNewUser.ShadowDecoration.Parent = this.btnNewUser;
            this.btnNewUser.Size = new System.Drawing.Size(222, 47);
            this.btnNewUser.TabIndex = 14;
            this.btnNewUser.Text = "Modificar Usuarios";
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Animated = true;
            this.btnLogOut.CheckedState.Parent = this.btnLogOut;
            this.btnLogOut.CustomImages.Parent = this.btnLogOut;
            this.btnLogOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.HoverState.Parent = this.btnLogOut;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogOut.ImageSize = new System.Drawing.Size(36, 36);
            this.btnLogOut.Location = new System.Drawing.Point(6, 700);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.PressedDepth = 20;
            this.btnLogOut.ShadowDecoration.Parent = this.btnLogOut;
            this.btnLogOut.Size = new System.Drawing.Size(222, 47);
            this.btnLogOut.TabIndex = 13;
            this.btnLogOut.Text = "Cerrar Sesion";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHora.Location = new System.Drawing.Point(12, 784);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(51, 16);
            this.lblHora.TabIndex = 12;
            this.lblHora.Text = "label2";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFecha.Location = new System.Drawing.Point(143, 784);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(51, 16);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "label2";
            // 
            // btnProveedor
            // 
            this.btnProveedor.Animated = true;
            this.btnProveedor.CheckedState.Parent = this.btnProveedor;
            this.btnProveedor.CustomImages.Parent = this.btnProveedor;
            this.btnProveedor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.btnProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedor.ForeColor = System.Drawing.Color.White;
            this.btnProveedor.HoverState.Parent = this.btnProveedor;
            this.btnProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnProveedor.Image")));
            this.btnProveedor.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProveedor.ImageSize = new System.Drawing.Size(36, 36);
            this.btnProveedor.Location = new System.Drawing.Point(6, 280);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.PressedDepth = 20;
            this.btnProveedor.ShadowDecoration.Parent = this.btnProveedor;
            this.btnProveedor.Size = new System.Drawing.Size(222, 47);
            this.btnProveedor.TabIndex = 7;
            this.btnProveedor.Text = "Proveedor";
            this.btnProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Animated = true;
            this.btnVentas.CheckedState.Parent = this.btnVentas;
            this.btnVentas.CustomImages.Parent = this.btnVentas;
            this.btnVentas.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.HoverState.Parent = this.btnVentas;
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnVentas.ImageSize = new System.Drawing.Size(36, 36);
            this.btnVentas.Location = new System.Drawing.Point(6, 130);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.PressedDepth = 20;
            this.btnVentas.ShadowDecoration.Parent = this.btnVentas;
            this.btnVentas.Size = new System.Drawing.Size(222, 47);
            this.btnVentas.TabIndex = 4;
            this.btnVentas.Text = "Vendedor";
            this.btnVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.sidePanel.Location = new System.Drawing.Point(1, 28);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(6, 47);
            this.sidePanel.TabIndex = 3;
            this.sidePanel.Visible = false;
            // 
            // HoraFecha
            // 
            this.HoraFecha.Enabled = true;
            this.HoraFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
            // 
            // formPanel
            // 
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formPanel.Location = new System.Drawing.Point(228, 72);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(981, 677);
            this.formPanel.TabIndex = 3;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1209, 749);
            this.Controls.Add(this.formPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Facturacion";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnProductos;
        private Guna.UI2.WinForms.Guna2Button btnProveedor;
        private Guna.UI2.WinForms.Guna2Button btnVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer HoraFecha;
        private Guna.UI2.WinForms.Guna2ImageButton btnImageClose;
        private System.Windows.Forms.Panel formPanel;
        private Guna.UI2.WinForms.Guna2ImageButton btnImageMinimize;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private Guna.UI2.WinForms.Guna2Button btnCliente;
        private Guna.UI2.WinForms.Guna2Button btnSucursal;
        public System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btnTelProveedor;
        private Guna.UI2.WinForms.Guna2Button btnTelSucursal;
        private Guna.UI2.WinForms.Guna2Button btnCategoriaProd;
        private Guna.UI2.WinForms.Guna2Button btnCiudad;
        private Guna.UI2.WinForms.Guna2Button btnReporte;
        public Guna.UI2.WinForms.Guna2Button btnNewUser;
    }
}

