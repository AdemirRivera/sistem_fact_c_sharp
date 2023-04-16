using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//InteropServices es una Libreria para mover la pantalla a travez del panel:
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
            );

        private void btnImageClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImageClose_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
        private void movePanelLeft(Control c)
        {
            sidePanel.Height = c.Height;
            sidePanel.Top = c.Top;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            movePanelLeft(btnProductos);
            abrirFormulario<frmProducto_>();
            //abrirForm(new frmProductos());
            sidePanel.Visible = true;
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void btnImageClose_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de querer Cerrar el Programa? ","Cerrar",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes) {
                Application.Exit();
            }
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            movePanelLeft(btnVentas);
            abrirFormulario<frmVendedor>();
            sidePanel.Visible = true;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            movePanelLeft(btnProveedor);
            abrirFormulario<frmProveedor>();
            sidePanel.Visible = true;
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
        }
        private void abrirFormulario<abrirForm>() where abrirForm : Form, new()
        {
            //DECLARANDO FORMULARIO
            Form formulario;
            formulario = formPanel.Controls.OfType<abrirForm>().FirstOrDefault(); //Busca en la coleccion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new abrirForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                formPanel.Controls.Add(formulario);
                formPanel.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //SI EL FORMULARIO/INSTANCIA EXISTE
            else
            {
                formulario.BringToFront();
            }
        }
        //IMPORTACION DE DLL PARA MOVER LA VENTANA
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnImageMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro de Cerrar Sesion?", "Peligro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                frmLogin login = new frmLogin();
                login.Show();
            }
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminAdd admin = new frmAdminAdd();
            admin.Show();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            movePanelLeft(btnCliente);
            abrirFormulario<CRUD_S.frmCliente>();
            sidePanel.Visible = true;
        }

        private void btnSucursal_Click(object sender, EventArgs e)
        {
            movePanelLeft(btnSucursal);
            abrirFormulario<frmSucursal>();
            sidePanel.Visible = true;
        }

        private void btnCiudad_Click(object sender, EventArgs e)
        {
            movePanelLeft(btnCiudad);
            abrirFormulario<frmCiudad>();
            sidePanel.Visible = true;
        }

        private void btnCategoriaProd_Click(object sender, EventArgs e)
        {
            movePanelLeft(btnCategoriaProd);
            abrirFormulario<frmCategoriaProducto>();
            sidePanel.Visible = true;
        }

        private void btnTelSucursal_Click(object sender, EventArgs e)
        {
            movePanelLeft(btnTelSucursal);
            abrirFormulario<frmTelSucursal>();
            sidePanel.Visible = true;
        }

        private void btnTelProveedor_Click(object sender, EventArgs e)
        {
            movePanelLeft(btnTelProveedor);
            abrirFormulario<frmTelProveedor>();
            sidePanel.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            frmReporte.llamarReporte.Show();
        }
    }
}
