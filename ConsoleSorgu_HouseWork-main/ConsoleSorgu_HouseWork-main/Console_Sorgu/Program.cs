using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Sorgu
{
    class Program
    {
        static void Main(string[] args)
        {
            void KitaplariListele()
            {
                KutuphaneSabahEntities kutuphane = new KutuphaneSabahEntities();
                var kitaplar = kutuphane.Kitaplar.ToList();

                Console.WriteLine($"Kitap ISBN\tKitap Adı");
                foreach (var kitap in kitaplar)
                {
                    Console.WriteLine($"{kitap.ISBN}\t\t{kitap.Ad}");
                }
                Console.ReadLine();
            }

            void YazarlariListele()
            {
                using (KutuphaneSabahEntities hastane = new KutuphaneSabahEntities())
                {
                    var adlar = hastane.Yazarlar.Select(x => x.AdSoyad);
                    Console.WriteLine($"Yazar Adı");
                    foreach (var ad in adlar)
                    {
                        Console.WriteLine(ad);
                    }
                    Console.ReadLine();
                }
            }

            KitaplariListele();
            YazarlariListele();
        }
    }
}
