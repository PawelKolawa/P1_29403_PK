using System;

namespace Calculator.ConsoleApp
{
    public class Program
    {
        static void Main() 
        {
            Console.WriteLine(7 % 2);
        }
        public double dodawanie(double a, double b)
        {
            return a + b;
        }

        public double odejmowanie(double a, double b)
        {
            return a - b;
        }

        public double mnozenie(double a, double b)
        {
            return a * b;
        }

        public double dzielenie(double a, double b)
        {
            double y = 0;
            if (b == 0)
            {
                Console.WriteLine("Nie dzielimy przez 0");
            }            
            else
            {
               
                y = a / b;
            }
            return y;
        }

        public double reszta_z_dzielenia(double a, double b)
        {
            double y = 0;
            if (b == 0)
            {
                Console.WriteLine("Nie dzielimy przez 0");
            }
            else
            {

                y = a % b;
            }
            return y;
        }

        public double potega(double a, double b)
        {
            double wynik=1;
            while (b > 0)
            {
                wynik *= a;
                b--;
            }
            return wynik;
        }

    }
}