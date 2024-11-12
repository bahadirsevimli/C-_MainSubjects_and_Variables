/* double number;
number=4.85;
Console.WriteLine(number); */

/* double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

applePrice=12.25;
orangePrice=4.20;
strawberryPrice=8.50;
potatoPrice=2.5;
tomatoPrice=13.10;

Console.WriteLine("****Fiyat Listesi****");
Console.WriteLine();
Console.WriteLine("----Elma Birim Fiyatı: " + applePrice + " TL");
Console.WriteLine("----Portakal Birim Fiyatı: " + orangePrice + " TL");
Console.WriteLine("----Çilek Birim Fiyatı: " + strawberryPrice + " TL");
Console.WriteLine("----Patates Birim Fiyatı: " + potatoPrice + " TL");
Console.WriteLine("----Domates Birim Fiyatı: " + tomatoPrice + " TL");
Console.WriteLine();
Console.WriteLine();

double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

appleGram=2.30;
orangeGram=3.20;
strawberryGram=0.55;
potatoGram=5.70;
tomatoGram=4.30;

double appleTotalPrice, orangeTotalPrices, strawberryTotalPrices, potatoTotalPrices, tomatoTotalPrices, totalPrice;
appleTotalPrice=appleGram * applePrice;
orangeTotalPrices=orangeGram * orangePrice;
strawberryTotalPrices=strawberryGram * strawberryPrice;
potatoTotalPrices=potatoGram * potatoPrice;
tomatoTotalPrices=tomatoGram * tomatoPrice;

totalPrice=appleTotalPrice + orangeTotalPrices + strawberryTotalPrices + potatoTotalPrices + tomatoTotalPrices;

Console.WriteLine("Alınacak ürün: Elma -" + "Birim Fiyatı: " + applePrice +  " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice + " TL");
Console.WriteLine("Alınacak ürün: Portakal -" + "Birim Fiyatı: " + orangePrice +  " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrices + " TL");
Console.WriteLine("Alınacak ürün: Çilek -" + "Birim Fiyatı: " + strawberryPrice+  " - Gramaj: " + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrices+ " TL");
Console.WriteLine("Alınacak ürün: Patates -" + "Birim Fiyatı: " + potatoPrice+  " - Gramaj: " + potatoGram + " - Toplam Tutar: " + potatoTotalPrices + " TL");
Console.WriteLine("Alınacak ürün: Domates -" + "Birim Fiyatı: " + tomatoPrice +  " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrices+ " TL");
Console.WriteLine();
Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");
 Console.WriteLine();
Console.WriteLine("*** Afiyet Olsun ***"); */

//Char Değişkenler

/* char symbol;
symbol='a';
Console.WriteLine(symbol); */

//Klavyeden Veri Girişleri String Değişkenler

/* Console.WriteLine("*** THY Yolcu Bilgisi ***");
Console.WriteLine();

string passangerName, passangerSurname, District, passangerCity, passangerAge, passangerIdentitynumber;

Console.Write("Yolcu Adı: ");
passangerName= Console.ReadLine();

Console.Write("Yolcu Soyadı: ");
passangerSurname= Console.ReadLine();

Console.Write("Yolcu İlçe Bilgisi: ");
District= Console.ReadLine();

Console.Write("İl Bilgisi: ");
passangerCity= Console.ReadLine();

Console.Write("Yolcu Yaşı: ");
passangerAge= Console.ReadLine();

Console.Write("TC Kimlik No: ");
passangerIdentitynumber= Console.ReadLine();

Console.WriteLine();
Console.WriteLine("------------------------------------");
Console.WriteLine("Yolcu TC No: " + passangerIdentitynumber + " --- Yolcu: " + passangerName + " " + passangerSurname + " " + District + "/" + passangerCity + " " + passangerAge ); */

//Klavyeden Tam Sayı Girişleri ve Dönüşümler

/* int shoesPrices, computerPrices, chairPrice, tvPrices;
shoesPrices=2000;
computerPrices=10000;
chairPrice=1500;
tvPrices=12000;

int shoesCount, computerCount, chairCount, tvCount, totalPrice;


Console.WriteLine("***Trendyol***");
Console.WriteLine();


Console.Write("Lütfen Aldığınız ayakkabı sayısını giriniz: ");
shoesCount= int.Parse(Console.ReadLine());

Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
computerCount=int.Parse(Console.ReadLine());

Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
chairCount=int.Parse(Console.ReadLine());

Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
tvCount=int.Parse(Console.ReadLine());


int totalShoppingPrice= shoesCount * shoesPrices + computerCount * computerPrices + chairCount * chairPrice + tvCount * tvPrices;


Console.WriteLine();
Console.WriteLine("-------------------------");
Console.WriteLine();
Console.WriteLine("Toplam Ödenecek Tutar: " + totalShoppingPrice + " TL"); */

//Klavyeden ondalıklı sayı işlemleri

/* double exam1, exam2, exam3, result;

Console.Write("Lütfen 1. sınav notunu giriniz: ");
exam1=double.Parse(Console.ReadLine());

Console.Write("Lütfen 2. sınav notunu giriniz: ");
exam2=double.Parse(Console.ReadLine());

Console.Write("Lütfen 3. sınav notunu giriniz: ");
exam3=double.Parse(Console.ReadLine());

result= (exam1 + exam2 + exam3) / 3;

Console.WriteLine();
Console.WriteLine("Ortalamanız: " + result + " puan"); */

//Klavyeden karakter girişleri

/* char gender;
Console.Write("Lütfen cinsiyet seçiniz: ");
gender=char.Parse(Console.ReadLine());

Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender); */ 



























