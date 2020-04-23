using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Venta
    {
        private int vta_Id;
        private string cli_Dni;
        private string veh_Matricula;
        private int usu_Id;
        private DateTime vta_Fecha;
        private string vta_FormaPago;
        private decimal vta_PrecioFinal;

        public Venta()
        {

        }

        public Venta(int vta_Id, string cli_Dni, string veh_Matricula, int usu_Id, DateTime vta_Fecha, string vta_FormaPago, decimal vta_PrecioFinal)
        {
            this.Vta_Id = vta_Id;
            this.Cli_Dni = cli_Dni;
            this.Veh_Matricula = veh_Matricula;
            this.Usu_Id = usu_Id;
            this.Vta_Fecha = vta_Fecha;
            this.Vta_FormaPago = vta_FormaPago;
            this.Vta_PrecioFinal = vta_PrecioFinal;
        }

        public int Vta_Id { get => vta_Id; set => vta_Id = value; }
        public string Cli_Dni { get => cli_Dni; set => cli_Dni = value; }
        public string Veh_Matricula { get => veh_Matricula; set => veh_Matricula = value; }
        public int Usu_Id { get => usu_Id; set => usu_Id = value; }
        public DateTime Vta_Fecha { get => vta_Fecha; set => vta_Fecha = value; }
        public string Vta_FormaPago { get => vta_FormaPago; set => vta_FormaPago = value; }
        public decimal Vta_PrecioFinal { get => vta_PrecioFinal; set => vta_PrecioFinal = value; }
    }
}