using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class ClsUsuario
    {
        private int id_usuario;
        private int id_vendedor;
        private int id_tipo_usuario;
        private string usuario;
        private string contrasena;

        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public int Id_vendedor { get => id_vendedor; set => id_vendedor = value; }
        public int Id_tipo_usuario { get => id_tipo_usuario; set => id_tipo_usuario = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
  
        public ClsUsuario()
        {

        }

        public ClsUsuario(int pId_usuario, int pId_vendedor, int pId_tipo_usuario, string pUsuario, string pContrasena)
        {
            this.Id_usuario = pId_usuario;
            this.Id_vendedor = pId_vendedor;
            this.Id_tipo_usuario = pId_tipo_usuario;
            this.Usuario = pUsuario;
            this.Contrasena = pContrasena;
        }
    }
}
