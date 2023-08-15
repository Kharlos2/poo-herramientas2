using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_Herramientas_2
{
    internal class Docente: Persona
    {

        string horario = String.Empty;
        string programa = String.Empty;
        string facultad = String.Empty;
        double sueldo = 0;

        public string Horario { get => horario; set => horario = value; }
        public string Programa { get => programa; set => programa = value; }
        public string Facultad { get => facultad; set => facultad = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }

        public Docente()
        {
        }

        public Docente(string nom, int edad, float p, double est, string sex, string horario, string programa, string facultad, double sueldo) : base(nom, edad, p, est, sex)
        {
            Horario = horario;
            Programa = programa;
            Facultad = facultad;
            Sueldo = sueldo;
        }
        public override string ToString()
        {
            return base.ToString() + ($" horario: {Horario}, Programa: {Programa}, Facultad: {Facultad}, Sueldo: {Sueldo}");
        }
        public string CambioNombre(string nom)
        {
            base.Nombre = nom;
            return base.Nombre;
        }
    }
}
