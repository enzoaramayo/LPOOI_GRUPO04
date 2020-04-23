using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase1
{
    public class Cliente
    {
        private string CLI_dni;
        private string CLI_nombre;
        private string CLI_apellido;
        private string CLI_telefono;
        private string CLI_direccion;


        public Cliente() { }
        public Cliente(string dni, string nombre, string apellido, string telefono, string direccion)
        {
            this.CLI_dni = dni;
            this.CLI_nombre = nombre;
            this.CLI_apellido = apellido;
            this.CLI_telefono = telefono;
            this.CLI_direccion = direccion;
        }
        /* getters and setters*/

        public string CLI_Dni
        {
            get { return this.CLI_dni; }
            set { this.CLI_dni = value; }
        }

        public string CLI_Nombre
        {
            get { return this.CLI_nombre; }
            set { this.CLI_nombre = value; }
        }

        public string CLI_Apellido
        {
            get { return this.CLI_apellido; }
            set { this.CLI_apellido = value; }
        }

        public string CLI_Telefono
        {
            get { return this.CLI_telefono; }
            set { this.CLI_telefono = value; }
        }

        public string CLI_Direccion
        {
            get { return this.CLI_direccion; }
            set { this.CLI_direccion = value; }
        }
    }
}
