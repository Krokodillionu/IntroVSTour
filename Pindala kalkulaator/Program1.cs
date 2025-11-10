Console.WriteLine("Kas sinu tuba on kolmnurga, ringi või ristküliku kujuline?");
string valik = Console.ReadLine();
if (valik == "kolmnurga")
{
    Console.WriteLine("Sisesta oma toa esimese külje mõõdud");
    double mõõtA = double.Parse(Console.ReadLine());
    Console.WriteLine("Sisesta oma toa teise külje mõõdud");
    double mõõtB = double.Parse(Console.ReadLine());
    Console.WriteLine("Sisesta oma toa kolmanda külje mõõdud");
    double mõõtC = double.Parse(Console.ReadLine());
    double kogupindala = mõõtA + mõõtB + mõõtC / 2;
    Console.WriteLine($"Sinu toa suurus on {kogupindala} kuupmeetrit");

}
else if (valik == "ristküliku")
{
    Console.WriteLine("Sisesta oma toa lühemate külgede pikkused");
    double lühemkülgA = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Sisesta oma toa pikemate külgede pikkused");
    double pikemkülgA = double.Parse(Console.ReadLine());
    
    double kogupindala = (lühemkülgA * lühemkülgA) + ( pikemkülgA * pikemkülgA) ;
    Console.WriteLine($"Sinu toa kogumõõt on {kogupindala} meetrit");
    
}
else if (valik == "ringi")
{
    Console.WriteLine("Sisesta oma läbimõõt");
    double raadius = double.Parse(Console.ReadLine());
    double ringipindala = (raadius * raadius) * Math.Pi; 
    Console.WriteLine($"Sinu toa läbimõõt on {ringipindala} m²");
}