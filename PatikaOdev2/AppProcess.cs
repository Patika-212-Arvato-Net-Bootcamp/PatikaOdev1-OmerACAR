using PatikaOdev1.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PatikaOdev1
{
    
    public class AppProcess
    
        // Classları List olarak Çağırıyoruz ve gerekli yerlerde kullanıyoruz.
    {
        List<Users> users = new List<Users>();
        
        List<Araba> cars = new List<Araba>();

        List<Araba> phones = new List<Araba>();

        //Default kullanıcı eklemek için AddUser metotunu kullanıyoruz.
        public void AddUser()
        {
            users.Add(new Users() { Tc = "5", Name = "Omer", SurName = "ACAR", PhoneNumber = "05511121305" });
        }

        // Tc kontrolü için CheckTC metotunu kullanıyoruz.
        public  string CheckTC(string tc)
        {
            foreach (var user in users)
            {
                if (tc == user.Tc)
                {
                    return tc;
                }
                else
                {
                    return null;
                }
            }
            return null;

        }

        // Yeni kullanıcı eklemek için newuser metotunu kullanıyoruz.
        public void NewUser(string tc)
        {
            foreach (var user in users)
            {
                Console.WriteLine("Bu kullanıcıya ait kayıt yok, kayıt olmak için bir tuşa basınız.");
                Console.ReadLine();
                user.Tc = tc;
                Console.Write("İsim : ");
                var name = Console.ReadLine();
                user.Name = name;
                Console.Write("Soy isim : ");
                var surname = Console.ReadLine();
                user.SurName = surname;
                Console.Write("Telefon : ");
                var phone = Console.ReadLine();
                user.PhoneNumber = phone;
                users.Add(user);
                Console.WriteLine(user.Name +""+ "Adli kullanici kaydi alinmistir.");
                PrintDotAnimation();
                Console.Clear();
                break;

            }

        }

        //Ürünler seçildikten sonra SaveProduct Metotu ile kaydedebiliyoruz.
        public void SaveProduct(string selectedProduct , string model,string color , string quantity)
            
        {
            
            if (selectedProduct == "Araba")
            {
                cars.Add(new Araba() { Quantity = quantity, Model = model, Color = color });

            }
            else if (selectedProduct == "Telefon")
            {
                phones.Add(new Araba() { Quantity = quantity, Model = model, Color = color });
            }
            PrintDotAnimation();

        }

        //Ürünler Listelenmek için ListProducts metotunu kullanıyoruz.
        public void ListProducts()
        {
            Console.WriteLine("Urunler Listeleniyor");
            PrintDotAnimation();
            foreach (var car in cars)
            {
                Console.WriteLine("Sectiğiniz Araba Modeli: "+ car.Model+ "\n"
                    + "Sectiğiniz Araba Rengi: "+ car.Color + "\n"
                    + "Sectiğiniz Araba Adedi: "+ car.Quantity + "\n" );
            }

            foreach (var phone in phones)
            {
                Console.WriteLine("Sectiğiniz Telefon Modeli: " + phone.Model + "\n"
                    + "Sectiğiniz Telefon Rengi: " + phone.Color + "\n"
                    + "Sectiğiniz Telefon Adedi: " + phone.Quantity + "\n");
            }

            Console.ReadLine();
        }

        // "...." Efekti kullanmak için PrintDotAnimation kullanıyoruz.
        public static void PrintDotAnimation()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write(".");
                Thread.Sleep(200);
            }
        }

    }
}
