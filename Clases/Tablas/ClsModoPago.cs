using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class ClsModoPago
    {
        private int id_modo_pago;
        private int tipo_pago;

        public int Id_modo_pago { get => id_modo_pago; set => id_modo_pago = value; }
        public int Tipo_pago { get => tipo_pago; set => tipo_pago = value; }

        public ClsModoPago()
        {

        }

        public ClsModoPago(int pId_modo_pago, string pTipo_pago)
        {
            this.Id_modo_pago = pId_modo_pago;
            this.Tipo_pago = int.Parse(pTipo_pago); ;
        }
    }
}
