using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller06._09._24
{
    internal class Circulo
    {
        private float r;

        public Circulo(float r)
        {
            this.r = r;
        }

        public float CalcularArea() => r * r;
    }
}
