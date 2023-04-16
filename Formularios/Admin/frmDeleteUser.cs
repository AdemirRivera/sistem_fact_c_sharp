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


namespace Formularios
{
    public partial class frmDeleteUser : Form
    {
        public frmDeleteUser()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex, "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        public void limpiar()
        {
            txtId.Clear();
            txtUsuario.Clear();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenuAdmin frm = new frmMenuAdmin();
            frm.Show();
        }

        #region MOVER VENTANA A TRAVEZ DEL PANEL TOP
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Desea Cancelar?","Cancelar",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)== DialogResult.Yes)
            {
                this.Close();
                frmMenuAdmin frm = new frmMenuAdmin();
                frm.Show();
            }
        }
    }
}
