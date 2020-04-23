using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase1
{
    public class Venta
    {
        private int VTA_id;
        private string CLI_dni;
        private string VEH_matricula;
        private int USU_id;
        private DateTime VTA_fecha;
        private string VTA_formaPago;
        private decimal VTA_precioFinal;

        public Venta() { }
        public Venta(int id, string cliDni, string vehMatricula, int usuId, DateTime fecha,
            string formaPago, decimal precioFinal)
        {
            this.VTA_id = id;
            this.CLI_dni = cliDni;
            this.VEH_matricula = vehMatricula;
            this.USU_id = usuId;
            this.VTA_fecha = fecha;
            this.VTA_formaPago = formaPago;
            this.VTA_precioFinal = precioFinal;
        }
        /*get set*/
        public int VTA_Id
        {
            get { return VTA_id; }
            set { VTA_id = value; }
        }

        public string CLI_Dni
        {
            get { return CLI_dni; }
            set { CLI_dni = value; }
        }

        public string VEH_Matricula
        {
            get { return VEH_matricula; }
            set { VEH_matricula = value; }
        }

        public int USU_Id
        {
            get { return USU_id; }
            set { USU_id = value; }
        }

        public DateTime VTA_Fecha
        {
            get { return VTA_fecha; }
            set { VTA_fecha = value; }
        }

        public string VTA_FormaPago
        {
            get { return VTA_formaPago; }
            set { VTA_formaPago = value; }
        }

        public decimal VTA_PrecioFinal
        {
            get { return VTA_precioFinal; }
            set { VTA_precioFinal = value; }
        }
    }
}
