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

namespace Formularios
{
    public partial class frmReporte : Form
    {
        public frmReporte()
        {
            InitializeComponent();
        }

        private void btnImageClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

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

        public static frmReporte reporte = null;
        public static frmReporte llamarReporte
        {
            get
            {
                if (reporte == null || reporte.IsDisposed)
                {
                    reporte = new frmReporte();
                }
                return reporte;
            }
        }
    }
}
