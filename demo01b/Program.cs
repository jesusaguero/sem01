using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01b
{
    internal class Program
    {
        static void Main(string[] args)
        {

                
            persona persona = new persona();
            persona.Nombres = "Jesus Roberto";
            persona.Apellidos = "Agüero Anchivilca";
            persona.AsignarNombresCompletos();

            persona Persona2 = new persona
            {
                Nombres = "Juan",
                Apellidos = "Marquez",
            };

            triangle triangle = new triangle();
            triangle.Altura = 2;
            triangle.Base = 2;
            triangle.CalcularArea();


            Console.WriteLine(triangle.CalcularArea());
            Console.WriteLine(persona.NombresCompletos);
            Console.WriteLine("Hola Mundo");
            Console.Read();
        }

    }
}
