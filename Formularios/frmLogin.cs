using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Clases;

namespace Formularios
{
    public partial class frmLogin : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
            );
        public frmLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            
        }

        private void btnImageClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                ClsConexion.obtenerConexion();
                SqlDataAdapter admin = new SqlDataAdapter("SELECT COUNT(*) FROM USUARIO WHERE NOMBRE ='" + txtUserName.Text + "' AND PWDCOMPARE ('" + txtContrasena.Text + "',CONTRASENIA)=1 AND ID_TIPO_USUARIO = 1", ClsConexion.obtenerConexion());
                DataTable dtAdmin = new DataTable();
                SqlDataAdapter empleado = new SqlDataAdapter("SELECT COUNT(*) FROM USUARIO WHERE NOMBRE ='" + txtUserName.Text + "' AND PWDCOMPARE ('" + txtContrasena.Text + "',CONTRASENIA)=1 AND ID_TIPO_USUARIO = 2", ClsConexion.obtenerConexion());
                DataTable dtEmpleado = new DataTable();

                admin.Fill(dtAdmin);
                empleado.Fill(dtEmpleado);

                //ESTA ES LA CONDICION PARA EL USUARIO EMPLEADO
                if (dtAdmin.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    Menu menu = new Menu();
                    menu.Show();
                    menu.btnNewUser.Enabled = false;
                    menu.btnNewUser.Visible = false;
                }
                //ESTA ES LA CONDICION PARA EL USUARIO ADMIN
                else if (dtEmpleado.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    Menu menu = new Menu();
                    menu.Show();
                    menu.btnNewUser.Enabled = true;
                    menu.btnNewUser.Visible = true;
                }
                else
                {
                    lblError.Text = "Usuario o Contraseña Incorrectos";
                    pbError.Visible = true;
                    lblError.Visible = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex, "Mensaje Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void msgError(string msg)
        {
            lblError.Text = "   " + msg;
            lblError.Visible = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    
    //IMPORTACION DE DLL PARA MOVER LA VENTANA
    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();
    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void frmLogin_Load(object sender, EventArgs e)
        {
            panelLogin.BackColor = Color.FromArgb(50,255,255,255);
            btnIniciarSesion.BackColor = Color.FromArgb(50, 0, 0, 0);
            panel1.BackColor = Color.FromArgb(50,0,0,0);
            lblError.BackColor = Color.FromArgb(0,0,0,0);
            pbError.BackColor = Color.FromArgb(0,0,0,0);
            checkMostrar1.BackColor = Color.FromArgb(0,0,0,0);
            txtUserName.Focus();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void checkMostrar1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMostrar1.Checked == true)
            {
                if (txtContrasena.PasswordChar == '•')
                {
                    txtContrasena.PasswordChar = '\0';
                }

            }
            else
            {
                txtContrasena.PasswordChar = '•';
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void imgShow_Click(object sender, EventArgs e)
        {
            if (checkMostrar1.Checked != true)
            {
                checkMostrar1.Checked = true;
            }
            else
            {
                checkMostrar1.Checked = false;
            }
        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
