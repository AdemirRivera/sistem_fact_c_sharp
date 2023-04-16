using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class ClsTelProveedor
    {
        private int id_tel_proveedor;
        private int id_proveedor;
        private string telefono;

        public int Id_tel_proveedor { get => id_tel_proveedor; set => id_tel_proveedor = value; }
        public int Id_proveedor { get => id_proveedor; set => id_proveedor = value; }
        public string Telefono { get => telefono; set => telefono = value; }

        public ClsTelProveedor()
        {

        }

        public ClsTelProveedor(int pId_tel_proveedor, int pId_proveedor, string pTelefono)
        {
            this.Id_tel_proveedor = pId_tel_proveedor;
            this.Id_proveedor = pId_proveedor;
            this.Telefono = pTelefono;
        }
    }
}
