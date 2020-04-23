using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Vehiculo
    {
        private string veh_Matricula;
        private string veh_Marca;
        private string veh_Linea;
        private int veh_Modelo;
        private string veh_Color;
        private int veh_Puertas;
        private bool veh_Gps;
        private string veh_TipoVehiculo;
        private string veh_ClaseVehiculo;
        private decimal veh_Precio;

        public Vehiculo()
        {

        }

        public Vehiculo(string veh_Matricula, string veh_Marca, string veh_Linea, int veh_Modelo, string veh_Color, int veh_Puertas, bool veh_Gps, string veh_TipoVehiculo, string veh_ClaseVehiculo, decimal veh_Precio)
        {
            this.veh_Matricula = veh_Matricula;
            this.veh_Marca = veh_Marca;
            this.veh_Linea = veh_Linea;
            this.veh_Modelo = veh_Modelo;
            this.veh_Color = veh_Color;
            this.veh_Puertas = veh_Puertas;
            this.veh_Gps = veh_Gps;
            this.veh_TipoVehiculo = veh_TipoVehiculo;
            this.veh_ClaseVehiculo = veh_ClaseVehiculo;
            this.veh_Precio = veh_Precio;
        }

        public string Veh_Matricula { get => veh_Matricula; set => veh_Matricula = value; }
        public string Veh_Marca { get => veh_Marca; set => veh_Marca = value; }
        public string Veh_Linea { get => veh_Linea; set => veh_Linea = value; }
        public int Veh_Modelo { get => veh_Modelo; set => veh_Modelo = value; }
        public string Veh_Color { get => veh_Color; set => veh_Color = value; }
        public int Veh_Puertas { get => veh_Puertas; set => veh_Puertas = value; }
        public bool Veh_Gps { get => veh_Gps; set => veh_Gps = value; }
        public string Veh_TipoVehiculo { get => veh_TipoVehiculo; set => veh_TipoVehiculo = value; }
        public string Veh_ClaseVehiculo { get => veh_ClaseVehiculo; set => veh_ClaseVehiculo = value; }
        public decimal Veh_Precio { get => veh_Precio; set => veh_Precio = value; }
    }
}