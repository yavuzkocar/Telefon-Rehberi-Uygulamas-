using System;
using System.Collections.Generic;

namespace Telefon_Rehberi_Uygulaması
{
    public class Program
    {
        Dictionary<int, string> İsimler = new Dictionary<int, string>();
        Dictionary<int, string> Soyisimler = new Dictionary<int, string>();
        Dictionary<int, int> TelefonNumaraları = new Dictionary<int, int>();
        public static void Main(string[] args)
        {

        }

        public void TelefonNumarasıKaydet(int a, string isim, string soyisim, int numara)
        {
            İsimler.Add(a, isim);
            Soyisimler.Add(a, soyisim);
            TelefonNumaraları.Add(a, numara);
        }
        public void TelefonNumarasıSil(string girdi)
        {
           bool Ad = İsimler.ContainsValue(girdi);
           bool Soyad = Soyisimler.ContainsValue(girdi);
           if (Ad==false && Soyad==false)//'&&'ve bağlacı
           {
               Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
               Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
               Console.WriteLine("* Yeniden denemek için      : (2)");
               int karar= Convert.ToInt32(Console.ReadLine());
               if (karar==1)
               {
                  //buralar yapılacak
               }
               else
               {
                   //buralar yapılacak
               }
           }
           else
           {
               Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)",girdi);
           }


        }
        public void TelefonNumarasıGuncelle(int a, string b)
        {
            İsimler.Add(a, b);
        }
        public void RehberListele(int a, string b)
        {
            İsimler.Add(a, b);
        }
        public void RehberdeArama(int a, string b)
        {
            İsimler.Add(a, b);
        }



    }
}
