using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class ClsProducto
    {
        private int id_producto;
        private int id_proveedor;
        private int id_categoria_producto;
        private string nombre;
        private decimal precio;
        private int existencias;
        private DateTime fecha_Vencimiento;

        public int Id_producto { get => id_producto; set => id_producto = value; }
        public int Id_proveedor { get => id_proveedor; set => id_proveedor = value; }
        public int Id_categoria_producto { get => id_categoria_producto; set => id_categoria_producto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public int Existencias { get => existencias; set => existencias = value; }
        public DateTime Fecha_Vencimiento { get => fecha_Vencimiento; set => fecha_Vencimiento = value; }

        public ClsProducto()
        {

        }

        public ClsProducto(int pId_producto, int pId_proveedor, int pId_categoria_producto, string pNombre, decimal pPrecio, int pExistencias, DateTime pFechaVenci)
        {
            this.Id_producto = pId_producto;
            this.Id_proveedor = pId_proveedor;
            this.Id_categoria_producto = pId_categoria_producto;
            this.Nombre = pNombre;
            this.Precio = pPrecio;
            this.Existencias = pExistencias;
            this.Fecha_Vencimiento = pFechaVenci;
        }
    }
}
