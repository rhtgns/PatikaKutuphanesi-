using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PatikaKutuphanesi_
{
    public class Kitap
    {
        public string Ad {  get; set; }
        public string YazarAdi { get; set; }
        public string YazarSoyadi {  get; set; }
        public int SayfaSayisi {  get; set; }
        public string YayinEvi {  get; set; }
        public  DateTime KayitTarihi { get; set; }


        public Kitap()//burada default constuctor yazıyoruz 
        {
           


            KayitTarihi = DateTime.Now;//kayıt tarihi o an gercek zamanlı olarak atanıyor 

        }
        // şimdi ise  paremeter alan constructor yapacagız
        //constructor ise bir yapıcı fonksiyondur burda degerleir alır ve propertylere atar

        public  Kitap(string ad,string yazarAdi,string yazarSoyadi,int sayfaSayisi,string yayinEvi)
        {
            Ad= ad;
            YazarAdi = yazarAdi;
            YazarSoyadi = yazarSoyadi;
            SayfaSayisi = sayfaSayisi;
            YayinEvi = yayinEvi;
            KayitTarihi= DateTime.Now;//  we create this with real time 


        }


    }
}
