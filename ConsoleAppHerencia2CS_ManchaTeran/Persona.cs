using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHerencia2CS_ManchaTeran
{
    class Persona
    {
        protected string nombre;
        protected string fechadenacimiento;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public string Fechadenacimiento
        {
            get
            {
                return fechadenacimiento;
            }
            set
            {
                fechadenacimiento = value;
            }
        }

        public Persona()
        {
            nombre = "" ;
            fechadenacimiento = "";
        }

        public override string ToString()
        {
            return "    Nombre: " + nombre + "    Fecha de nacimiento: " + fechadenacimiento;
        }
    }
}
