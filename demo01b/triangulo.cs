using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01b
{
    public class Triangulo 
    {
        public int x1 { get; set; }
        public int x2 { get; set; }
        public int x3 { get; set; }

        public int y1 { get; set; }
        public int y2 { get; set; }
        public int y3 { get; set; }

        public Triangulo(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
        }

        public double CalcularArea()
        {
            double a = CalcularDistance(x1, y1, x2, y2);
            double b = CalcularDistance(x2, y2, x3, y3);
            double c = CalcularDistance(x3, y3, x1, y1);

            double semiperimetro = (a + b + c) / 2;
            return Math.Sqrt(semiperimetro * (semiperimetro - a) * (semiperimetro - b) * (semiperimetro - c));
        }

        public double CalcularDistance(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public double CalcularPerimetro()
        {
            double a = CalcularDistance(x1, y1, x2, y2);
            double b = CalcularDistance(x2, y2, x3, y3);
            double c = CalcularDistance(x3, y3, x1, y1);
            return a + b + c;
        }


    }

}
