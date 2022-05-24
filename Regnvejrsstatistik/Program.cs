using System;
using System.Collections.Generic;
using System.Linq;

namespace Regnvejrsstatistik
{
    class Program
    {
        private static Beregninger beregninger = new Beregninger();

        static void Main(string[] args)
        {
            double indtastet;
            int antalDage;

            while (true)
            {
                try
                {
                    Console.WriteLine("Indtast antal af dage du ønsker at føre statistik over: ");
                    antalDage = Convert.ToInt32(Console.ReadLine());


                }
                catch (FormatException)
                {

                    Console.WriteLine("Du har ikke indtastet et gyldigt tal. Prøv igen.");
                    continue;
                }

                break;
            }
            

            int nummer = 1;
            for (int i = 0; i < antalDage; i++)
            {
                Console.WriteLine("\n\nVærdi {0}: ", nummer++);
                indtastet = Convert.ToDouble(Console.ReadLine());
                beregninger.daysList.Add(indtastet);
            }


            Menu();

            Console.ReadLine();
        }


        static void Menu()
        {
            int svar;

            while (true)
            {
                try
                {

                    Console.WriteLine("\n\nHvilke af disse muligheder ønsker du? Indtast 1, 2, 3 eller 4.\n1: Beregne gennemsnittet\n2: Finde maksimum-værdien\n3: Finde minimum-værdien\n4: En udskrift af alle indtastede værdier");
                    svar = Convert.ToInt32(Console.ReadLine());

                        switch (svar)
                        {
                            case 1:
                                beregninger.Gennemsnittet();
                                break;
                            case 2:
                                beregninger.Maksimumvalue();
                                break;
                            case 3:
                                beregninger.Minimumvalue();
                                break;
                            case 4:
                                beregninger.VisVærdier();
                                break;
                        
                        default:
                            Console.WriteLine("\n\nDu har ikke indtastet et gyldigt tal! Prøv igen og indtast 1, 2, 3 eller 4.\n\n");
                            break;
                            
                        }
                    break;
                }

                catch (FormatException)
                {

                    Console.WriteLine("\n\nDu har ikke indtastet et gyldigt tal. Prøv igen.\n\n");
                    continue;
                }


            }
        }

        class Beregninger
        {

            public List<double> daysList = new List<double>();

            public void Gennemsnittet()
            {
                double gennemsnit = daysList.Average();
                Console.WriteLine("\n\nGennemsnittet for de indtastede værdier er: {0}mm", gennemsnit);
            }

            public void Maksimumvalue()
            {
                double maksimumværdi = daysList.Max();
                Console.WriteLine("\n\nMaksimumværdi for de indtastede værdier er: {0}mm", maksimumværdi);
            }

            public void Minimumvalue()
            {
                double minimumværdi = daysList.Min();
                Console.WriteLine("\n\nMinimumværdi for de indtastede værdier er: {0}mm", minimumværdi);
            }

            public void VisVærdier()
            {
                Console.WriteLine("\nOversigt over indtastede værdier:\n");
                
                int num = 1;
                foreach (double værdi in daysList)
                {
                    Console.WriteLine("Værdi {0}: {1}mm", num++, værdi);
                }
            }

        }
        
      


    }  


}
    
