using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Створити узагальнений клас прямої на площині.
//У класі передбачити 2 поля типу узагальненої точки — точки, через які проходить пряма.
//Реалізувати в класі:
//■ конструктор, який приймає 2 точки
//■ конструктор, які приймає 4 координати (x і у координати для першої та другої точки)
//■ метод ToString()


namespace Line_class
{
    public class Point2D<T>
    {
        public T X { get; set; }
        public T Y { get; set; }

        public Point2D(T x, T y) { X = x; Y = y; }
        public Point2D() { X = default(T); Y = default(T); }
        public override string ToString()
        {
            return $"(X = {this.X}; Y = {this.Y})";
        }
    }


    public class Line<T,T1>
    {
        private Point2D<T> pointA;
        private Point2D<T1> pointB;

        public Line()
        {
            this.pointA = new Point2D<T>();
            this.pointB = new Point2D<T1>();
        }

        public Line(Point2D<T> pointA, Point2D<T1> pointB)
        {
            this.pointA = pointA;
            this.pointB = pointB;
        }

        public Line(T x1, T y1, T1 x2, T1 y2)
        {
            this.pointA = new Point2D<T>(x1, y1);
            this.pointB = new Point2D<T1>(x2, y2); 
        }

        public override string ToString() 
        {
            return $"Point A {pointA}\nPoint B {pointB}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point2D<int>(200, 220);
            Console.WriteLine($"Point A coordinates {p1}");
            var p2 = new Point2D<double>(-50, -10);
            Console.WriteLine($"Point B coordinates {p2}");

            var line_default = new Line<double, int>();
            Console.WriteLine($"\nUsing Line default constructor_________________________________");
            Console.WriteLine($"Points through which the line passes.\n{line_default}");
            Console.WriteLine($"\nUsing Line constructor with two point objects__________________");
            var line_from_points = new Line<int, double>(p1, p2);
            Console.WriteLine($"Points through which the line passes.\n{line_from_points}");
            Console.WriteLine($"\nUsing Line constructor with four coordinates___________________");
            var line_from_coord = new Line<double, float>(10.4, 12, 120, 188.55f);
            Console.WriteLine($"Points through which the line passes.\n{line_from_coord}");
        }
    }
}
