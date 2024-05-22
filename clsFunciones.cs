using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryReservasLopezTerminado
{
    public class clsFunciones
    {
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public string Teatro { get; set; }
        public decimal Costo { get; set; }

        public clsFunciones(string nombre, DateTime fecha, string hora, string teatro, decimal costo)
        {
            Nombre = nombre;
            Fecha = fecha;
            Hora = hora;
            Teatro = teatro;
            Costo = costo;
        }

        public override string ToString()
        {
            return $"{Nombre} - {Fecha.ToShortDateString()} {Hora}";
        }
    }
}
