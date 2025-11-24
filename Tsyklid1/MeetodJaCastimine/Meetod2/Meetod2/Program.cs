namespace Meetod2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tervitus();
            string kasutajanimi = "";
            kasutajanimi = NimeKüsimine(kasutajanimi);
            {
                Tervitus();
                Console.WriteLine("Palun sisesta oma kasutajanimi");
                kasutajanimi = Console.ReadLine();
            }
            Console.WriteLine("Mis on sinu nädalane eelarve?");
            float eelarve = 0.00f;
            bool kaskasutajanõustub = false;
            while (kaskasutajanõustub!= true)
            {
                Console.WriteLine($"Praegune eelarve on {eelarve}, kas see on õige");
                Console.WriteLine("Vasta, kas jah või ei");
                string mistaütles = Console.ReadLine();
                if (mistaütles == "jah")
                {
                    kaskasutajanõustub = true;
                }
                Console.WriteLine($"{kasutajanimi}sinu eelarve on {SinuEelarvePäevas(eelarve)}");
                SinuEelarvePäevas(eelarve);
            }

           
        }
        public static void Tervitus()
        {
            Console.WriteLine("Hommik");
        }

        public static int SinuEelarvePäevas(float eelarve)
        {
            double eelarvepäevas = eelarve / 7;
            return (int)eelarvepäevas;
        }
    }
}
