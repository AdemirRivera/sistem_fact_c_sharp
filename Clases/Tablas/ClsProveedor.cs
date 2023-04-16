using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class ClsProveedor
    {
        private int id_proveedor;
        private string nombre;
        private string direccion;
        private string email;

        public int Id_proveedor { get => id_proveedor; set => id_proveedor = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Email { get => email; set => email = value; }

        public ClsProveedor()
        {

        }

        public ClsProveedor(int pId_proveedor, string pNombre, string pDireccion, string pEamil)
        {
            this.Id_proveedor = pId_proveedor;
            this.Nombre = pNombre;
            this.Direccion = pDireccion;
            this.Email = pEamil;
        }
    }
}
