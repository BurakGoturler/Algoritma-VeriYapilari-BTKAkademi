using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_VeriYapilari
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// SozDizimi();

			Degiskenler();
		}

		private static void SozDizimi()
		{
			// C# Söz dizimini anlama.

			// Bellekte tam sayı boyutu kadar alan ayırdık.
			// Bu alana herhangi bir değer koymadık.
			// int x;

			// Bu durumda artık x değişkeni içerisinde 2 değeri var.
			// x = 2;

			// Tanımlama sırasında da değişkene değerini verebiliriz.
			int x = 3;

			// y değişkenine x değerinin 2 rakamı ile çarpılmış değerini atadık.
			var y = 2 * x;

			// "var" diye kullandığımız bir anahtar sözcüğümüz var.
			// Değişken tipinin belirtilmediği durumlarda dinamik şekilde veri tipi verilmesi gereken durumlarda kullanılır.

			// y değişkeninin veri tipini ekrana yazdırdık.
			Console.WriteLine(y.GetType());

			// y değişkenini ekrana yazdırdık.
			Console.WriteLine(y);

			// Program kapanmadan önce bir tuşa basmamı beklesin demiş olduk.
			Console.ReadKey();
		}

		private static void Degiskenler() 
		{
			// Bir değişken tanımı yaparken -Tip (Type) konusunda dikkatli olmalıyız.
			// Değişken tipleri kısıtlayıcı unsurlar içerir. Değişken tipi bu noktada belirleyici etkiye sahiptir.

			// Genelde tipler 2 başlık altında değerlendirilir. Bunlar
			// Yerleşik tipler -> Temel işlemler için gerekli olan tiplerdir.
			// int, double, float, datetime, bool, char, string...

			// Kullanıcı taraflı tipler -> Ogrenci adında veri tipimiz var
			// İçerisinde öğrencinin numarasını, adını, soyadını ve cinsiyet bilgisini içermesini isteyebiliriz.
			// Numara için int, ad soyad için string, cinsiyet için ise bool(true-false) veri tiplerini beraber içeren yeni bir tipe ihtiyaç duyabiliriz.
			// Bunları struct ve class yapısı ile kullanabiliriz.

			// İsimlendirmelere dikkat etmeliyiz.
			// Değişkenler birçok programlama dilinde rakam ile başlamaz.
			// int 2sayi = 3; --> Yanlış Kullanım.

			// Rakamla beraber yine #,?,! gibi özel karakterler değişken isimlendirilirken kullanılmaz.
			// Tek özel karakter istisnası "_"(alt çizgi)'dir.
			// double en_Kucuk_Sayi = 0;

			// Türkçe karakterler kullanılmaz.

			//	Best Practics
			// UpperCase -> UzunFonksiyonIsmi
			// camelCase -> uzunFonksiyonIsmi

			// Tip
			// int sayi1;
			// double pi = 3.14;
			// char secim = 'b';
			// string isim = "burak";
			// bool dogruMu = false;

			string isim = "Burak";

            // İsim ifadesi bir ya da daha fazla yerde kullanılabilir.
            // Program içerisinde herhangi bir yerde değeri değişebilir.

            Console.WriteLine("Merhaba " + isim + ".");

			isim = "Mehmet";

			Console.WriteLine("Merhaba Sayın " + isim + ".");

			// Basit Değişken Örneği
			int sayi1 = 2;
            Console.WriteLine(sayi1);
            Console.WriteLine(sayi1 + 2);
            Console.WriteLine(sayi1 * sayi1);
			Console.WriteLine(sayi1 - 5);

			Console.ReadKey();
		}
	}
}