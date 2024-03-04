using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabRepaso1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Empleado> Empleados = new List<Empleado>();
        List<Asistencia> asistencias=new List<Asistencia>();
        List<Reporte> reportes = new List<Reporte>();
        public void MostrarEmpleados()
        {
            dataGridViewEmpleado.DataSource = null;
            dataGridViewEmpleado.DataSource = Empleados;
            dataGridViewEmpleado.Refresh();
        }

        public void MostrarAsistencia()
        {
            dataGridViewAsistencia.DataSource = null;
            dataGridViewAsistencia.DataSource = Empleados;
            dataGridViewAsistencia.Refresh();
        }

        public void cargarAsitencia()
        {
            string fileName = "Asistencia.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Asistencia asistencia = new Asistencia();
                asistencia.NoEmpleado = Convert.ToInt32(reader.ReadLine());
                asistencia.HoraMes = Convert.ToInt32(reader.ReadLine());
                asistencia.Mes = Convert.ToInt32(reader.ReadLine());

                asistencias.Add(asistencia);
            }
            reader.Close();
            MostrarAsistencia();
        }

        public void cargarEmpelados()
        {

            string fileName = "Empleado.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Empleado empleado = new Empleado();
                empleado.NoEmpleado = Convert.ToInt32(reader.ReadLine());
                empleado.NombreEmpleado = reader.ReadLine();
                empleado.SueldoHora = Convert.ToDecimal(reader.ReadLine());

                Empleados.Add(empleado);
            }
            reader.Close();
            MostrarEmpleados();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLeer_Click(object sender, EventArgs e)
        {
            cargarEmpelados();
            cargarAsitencia();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            foreach (Empleado empleado in Empleados)
            {
                int noEmpleado = empleado.NoEmpleado;
                foreach (Asistencia asistencia in asistencias)
                {
                    if (empleado.NoEmpleado == asistencia.NoEmpleado)
                    {
                        Reporte reporte = new Reporte();
                        reporte.NombreEmpleado=empleado.NombreEmpleado;
                        reporte.Mes=asistencia.Mes;
                        reporte.SueldoMesual = empleado.SueldoHora * asistencia.HoraMes;
                        reportes.Add(reporte);
                    }
                }
            }
            dataGridViewReporte.DataSource = null;
            dataGridViewReporte.DataSource = reportes;
            dataGridViewReporte.Refresh();


        }
    }
}
