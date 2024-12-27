using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları
            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            #endregion

            #region String Değişkenler
            //string name;
            //name = "Furkan";
            //Console.WriteLine(name);
            string customerName;
            string customerSurname;
            string customerPhone;
            string customerEmail, customerDistrict, customerCity;
            customerName = "Harry";
            customerSurname = "Kane";
            customerPhone = "+90 578 254 23 80";
            customerEmail = "harry_kane_74@gmail.com";
            customerDistrict = "Kemer";
            customerCity = "Antalya";
            Console.WriteLine("**** Rezervasyon Kartı ****");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Müşteri: "+customerName+ " " + customerSurname );
            Console.WriteLine("İletişim: "+customerPhone);
            Console.WriteLine("Email Adresi: " + customerEmail);
            Console.WriteLine("Adres: " + customerDistrict + "/" + customerCity);

            #endregion

            #region Int Değişkenler

            int hamburgerPrice = 150;
            int cokePrice = 30;
            int waterPrice = 15;
            int friesPrice = 12;
            int pizzaPrice = 160;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("--------Hamburger: " + hamburgerPrice + " TL ");
            Console.WriteLine("---------Pizza: "+pizzaPrice+ " TL ");
            Console.WriteLine("---------Kola: "+cokePrice+ " TL ");
            Console.WriteLine("---------Limonata: " + lemonadePrice + " TL ");
            Console.WriteLine("---------Kızartma: " +friesPrice+ " TL ");
            Console.WriteLine("---------Su: "+ waterPrice+ " TL ");
            Console.WriteLine() ;
            Console.WriteLine("**** Restoran Menü Fiyatı ****");

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 4;
            cokeCount=3;
            waterCount=3;
            friesCount=1;
            pizzaCount=0;
            lemonadeCount=0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice ;
            totalCokePrice= cokeCount * cokePrice ;
            totalWaterPrice = waterCount * waterPrice ;
            totalLemonadePrice = lemonadePrice * lemonadeCount ;
            totalFriesPrice = friesPrice * friesCount;
            totalPizzaPrice= pizzaPrice*pizzaCount ;
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Hamburger Tutarı: "+ totalHamburgerPrice+" TL ");
            Console.WriteLine("Pizza Tutarı :" +totalPizzaPrice + " TL ");
            Console.WriteLine("Kızartma Tutarı :" +totalFriesPrice + " TL ");
            Console.WriteLine("Kola Tutarı :" + totalCokePrice + " TL ");
            Console.WriteLine("Limonata Tutarı :" +totalLemonadePrice + " TL ");
            Console.WriteLine("Su Tutarı :" + totalWaterPrice + " TL ");
            Console.WriteLine();
            int totalPrice = totalCokePrice + totalWaterPrice + totalHamburgerPrice + totalLemonadePrice + totalPizzaPrice + totalFriesPrice;
            Console.WriteLine("Toplam Ödenecek Tutar : "+ totalPrice + " TL ");
            
            #endregion 

            Console.Read();
        }
    }
}
