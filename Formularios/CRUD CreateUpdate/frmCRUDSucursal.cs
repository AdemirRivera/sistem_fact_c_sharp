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
    public partial class frmCRUDSucursal : Form
    {
        public frmCRUDSucursal()
        {
            InitializeComponent();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region INSTANCIAMIENTO UNICO
        public static frmCRUDSucursal suc = null;

        public static frmCRUDSucursal LlamarSuc
        {
            get
            {
                if (suc == null || suc.IsDisposed)
                {
                    suc = new frmCRUDSucursal();
                }
                return suc;
            }
        }
        #endregion

        ClsMantComboBox combobox = new ClsMantComboBox();

        private void frmCRUDSucursal_Load(object sender, EventArgs e)
        {
            cmbIdCiudad.DataSource = combobox.CargarComboBoxCiudad();
            cmbIdCiudad.DisplayMember = "NOMBRE";
            cmbIdCiudad.ValueMember = "ID_CIUDAD";

            cmbIdCiudad.SelectedValue = _IdCiudad;
            txtNombre.Text = _Nombre;
            txtDireccion.Text = _Direccion;
        }

        public int _IdSucursal;
        public int _IdCiudad;
        public string _Nombre;
        public string _Direccion;

        public void limpiar()
        {
            cmbIdCiudad.Refresh();
            txtNombre.Clear();
            txtDireccion.Clear();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ClsSucursal obSucursal = new ClsSucursal();

                obSucursal.Id_ciudad = int.Parse(cmbIdCiudad.SelectedValue.ToString());
                obSucursal.Nombre = txtNombre.Text;
                obSucursal.Direccion = txtDireccion.Text;

                int resultado = ClsMantSucursal.AgregarSucursal(obSucursal);

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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ClsSucursal obSucursal = new ClsSucursal();
            obSucursal.Id_sucursal = _IdSucursal;
            obSucursal.Id_ciudad = int.Parse(cmbIdCiudad.SelectedValue.ToString());
            obSucursal.Nombre = txtNombre.Text;
            obSucursal.Direccion = txtDireccion.Text;

            int resultado = ClsMantSucursal.ModificarSucursal(obSucursal);
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
    }

}
