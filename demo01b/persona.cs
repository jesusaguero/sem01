using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01b
{
    public class persona
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }

        public int edad { get; set; }

        public String NombresCompletos { get; set; }


        public String EstadoEdad()
        {
            string mensaje = "Es menor de edad";
            if (edad > 18)
                mensaje = "Es mayor de edad";
            return mensaje;
            {

            }

        }

        public void AsignarNombresCompletos()
        {
            NombresCompletos = Nombres + " " + Apellidos;
        }

    
    }
}
