using System;
namespace inluppg35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv ett tal för att påbörja din miniräkning");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Megamäktigt, skriv det andra talet för att få din miniräkning");
            int tal2 = int.Parse(Console.ReadLine());
            Console.WriteLine("äe vänta lite du måste välja räknesättet också skriv 1 för addition, 2 för subtraktion, 3 för multiplikation eller 4 för division");
            string ettf = Console.ReadLine();

            switch (ettf)
            {
                case "1":
                    Console.WriteLine("ditt svar blir "+ (tal1 + tal2) + ". njut");
                    break;
                case "2":
                    Console.WriteLine("ditt svar blir " + (tal1 - tal2) + ". njut");
                    break;
                case "3":
                    Console.WriteLine("ditt svar blir " + (tal1 * tal2) + ". njut");
                    break;
                case "4":
                    Console.WriteLine("ditt svar blir " + (tal1 / tal2) + ". njut");
                    break;
            }
   
        }

    }

}
