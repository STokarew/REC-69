using System;

namespace REC_69
{
    class Program
    {
        static double GetSr( int x)
        {
            return Math.Round((Math.PI*Math.Pow(x,2)),2);
        }
        static double GetSd(int x)
        {
            return Math.Round(((Math.PI * Math.Pow(x, 2)) /4),2);
        }
        static void Main(string[] args)
        {
            Console.Write("Введите радиус круга: ");
            int r = Convert.ToInt32(Console.ReadLine());
            double S = GetSr(r);
            Console.WriteLine($"Площадь круга равна: {S}см") ;


            Console.Write("Введите диамерт круга: ");
            int d = Convert.ToInt32(Console.ReadLine());
            double S1 = GetSd(d);
            Console.WriteLine($"Площадь круга равна: {S1}см");

            Console.ReadKey();
        }
    }
}
