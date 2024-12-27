using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            applePrice = 14.90;
            orangePrice = 20.40;
            strawberryPrice = 35;
            potatoPrice = 10;
            tomatoPrice = 12.10;

            Console.WriteLine("----- Elma Birim Fiyatı : "+applePrice);
            Console.WriteLine("----- Portakal Birim Fiyatı : "+orangePrice);
            Console.WriteLine("----- Çilek Birim Fiyatı : "+ strawberryPrice);
            Console.WriteLine("----- Patates Birim Fiyatı : "+potatoPrice);
            Console.WriteLine("----- Domates Birim Fiyatı : "+tomatoPrice);
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            

            double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            appleGram = 1.200;
            orangeGram = 1.450;
            strawberryGram = 1.000;
            potatoGram = 5.260;
            tomatoGram = 6.452;

            double appleTotalPrice = appleGram * applePrice;
            double orangeTotalPrice = orangeGram * orangePrice;
            double strawberryTotalPrice = strawberryGram * strawberryPrice;
            double potatoTotalPrice = potatoGram * potatoPrice ;
            double tomatoTotalPrice = tomatoGram * tomatoPrice;
            Console.WriteLine("Alınan Ürün : Elma - " + " Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram + " Toplam Tutar: " + appleTotalPrice);
            Console.WriteLine("Alınan Ürün : Portakal - " + " Birim Fiyat: " + orangePrice + " - Gramaj: " + orangeGram + " Toplam Tutar: " + orangeTotalPrice );
            Console.WriteLine("Alınan Ürün : Çilek - " + " Birim Fiyat: " + strawberryPrice + " - Gramaj: " + strawberryGram + " Toplam Tutar: " + strawberryTotalPrice);
            Console.WriteLine("Alınan Ürün : Patates - " + " Birim Fiyat: " + potatoPrice + " - Gramaj: " + potatoGram + " Toplam Tutar: " + potatoTotalPrice);
            Console.WriteLine("Alınan Ürün : Domates - " + " Birim Fiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + " Toplam Tutar: " + tomatoTotalPrice);

            double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + potatoTotalPrice;

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Alışveriş Toplam Tutar:" + shoppingTotalPrice + "TL");



            #endregion

            #region Char Değişkenler
            char symbol;
            symbol = 'a';

            Console.WriteLine(symbol);


            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler
            Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            Console.WriteLine();

            string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge,
                passengerIdentityNumber;

            Console.WriteLine("Yolcu Adı: ");
            passengerName =Console.ReadLine();

            Console.WriteLine("Yolcu Soyadı: ");
            passengerSurname =Console.ReadLine();

            Console.WriteLine("Yolcu Semti: ");
            passengerDistrict =Console.ReadLine();

            Console.WriteLine("Yolcu Şehri: ");
            passengerCity =Console.ReadLine();

            Console.WriteLine("Yolcu Yaş: ");
            passengerAge =Console.ReadLine();

            Console.WriteLine("Yolcu TC Kimlik Numarası: ");
            passengerIdentityNumber = Console.ReadLine();

            Console.WriteLine("-----------------------");
            Console.WriteLine("Yolcu TC Kimlik No:"+passengerName+" "+passengerSurname+" "+passengerDistrict+" / "+passengerCity+" "+passengerAge);





            #endregion


            Console.Read();


        }
    }
}
