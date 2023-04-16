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
    public partial class frmCRUDCiudad : Form
    {
        public frmCRUDCiudad()
        {
            InitializeComponent();
        }

        private void frmCRUDCiudad_Load(object sender, EventArgs e)
        {
            txtNombre.Text = _Nombre;
        }
        #region INSTANCIAMIENTO UNICO
        public static frmCRUDCiudad Ciudad = null;

        public static frmCRUDCiudad LlamarCRUDCiudad
        {
            get
            {
                if (Ciudad == null || Ciudad.IsDisposed)
                {
                    Ciudad = new frmCRUDCiudad();
                }
                return Ciudad;
            }
        }
        #endregion

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region IMPORTACION DE DLL PARA MOVER VENTANA A TRAVEZ DEL PANEL TOP
        //IMPORTACION DE DLL PARA MOVER LA VENTANA
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        public void limpiar()
        {
            txtNombre.Clear();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ClsCiudad obCiudad = new ClsCiudad();

                obCiudad.Nombre = txtNombre.Text;

                int resultado = ClsMantCiudad.AgregarCiudad(obCiudad);

                if (resultado > 0)
                {
                    MessageBox.Show("Datos Guardados Correctamente", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
                else
                {
                    MessageBox.Show("No se Pudieron Guardar los Datos", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show("Se produjo un Error" + ex.ToString(), "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un Error" + ex.Message);
            }

        }
        public int _ID;

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ClsCiudad obCiudad = new ClsCiudad();

            obCiudad.Nombre = txtNombre.Text;
            obCiudad.Id_ciudad = _ID;

            int resultado = ClsMantCiudad.ModificarCiudad(obCiudad);
            if (resultado > 0)
            {
                MessageBox.Show("Registro modificado con éxito", "Registro Modificado",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo modificar Registro", "Error Modificación",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        public ClsCiudad CiudadSeleccionada { get; set; }
        public string _Nombre;
    }
}
