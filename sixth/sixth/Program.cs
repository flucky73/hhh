using System;

namespace sixth
{
    //Polygon Class
    public abstract class polygon
    {
        public int No_Side { get; set; }
        public string name { get; set; }
        public abstract double Mohit();
        public abstract double Masahat();

        public virtual void Show()
        {
            Console.WriteLine($"This Shape is a {name} and has {No_Side} Sides!");
        }
    }

    //Circle
    public class circle : polygon
    {
        public double r { get; set; }
        public double pi { get; set; }

        public circle(double a)
        {
            r = a;
            pi = 3.14;
            No_Side = 0;
            name = "Circle";
        }
        public override double Mohit()
        {
            return 2 * pi * r;
        }

        public override double Masahat()
        {
            return pi * Math.Pow(r, 2);
        }

        public override void Show()
        {
            Console.Write($"This Circle Radius is {r}\n");
            base.Show();
        }
    }
    //rectangle
    public class rectangle : polygon
    {
        public double tul { get; set; }
        public double arz { get; set; }

        public rectangle(double t,double a)
        {
            tul = t;
            arz = a;
            No_Side = 4;
            name = "Rectangle";
        }
        public override double Mohit()
        {
            return 2 *(tul+arz);
        }

        public override double Masahat()
        {
            return tul*arz;
        }

        public override void Show()
        {
            //Console.Write($"This Circle Radius is {r}");
            base.Show();
        }
    }





    class Program
    {
        static void Main(string[] args)
        {
            polygon r1 = new rectangle(6,7);
            polygon c1 = new circle(4);

            r1.Show();
            Console.WriteLine($"Mohit = {r1.Mohit()}\nMasahat = {r1.Masahat()}");
            Console.WriteLine("\n__________________\n");
            c1.Show();
            Console.WriteLine($"Mohit = {c1.Mohit()}\nMasahat = {c1.Masahat()}");

            Console.ReadKey();

        }
    }
}
