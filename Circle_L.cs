using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures_Lab
{

    class Circle_L : Figure_Lab, IPrint_L
{
        /// <summary>
        /// Радиус
        /// </summary>
        double radius;

        /// <summary>
        /// Основной конструктор
        /// </summary>
        
        public Circle_L(double pr)
        {
            this.radius = pr;
            this.Type = "Круг";
        }

        public override double Area()
        {
            double Result = Math.PI * this.radius * this.radius;
            return Result;
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
