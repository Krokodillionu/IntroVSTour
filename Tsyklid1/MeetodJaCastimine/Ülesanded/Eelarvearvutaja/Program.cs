using System.Diagnostics.CodeAnalysis;
using System.Net.Sockets;
using System.Runtime.CompilerServices;

namespace Eelarvearvutaja
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string kasutajanimi = "";
            Console.WriteLine("Mis on teie nimi?");
            do
            {
                kasutajanimi = Console.ReadLine();
            } while (kasutajanimi == "");


            List<float> tulud = new List<float>();
            List<float> kulud = new List<float>();
            string kasutajasisestus = "";
            kasutajasisestus = KüsiSisendeid(kasutajasisestus, tulud, true);
            kasutajasisestus = KüsiSisendeid(kasutajasisestus, kulud, false);
        }

        public static float Arvutus(List<float> kokkuarvutatavkollektsioon)
        {
            foreach (var arv in kokkuarvutatavkollektsioon)
            {
                
            }
            return null;
        }

            
           
            private static string KüsiSisendeid(string kasutajasisestus, List<float> tulud, bool whichone)
            { 
            while (kasutajasisestus != "rohkem pole")
            {
              if (whichone)
                {
                    Console.WriteLine("Mis on teie sissetulekud: \n kui rohkem ei ole midagi lisada, siis kirjuta \"rohkem pole\"");
                }
                else
                {
                    Console.WriteLine("Mis on teie kulud: \n kui rohkem ei ole midagi lisada, siis kirjuta \"rohkem pole\"");
                }
                    kasutajasisestus = Console.ReadLine();
                if (kasutajasisestus != "rohkem pole")
                {
                    tulud.Add(float.Parse(kasutajasisestus));
                } return kasutajasisestus;
                 
            }
            

            //while (kasutajasisestus != "rohkem pole")
            //{
                    
            //    Console.WriteLine("Mis on teie väljaminekud? \n kui rohkem ei ole midagi lisada, siis kirjuta \"rohkem pole\"");
            //    kasutajasisestus = Console.ReadLine();
            //    if (kasutajasisestus != "rohkem pole")
            //    {
            //        kulud.Add(float.Parse(kasutajasisestus));
            //    }
                    



            //}
           

        }
    }
}
