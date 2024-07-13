namespace ConceptosBasicos;

public class Polimorfismo
{

    public class Shape
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public Shape(int x, int y, int height, int width)
        {
            X = x;
            Y = y;
            Height = height;
            Width = width;
        }

        public Shape()
        {
        }

        public virtual void Drav()
        {
            Console.WriteLine("Clase Base");
        }
    }

    public class Triangle : Shape
    {
        public override void Drav()
        {
            Console.WriteLine("Triangle");
            base.Drav();
        }
    }
    public class Rectangle : Shape
    {
        public override void Drav()
        {
            Console.WriteLine("Rectangle");
            base.Drav();
        }
    }

}


