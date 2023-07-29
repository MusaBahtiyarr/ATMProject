using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Giriş Yap");
            Console.Write("Ad : ");
            string ad = Console.ReadLine();
            Console.Write("Soyad : ");
            string soyad = Console.ReadLine();
            Console.Write("Şifre : ");
            string sifre = Console.ReadLine();

            Console.WriteLine("Giriş Yapılıyor Lütfen Bekleyiniz...");
            System.Threading.Thread.Sleep(5000);

            Console.Clear();

            Console.WriteLine("Yapmak İstediğiniz İşlemi Seçiniz");
            Console.WriteLine("1- Bakiye Görüntüle");
            Console.WriteLine("2- Para Yatır");
            Console.WriteLine("3- Para Çek");
            Console.WriteLine("4- Çıkış");

            int bakiye = 500;

            string islem = Console.ReadLine();

            switch (islem)
            {
                case "1":
                    Console.WriteLine("Bakiyeniz : " + bakiye);
                    break;
                case "2":
                    Console.WriteLine("Yatırmak istediğiniz miktarı yazınız");
                    int yatiralacakTutar = Convert.ToInt32(Console.ReadLine());
                    if (yatiralacakTutar <= 1000)
                    {
                        Console.WriteLine("Yeni Bakiyeniz : " + (bakiye + yatiralacakTutar));
                    }
                    else
                    {
                        Console.WriteLine("Limiti Aştınız Lütfen 1000 TL'den Daha Az Bir Miktar Yatırın");
                    }
                    break;
                case "3":
                    Console.WriteLine("Çekmek istediğiniz miktarı yazınız");
                    int cekilecekTutar = Convert.ToInt32(Console.ReadLine());
                    if (cekilecekTutar <= 1000)
                    {

                        Console.WriteLine("Yeni Bakiyeniz : " + (bakiye - cekilecekTutar));
                    }
                    else
                    {
                        Console.WriteLine("Limiti Aştınız Lütfen 1000 TL'den Daha Az Bir Miktar Çekin");
                    }
                    break;
                case "4":
                    Console.WriteLine("ATM'den Çıkış Yapılıyor İyi Günler");
                    break;
            }

        }
    }
}
