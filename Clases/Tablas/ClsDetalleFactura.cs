using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class ClsDetalleFactura
    {
        private int id_detalle_factura;
        private int id_factura;
        private int id_producto;
        private int cantidad;
        private float precio;
        private float subtotal;

        public int Id_detalle_factura { get => id_detalle_factura; set => id_detalle_factura = value; }
        public int Id_factura { get => id_factura; set => id_factura = value; }
        public int Id_producto { get => id_producto; set => id_producto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public float Precio { get => precio; set => precio = value; }
        public float Subtotal { get => subtotal; set => subtotal = value; }

        public ClsDetalleFactura()
        {

        }

        public ClsDetalleFactura(int pId_detalle_factura, int pId_factura, int pId_producto, int pCantidad, float pPrecio, float pSubtotal)
        {
            this.Id_detalle_factura = pId_detalle_factura;
            this.Id_factura = pId_factura;
            this.Id_producto = pId_producto;
            this.Cantidad = pCantidad;
            this.Precio = pPrecio;
            this.Subtotal = pSubtotal;
        }
    }
}
