using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller06._09._24
{
    internal abstract class Figura // Es abstracta debido a que quiero tenerlo como base de futuras subclases y que respeten su estructura. Y como reemplazo del return 0 del método public virtual float CalcularArea(), dejando la implementacion faltante en sus subclases
    {
        public abstract float CalcularArea();
    }

}
