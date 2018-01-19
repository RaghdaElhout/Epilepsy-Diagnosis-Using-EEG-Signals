using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackPropagation
{
    class Layer
    {
        public List<Neourn> layer = new List<Neourn>();
        public Layer(int NeournCount)
        {
            for (int i=0; i < NeournCount; i++)
            {
                layer.Add(new Neourn());
            }
        }

    }
}
