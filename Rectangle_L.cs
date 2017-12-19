using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures_Lab
{
    class Rectangle_L : Figure_Lab, IPrint_L
    {
        /// <summary>
        /// Высота
        /// </summary>
        double height;

        /// <summary>
        /// Ширина
        /// </summary>
        double width;

        /// <summary>
        /// Основной конструктор
        /// </summary>
        /// <param name="ph">Высота</param>
        /// <param name="pw">Ширина</param>
        public Rectangle_L(double ph, double pw)
        {
            this.height = ph;
            this.width = pw;
            this.Type = "Прямоугольник";
        }

        /// <summary>
        /// Вычисление площади
        /// </summary>
        public override double Area()
        {
            double Result = this.width * this.height;
            return Result;
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
