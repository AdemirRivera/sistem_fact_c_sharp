using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class ClsTelSucursal
    {
        private int id_tel_sucursal;
        private int id_sucursal;
        private string telefono;

        public int Id_tel_sucursal { get => id_tel_sucursal; set => id_tel_sucursal = value; }
        public int Id_sucursal { get => id_sucursal; set => id_sucursal = value; }
        public string Telefono { get => telefono; set => telefono = value; }

        public ClsTelSucursal()
        {

        }

        public ClsTelSucursal(int pId_tel_sucursal, int pId_sucursal, string pTelefono)
        {
            this.Id_tel_sucursal = pId_tel_sucursal;
            this.Id_sucursal = pId_sucursal;
            this.Telefono = pTelefono;
        }
    }
}
