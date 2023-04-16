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
    public partial class frmVendedor : Form
    {
        public frmVendedor()
        {
            InitializeComponent();
        }

        private void frmVendedor_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Vendedor";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmCRUDVendedor.LlamarVendedor.Show();
            frmCRUDVendedor.LlamarVendedor.lblTitulo.Text = "Vendedor";
            frmCRUDVendedor.LlamarVendedor.BringToFront();
            frmCRUDVendedor.LlamarVendedor.btnModificar.Visible = false;
            frmCRUDVendedor.LlamarVendedor.btnAceptar.Visible = true;
        }

        public ClsVendedor VendedorSeleccionado { get; set; }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 1)
            {
                int Id = Convert.ToInt16(dgv.CurrentRow.Cells[0].Value);
                VendedorSeleccionado = ClsMantVendedor.ObtenerVendedor(Id);

                frmCRUDVendedor pEditar = new frmCRUDVendedor();
                pEditar._IdVendedor = VendedorSeleccionado.Id_vendedor;
                pEditar._IdSucursal = VendedorSeleccionado.Id_sucursal;
                pEditar._Nombre = VendedorSeleccionado.Nombre;
                pEditar._Apellido = VendedorSeleccionado.Apellido;
                pEditar._Direccion = VendedorSeleccionado.Direccion;
                pEditar._Dui = VendedorSeleccionado.Dui;
                pEditar._Telefono = VendedorSeleccionado.Telefono;
                pEditar._Email = VendedorSeleccionado.Email;
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
                VendedorSeleccionado = ClsMantVendedor.ObtenerVendedor(Id);
                int resultado = ClsMantVendedor.EliminarVendedor(VendedorSeleccionado.Id_vendedor);

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
            dgv.DataSource = ClsMantVendedor.CargarVendedor();
        }

        private void btnImageBuscar_Click(object sender, EventArgs e)
        {
            dgv.DataSource = ClsMantVendedor.BuscarVendedor(txtBuscar.Text);
        }
    }
}
