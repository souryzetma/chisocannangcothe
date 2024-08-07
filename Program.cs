using System;
namespace canangcothe 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap can nang vao");
            double chieucao = double.Parse (Console.ReadLine());
            Console.WriteLine("Nhap can nang vao");
            double cannang = double.Parse (Console.ReadLine());

            double canangcothe  = cannang / Math.Pow(chieucao,2);

            canangcothe = Math.Round(canangcothe, 1);

            Console.Write("CANNANG:"+ canangcothe);

            if (canangcothe < 18)
                Console.WriteLine("thieucan");
            else if (canangcothe < 25.0)
                Console.WriteLine("binhthuong");
            else if (canangcothe < 30.0)
                Console.WriteLine("thuacan");
            else
                Console.WriteLine("beophi");

        }
    }
}