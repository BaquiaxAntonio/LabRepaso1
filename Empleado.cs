using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRepaso1
{
    internal class Empleado
    {
        int noEmpleado;
        string nombreEmpleado;
        decimal sueldoHora;

        public int NoEmpleado { get => noEmpleado; set => noEmpleado = value; }
        public string NombreEmpleado { get => nombreEmpleado; set => nombreEmpleado = value; }
        public decimal SueldoHora { get => sueldoHora; set => sueldoHora = value; }
    }
}
