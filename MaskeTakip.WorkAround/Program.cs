
using MaskeTakip.Business.Concrete;
using MaskeTakip.Entities.Concrete;

namespace Workaround
{

    public class Program
    {
       public static void Main(string[] args)
        {

            SelamVer("Ateş");
            SelamVer("Ayşe");
            SelamVer("Faruk");
            SelamVer();

            int sonuc = Topla(26,20);
            Console.ReadLine();

            ////string ogrenci1 = "Ateş";
            ////string ogrenci2 = "Selin";
            ////string ogrenci3 = "Selim";

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Ateş";
            ogrenciler[1] = "Selin";
            ogrenciler[2] = "Selim";
            ogrenciler = new string[4];
            ogrenciler[3] = "Ayşe";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };
            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }
            List<string> yenisehirler1 = new List<string> {"Ankara 1", "İstanbul 1", "İzmir 1" };
            yenisehirler1.Add("Adana 1");
            foreach (string sehir in yenisehirler1)
            {
                Console.WriteLine(sehir);
            }
            Citizen citizen1 = new Citizen();
            citizen1.FirstName = "MEHMET ATEŞ";
            citizen1.LastName = "ÖZATEŞ";
            citizen1.DateOfBirthYear = 1988;
            citizen1.NationalIdentity = 42217600888;



            PttManager pttManager = new PttManager(new CitizenManager());
            pttManager.GiveMask(citizen1);


            FarmacyManager farmacyManager = new FarmacyManager(new CitizenManager());
            farmacyManager.GiveMask(citizen1);


            Console.ReadLine();
        }

        static void SelamVer(string isim="isimsiz")
        {
            Console.WriteLine("Merhaba" + " "  + isim);
        }

        static int Topla(int sayi1 = 5,int sayi2 =10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam" + " " + sonuc);
            return sonuc;
        }
    }
}
