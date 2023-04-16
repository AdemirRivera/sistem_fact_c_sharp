using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class ClsTipoUsuario
    {
        private int id_tipo_usuario;
        private string tipo_usuario;

        public int Id_tipo_usuario { get => id_tipo_usuario; set => id_tipo_usuario = value; }
        public string Tipo_usuario { get => tipo_usuario; set => tipo_usuario = value; }

        public ClsTipoUsuario()
        {

        }

        public ClsTipoUsuario(int pId_tipo_usuario, string pTipo_usuario)
        {
            this.Id_tipo_usuario = pId_tipo_usuario;
            this.Tipo_usuario = pTipo_usuario;
        }
    }
}
