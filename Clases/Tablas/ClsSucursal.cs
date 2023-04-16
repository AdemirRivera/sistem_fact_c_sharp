using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class ClsSucursal
    {
        private int id_sucursal;
        private int id_ciudad;
        private string nombre;
        private string direccion;

        public int Id_sucursal { get => id_sucursal; set => id_sucursal = value; }
        public int Id_ciudad { get => id_ciudad; set => id_ciudad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        public ClsSucursal()
        {

        }

        public ClsSucursal(int pId_sucursal, int pId_ciudad, string pNombre, string pDireccion)
        {
            this.Id_sucursal = pId_sucursal;
            this.Id_ciudad = pId_ciudad;
            this.Nombre = pNombre;
            this.Direccion = pDireccion;
        }
    }
}
