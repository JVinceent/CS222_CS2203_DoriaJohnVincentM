using System;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter amount in USD: ");
            double usdAmount = double.Parse(Console.ReadLine());

            Console.Write("Enter exchange rate from USD to EUR: ");
            double exchangeRate = double.Parse(Console.ReadLine());

            Converter myConverter = new Converter(exchangeRate);
            double result = myConverter.ToEuro(usdAmount);

            Console.WriteLine($"Amount in EUR: {result:F2}");

            Console.ReadKey();
        }
    }

    class Converter
    {
        private double rate;
        public Converter(double currentRate)
        {
            rate = currentRate;
        }

        public double ToEuro(double amount)
        {
            return amount * rate;
        }
    }
}