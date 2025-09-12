namespace Kirs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int KäimasolevAasta = 2025;
            //int olenNiiVana = 16;
            //int tehteTulemus = KäimasolevAasta + olenNiiVana;
            ////float pikkus = 2.5f;

            //string sõnum = "Teie vanus on: ";

            //bool miskion = false; 

            //Console.WriteLine(sõnum + tehteTulemus);
            //Console.WriteLine(sõnum + tehteTulemus);
            //Console.WriteLine(sõnum + tehteTulemus);
            //Console.WriteLine(sõnum + tehteTulemus);
            //Console.WriteLine(sõnum + tehteTulemus);
            //Console.WriteLine(sõnum+tehteTulemus);
            // int liidetav1 = 0;
            // int liidetav2 = 0;
            // Console.WriteLine("Tere, palun sisesta esimene liidetav");
            // liidetav1 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Tere, palun sisesta esimene liidetav");
            // liidetav2 = int.Parse(Console.ReadLine());
            //int liitmine = liidetav1 + liidetav2;
            int arv1 = 0;
            int arv2 = 0;
            Console.WriteLine("Tere, palun sisesta esimene arv: ");
            arv1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Tere, palun sisesta teine arv: ");
            arv2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Missugust tehet soovid teha? Kirjuta kas: + - / * ^");
            string tehtetüüp = Console.ReadLine();
            int tehe = 0;
            if (tehtetüüp == "+" /*tingimus siia*/)
            {
                tehe = arv1 + arv2;
            }
            if (tehtetüüp == "-" /*tingimus siia*/)
            {
                tehe = arv1 - arv2;
            }
            if (tehtetüüp == "*" /*tingimus siia*/)
            {
                tehe = arv1 * arv2;
            }
            if (tehtetüüp == "/" /*tingimus siia*/)
            {
                tehe = arv1 / arv2;
            }
            if (tehtetüüp == "^" /*tingimus siia*/)
            {
                tehe = (int)Math.Pow(arv1,arv2);
            }

            Console.WriteLine($"{tehtetüüp} Tehte tulemus: {tehe}");


            // + liitmine
            // - lahutame
            // / jagamine
            // * korrutamine
            // ^ astendamine


            //int lahutatav1 = 0;
            //int lahutatav2 = 0;
            //    Console.WriteLine("Tere, palun sisesta esimene lahutatav");
            //lahutatav1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Tere, palun sisesta teine lahutaja");
            //lahutatav2 = int.Parse(Console.ReadLine());
            //int lahutamine = lahutatav1 - lahutatav2;
            //Console.WriteLine($"Tehte tulemus: {lahutamine}");
            //int korrutatav1 = 0;
            //int korrutatav2 = 0;
            //Console.WriteLine("Tere, palun sisesta esimene korrutaja");
            //korrutatav1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Tere, palun sisesta teine korrutaja");
            //korrutatav2 = int.Parse(Console.ReadLine());
            //int korrutamine = korrutatav1 * korrutatav2;
            //Console.WriteLine($"Tehte tulemus: {korrutamine}");
            //int jagatav1 = 0;
            //int jagatav2 = 0;
            //Console.WriteLine("Tere, palun sisesta esimene jagatav");
            //jagatav1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Tere, palun sisesta teine jagatav");
            //jagatav2 = int.Parse(Console.ReadLine());
            //int jagamine = jagatav1 / jagatav2;
            //Console.WriteLine($"Tehte tulemus: {jagamine}");
            int astendatav1 = 0;
            int astendatav2 = 0;
            Console.WriteLine("Tere, palun sisesta esimene astendatav");
            astendatav1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Tere, palun sisesta teine astendaja");
            astendatav2 = int.Parse(Console.ReadLine());
            int astendamine = astendatav1 ^ astendatav2;
            Console.WriteLine($"Tehte tulemus: {astendamine}");














        }
    }
}
    

