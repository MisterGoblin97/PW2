using PW2;
using System.Xml.Linq;

namespace PW2 {
    class calcDisc {
        double a;
        double b;
        double c;

        double FirstRoot;
        double SecondRoot;

        public calcDisc(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        //нахождение дискриминанта
        private double FindDisc()
        {
            return Math.Pow(b, 2) - 4 * a * c;

        }

        //расчет корней
        public void FindRoots()
        {
            double d = FindDisc();
            if (d >= 1)
            {
                FirstRoot = (-b + Math.Sqrt(d)) / (2 * a);
                SecondRoot = (-b - Math.Sqrt(d)) / (2 * a);

                Console.WriteLine($"X1 = {FirstRoot}, X2 = {SecondRoot}");
            }
            else if (d == 0)
            {
                FirstRoot = -b / (2 * a);
                SecondRoot = 0;

                Console.WriteLine($"X1 = {FirstRoot}, X2 = {SecondRoot}");
            }
            else if (d < 0)
            {
                FirstRoot = 0;
                SecondRoot = 0;

                Console.WriteLine("Корней нет");
            }
        }
            

        private double StateFirstRoot()
        {
            return this.FirstRoot;
        }
        private double StateSecondRoot()
        {
            return this.FirstRoot;
        }
    } }
class Program
{
    public static void Main()
    {
        calcDisc disc = new calcDisc(5, 3, -26);
        disc.FindRoots();
    }
}