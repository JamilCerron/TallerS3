using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller06._09._24
{
    internal class Triangulo
    {
        private float b;
        private float h;

        public Triangulo(float b, float h)
        {
            this.b = b;
            this.h = h;
        }

        public float CalcularArea() => b * h / 2;

    }
}

