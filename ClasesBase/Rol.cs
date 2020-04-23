using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Rol
    {
        private string rol_Codigo;
        private string rol_Descripcion;

        public Rol()
        {

        }

        public Rol(string rol_Codigo, string rol_Descripcion)
        {
            this.Rol_Codigo = rol_Codigo;
            this.Rol_Descripcion = rol_Descripcion;
        }

        public string Rol_Codigo { get => rol_Codigo; set => rol_Codigo = value; }
        public string Rol_Descripcion { get => rol_Descripcion; set => rol_Descripcion = value; }
    }
}