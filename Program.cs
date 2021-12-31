using System;
using System.Collections.Generic;

namespace Telefon_Rehberi_Uygulaması
{
    public class Program
    {
        static Dictionary<string, int> İsimler = new Dictionary<string, int>();
        static Dictionary<string, int> Soyisimler = new Dictionary<string, int>();
        static Dictionary<int, double> TelefonNumaraları = new Dictionary<int, double>();

        //soyisime göre arama yapınca hata veriyo
        //güncellemede sıkıntılar var

        public static void Main(string[] args)
        {
        Bas:
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("********************************************");
            Console.WriteLine();
            Console.WriteLine(" (1) Yeni Numara Kaydetmek");
            Console.WriteLine(" (2) Varolan Numarayı Silmek");
            Console.WriteLine(" (3) Varolan Numarayı Güncelleme");
            Console.WriteLine(" (4) Rehberi Listelemek");
            Console.WriteLine(" (5) Rehberde Arama Yapmak");
            int karar = Convert.ToInt32(Console.ReadLine());
            if (karar == 1)
            {
                TelefonNumarasıKaydet();
                goto Bas;
            }
            else if (karar == 2)
            {
                Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                TelefonNumarasıSil(Console.ReadLine());
                goto Bas;
            }
            else if (karar == 3)
            {
                Console.Write("Lütfen değişiklik yapmak istediğiniz kişinin adını ya da soyadını giriniz:");
                TelefonNumarasıGuncelle(Console.ReadLine());
                goto Bas;
            }
            else if (karar == 4)
            {
                RehberListele();
                goto Bas;
            }
            else if (karar == 5)
            {
                RehberdeArama();
                goto Bas;
            }
        }

        public static string IsimGetir(int a)
        {
            string[] IsimDizisi = new string[İsimler.Count];
            foreach (var item in İsimler.Values)
            {
                foreach (var item2 in İsimler.Keys)
                {
                    IsimDizisi[item] = item2;
                }
            }

            return IsimDizisi[a];
        }

        public static string SoyisimGetir(int a)
        {
            string[] SoyisimDizisi = new string[İsimler.Count];
            foreach (var item in Soyisimler.Values)
            {
                foreach (var item2 in Soyisimler.Keys)
                {
                    SoyisimDizisi[item] = item2;
                }
            }
            return SoyisimDizisi[a];
        }


        public static void TelefonNumarasıKaydet()
        {
            int SıraNo = İsimler.Count;
            Console.Write("Lütfen isim giriniz             : ");
            string isim = Console.ReadLine();
            Console.Write("Lütfen soyisim giriniz          : ");
            string soyisim = Console.ReadLine();
            Console.Write("Lütfen telefon numarası giriniz : ");
            double numara = Convert.ToDouble(Console.ReadLine());
            İsimler.Add(isim, SıraNo);
            Soyisimler.Add(soyisim, SıraNo);
            TelefonNumaraları.Add(SıraNo, numara);
        }
        public static void TelefonNumarasıSil(string girdi)
        {
            bool Ad = İsimler.ContainsKey(girdi);
            bool Soyad = Soyisimler.ContainsKey(girdi);
            if (Ad == false && Soyad == false)//'&&'ve bağlacı
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");
                int karar = Convert.ToInt32(Console.ReadLine());
                if (karar == 2)
                {
                    TelefonNumarasıSil(Console.ReadLine());
                }
            }
            else
            {
                Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", girdi);
                string karar = Console.ReadLine();
                if (karar == "y")
                {
                    İsimler.Remove(girdi);
                    Soyisimler.Remove(girdi);
                    TelefonNumaraları.Remove(İsimler[girdi]);
                }
            }


        }
        public static void TelefonNumarasıGuncelle(string girdi)
        {
            bool Ad = İsimler.ContainsKey(girdi);
            bool Soyad = Soyisimler.ContainsKey(girdi);
            if (Ad == false && Soyad == false)//'&&'ve bağlacı
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* güncelleme işlemini sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için                  : (2)");
                int karar = Convert.ToInt32(Console.ReadLine());
                if (karar == 2)
                {
                    TelefonNumarasıGuncelle(Console.ReadLine());
                }
            }
            else
            {
                Console.WriteLine("{0} isimli kişide değişiklik yapmak üzere, onaylıyor musunuz ?(y/n)", girdi);
                string karar = Console.ReadLine();
                if (karar == "y")
                {
                    int SıraNO = İsimler[girdi];
                    İsimler.Remove(girdi);
                    Soyisimler.Remove(girdi);
                    TelefonNumaraları.Remove(İsimler[girdi]);
                    Console.Write("Lütfen yeni isimi giriniz             : ");
                    string isim = Console.ReadLine();
                    Console.Write("Lütfen yeni soyisimi giriniz          : ");
                    string soyisim = Console.ReadLine();
                    Console.Write("Lütfen yeni telefon numarasını giriniz: ");
                    int numara = Convert.ToInt32(Console.ReadLine());
                    İsimler.Add(isim, SıraNO);
                    Soyisimler.Add(soyisim, SıraNO);
                    TelefonNumaraları.Add(SıraNO, numara);
                }
            }

        }
        public static void RehberListele()
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("************************************");
            Console.WriteLine();
            string[] IsimDizisi = new string[İsimler.Count];
            foreach (var item in İsimler.Values)
            {
                foreach (var item2 in İsimler.Keys)
                {
                    IsimDizisi[item] = item2;
                }
            }
            string[] SoyisimDizisi = new string[İsimler.Count];
            foreach (var item in Soyisimler.Values)
            {
                foreach (var item2 in Soyisimler.Keys)
                {
                    SoyisimDizisi[item] = item2;
                }
            }
            for (int i = 0; i < İsimler.Count; i++)
            {
                Console.WriteLine("Isim            :{0}", IsimDizisi[i]);
                Console.WriteLine("Soyisim         :{0}", SoyisimDizisi[i]);
                Console.WriteLine("Telefon Numarası:{0}", TelefonNumaraları[i]);
                Console.WriteLine("-");
            }


        }
        public static void RehberdeArama()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("");
            Console.WriteLine(" İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine(" Telefon numarasına göre arama yapmak için: (2)");
            int karar = Convert.ToInt32(Console.ReadLine());
            if (karar == 1)
            {
                Console.WriteLine("Aramak istediğiniz isimi veya soyisimi giriniz.");
                string girdi = Console.ReadLine();
                bool Ad = İsimler.ContainsKey(girdi);
                bool Soyad = Soyisimler.ContainsKey(girdi);
                if (Ad == false && Soyad == false)//'&&'ve bağlacı
                    Console.WriteLine("Bu isimde kayıt bulunamadı.");
                else
                {
                    Console.WriteLine("Bu isimdeki kayıt bilgileri.");
                    Console.WriteLine("Isim            :{0}", IsimGetir(İsimler[girdi]));
                    Console.WriteLine("Soyisim         :{0}", SoyisimGetir(İsimler[girdi]));
                    Console.WriteLine("Telefon Numarası:{0}", TelefonNumaraları[İsimler[girdi]]);

                }


            }

        }



    }
}
