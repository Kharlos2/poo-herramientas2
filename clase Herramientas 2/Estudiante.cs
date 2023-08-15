using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_Herramientas_2
{
    internal class Estudiante : Persona
    {
        string programa = string.Empty;
        int semestre = 0;
        string asignatura = string.Empty;
        string codigo = string.Empty;
        string jornada = string.Empty;
        bool matricula = false;

        public string Programa { get => programa; set => programa = value; }
        public int Semestre { get => semestre; set => semestre = value; }
        public string Asignatura { get => asignatura; set => asignatura = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Jornada { get => jornada; set => jornada = value; }
        public bool Matricula { get => matricula; set => matricula = value; }


        public Estudiante(string nom, float p, double est, string sex, int edad, string programa, int semestre, string asignatura, string codigo, string jornada, bool matricula) : base(nom, edad, p, est, sex)
        {
            Programa = programa;
            Semestre = semestre;
            Asignatura = asignatura;
            Codigo = codigo;
            Jornada = jornada;
            Matricula = matricula;
        }

        public override string ToString()
        {
            return base.ToString() + "Programa: " + Programa + " Semestre: " + Semestre + " Asignatura: " + Asignatura + " Codigo: " + Codigo + " Jordana: " + Jornada + " Matricula: " + Matricula;
        }

        public Estudiante() { }

        public string CambioNombre(string nom)
        {
            base.Nombre = nom;
            return base.Nombre;
        }

    }
}
