using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class ClsCategoriaProducto
    {
        private int id_categoria;
        private string nombre;

        public int Id_categoria { get => id_categoria; set => id_categoria = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public ClsCategoriaProducto()
        {

        }

        public ClsCategoriaProducto(int pId_categoria, string pNombre)
        {
            this.Id_categoria = pId_categoria;
            this.Nombre = pNombre;
        }
    }
}
