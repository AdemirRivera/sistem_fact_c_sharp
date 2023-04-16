using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class ClsCiudad
    {
        private int id_ciudad;
        private string nombre;

        public int Id_ciudad { get => id_ciudad; set => id_ciudad = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public ClsCiudad()
        {

        }

        public ClsCiudad(int pId_Ciudad, string pNombre)
        {
            this.Id_ciudad = pId_Ciudad;
            this.Nombre = pNombre;
        }
    }
}
