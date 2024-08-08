using PatikaKutuphanesi_;
using System;
using System.Net.WebSockets;


public class Program  
    //kitapları temsil eden bir sınıftır ve kitapları ait bilgileri içerir 
{

    public static void Main()
    {

        Kitap kitap1 = new Kitap();//we create the object //new burda yeni bir nesne oluşturmak için kullanılır 
        kitap1.Ad = "Amok Koşucusu";
        kitap1.YazarAdi = "Stefan ";
        kitap1.YazarSoyadi = "Zweig";
        kitap1.SayfaSayisi = 60;
        kitap1.YayinEvi = "İs Bankası Yayın Evi";

        Kitap kitap2 = new Kitap("Adı: Satranc", "Stefan", "Zweig",60, "İs Bankası Yayın Evi");

        //we shows books info on the screen 
        Console.WriteLine("kitap 1:");
        Console.WriteLine($"Ad:{kitap1.Ad}");
        Console.WriteLine($"YazarAdı :{kitap1.YazarAdi}");
        Console.WriteLine($"YazarSoyadi:{kitap1.YazarSoyadi}");
        Console.WriteLine($"Sayfasayisi{kitap1.SayfaSayisi}");
        Console.WriteLine($"YayinEvi:{kitap1.YayinEvi}");
        Console.WriteLine($"KayıtTarihi:{kitap1.KayitTarihi}");




        Console.WriteLine("\nkitap 2:");
        Console.WriteLine($"Ad:{kitap2.Ad}");
        Console.WriteLine($"YazarAdı :{kitap2.YazarAdi}");
        Console.WriteLine($"YazarSoyadi:{kitap2.YazarSoyadi}");
        Console.WriteLine($"Sayfasayisi{kitap2.SayfaSayisi}");
        Console.WriteLine($"YayinEvi:{kitap2.YayinEvi}");
        Console.WriteLine($"KayıtTarihi{kitap2.KayitTarihi}");



    }

}

