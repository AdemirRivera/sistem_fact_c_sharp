using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class ClsCliente
    {
        private int id_cliente;
        private int id_ciudad;
        private string nombre;
        private string apellido;
        private string direccion;
        private DateTime fecha_nacimiento;
        private string dui;
        private string telefono;
        private string email;

        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public int Id_ciudad { get => id_ciudad; set => id_ciudad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public DateTime Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public string Dui { get => dui; set => dui = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }

        public ClsCliente()
        {

        }

        public ClsCliente(int pId_cliente, int pId_ciudad, string pNombre, string pApellido, string pDireccion, DateTime pFecha_nacimiento, string pDui, string pTelefono, string pEmail)
        {
            this.Id_cliente = pId_cliente;
            this.Id_ciudad = pId_ciudad;
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.Direccion = pDireccion;
            this.Fecha_nacimiento = pFecha_nacimiento;
            this.Dui = pDui;
            this.Telefono = pTelefono;
            this.Email = pEmail;
        }
    }
}
