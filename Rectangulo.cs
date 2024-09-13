using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller06._09._24
{
    internal class Rectangulo:Figura
    {
        float baseRectangulo;
        float alturaRectangulo; 

        public Rectangulo(float a,float b)
        {
            baseRectangulo = a;
            alturaRectangulo = b;
        }
        public override float CalcularArea()
        {
            return baseRectangulo * alturaRectangulo;
        }
    }
}
