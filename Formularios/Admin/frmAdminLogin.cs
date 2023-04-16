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
using Clases;
using System.Data.SqlClient;

namespace Formularios
{
    public partial class frmAdminAdd : Form
    {
        public frmAdminAdd()
        {
            InitializeComponent();
        }
        //IMPORTACION DE DLL PARA MOVER LA VENTANA
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void frmAdminAdd_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(50,250,250,250);
            panelTop.BackColor = Color.FromArgb(50,0,0,0);
            pbError.BackColor = Color.FromArgb(0,0,0,0);
            lblError.BackColor = Color.FromArgb(0, 0, 0, 0);
            checkMostrar1.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnIniciarSesion.BackColor = Color.FromArgb(100, 0, 0, 0);
            txtUserName.BackColor = Color.FromArgb(0,0,0,0);
            txtContrasena.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.BackColor = Color.FromArgb(0,0,0,0);



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
                checkMostrar1.Checked = false;
                txtContrasena.PasswordChar = '•';
            }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                ClsConexion.obtenerConexion();
                SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(*) FROM USUARIO WHERE USUARIO ='" + txtUserName.Text + "' AND PWDCOMPARE ('" + txtContrasena.Text + "',CONTRASENIA)=1 AND TIPO_USUARIO = 'Admin'", ClsConexion.obtenerConexion());

                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    new frmMenuAdmin().Show();
                }
                else
                {
                    lblError.Text = "Usuario o Contraseña Incorrecta";
                    lblError.Visible = true;
                    pbError.Visible = true;
                    MessageBox.Show("Podria ser que no seas Usuario Administrador", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUserName.Clear();
                    txtContrasena.Clear();
                    txtUserName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mensaje de error: " + ex.ToString());
            }
        }

        private void btnImageClose_Click(object sender, EventArgs e)
        {
            this.Close();
            new Menu().Show();
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void imgShow_Click(object sender, EventArgs e)
        {

        }

        private void imgShow_Click_1(object sender, EventArgs e)
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
    }
}
