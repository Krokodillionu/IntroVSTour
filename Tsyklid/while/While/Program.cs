//Console.WriteLine("Joonistan sulle kolmnurga:");
//int kolmnurgasuurus = int.Parse(Console.ReadLine());

//int i = 1;
//while (i <= kolmnurgasuurus)
//{
//    Console.WriteLine();
//    int j = 1;
//    while (j <= 1)
//    {
//        Console.Write("_░");
//        j++;
//    }
//    i++;

//}
Console.WriteLine("Tere tulemast MobiFix parandusautomaati, kuidas saan aidata?");
Console.WriteLine("0  - head aega\n - tahan telefoni parandada");
Console.WriteLine("Palun tee oma valik kirjutades vastava arvu");
int kasutajavalik = int.Parse(Console.ReadLine());
while(kasutajavalik < 0 && kasutajavalik > 1)
{
    Console.WriteLine("Palun tee oma valik kirjutades vastava arvu");
    kasutajavalik = int.Parse(Console.ReadLine());
}
if (kasutajavalik == 0)
{
    Console.WriteLine("Headaega, tulge jälle");
}
else
{
    Console.WriteLine("Palun sisesta oma telefonimudel, mida soovid parandada");
    Console.WriteLine("1- Iphone\n2-Xiaomi\n3-Huawei\n4-Samsung");
    int kasutajatelefon = int.Parse(Console.ReadLine());
    while (kasutajatelefon < 1 && kasutajatelefon > 4) ;
    {
        kasutajatelefon = int.Parse(Console.ReadLine());
        Console.WriteLine("Palun tee oma valik kirjutades vastava arvu");
    }
    switch (kasutajatelefon)
    {
        case 1:
            Console.WriteLine("Aitäh, saad oma Iphone tagasi 1 nädala pärast");
            break;
        case 2:
            Console.WriteLine("Aitäh, sinu xiaomi on valmis 2 kuu pärast");
            break;
        case 3:
            Console.WriteLine("Kahjuks me huaweid ei teeninda");
            break;
        case 4:
            Console.WriteLine("Sinu samsung saab valmis 2 päeva pärast");
            break;
        default:
            break;

    }
    Console.WriteLine("Kas soovid mõnda muud mudelit parandada?");
    Console.WriteLine("0.jah\n1- ei ");
    int kasutajaTeineValik = 0;
    while (kasutajaTeineValik < 0 && kasutajaTeineValik > 1)
    {
        Console.WriteLine("Palun tee oma valik kirjutades vastava arvu");
        kasutajavalik = int.Parse(Console.ReadLine());

    }
    if (kasutajaTeineValik ==0)
    {
        kasutajatelefon = kasutajaTeineValik;
    }
}