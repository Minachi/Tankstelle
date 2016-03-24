using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kassenautomat
{
    public class Program
    {
        static void Main(string[] args)
        {

            Kassenautomat kassenautomat = new Kassenautomat();
            string befehl;
            Console.WriteLine("Münze einwerfen -> ME");
            Console.WriteLine("Betrag abfragen -> BA");
            Console.WriteLine("Bitte geben Sie einen Befehl ein: ");
            befehl = Console.ReadLine();
            switch (befehl)
            {
                case "ME":
                    Console.WriteLine("10Rp. -> 10");
                    Console.WriteLine("20Rp. -> 20");
                    Console.WriteLine("50Rp.. -> 50");
                    Console.WriteLine("1Fr. -> 100");
                    Console.WriteLine("2Fr. -> 200");
                    Console.WriteLine("5Fr. -> 500");
                    Console.WriteLine("Bitte geben Sie einen Wert ein: ");
                    int muenze = Convert.ToInt32(Console.ReadLine());
                    kassenautomat.InsertCoin(muenze);
                    break;
                case "BA":
                    Console.WriteLine(kassenautomat.GetValueInput());
                    Console.ReadKey();
                    break;
                default:
                    break;
            }
        }
    }
}
