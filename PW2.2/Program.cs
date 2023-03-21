using static System.Net.Mime.MediaTypeNames;

namespace PW2_2
{
    class UsingNumbers
    {
        private int n = 0;

        public bool setNumber(int number)
        {
            if (number == n + 1)
            {
                n = number;
                return true;
            }
            else
            {
                n = 0;
                return false;
            }
        }

        public int getNumber()
        {
            return n + 1;
        }

        class Program
        {
            public static void Main()
            {
                UsingNumbers num = new UsingNumbers();
                while (true) 
                {
                    Console.WriteLine($"Введи число: {num.getNumber}");

                    int x = Convert.ToInt32(Console.ReadLine());

                    if (num.setNumber(x))
                    {
                        Console.WriteLine("четко");
                    }
                    else
                    {
                        Console.WriteLine("по новой");
                    }
                }
                
            }
        }
    }
}