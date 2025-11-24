namespace Castimine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double komakohagaarv = 9.45d;
            Console.WriteLine((int)komakohagaarv);
            int roundearv = (int)Math.Round(komakohagaarv);
            Console.WriteLine(roundearv);


            int arv = 35;
            string arvtekstina = arv.ToString();
            Console.WriteLine(arvtekstina);
            Console.WriteLine(arv);
            double arvdouble = 67676767d;
            int arvint = 0;
            arvint = (int)arvdouble;

            double uusdouble = arvint;

           string pikkusm = "";
             Console.WriteLine("Palun sisesta oma pikkus meetrites");
            pikkusm = Console.ReadLine();
            float pikkusFm = float.Parse(pikkusm);
            int pikkuscm = (int)pikkusFm * 10;
            Console.WriteLine($"Sinu pikkus sentimeetrites on : {pikkuscm}");
        }


    }
}
