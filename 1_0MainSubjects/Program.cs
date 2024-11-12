using System.ComponentModel.DataAnnotations;

namespace _1_0MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
           #region YazdırmaKomutları
            //Console.Write("merhaba dünya");
            //Console.WriteLine("selam");
            
            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            //Değişkenler

        #endregion

        #region Değişkenler

            //string

            //değişken_türüü değişken_adı;

            //string name;
            //name="murat";
            //Console.Write(name);

           /*  string customerName;
            string customerSurname;
            string customerPhonenumber;
            string customerEmail, district, city;

            customerName= "Bahadır";
            customerSurname= "Sevimli";
            customerPhonenumber = "+90543 730 6262";
            customerEmail= "bahadirsevimli@gmail.com";
            district= "İzmit";
            city= "Kocaeli";

            Console.WriteLine("**** Rezervasyon Kartı ****");
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Müşteri:" + customerName + " " + customerSurname);
            Console.WriteLine("Telefon numarası:" + customerPhonenumber);
            Console.WriteLine("Mail Adresi:" + customerEmail);
            Console.WriteLine("Adres:" + district + "/" + city);
            Console.WriteLine("--------------------------------------------");

            customerName= "Melih";
            customerSurname= "Sevimli";
            customerPhonenumber= "+90500 400 30 20";
            customerEmail= "melihsevimli@gmail.com";
            district= "Beşiktaş";
            city= "İstanbul";
 */
            /* Console.WriteLine(" ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Müşteri:" + customerName + " " + customerSurname);
            Console.WriteLine("Telefon numarası:" + customerPhonenumber);
            Console.WriteLine("Mail Adresi:" + customerEmail);
            Console.WriteLine("Adres:" + district + "/" + city); */
            /* Console.WriteLine("--------------------------------------------"); */

        #endregion


        #region Int Değişkenler

        //int
        //int number= 24;
        //console.writeline(number);

        int hamburgerPrice=300;
        int cokePrice=35;
        int waterPrice=10;
        int friesPrices=50;
        int pizzaPrices=250;
        int lemonadePrices=30;

        Console.WriteLine("**** Restoran Menü Fiyatı ****");
        Console.WriteLine();
        Console.WriteLine("----Hamburger:" + hamburgerPrice + " TL");
        Console.WriteLine("----Kola:" + cokePrice + " TL");
        Console.WriteLine("----Su:" + waterPrice + " TL");
        Console.WriteLine("----Kızartma:" + friesPrices + " TL");
        Console.WriteLine("----Pizza:" + pizzaPrices + " TL");
        Console.WriteLine("----Limonata:" + lemonadePrices + " TL");

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        int hamburgerCount;
        int cokeCount;
        int waterCount; 
        int friesCount;
        int pizzaCount;
        int lemonadeCount;

        hamburgerCount=3;
        cokeCount=2;
        waterCount=1;
        friesCount=0;
        pizzaCount=5;
        lemonadeCount=3;

        int totalHamburgerPrice;
        int totalCokePrices;
        int totalWaterPrices;
        int totalFriesPrices;
        int totalPizzaPrices;
        int totalLemonadePrices;

        totalHamburgerPrice= hamburgerCount * hamburgerPrice;
        totalCokePrices= cokeCount * cokePrice;
        totalWaterPrices= waterCount * waterPrice;
        totalFriesPrices= friesCount * friesPrices;
        totalPizzaPrices= pizzaCount * pizzaPrices;
        totalLemonadePrices=lemonadeCount * lemonadePrices;

        int totalPrices;
        totalPrices= totalCokePrices + totalFriesPrices + totalHamburgerPrice + totalLemonadePrices + totalPizzaPrices + totalWaterPrices;



        Console.WriteLine("Hamburger Tutarı:" + totalHamburgerPrice + " TL");
        Console.WriteLine("Kola Tutarı:" + totalCokePrices + " TL");
        Console.WriteLine("Su Tutarı:" + totalWaterPrices + " TL");
        Console.WriteLine("Kızartma Tutarı:" + totalFriesPrices + " TL");
        Console.WriteLine("Pizza Tutarı:" + totalPizzaPrices + " TL");
        Console.WriteLine("Limonata Tutarı:" + totalLemonadePrices+ " TL");
        Console.WriteLine();
        Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrices + " TL");
        Console.WriteLine();
        Console.WriteLine("***Afiyet Olsun***");
        
        














        #endregion

            
            
            
            Console.Read();
            
        }
    }
}