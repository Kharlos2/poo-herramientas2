using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_Herramientas_2
{
    /// <summary>
    /// Clase Persona con atributos y metodos
    /// </summary>
    internal class Persona
    {

        /// <summary>
        /// Atributos de la clase Persona
        /// </summary>
        string nombre = String.Empty;
        int edad = 0;
        float peso = 0;
        double estatura = 0;
        string sexo = String.Empty;


        /// <summary>
        /// Metodo constructor simple
        /// </summary>
        public Persona() { }

        /// <summary>
        /// Metodo Constructor de la clase Persona
        /// </summary>
        /// <param name="nom">asigna nombre persona</param>
        /// <param name="edad">asigna edad persona</param>
        /// <param name="p">asigna peso persona</param>
        /// <param name="est">asigna estatura</param>
        /// <param name="sex">asigna sexo</param>
        public Persona(string nom, int edad, float p,
            double est, string sex)
        {

            this.nombre = nom;
            this.edad = edad;
            this.peso = p;
            this.estatura = est;
            this.sexo = sex;


        }


        /// <summary>
        /// Metodo para decir el nombre de la persona
        /// </summary>
        /// <returns>mensaje con el nombre</returns>
        public string Hablar()
        {
            return "Hola mi nombre es: " + nombre;
        }

        /// <summary>
        /// Metodo para desplazarse
        /// </summary>
        /// <returns>nuevo peso</returns>
        public float Desplazarse()
        {
            peso = peso - 1;
            return peso;
        }

        /// <summary>
        /// Metodo para comer
        /// </summary>
        /// <returns>nuevo peso</returns>
        public float Comer()
        {
            peso = peso + 1;
            return peso;
        }

        public double Envejecer()
        {

            edad = edad + 1;
            return edad;
        }

        public override string ToString()
        {
            return "nombre: " + nombre + " Edad: " + edad +
                " peso: " + peso + " estatura: " + estatura +
                " sexo: " + sexo;
        }

        protected string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public double Estatura { get => estatura; set => estatura = value; }
        public float Peso { get => peso; set => peso = value; }

    }
}
