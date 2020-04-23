using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase1
{
    public class Vehiculo
    {
        private string VEH_matricula;
        private string VEH_marca;
        private string VEH_linea;
        private int VEH_modelo;
        private string VEH_color;
        private int VEH_puertas;
        private bool VEH_gps;
        private string VEH_tipoVehiculo;
        private string VEH_claseVehiculo;
        private decimal VEH_precio;

        public Vehiculo() { }
        public Vehiculo(string matricula, string marca, string linea, int modelo, string color,
            int puertas, bool gps, string tipoVehiculo, string claseVehiculo, decimal precio)
        {
            this.VEH_matricula = matricula;
            this.VEH_marca = marca;
            this.VEH_linea = linea;
            this.VEH_modelo = modelo;
            this.VEH_color = color;
            this.VEH_puertas = puertas;
            this.VEH_gps = gps;
            this.VEH_tipoVehiculo = tipoVehiculo;
            this.VEH_claseVehiculo = claseVehiculo;
            this.VEH_precio = precio;
        }

        /*get set*/
        public string VEH_Matricula
        {
            get { return this.VEH_matricula; }
            set { this.VEH_matricula = value; }
        }

        public string VEH_Marca
        {
            get { return this.VEH_marca; }
            set { this.VEH_marca = value; }
        }

        public string VEH_Linea
        {
            get { return this.VEH_linea; }
            set { this.VEH_linea = value; }
        }

        public int VEH_Modelo
        {
            get { return this.VEH_modelo; }
            set { this.VEH_modelo = value; }
        }

        public string VEH_Color
        {
            get { return this.VEH_color; }
            set { this.VEH_color = value; }
        }

        public int VEH_Puertas
        {
            get { return this.VEH_puertas; }
            set { this.VEH_puertas = value; }
        }

        public bool VEH_Gps
        {
            get { return this.VEH_gps; }
            set { this.VEH_gps = value; }
        }

        public string VEH_TipoVehiculo
        {
            get { return this.VEH_tipoVehiculo; }
            set { this.VEH_tipoVehiculo = value; }
        }

        public string VEH_ClaseVehiculo
        {
            get { return this.VEH_claseVehiculo; }
            set { this.VEH_claseVehiculo = value; }
        }

        public decimal VEH_Precio
        {
            get { return this.VEH_precio; }
            set { this.VEH_precio = value; }
        }
    }
}
