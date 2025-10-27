//Console.WriteLine("For tsükkel");

//int kogus = 5;

//for (int i = 0; i < kogus; i++)
//{
//    Console.WriteLine("🍐");
//    Console.Beep();
//}



//using System.ComponentModel.DataAnnotations;

//string[]objectArray = new string [5] ; //array, massiiv mitmest elemendist
//string temp = "no name"; // muutuja mis hetkel on "tühi"
//int objectCount = 0; // loend kui palju kordi küsida
//while (objectCount < 5) //while tsükkel mis küsib nimesid
//{
//Console.WriteLine("Sisesta järgmine lemmikloomanimi:");
//    temp = Console.ReadLine(); //temp muutujasse  väärtuse (mida me tahame) sisestamine
//    objectArray[objectCount] = temp; // massiivi, asukohal objectCount asetame ajutisest muutujast väärtuse
//    objectCount++; //tsükli inkremetatsioon
//}
//Console.WriteLine("Oled sisestanud järgnevad objektid"); // sõnum
//for (int i = 0; i < objectArray.Length; i++)
//{
//    Console.WriteLine($"{i+1}. element on :{objectArray[i]}");
//    // kuvame välja reanumbri koos vastava elemendiga, muutuja i abil
//}
//Console.ReadLine(); //peatame programmi klahvisisestuse taha
Console.WriteLine("Tere, sisesta oma kasutajanimi");
string kasutajanimi = Console.ReadLine();

if (kasutajanimi != "Aaro")
{
    Console.WriteLine("Kasutaja pole registreeritud");
}
if (kasutajanimi == "Aaro")
{
  Console.WriteLine($"Tere, {kasutajanimi}, palun sisesta oma parool");
}

string parool = Console.ReadLine();
if (parool != "Kassike100")
{
    Console.WriteLine("Vabandust, sisestatud parool ei ole õige, proovi uuesti");
}
if (parool == "Kassike100")
{
    Console.WriteLine("Õige parool, ligipääs lubatud");
}
Console.WriteLine("Mis on sinu 3 lemmiklooma nimi");
int[] arvumassiiv =[1, 2, 3];
arvumassiiv[1] = 1;
arvumassiiv[2] = 2;
arvumassiiv[3] = 3;






