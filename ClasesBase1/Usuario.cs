using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase1
{
    public class Usuario
    {
        private int USU_id;
        private string USU_nombreUser;
        private string USU_contrasena;
        private string USU_apellidoNombre;
        private string ROL_codigo;

        public Usuario() { }

        public Usuario(int id, string nombreUser, string contrasena, string apellidoNombre, string rolCodigo)
        {
            this.USU_id = id;
            this.USU_nombreUser = nombreUser;
            this.USU_contrasena = contrasena;
            this.USU_apellidoNombre = apellidoNombre;
            this.ROL_codigo = rolCodigo;
        }

        public int USU_Id
        {
            get { return USU_id; }
            set { USU_id = value; }
        }

        public string USU_NombreUser
        {
            get { return USU_nombreUser; }
            set { USU_nombreUser = value; }
        }

        public string USU_Contrasena
        {
            get { return USU_contrasena; }
            set { USU_contrasena = value; }
        }

        public string USU_ApellidoNombre
        {
            get { return USU_apellidoNombre; }
            set { USU_apellidoNombre = value; }
        }

        public string ROL_Codigo
        {
            get { return ROL_codigo; }
            set { ROL_codigo = value; }
        }
    }
}
