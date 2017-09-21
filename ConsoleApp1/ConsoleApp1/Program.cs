using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum Typy
    {
        Lod, Prazdno, Strela, Minuto
    }
    class Program
    {
        static void Main(string[] args)
        {   
            // Hrací plocha
            int[,] hraciPole = new int[10, 10];
            // Zobrazení hrací plochy
            for (int i = 0; i < hraciPole.GetLength(0); i++)
            {
                for (int x = 0; x < hraciPole.GetLength(1); x++)
                {
                    Console.Write(hraciPole[i, x]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            for (int z = 0; z < 5; z++)
            {
                // Zadání pozice lodě
                int pX = 0;
                int pY = 0;
                int velikostLode = 0;
                Console.WriteLine();
                Console.WriteLine("Vyberte velikost lodě: ");
                string velikostLodeI = Console.ReadLine();
                Console.WriteLine("Zadejte souřadnici X: ");
                string vX = Console.ReadLine();
                Console.WriteLine("Zadajte souřadnici Y: ");
                string vY = Console.ReadLine();
                Console.WriteLine("Umístit loď vertikálně nebo horizontálně? (v/h)");
                string pozice = Console.ReadLine();
                try
                {
                    pX = int.Parse(vX);
                    pY = int.Parse(vY);
                    velikostLode = int.Parse(velikostLodeI);
                }
                catch (Exception)
                {
                    Console.Write("Zadávejte pouze čísla!");
                    Console.WriteLine();
                }
                // Umístění lodě na hrací pole
                int aX = 0;
                int bX = 0;
                bool stop = false;
                for (int f = 0; f < velikostLode; f++)
                {
                    if (pozice == "v")
                    {
                        aX = f;
                    }
                    else if (pozice == "h")
                    {
                        bX = f;
                    }
                    if (((hraciPole[pX + aX, pY + bX] == 1)) || ( stop == true))
                    {
                        Console.WriteLine("Na této pozici se loď již nachází!");
                        stop = true;
                        z = z - 1;  // bug
                    }
                    else
                    {
                        // Zapsání lodě do pole
                        hraciPole[pX + aX, pY + bX] = 1;
                    }
                    
                }
                // Zobrazení hrací plochy
                for (int i = 0; i < hraciPole.GetLength(0); i++)
                {
                    for (int x = 0; x < hraciPole.GetLength(1); x++)
                    {
                        Console.Write(hraciPole[i, x]);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
            

        }
        static void zobrazitPole(string hraciPole)
        {

        }
    }
}
