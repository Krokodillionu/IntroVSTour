using System.ComponentModel.Design;
using System.Threading.Channels;

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
            // Ülesanne kasutades süntaksisisestust, kirjelda komentaariga iga koodirida
            // Console.WriteLine("Tere, palun sisesta esimene liidetav");
            // //Adresseerimine moodulit "Console", punkti abil ütleme, et kasutame funktsiooni WriteLine, et kasutajale öelda sõnum
            // // mis asub funktsiooni taga olevate sulgude vahel, antud rida lõpeb lasuelõpumärgiga
            // int liidetav1 = int.Parse(Console.ReadLine());
            // // instantsieerime muutuja "arv1", ning ütleme, et sinna saab panna täisarve andmetüübisõnaga, int, selle muutuja sisse omistame tulemuse, mille saame
            // // kasutajalt Console.Readline abil
            // liidetav1 = int.Parse(Console.ReadLine());
            // //int arv1 = 0;
            // int arv2 = 0;
            // //Console.WriteLine("Tere, palun sisesta esimene arv: ");
            // //arv1 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Tere, palun sisesta teine arv: ");
            // //Adresseerimine moodulit "Console", punkti abil ütleme, et kasutame funktsiooni WriteLine, et kasutajale öelda sõnum
            // // mis asub funktsiooni taga olevate sulgude vahel, antud rida lõpeb lasuelõpumärgiga
            // // arv2 = int.Parse(Console.ReadLine());

            // Console.WriteLine("Missugust tehet soovid teha? Kirjuta kas: + - / * ^");
            // // adresseerime moodulit "Console", punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale öelda sõnum
            // // mis asub funktsiooni taga olevate sulgude vahel, antud rida lõppeb lauselõpumärgiga.
            // string tehtetüüp = Console.ReadLine();
            // // tekitame muutuja "tehtetüüp", mille ette paneme andmetüübiks string ehk ütleme, et seal on tekst, ning võrdusmärgi abil otsime talle konsooli
            // // rea pealt loetu infi, mis saame kasutades "Console" mooduli, Readline funktsiooni. Lause lõppeb lauselõpumärgiga ;..
            //int tehe = 0;
            // // instantsieerime muutuja tehe, mille andmetüübiks on int ja omistame talle esialgu väärtuse 0
            //         if (tehtetüüp == "+" /*tingimus siia*/)
            //     // teeme tingimuslause if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehtetüüp" sisu on samal kujul, kui sõne "+"
            //        //{
            //         //    tehe = arv1 + arv2;
            //         //}
            //         if (tehtetüüp == "-" /*tingimus siia*/)
            //         // teeme tingimuslause if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehtetüüp" sisu on samal kujul, kui sõne "-"
            //         //{
            //         //    tehe = arv1 - arv2;
            //         //}
            //         if (tehtetüüp == "*" /*tingimus siia*/)
            //         // teeme tingimuslause if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehtetüüp" sisu on samal kujul, kui sõne "*"
            //         //{
            //         //    tehe = arv1 * arv2;
            //         //}
            //         if (tehtetüüp == "/" /*tingimus siia*/)
            //         // // teeme tingimuslause if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehtetüüp" sisu on samal kujul, kui sõne "/"
            //         //{
            //         //    tehe = arv1 / arv2;
            //         //}
            //         if (tehtetüüp == "^" /*tingimus siia*/)
            //         // // teeme tingimuslause if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehtetüüp" sisu on samal kujul, kui sõne "^"
            //         //{
            //         //    tehe = (int)Math.Pow(arv1,arv2);
            //         //}

            //         Console.WriteLine($"{tehtetüüp} Tehte tulemus: {tehe}");
            // peale tingimust on koodiplokk loogiliste sulgude vahel, koodiplokk sisaldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus kasutades
            // moodulist "Math" punkti abil funktsiooni "Pow()", selle sees on arv1 astendatavana esimene parameeter, ning arv2 astendajana teine parameeter.
            // Funktsiooni ees on kiirteisendus kus funktsiooni väljund teisendatakse täisarvuks (int) abil. Lause lõppeb lauselõpumärgiga sulgude sees


            //// + liitmine
            //// - lahutame
            //// / jagamine
            //// * korrutamine
            //// ^ astendamine


            ////int lahutatav1 = 0;
            ////int lahutatav2 = 0;
            ////    Console.WriteLine("Tere, palun sisesta esimene lahutatav");
            ////lahutatav1 = int.Parse(Console.ReadLine());
            ////Console.WriteLine("Tere, palun sisesta teine lahutaja");
            ////lahutatav2 = int.Parse(Console.ReadLine());
            ////int lahutamine = lahutatav1 - lahutatav2;
            ////Console.WriteLine($"Tehte tulemus: {lahutamine}");
            ////int korrutatav1 = 0;
            ////int korrutatav2 = 0;
            ////Console.WriteLine("Tere, palun sisesta esimene korrutaja");
            ////korrutatav1 = int.Parse(Console.ReadLine());
            ////Console.WriteLine("Tere, palun sisesta teine korrutaja");
            ////korrutatav2 = int.Parse(Console.ReadLine());
            ////int korrutamine = korrutatav1 * korrutatav2;
            ////Console.WriteLine($"Tehte tulemus: {korrutamine}");
            ////int jagatav1 = 0;
            ////int jagatav2 = 0;
            ////Console.WriteLine("Tere, palun sisesta esimene jagatav");
            ////jagatav1 = int.Parse(Console.ReadLine());
            ////Console.WriteLine("Tere, palun sisesta teine jagatav");
            ////jagatav2 = int.Parse(Console.ReadLine());
            ////int jagamine = jagatav1 / jagatav2;
            ////Console.WriteLine($"Tehte tulemus: {jagamine}");
            //int astendatav1 = 0;
            //int astendatav2 = 0;
            //Console.WriteLine("Tere, palun sisesta esimene astendatav");
            //astendatav1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Tere, palun sisesta teine astendaja");
            //astendatav2 = int.Parse(Console.ReadLine());
            //int astendamine = astendatav1 ^ astendatav2;
            //Console.WriteLine($"Tehte tulemus: {astendamine}");
            //string lemmikpuuvili = "";
            //string valik = "";
            //string lemmikjuurvili = "";
            //Console.WriteLine("Kas sulle meeldivad puuviljad, või juurviljad, 0 kui puuvili, 1 kui juurvili");
            //bool milline = false;
            //valik = (Console.ReadLine().ToString());
            // if (milline == false)
            //{
            //    Console.WriteLine("Milline puuvili on sinu lemmik?");
            //}
            //lemmikpuuvili = Console.ReadLine();


            //if (lemmikpuuvili == "maasikas")
            //{
            //    Console.WriteLine("Maasikas ei ole puuvili");
            //}
            //else if (lemmikpuuvili == "pirn")
            //{
            //    Console.WriteLine("Kas hapupirn või magus pirn, mõlemad on head.");
            //}
            //else if (lemmikpuuvili == "kartul")
            //{
            //    Console.WriteLine("See ei kasva isegi puu otsas");
            //}

            //else
            //{
            //    Console.WriteLine("Ei tunne seda puuvilja");
            //}
            //if (milline == true)
            //{
            //    Console.WriteLine("Milline on su lemmik juurvili");
            //}
            //else if (valik == lemmikjuurvili) ;
            //{
            //    Console.WriteLine("Milline juurvili on sinu lemmik?");
            //    if (lemmikjuurvili == "hapukapsas")
            //    {
            //        Console.WriteLine("Hapukapsas on C-vitamiini rikas");
            //    }
            //    else if (lemmikjuurvili == "porgand");
            //    {
            //        Console.WriteLine("Porgand on väga maitsev ja magus juurvili");
            //    }
            Console.WriteLine("Sisesta ostusumma");
            double ostusumma = double.Parse(Console.ReadLine());
            if (ostusumma > 100)
            {
                Console.WriteLine("Saad 20% allahindlust");
            }
            else if (ostusumma < 101 && ostusumma > 50)
            {
                Console.WriteLine("Saad 10% allahindlust");
            }
            else if (ostusumma > 21 && ostusumma < 51)
            {
                Console.WriteLine("Saad 5% allahindlust");
            }
            else if (ostusumma < 21) 
            {
                Console.WriteLine("allahindlust ei saa :c");
            }
            else if (ostusumma < 1)
            {
                Console.WriteLine("Veaolek, ostusumma ei saa olla 0 ega sellest väiksem");
            }



        }
        




        }
    }




