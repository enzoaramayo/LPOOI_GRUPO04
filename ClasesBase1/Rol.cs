using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase1
{
    public class Rol
    {
        private string ROL_codigo;

        private string ROL_descripcion;

        public Rol() { }
        public Rol(string codigo, string descripcion)
        {
            this.ROL_codigo = codigo;
            this.ROL_descripcion = descripcion;
        }

        public string ROL_Codigo
        {
            get { return ROL_codigo; }
            set { ROL_codigo = value; }
        }

        public string ROL_Descripcion
        {
            get { return ROL_descripcion; }
            set { ROL_descripcion = value; }
        }
    }
}
