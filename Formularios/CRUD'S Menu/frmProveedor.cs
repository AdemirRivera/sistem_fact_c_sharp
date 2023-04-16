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
    public partial class frmProveedor : Form
    {
        public frmProveedor()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProveedor_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Proveedor";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmCRUDProveedor.LlamarProv.Show();
            frmCRUDProveedor.LlamarProv.lblTitulo.Text = "Proveedor";
            frmCRUDProveedor.LlamarProv.BringToFront();
            frmCRUDProveedor.LlamarProv.btnModificar.Visible = false;
            frmCRUDProveedor.LlamarProv.btnAceptar.Visible = true;
        }

        public ClsProveedor ProveedorSeleccionado { get; set; }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 1)
            {
                int Id = Convert.ToInt16(dgv.CurrentRow.Cells[0].Value);
                ProveedorSeleccionado = ClsMantProveedor.ObtenerProveedor(Id);

                frmCRUDProveedor pEditar = new frmCRUDProveedor();
                pEditar._IdProveedor = ProveedorSeleccionado.Id_proveedor;
                pEditar._Nombre = ProveedorSeleccionado.Nombre;
                pEditar._Direccion = ProveedorSeleccionado.Direccion;
                pEditar._Email = ProveedorSeleccionado.Email;
                pEditar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Aún no ha seleccionado ningún Registro");
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea eliminar el Registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int Id = Convert.ToInt16(dgv.CurrentRow.Cells[0].Value);
                ProveedorSeleccionado = ClsMantProveedor.ObtenerProveedor(Id);
                int resultado = ClsMantProveedor.EliminarProveedor(ProveedorSeleccionado.Id_proveedor);

                if (resultado > 0)
                {
                    MessageBox.Show("Registro eliminado correctamente", "Registro Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dgv.DataSource = ClsMantProveedor.CargarProveedor();
        }

        private void btnImageBuscar_Click(object sender, EventArgs e)
        {
            dgv.DataSource = ClsMantProveedor.BuscarProveedor(txtBuscar.Text);
        }
    }
}
