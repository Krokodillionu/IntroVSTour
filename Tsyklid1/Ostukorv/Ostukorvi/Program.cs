namespace Ostukorvi;

internal class Program
{
    static void Main(string[] args)
    {
        bool islogin;
        string kasutajanimi = "";
        string parool = "";
        Console.WriteLine("Mis on sinu kasutajanimi?");
        kasutajanimi = Console.ReadLine();
        
        if (kasutajanimi == "Krokodillionu")
        {
            Console.WriteLine($"Tere, {kasutajanimi}, palun sisesta oma parool");
        }
        while (kasutajanimi != "Krokodillionu")
        {
            Console.WriteLine("Tundmatu sisestus, ei tunne sellist inimest");
        }
        parool = Console.ReadLine();
        if (parool == "Kassike100")
        {
            Console.WriteLine("Õige parool");
        }
        while (parool != "Kassike100")
        {
            Console.WriteLine("Vale parool, palun sisesta õige parool!");
        }

    }
}
