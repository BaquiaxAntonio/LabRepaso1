using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRepaso1
{
    internal class Reporte
    {
        string nombreEmpleado;
        decimal sueldoMesual;
        int mes;

        public string NombreEmpleado { get => nombreEmpleado; set => nombreEmpleado = value; }
        public decimal SueldoMesual { get => sueldoMesual; set => sueldoMesual = value; }
        public int Mes { get => mes; set => mes = value; }
    }
}
