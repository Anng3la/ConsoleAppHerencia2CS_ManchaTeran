using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHerencia2CS_ManchaTeran
{
    class Alumno : Persona
    {
        private string matricula;
        private string carrera;

        public string Matricula
        {
            get
            {
                return matricula;
            }
            set
            {
                matricula = value;
            }
        }

        public string Carrera
        {
            get
            {
                return carrera;
            }
            set
            {
                carrera = value;
            }
        }

        public Alumno() 
        {
            matricula = "";
            carrera = "";
        }

        public Alumno( string nombre , string fechadenacimiento , string matricula , string carrera ) : base()
        {
            this.matricula = matricula;
            this.carrera = carrera;
        }

        public override string ToString()
        {
            return "    Nombre: " + nombre + "    Fecha de nacimiento: " + fechadenacimiento + "    Matrícula: " + matricula + "    Carrera: " + carrera;
        }
    }
}
