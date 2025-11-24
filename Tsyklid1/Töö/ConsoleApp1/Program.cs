using System.Globalization;

Console.WriteLine("Mis on sinu nimi?");
string nimi = "";
do
{
    nimi = Console.ReadLine();
    Console.WriteLine($"Tere, {nimi}");
} while (nimi != "");

if (nimi == "")
{
    Console.WriteLine("Tundmatu sisestus, palun sisesta tuntav nimi");
}
Console.WriteLine("Mis on sinu parool? Parool peab olema neljakohaline");
int parool = 0;
{
    parool = int.Parse(Console.ReadLine());
    Console.WriteLine($"Sinu parool {parool} on õige, olete sisse lubatud");

} while (parool >= 1000 && parool < 9999) ;

if (parool > 9999 && parool < 999)
{
    Console.WriteLine("Parool pole neljakohaline, vale parool");
}

