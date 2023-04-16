namespace Formularios
{
    partial class frmAdminAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminAdd));
            this.checkMostrar1 = new System.Windows.Forms.CheckBox();
            this.pbError = new System.Windows.Forms.PictureBox();
            this.lblError = new System.Windows.Forms.Label();
            this.txtContrasena = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnIniciarSesion = new Guna.UI2.WinForms.Guna2Button();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgShow = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnImageClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbError)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgShow)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkMostrar1
            // 
            this.checkMostrar1.AutoSize = true;
            this.checkMostrar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkMostrar1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkMostrar1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkMostrar1.Location = new System.Drawing.Point(298, 128);
            this.checkMostrar1.Name = "checkMostrar1";
            this.checkMostrar1.Size = new System.Drawing.Size(58, 17);
            this.checkMostrar1.TabIndex = 17;
            this.checkMostrar1.Text = "Mostrar";
            this.checkMostrar1.UseVisualStyleBackColor = true;
            this.checkMostrar1.Visible = false;
            this.checkMostrar1.CheckedChanged += new System.EventHandler(this.checkMostrar1_CheckedChanged);
            // 
            // pbError
            // 
            this.pbError.Image = ((System.Drawing.Image)(resources.GetObject("pbError.Image")));
            this.pbError.InitialImage = null;
            this.pbError.Location = new System.Drawing.Point(74, 175);
            this.pbError.Name = "pbError";
            this.pbError.Size = new System.Drawing.Size(16, 16);
            this.pbError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbError.TabIndex = 16;
            this.pbError.TabStop = false;
            this.pbError.Visible = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblError.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblError.Location = new System.Drawing.Point(92, 175);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(107, 16);
            this.lblError.TabIndex = 15;
            this.lblError.Text = "Mensaje de Error";
            this.lblError.Visible = false;
            // 
            // txtContrasena
            // 
            this.txtContrasena.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtContrasena.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContrasena.DefaultText = "";
            this.txtContrasena.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContrasena.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContrasena.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContrasena.DisabledState.Parent = this.txtContrasena;
            this.txtContrasena.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContrasena.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtContrasena.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContrasena.FocusedState.Parent = this.txtContrasena;
            this.txtContrasena.ForeColor = System.Drawing.Color.DimGray;
            this.txtContrasena.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContrasena.HoverState.Parent = this.txtContrasena;
            this.txtContrasena.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtContrasena.IconLeft")));
            this.txtContrasena.Location = new System.Drawing.Point(92, 121);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '•';
            this.txtContrasena.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtContrasena.PlaceholderText = "Contraseña";
            this.txtContrasena.SelectedText = "";
            this.txtContrasena.ShadowDecoration.Parent = this.txtContrasena;
            this.txtContrasena.Size = new System.Drawing.Size(200, 28);
            this.txtContrasena.TabIndex = 14;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(140)))), ((int)(((byte)(167)))));
            this.btnIniciarSesion.CheckedState.Parent = this.btnIniciarSesion;
            this.btnIniciarSesion.CustomImages.Parent = this.btnIniciarSesion;
            this.btnIniciarSesion.FillColor = System.Drawing.Color.Transparent;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.LightGray;
            this.btnIniciarSesion.HoverState.Parent = this.btnIniciarSesion;
            this.btnIniciarSesion.Location = new System.Drawing.Point(137, 209);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.ShadowDecoration.Parent = this.btnIniciarSesion;
            this.btnIniciarSesion.Size = new System.Drawing.Size(108, 31);
            this.btnIniciarSesion.TabIndex = 12;
            this.btnIniciarSesion.Text = "Iniciar Sesion";
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUserName.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "";
            this.txtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.DisabledState.Parent = this.txtUserName;
            this.txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.FocusedState.Parent = this.txtUserName;
            this.txtUserName.ForeColor = System.Drawing.Color.DimGray;
            this.txtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.HoverState.Parent = this.txtUserName;
            this.txtUserName.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtUserName.IconLeft")));
            this.txtUserName.Location = new System.Drawing.Point(92, 28);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtUserName.PlaceholderText = "Nombre de Usuario";
            this.txtUserName.SelectedText = "";
            this.txtUserName.ShadowDecoration.Parent = this.txtUserName;
            this.txtUserName.Size = new System.Drawing.Size(200, 28);
            this.txtUserName.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.imgShow);
            this.panel1.Controls.Add(this.checkMostrar1);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.btnIniciarSesion);
            this.panel1.Controls.Add(this.pbError);
            this.panel1.Controls.Add(this.txtContrasena);
            this.panel1.Controls.Add(this.lblError);
            this.panel1.Location = new System.Drawing.Point(61, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 271);
            this.panel1.TabIndex = 18;
            // 
            // imgShow
            // 
            this.imgShow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.imgShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgShow.Image = ((System.Drawing.Image)(resources.GetObject("imgShow.Image")));
            this.imgShow.Location = new System.Drawing.Point(265, 123);
            this.imgShow.Name = "imgShow";
            this.imgShow.Size = new System.Drawing.Size(25, 25);
            this.imgShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgShow.TabIndex = 22;
            this.imgShow.TabStop = false;
            this.imgShow.Click += new System.EventHandler(this.imgShow_Click_1);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Transparent;
            this.panelTop.Controls.Add(this.btnImageClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(502, 35);
            this.panelTop.TabIndex = 19;
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
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
            this.btnImageClose.Location = new System.Drawing.Point(472, 5);
            this.btnImageClose.Name = "btnImageClose";
            this.btnImageClose.PressedState.ImageSize = new System.Drawing.Size(22, 22);
            this.btnImageClose.PressedState.Parent = this.btnImageClose;
            this.btnImageClose.Size = new System.Drawing.Size(25, 25);
            this.btnImageClose.TabIndex = 16;
            this.btnImageClose.UseTransparentBackground = true;
            this.btnImageClose.Click += new System.EventHandler(this.btnImageClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(199, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 36);
            this.label1.TabIndex = 20;
            this.label1.Text = "Admin";
            // 
            // frmAdminAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(502, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdminAdd";
            this.Load += new System.EventHandler(this.frmAdminAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbError)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgShow)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkMostrar1;
        private System.Windows.Forms.PictureBox pbError;
        private System.Windows.Forms.Label lblError;
        private Guna.UI2.WinForms.Guna2TextBox txtContrasena;
        private Guna.UI2.WinForms.Guna2Button btnIniciarSesion;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTop;
        private Guna.UI2.WinForms.Guna2ImageButton btnImageClose;
        private System.Windows.Forms.PictureBox imgShow;
        private System.Windows.Forms.Label label1;
    }
}