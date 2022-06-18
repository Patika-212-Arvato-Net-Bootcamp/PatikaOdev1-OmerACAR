using System;
using System.Collections.Generic;

namespace PatikaOdev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Kullanicilar> kullanicilar = new List<Kullanicilar>();
            kullanicilar.Add(new Kullanicilar());

            Urunler urunler = new Urunler();
            while (true)
            {
                Console.Write("Tc'nizi Giriniz.");
                var tc = Console.ReadLine();
                foreach (var item in kullanicilar)
                {
                    if (tc == item.Tc)
                    {
                        Console.WriteLine(item.Isim + ""+ "Hoşgeldiniz.");
                        Console.WriteLine("Ürünler : Araba , Telefon");
                        Console.Write("Seçiceğiniz Ürünü Seçiniz :");
                        var secilenUrun = Console.ReadLine();
                        switch (secilenUrun)
                        {
                            case "Araba":
                                Console.WriteLine("Araba Markaları : Ford , Hydundai , BWM , Mercedes");
                                Console.Write("Marka Seçiniz :");
                                var secilenMarka = Console.ReadLine();
                                
                                urunler.Arabalar.Add(secilenMarka);
                                //switch (secilenMarka)
                                //{
                                //   
                                //    case "Ford":
                                //        Console.WriteLine("Ford Araba seçildi.");
                                //        break;
                                //    case "Hydundai":
                                //        Console.WriteLine("Hydundai Araba seçildi.");
                                //        break;
                                //    case "BWM":
                                //        Console.WriteLine("BWM Araba seçildi.");
                                //        break;
                                //    case "Mercedes":
                                //        Console.WriteLine("Mercedes Araba seçildi.");
                                //        break;

                                //}
                                break;
                            case "Telefon":
                                Console.WriteLine("Telefon Seçildi.");
                                Console.ReadLine();
                                break;

                        }
                    }
                    else
                    {
                        Console.WriteLine("Bu kullanıcıya ait kayıt yok, kayıt olmak için bir tuşa basınız.");
                        Console.ReadLine();
                        item.Tc = tc;
                        Console.Write("İsim : ");
                        var isim = Console.ReadLine();
                        item.Isim = isim;
                        Console.Write("Soy isim : ");
                        var soyisim = Console.ReadLine();
                        item.Soyisim = soyisim;
                        Console.Write("Telefon : ");
                        var telefon = Console.ReadLine();
                        item.Telefon = telefon;
                        kullanicilar.Add(item);
                        
                        Console.WriteLine(item.Isim + "Adli kullanici kaydi alinmistir.");
                        break;
                    }
                }

            }


        }


    }
}
