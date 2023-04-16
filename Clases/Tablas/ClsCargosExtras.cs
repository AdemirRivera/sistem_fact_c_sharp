using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class ClsCargosExtras
    {
        private int id_cargos_extras;
        private int id_factura;
        private float impuestos;
        private float iva;
        private float descuentos;

        public int Id_cargos_extras { get => id_cargos_extras; set => id_cargos_extras = value; }
        public int Id_factura { get => id_factura; set => id_factura = value; }
        public float Impuestos { get => impuestos; set => impuestos = value; }
        public float Iva { get => iva; set => iva = value; }
        public float Descuentos { get => descuentos; set => descuentos = value; }

        public ClsCargosExtras()
        {

        }

        public ClsCargosExtras(int pId_cargos_extras, int pId_factura, float pImpuestos, float pIva, float pDescuentos)
        {
            this.Id_cargos_extras = pId_cargos_extras;
            this.Id_factura = pId_factura;
            this.Impuestos = pImpuestos;
            this.Iva = pIva;
            this.Descuentos = pDescuentos;
        }
    }
}
