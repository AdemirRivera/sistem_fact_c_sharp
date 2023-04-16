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

namespace Formularios.CRUD_S
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Cliente";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu panel = new Menu();
            panel.sidePanel.Visible = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmCRUDCliente.llamarCRUDCliente.Show();
            frmCRUDCliente.llamarCRUDCliente.lblTitulo.Text = "Cliente";
            frmCRUDCliente.llamarCRUDCliente.BringToFront();
            frmCRUDCliente.llamarCRUDCliente.btnModificar.Visible = false;
            frmCRUDCliente.llamarCRUDCliente.btnNuevo.Visible = true;
            frmCRUDCliente.llamarCRUDCliente.msktxtFechaNacimiento.Clear();
        }
        public ClsCliente ClienteSeleccionado { get; set; }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 1)
            {
                int Id = Convert.ToInt16(dgv.CurrentRow.Cells[0].Value);
                ClienteSeleccionado = ClsMantCliente.ObtenerCliente(Id);

                frmCRUDCliente pEditar = new frmCRUDCliente();
                pEditar._IdCliente= ClienteSeleccionado.Id_cliente;
                pEditar._IdCiudad = ClienteSeleccionado.Id_ciudad;
                pEditar._Nombre = ClienteSeleccionado.Nombre;
                pEditar._Apellido = ClienteSeleccionado.Apellido;
                pEditar._Direccion = ClienteSeleccionado.Direccion;
                pEditar._FechaNac = ClienteSeleccionado.Fecha_nacimiento;
                pEditar._Dui = ClienteSeleccionado.Dui;
                pEditar._Telefono = ClienteSeleccionado.Telefono;
                pEditar._Email = ClienteSeleccionado.Email;
                pEditar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Aún no ha seleccionado ningún Registro");
            }
        }
        //BOTON ELIMINAR
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea eliminar el Registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int Id = Convert.ToInt16(dgv.CurrentRow.Cells[0].Value);
                ClienteSeleccionado = ClsMantCliente.ObtenerCliente(Id);
                int resultado = ClsMantCliente.EliminarCliente(ClienteSeleccionado.Id_cliente);

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
            dgv.DataSource = ClsMantCliente.CargarCliente();
        }

        private void btnImageBuscar_Click(object sender, EventArgs e)
        {
            dgv.DataSource = ClsMantCliente.BuscarCliente(txtBuscar.Text);
        }
    }
}
