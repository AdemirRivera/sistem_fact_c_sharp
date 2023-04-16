using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class ClsVendedor
    {
        private int id_vendedor;
        private int id_sucursal;
        private string nombre;
        private string apellido;
        private string direccion;
        private string dui;
        private string telefono;
        private string email;

        public int Id_vendedor { get => id_vendedor; set => id_vendedor = value; }
        public int Id_sucursal { get => id_sucursal; set => id_sucursal = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Dui { get => dui; set => dui = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }

        public ClsVendedor()
        {

        }

        public ClsVendedor(int pId_vendedor, int pId_sucursal, string pNombre, string pApellido, string pDireccion, string pDui, string pTelefono, string pEmail)
        {
            this.id_vendedor = pId_vendedor;
            this.Id_sucursal = pId_sucursal;
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.Direccion = pDireccion;
            this.Dui = pDui;
            this.Telefono = pTelefono;
            this.Email = pEmail;
        }
    }
}
