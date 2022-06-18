using PatikaOdev1.Domain;
using System;
using System.Collections.Generic;

namespace PatikaOdev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppProcess appProcess = new AppProcess();

            var loop = true;
            while (loop)
            {
                // Ilk Giriş Sayfasında Tc Kimlik No Alınıyor.
                Console.WriteLine("---------------Hos Geldiniz---------------");
                Console.Write("Urun Alabilmek icin lutfen kayitli tc kimlik no giriniz : ");
                var tc = Console.ReadLine();

                //Default Kullanıcı Ekleniyor.
                appProcess.AddUser();

                // Girilen kullanının kayıtlı olup olunmadığına bakılıyor.
                // Eğer Kayıtlıysa Alışverişe geçiyor değilse kayıt sayfasına.
                var check = appProcess.CheckTC(tc);
                if (check == null)
                {
                    // Kayıt Alınıyor
                    appProcess.NewUser(tc);
                }
                else
                {
                    //Loop için action diye bir değer tanımlanıyor.
                    int action = 1;

                    //Urun seçme ve Listeleme için while döngüsü kullanılıyor.
                    while (action != 0)
                    {
                        //Ürün seçme ve listeleme için giriş sayfası.
                        Console.Clear();
                        Console.WriteLine("1 => Urun Sec\n" + "2 => Secilen Urunleri Listele\n" + "0 => Çıkış\n");
                        Console.Write("Seciminizi Yapınız  = ");
                        var choise = int.Parse(Console.ReadLine());
                        switch (choise)
                        {
                            //0 seçilirse çıkış yapılıyor.
                            case 0:
                                loop = false;
                                action = 0;
                                break;

                            //1 Seçilirse Ürün Alınıyor.
                            case 1:
                                Console.Clear();
                                Console.WriteLine("---------------Urunler---------------");
                                Console.WriteLine("0 => Araba\n" + "1 => Telefon\n");
                                Console.Write("Seciminizi Yapınız  = ");
                                var choise2 = int.Parse(Console.ReadLine());
                                switch (choise2)
                                {
                                    // Eğer Araba seçilirse Araba değerleri alınıp saveproduct metotunda kaydediliyor.
                                    case 0:
                                        Console.Clear();
                                        Console.WriteLine("--------------Araba Secimi--------------");
                                        Console.WriteLine("Marka Yazınız.");
                                        var carBrand = Console.ReadLine();
                                        Console.WriteLine("Renk Yazınız.");
                                        var carColor = Console.ReadLine();
                                        Console.WriteLine("Adet Yazınız.");
                                        var carQuantity = Console.ReadLine();                                     
                                        appProcess.SaveProduct("Araba", carBrand, carColor, carQuantity);

                                        break;

                                    // Eğer Telefon seçilirse Telefon değerleri alınıp saveproduct metotunda kaydediliyor.
                                    case 1:
                                        Console.Clear();
                                        Console.WriteLine("--------------Telefon Secimi Secimi--------------");
                                        Console.WriteLine("Marka Yazınız.");
                                        var phoneBrand = Console.ReadLine();
                                        Console.WriteLine("Renk Yazınız.");
                                        var phoneColor = Console.ReadLine();    
                                        Console.WriteLine("Adet Yazınız.");
                                        var phoneQuantity = Console.ReadLine();
                                        appProcess.SaveProduct("Araba", phoneBrand, phoneColor, phoneQuantity);
                                        break;
                                }
                                break;

                            // 2 Seçilirse Alınan ürünler listeleniyor.
                            case 2:
                                // Listelenmek için ListProduct kullanılıyor.
                                appProcess.ListProducts();
                                break;



                        }
                    }
                }
            }


        }

    }
}
