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
    public partial class frmCRUDTelSucursal : Form
    {
        public frmCRUDTelSucursal()
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
        public static frmCRUDTelSucursal telSuc = null;

        public static frmCRUDTelSucursal LlamarTelSuc
        {
            get
            {
                if (telSuc == null || telSuc.IsDisposed)
                {
                    telSuc = new frmCRUDTelSucursal();
                }
                return telSuc;
            }
        }
        #endregion

        ClsMantComboBox mantenimiento = new ClsMantComboBox();

        private void frmCRUDTelSucursal_Load(object sender, EventArgs e)
        {
            cmbId.DataSource = mantenimiento.CargarComboBoxSucursal();
            cmbId.DisplayMember = "NOMBRE";
            cmbId.ValueMember = "ID_SUCURSAL";

            cmbId.SelectedValue = _IdSucursal;
            txtTelefono.Text = _Telefono;
        }

        public int _IdTelSucursal;
        public int _IdSucursal;
        public string _Telefono;

        public void limpiar()
        {
            txtTelefono.Clear();
            cmbId.ResetText();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ClsTelSucursal obTelSuc = new ClsTelSucursal();

            obTelSuc.Telefono = txtTelefono.Text;
            obTelSuc.Id_sucursal = int.Parse(cmbId.SelectedValue.ToString());
            obTelSuc.Id_tel_sucursal = _IdTelSucursal;

            int resultado = ClsMantTelSucursal.ModificarTelSucursal(obTelSuc);
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
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ClsTelSucursal telsuc = new ClsTelSucursal();

                telsuc.Id_sucursal = int.Parse(cmbId.SelectedValue.ToString());
                telsuc.Telefono = txtTelefono.Text;


                int resultado = ClsMantTelSucursal.AgregarTelSucursal(telsuc);

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
                MessageBox.Show("Se produjo un error! " + ex.ToString(), "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error! " + ex.Message);
            }
        }
    }

}
