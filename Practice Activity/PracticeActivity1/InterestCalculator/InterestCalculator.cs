using System;

namespace InterestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter principal amount: ");
            double p = double.Parse(Console.ReadLine());

            Console.Write("Enter rate of interest: ");
            double r = double.Parse(Console.ReadLine());

            Console.Write("Enter time in years: ");
            double t = double.Parse(Console.ReadLine());

            Interest calc = new Interest(p, r, t);

            Console.WriteLine("Simple Interest: " + calc.Compute().ToString("F2"));

            Console.ReadKey();
        }
    }

    class Interest
    {
        private double principal;
        private double rate;
        private double time;

        public Interest(double p, double r, double t)
        {
            principal = p;
            rate = r;
            time = t;
        }

        public double Compute()
        {
            return (principal * rate * time) / 100;
        }
    }
}