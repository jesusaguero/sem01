using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01b
{
    public class triangle
    {
        public int Base { get; set; }
        public int Altura { get; set; }

        public int CalcularArea()
        { 
            return (Base * Altura)/2; 
        }


    }
}
