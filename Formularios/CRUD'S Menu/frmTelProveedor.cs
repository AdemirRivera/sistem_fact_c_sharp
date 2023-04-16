using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;
using System.Data.SqlClient;

namespace Formularios
{
    public partial class frmTelProveedor : Form
    {
        public frmTelProveedor()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTelProveedor_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Telefono Proveedor";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmCRUDTelProveedor.LlamarTelProv.Show();
            frmCRUDTelProveedor.LlamarTelProv.lblTitulo.Text = "Telefono Proveedor";
            frmCRUDTelProveedor.LlamarTelProv.BringToFront();
            frmCRUDTelProveedor.LlamarTelProv.btnModificar.Visible = false;
            frmCRUDTelProveedor.LlamarTelProv.btnAceptar.Visible = true;
        }

        public ClsTelProveedor TelProvSeleccionado { get; set; }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 1)
            {
                int Id = Convert.ToInt16(dgv.CurrentRow.Cells[0].Value);
                TelProvSeleccionado = ClsMantTelProv.ObtenerTelProv(Id);

                frmCRUDTelProveedor pEditar = new frmCRUDTelProveedor();
                pEditar._IdTelProveedor = TelProvSeleccionado.Id_tel_proveedor;
                
                pEditar._IdProveedor = TelProvSeleccionado.Id_proveedor;
                pEditar._Telefono = TelProvSeleccionado.Telefono;
                pEditar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Aún no ha seleccionado ningún Registro");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dgv.DataSource = ClsMantTelProv.CargarTelProv();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea eliminar el Registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int Id = Convert.ToInt16(dgv.CurrentRow.Cells[0].Value);
                TelProvSeleccionado = ClsMantTelProv.ObtenerTelProv(Id);
                int resultado = ClsMantTelProv.EliminarTelProv(TelProvSeleccionado.Id_tel_proveedor);

                if (resultado > 0)
                {
                    MessageBox.Show("Registro eliminado correctamente", "Registro Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgv.DataSource = ClsMantTelProv.CargarTelProv();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el Registro", "Error de Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Se canceló la eliminación", "Cancelación");
            }
        }

        private void btnImageBuscar_Click(object sender, EventArgs e)
        {
            dgv.DataSource = ClsMantTelProv.BuscarTelProv(int.Parse(txtBuscar.Text));
        }
    }
}
