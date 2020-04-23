using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Usuario
    {
        private int usu_Id;
        private string usu_NombreUsuario;
        private string usu_Contrasena;
        private string usu_ApellidoNombre;
        private string rol_Codigo;
       
        public Usuario()
        {

        }

        public Usuario(string usu_NombreUsuario, string usu_Contrasena, string rol_Codigo)
        {
            this.usu_NombreUsuario = usu_NombreUsuario;
            this.usu_Contrasena = usu_Contrasena;
            this.rol_Codigo = rol_Codigo;
        }

        public Usuario(int usu_Id, string usu_NombreUsuario, string usu_Contrasena, string usu_ApellidoNombre, string rol_Codigo)
        {
            this.Usu_Id = usu_Id;
            this.Usu_NombreUsuario = usu_NombreUsuario;
            this.Usu_Contrasena = usu_Contrasena;
            this.Usu_ApellidoNombre = usu_ApellidoNombre;
            this.Rol_Codigo = rol_Codigo;
        }

        public int Usu_Id { get => usu_Id; set => usu_Id = value; }
        public string Usu_NombreUsuario { get => usu_NombreUsuario; set => usu_NombreUsuario = value; }
        public string Usu_Contrasena { get => usu_Contrasena; set => usu_Contrasena = value; }
        public string Usu_ApellidoNombre { get => usu_ApellidoNombre; set => usu_ApellidoNombre = value; }
        public string Rol_Codigo { get => rol_Codigo; set => rol_Codigo = value; }


        public override string ToString()
        {
            return Usu_NombreUsuario;
        }
    }

    
}