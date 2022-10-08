using System;
using System.Drawing;

namespace I1P622_GianlucaPetronio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Feu de signalisation");
            Console.WriteLine();

            Signalisation[] signalisation = new Signalisation[2];

            for (int i = 0; i < signalisation.Length; i++)
            {
                Console.WriteLine("état des feux :");
                Console.WriteLine("---------------");
                Console.WriteLine(signalisation.afficheColorAndType());

                Console.WriteLine("changement d'état :");
                Console.WriteLine("-------------------");

                Console.WriteLine("feu clignotant :");
                Console.WriteLine("----------------");
            }
        }
    }
}