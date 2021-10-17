using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHerencia2CS_ManchaTeran
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona a = new Persona();
            Alumno b = new Alumno();
            
            Console.WriteLine("--> INGRESA DATOS <--");

            Console.WriteLine("");
            Console.WriteLine("DATOS PERSONA");
            Console.WriteLine(" - Nombre:");
            a.Nombre = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine(" - Fecha de nacimiento:");
            a.Fechadenacimiento = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("DATOS ALUMNO");
            Console.WriteLine(" - Nombre:  ");
            b.Nombre = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine(" - Fecha de nacimiento:");
            b.Fechadenacimiento = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine(" - Matricula:");
            b.Matricula = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine(" - Carrera:");
            b.Carrera = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("DATOS DE LA PERSONA= " + a.ToString());
            Console.WriteLine("DATOS DEL ALUMNO= " + b.ToString());
            Console.ReadKey();
        }
    }
}
