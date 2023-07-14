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
			// Degiskenler();
			// KarakterDizeleri();
			// DizeDegismezleriVeSabitTanimlama();
			// Operatorler();
			// Kosulİfadeleri();

			Console.ReadKey();
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

		private static void KarakterDizeleri()
		{
			// Bazı zamanlar kod içerisinde not düşmek isteyebiliriz.
			// Dolayısıyla bu not kodu etkilememeli ve derleyici tarafından sanki bir kodmuşcasına anlaşılmamalıdır.

			// Bu yüzden yorum satırladını kullanırız.
			// C#'da yorum satırı için çift bölü işaretini kullanırız -> //
			// Tek bir satırı değil bir kod bloğunu yoruma almak istiyorsak /* */ şeklinde bir kullanımı var.

			/*
			int x;
			x = 2;
			*/

			// Refectoring kavramı zaman zaman yazdığımız kodları iyileştirmek, bazı kodları başka dosyalara taşımak veya mevcut kodu bir metoda çevirmek gibi işlemleri kapsayabilir.

			// Escape ifadeleri, kaçış ifadelerine \n, \t, \q bakacağız.

			// \n ifadesi yazıldığı yerden sonra bir alt satıra geçiyor.
			string ifade1 = "\nBTK \nAkademi \nProgramlama \nÖğreniyorum.";

			// Her bir kelime arasına tab kadar boşluk bırakıyor.
			string ifade2 = "\tBTK \tAkademi \tProgramlama \tÖğreniyorum.";

			// \a Uyarı sesi veriyor.
			string ifade3 = "\aBTK Akademi Programlama Öğreniyorum.";

			Console.WriteLine(ifade1);
			Console.WriteLine(ifade2);
			Console.WriteLine(ifade3);

			// Bu dosya yolu gösterimi C# üzerinde çalışmaz.
			// string YanlisDosyaYoluTanimi = "C:\user\burak";

			// Bu tarz ifadeleri kullanmak için çift ters slash işareti ekliyoz.
			string DogruDosyaYoluTanimi = "C:\\user\\burak";

			// eğer yine de "C:\user\burak" şu şekilde göstermek istiyorsanız bu kullanım uygun olacaktır.
			string DogruDosyaYoluTanimi2 = @"C:\user\burak";

            Console.WriteLine(DogruDosyaYoluTanimi);
            Console.WriteLine(DogruDosyaYoluTanimi2);

			Console.ReadKey();
		}

		private static void DizeDegismezleriVeSabitTanimlama()
		{
			// Örtülü Değişken
			// var ifade = Console.ReadKey();
			// Console.WriteLine(ifade.Key);
			// Console.WriteLine(ifade.KeyChar);

			var ifade = "Merhaba programlama dünyası.";

            Console.WriteLine(ifade);                 // Merhaba programlama dünyası.
			Console.WriteLine(ifade.Length);          // 27
            Console.WriteLine(ifade.ToUpper());       // MERHABA PROGRAMLAMA DÜNYASI.
			Console.WriteLine(ifade.ToLower());       // merhaba programlama dünyası.
			Console.WriteLine(ifade.TrimStart());     // Merhaba programlama dünyası.
			Console.WriteLine(ifade.TrimEnd());       // Merhaba programlama dünyası.
			Console.WriteLine(ifade[0]);              // M
			Console.WriteLine(ifade[1]);              // e
			Console.WriteLine(ifade[ifade.Length-1]); // .

			Console.ReadKey(true);
		}

		private static void Operatorler()
		{
			// Aritmetik Operatörler
			// +, -, /, *, %

			// İlişkisel Operatörler
			// <, <=, >, >=, ==, !=

			// Mantıksal Operatörler
			// &&/ve -> tüm koşulların sağlanması gerekir.

			// ||/veya bir koşulun sağlanması yeterli olacaktır.

			// !/not/değil -> true false.

			int A = 20, B = 10;

            // Aritmetik Operatör örnekleri
            Console.WriteLine(A + B);
			Console.WriteLine(A - B);
			Console.WriteLine(A * B);
			Console.WriteLine(A / B);
			Console.WriteLine(A % B);

			Console.WriteLine("---");

			// İlişkisel Operatör örnekleri
			Console.WriteLine(A > B);
            Console.WriteLine(A < B);
			Console.WriteLine(A >= B);
			Console.WriteLine(A <= B);
			Console.WriteLine(A == B);
			Console.WriteLine(A != B);

            Console.WriteLine("---");

            // Mantıksal Operatör örnekleri
            Console.WriteLine(A > B && A > 5);
            Console.WriteLine(A < B || B > 5);
		}

		private static void Kosulİfadeleri()
		{
            // if-else

            // Tek Çift örneği

            Console.WriteLine("Bir sayı giriniz: ");

			int sayi = Convert.ToInt32(Console.ReadLine());

			if (sayi % 2 == 0)
			{
                Console.WriteLine($"{sayi} çift bir sayıdır.");
            }
			else
			{
				Console.WriteLine($"{sayi} tek bir sayıdır.");
			}

            Console.WriteLine("----");

            // Mutlak De ğer örneği

            int n = Convert.ToInt32(Console.ReadLine());

			if (n<0)
			{
                Console.WriteLine($"|{n}| = {n*-1}");
            }
			else
			{
                Console.WriteLine($"|{n}| = {n}");
            }

			Console.WriteLine("----");

			var k = (char)Console.Read();

			if (char.IsDigit(k)) // k değeri bir rakam mı ?
			{
                Console.WriteLine("Rakamdır.");
            }
			else if (char.IsLower(k)) // k değeri küçük bir ifade mi ?
			{
				Console.WriteLine("Küçük karakter.");
			}
			else if (char.IsUpper(k)) // k değeri büyük bir ifade mi ?
			{
				Console.WriteLine("Büyük karakter.");
			}
			else
			{
				Console.WriteLine("Bilinmeyen karakter.");
			}

			Console.WriteLine(k);

        }
	}
}