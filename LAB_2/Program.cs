using System;


namespace Figures_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle_L rect = new Rectangle_L(5, 4);
            Square_L square = new Square_L(5);
            Circle_L circle = new Circle_L(5);

            rect.Print();
            square.Print();
            circle.Print();

            Console.ReadLine();
        }
    }
}

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

/// <summary>
/// Класс фигура
/// </summary>
abstract class Figure_Lab
{
    public Figure_Lab()
    {
    }
    /// <summary>
    /// Тип фигуры
    /// </summary>
    public string Type
    {
        get
        {
            return this._Type;
        }
        protected set
        {
            this._Type = value;
        }
    }
    string _Type;

    /// <summary>
    /// Вычисление площади
    /// </summary>
    public abstract double Area();

    /// <summary>
    /// Приведение к строке, переопределение метода Object
    /// </summary>
    public override string ToString()
    {
        return this.Type + " площадью " + this.Area().ToString();
    }
}

/// <summary>
/// Класс квадрат
/// </summary>
class Square_L : Rectangle_L, IPrint_L
{
    public Square_L(double size) : base(size, size)
    {
        this.Type = "Квадрат";
    }
}

/// <summary>
/// Интерфейс IPrint_L
/// </summary>
interface IPrint_L
{
    void Print();
}

/// <summary>
/// Класс круг
/// </summary>
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