using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures_Lab
{
    class Square_L : Rectangle_L, IPrint_L
    {
        public Square_L(double size) : base(size, size)
        {
            this.Type = "Квадрат";
        }
    }
}
