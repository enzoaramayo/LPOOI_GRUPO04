using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Cliente
    {
        private string cli_Dni;
        private string cli_Nombre;
        private string cli_Apellido;
        private string cli_Direccion;
        private string cli_Telefono;

        
        public Cliente()
        {

        }

        public Cliente(string cli_Dni, string cli_Nombre, string cli_Apellido, string cli_Direccion, string cli_Telefono)
        {
            this.cli_Dni = cli_Dni;
            this.cli_Nombre = cli_Nombre;
            this.cli_Apellido = cli_Apellido;
            this.cli_Direccion = cli_Direccion;
            this.cli_Telefono = cli_Telefono;
        }

        public string Cli_Dni { get => cli_Dni; set => cli_Dni = value; }
        public string Cli_Nombre { get => cli_Nombre; set => cli_Nombre = value; }
        public string Cli_Apellido { get => cli_Apellido; set => cli_Apellido = value; }
        public string Cli_Direccion { get => cli_Direccion; set => cli_Direccion = value; }
        public string Cli_Telefono { get => cli_Telefono; set => cli_Telefono = value; }
    }
}