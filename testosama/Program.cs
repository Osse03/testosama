
using System;
using System.Diagnostics.SymbolStore;
using System.Globalization;

namespace testosama
{
    internal class Program
    {
        const double skatt = 0.3;
        static void Main(string[] args)
        {


            //Console.WriteLine("Skriv in ditt namn: ");

            //string username = Console.ReadLine();

            //Console.WriteLine("Hur gammal är du ? ");

            //string userage = Console.ReadLine();

            ////place holder syntax
            //Console.WriteLine("Jag heter {0} och jag är {1} gammal", username, userage);

            //string name = "Osama";
            //string age = "21";
            //string gender = "Man";


            //string profil = $"Jag heter {name} och är {age} gammal plus jag är {gender}";

            //Console.WriteLine(profil);

            //Console.WriteLine("Tryck enter för att försätta.");
            //Console.ReadLine();


            //string minText = "hej på dig";
            //int mittTal = 21;
            //int userTal = 0;

            //Console.WriteLine("Variabeln minText är tilldelad till:" + " " + minText);

            //Console.WriteLine(mittTal);


            //Console.WriteLine("Variabeln minTal innehåller nu:");

            //Console.WriteLine("Ange ett tal för addera med 21:");

            //userTal = int.Parse(Console.ReadLine());

            //int nySum = 21 + userTal;

            //Console.WriteLine("ditt resultar är: {0}", nySum);

            //Console.WriteLine("Ange första tal: ");

            //float tal1 = float.Parse(Console.ReadLine());

            //Console.WriteLine("Ange andra tal: ");

            //float tal2 = float.Parse(Console.ReadLine());

            //float sum1 = tal1 + tal2;

            //float sum2 = tal1 * tal2;

            //float sum3 = tal1 / tal2;

            //Console.WriteLine("Summan :" + " " + sum1);

            //Console.WriteLine("Produkten :" + " " + sum2);

            //Console.WriteLine("Divisionen " + " " + sum3);

            //Console.WriteLine("Trych på en valfri tangent för att fortsätta..");
            //Console.ReadLine();

            //Console.WriteLine("Mata in ditt förnamn:");
            //string firstName = Console.ReadLine();

            //Console.WriteLine("Mata in ditt efternamn:");
            //string lastName = Console.ReadLine();

            //Console.WriteLine("Hej {0} {1}!", firstName, lastName);


            //Console.WriteLine("Trych på en valfri tangent för att fortsätta..");
            //Console.ReadLine();

            //Console.Write("Mata in grader i Celsius: ");

            //double celsius = float.Parse(Console.ReadLine());

            //double farenhit = 1.8 * celsius + 32; 


            //Console.WriteLine("Det blir {0} grader Farenhit.", farenhit);

            //Console.WriteLine("Trych på en valfri tangent för att fortsätta..");
            //Console.ReadLine();


            //Console.Write("Mata in cirkelns radie: ");

            //double radie = float.Parse(Console.ReadLine());

            //double area = (float)(3.14 * radie * radie);
            //double omkrets = (float)(3.14 * 2 * radie);

            //Console.WriteLine("Area: " + area);
            //Console.WriteLine("Omkrets: " + omkrets);
            ///////////////////////////////////////////////

            //Logisk "if-sats" operators//
            //string userRole1 = "Chef";
            //string userRole2 = "Lärare";
            //string userRole3 = "Adminstratör";
            //string userRole4 = "Utvecklare";


            //Console.Write("Vad heter du? : ");
            //string userName = Console.ReadLine();

            //Console.Write("Inloggad som: {0}", userName);

            //Console.WriteLine("\n\nVad är det för roll du har? :");
            //string role = Console.ReadLine();


            //role = role.ToLower();

            //if (userRole1.ToLower() == role)
            //{
            //    Console.WriteLine("Välkommen chefen {0}.Du har tillgång för alla sidor.", userName);

            //}
            //else if (userRole2.ToLower() == role)
            //{
            //    Console.WriteLine("Välkommen Läraren " + userName);

            //}
            //else if (userRole3.ToLower() == role)
            //{
            //    Console.WriteLine("Välkommen Adminstratören " + userName);
            //}
            //else if (userRole4.ToLower() == role)
            //{
            //    Console.WriteLine("Välkommen Utvecklaren " + userName);
            //}
            //else
            //{
            //    Console.WriteLine("Du har ingen tillgång till länk.");
            //}
            //Logisk "if-sats" operators//



            //Ternery oprt///

            //Console.Write("Mata in Första tal:");
            //double num1 = double.Parse(Console.ReadLine());

            //Console.Write("Mata in Andra tal:");
            //double num2 = double.Parse(Console.ReadLine());

            //var result = num1 > num2 ? "Första är större än andra tal" : "Andra tal är större än första tal";

            //Console.WriteLine(result);
            //Ternery oprt///

            ///Switch///
            ////Console.Write("Vad heter du? ");
            ////string userName = Console.ReadLine();

            ////Console.Write("Hur gammal är du ? ");
            ////int userAge = int.Parse(Console.ReadLine());


            ////Console.Write("Är du äldst,mellersta eller yngsta barn ? ");
            ////string ordning = Console.ReadLine();



            ////switch (ordning)
            ////{
            ////    case "äldst":
            ////    case "Äldst":
            ////        Console.WriteLine("Du är den smartaste och starkaste. SLUT");
            ////        break;

            ////    case "Mellersta":
            ////    case "mellersta":
            ////        Console.WriteLine("Ingen bryr sig om dig.");
            ////        break;

            ////    case "yngsta":
            ////    case "Yngsta":
            ////        Console.WriteLine("Du är dum.");
            ////        break;
            ////}


            ///SWITCH!!!////


            /////TABEL////
            //Console.Write("Skriv in ditt för och efternamn: ");
            //string userName1 = Console.ReadLine();




            //string tabell = "{0,-10} | {1,-10} | {2,5}";

            //Console.WriteLine("------------------------------------------");
            //Console.WriteLine(tabell, "Förnamn", "Efternamn", "Ålder");
            //Console.WriteLine("------------------------------------------");


            //Console.WriteLine(userName1);
            //Console.WriteLine( "----------------------------------");
            //Console.WriteLine("Utskriven Datum: " + DateTime.Now);

            ////TALBEL/////

            //Console.Write("Ange pris exklusive moms: ");
            //double utanMoms = double.Parse(Console.ReadLine());


            ////MOMS///
            //double medMoms = utanMoms * (1 + momsSatsen);

            //Console.WriteLine("Ditt pris Ink moms: "+ medMoms);

            //Console.Write("Ange pris inklusive moms: ");
            //double medMoms = double.Parse(Console.ReadLine());

            //double utanMoms = medMoms / (1+ momsSatsen);

            //Console.WriteLine("Priset exklusive moms: "+ utanMoms); 
            ///MOMS///


            //double amotering = 10000;

            //Console.WriteLine("Hur mycket vill du låna? :");
            //double lån = double.Parse(Console.ReadLine());


            //Console.WriteLine("Ange räntasats i procent: ");
            //double räntaSatsen = double.Parse(Console.ReadLine());

            //double räntaDecimal = räntaSatsen / 100;

            //double totalRänta = lån * räntaDecimal;

            //double varjeMånad = totalRänta / 12;

            //double kvarTal = varjeMånad * 3;

            //double amoKvartal = kvarTal + amotering;

            //double kvarSkuld = lån - amotering;

            //Console.WriteLine($"Betalning varje månad: {varjeMånad}||Betalning varej kvartal:{kvarTal}");

            //Console.WriteLine("Efter varje kvartal betalar du i amortering: " + amotering);

            //Console.WriteLine("===============================================================");

            //Console.WriteLine("Totalt betalaning Kvartal 1: "+ amoKvartal);

            //Console.WriteLine("Kvarvarande skul efter första kvarta 1: "+ kvarSkuld);




            //Console.Write("\nHur mycket kvar av lånet: ");
            //double lån2 = double.Parse(Console.ReadLine());

            //double totalRänta2 = lån2 * räntaDecimal;

            //double varjeMånad2 = totalRänta2 / 12;

            //double kvarTal2 = varjeMånad2 * 3;

            //double amoKvartal2 = kvarTal + amotering;

            //double kvarSkuld2 = lån2 - amotering;

            //Console.WriteLine($"Betalning varje månad: {varjeMånad2}||Betalning varej kvartal:{kvarTal2}");

            //Console.WriteLine("Efter varje kvartal betalar du i amortering: " + amotering);

            //Console.WriteLine("===============================================================");

            //Console.WriteLine("Totalt betalaning Kvartal 1: " + amoKvartal2);

            //Console.WriteLine("Kvarvarande skul efter första kvarta 1: " + kvarSkuld2);

            //double prisLev = 2000;
            //double prisSäljare = 5000;

            //Console.Write("Ange beställning i ton: ");
            //double tonVikt = double.Parse(Console.ReadLine());

            //double bästellKosnad = tonVikt * prisLev;

            //double kundPris =  tonVikt * prisSäljare;

            //double vinstPris = kundPris - (prisLev * tonVikt);

            //Console.WriteLine("Pris för slutkund: "+ kundPris);
            //Console.WriteLine("Vinst för Kvarntorps kvar: "+ vinstPris);

            //Console.Write("Ange antal akiter du äger: ");
            //double antalAkiter = double.Parse(Console.ReadLine());

            //Console.Write("Ange antal utdelning per akiter: ");
            //double vinst = double.Parse(Console.ReadLine());

            //double akiterVinst = antalAkiter * vinst;

            //double efterskatt = akiterVinst * (1-skatt;

            //Console.WriteLine("Utdelning blir {0} föreskatt", akiterVinst);

            //Console.WriteLine("Utdelning blir {0} efter skatt", efterskatt); 
            string svar;
            int val;

            do
            {


                do

                {
                    Console.WriteLine("1. New York ");
                    Console.WriteLine("2. Los Angeles ");
                    Console.WriteLine("3. Chicago ");
                    Console.WriteLine("4. Houston  ");
                    Console.WriteLine("5. För att avsluta.");


                    Console.WriteLine("Ange siffran på staden du vill veta mer om?");
                    val = int.Parse(Console.ReadLine());



                    switch (val)
                    {
                        case 1:
                            Console.Clear();
                            NewYork();
                            break;

                        case 2:
                            Console.Clear();
                            LosAngeles();
                            break;

                        case 3:
                            Console.Clear();
                            Chicago();
                            break;

                        case 4:
                            Console.Clear();
                            Houston();
                            break;
                    }

                } while (val != 1 && val != 2 && val != 3 && val != 4);

                do
                {

                    Console.WriteLine("\nVill du se meny igen?");
                    svar = Console.ReadLine().ToUpper();

                    if (svar != "JA" && svar != "NEJ")
                    {
                        Console.WriteLine("Din inmatning är icke korret.");
                    }




                } while (svar != "JA" && svar != "NEJ");


            } while (svar != "NEJ");
            Console.WriteLine("Tack för din besök.");
             
   
        }
        static void NewYork()
        {

            Console.Write("Antal invånare är 5,8 miljoner.");
            Console.WriteLine("Befolkningstillväxt sedan 2020: -3,8 %" +
                "\n\nMedelålder: 38 år" +
                "\n\nMedelinkomst per hushåll: 70 000 dollar" +
                "\n\nMedelpris för en bostad: 685 000 dollar" +
                "\n\nSmeknamn: The Big Apple och The City That Never Sleeps" +
                "\n\nIntressanta sevärdheter: Frihetsgudinnan, Empire State Building och Central Park");
                
            Console.WriteLine("\n\nNew York är USA:s största stad sett till hur många som bor där. \nStaden är ledande inom det mesta. \nDet är inte heller fel att säga att New York har ett finger med i nästan allt som rör såväl USA som världen i övrigt." +
                "\nHär finns det bland annat stora mediehus och modehus, och så även populära universitet." +
                "\nTvå av världens största börser finns här, \ndet vill säga New York Stock Exchange och Nasdaq. FN:s högkvarter hittar du också här. " +
                "\nSå att säga att staden har politiskt inflytande och makt är absolut inte fel.");



        }
        static void LosAngeles()
        {
            Console.Write("Antal invånare är 3,9 miljoner.");

            Console.WriteLine("Befolkningstillväxt sedan 2020: -1 %" +
                "\r\nMedelålder: 37 år" +
                "\r\nMedelinkomst per hushåll: 70 000 dollar" +
                "\r\nMedelpris för en bostad: 813 000 dollar" +
                "\r\nSmeknamn: L.A., City of Angels och La-La Land" +
                "\r\nIntressanta sevärdheter: Hollywood och Sunset Boulevard");

            Console.WriteLine("Los Angeles är en dyr stad att bo i, i synnerhet om man vill äga sitt eget boende. Men de som väl bor här brukar trivas. " +
                "\rLos Angeles är nämligen ett berömt centrum för bland annat utbildning, forskning, kultur, vetenskap och teknik.");


            Console.WriteLine("\nStadsdelen Hollywood är som många vet också känd för sin film- och tv-serie-industri. " +
                "Hollywood är en riktig turistmagnet. " +
                "\rBland de mest lyxiga och dyra områdena i staden hittar du i Bel Air och Beverly Hills, där många rika kändisar bor.");

            Console.ReadKey();
        }


        static void Chicago()
        {
            Console.Write("Antal invånare är 2,7 miljoner.");

            Console.WriteLine("Befolkningstillväxt sedan 2020: -1,8 %" +
                "\r\nMedelålder: 36 år" +
                "\r\nMedelinkomst per hushåll: 65 000 dollar" +
                "\r\nMedelpris för en bostad: 298 000 dollar\r\nSmeknamn: The Windy City" +
                "\r\nIntressanta sevärdheter: Millennium Park och Navy Pier");

            Console.WriteLine("Chicago hittar du i delstaten Illinois. Staden är bland annat känd för sitt jordbruk och sina många industrier." +
                "\r\n\r\nChicago är dessutom en särskilt multikulturell stad där invandrare från olika länder oftast bor i olika stadsdelar. Det finns bland annat stadsdelar som domineras av exempelvis greker, syrier, serber, tyskar eller italienare.");
            Console.WriteLine("En rolig detalj är att den svenska stadsdelen Andersonville finns kvar i Chicago, även om det inte bor så många personer med anknytning till Sverige där längre." +
                "\r\n\r\nChicago var faktiskt en av de första svenskstäderna i USA. År 1900 fanns det fler svenskar här än i Göteborg, och vid den tidpunkten fanns även 40 svenska kyrkor.");
        }


        static void Houston()
        {
            Console.Write("Antal invånare är 2,3 miljoner.");

            Console.WriteLine("Befolkningstillväxt sedan 2020: -0,6 %" +
                "\r\nMedelålder: 34 år" +
                "\r\nMedelinkomst per hushåll: 56 000 dollar" +
                "\r\nMedelpris för en bostad: 201 000 dollar" +
                "\r\nSmeknamn: H-Town" +
                "\r\nIntressanta sevärdheter: Houston Space Center och Houston Zoo");


            Console.WriteLine("\nHouston är den största staden i delstaten Texas. " +
                "Staden grundades 1836 och är namngiven efter en amerikansk general som stred vid Slaget vid San Jacinto, som var en del av Texas frihetskrig. " +
                "Generalen hette Sam Houston, och Texasarmén besegrade då en mexikansk armé." +
                "Denna stad är ett högteknologisk centrum med många stora företag inom energi, rymd och teknik. " +
                "Energiföretaget Phillips 66 och datorföretaget Hewlett Packard är två av de största företagen som har sina huvudkontor i Houston.");


            Console.ReadKey();
        }




        




    }
}
