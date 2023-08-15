using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_VeriYapilari
{
	internal class Program
	{
		static void Main(string[] args)
		{
			VeriTurleriAltUstLimit();
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
			Console.WriteLine(ifade[ifade.Length - 1]); // .

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

			if (n < 0)
			{
				Console.WriteLine($"|{n}| = {n * -1}");
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

		public static void Cevrimler()
		{
			// Döngüler
			// Farklı döngü türleri vardır.
			// For, While, Do-While ve Foreach döngüleri mevcuttur.

			// While ifadesi
			// İken anlamına geliyor.

			// Bu şekilde sonsuz döngü üretmiş oluruz.
			int i = 10;

			while (i < 10) // i küçük 10 iken
			{
                Console.WriteLine("1. Döngü bloğu.");
            }

			// Bu şekilde de sonsuz döngü üretmiş oluruz. Ancak burada sonsuz döngüyü sayaç sayesinde gözlemleyebiliyoruz.
			int k = 10;
			int sayac1 = 0;

			while (k < 10) // k küçük 10 iken 
			{
				Console.WriteLine("2.Döngü bloğu.");
				sayac1++; // döngüye girdiği an 1 olarak başlasın
                Console.WriteLine(sayac1); // bu döngü her gerçekleştiğinde sayaç değerini görelim.
			}

			// Döngü içerisinde kontrol ettiğimiz ifadeyi güncellemediğimiz için sonsuz bir döngü yapısı ile karşılaşıyoruz.

			// Bu örnekde güncelleme işlemini yapıyoruz.
			int j = 10;
			int sayac2 = 0;

			while (j < 10) // j küçük 10 iken 
			{
				Console.WriteLine("3.Döngü bloğu.");
				sayac2++; // döngüye girdiği an 1 olarak başlasın
				Console.WriteLine(sayac2); // bu döngü her gerçekleştiğinde sayaç değerini görelim.
				j++;
                Console.WriteLine(j);
			}
		}

		public static void Cevrimler2()
		{
			// 1'den 10'a kadar olan sayıları yazdırdı.
			int sayac = 1;
            while (sayac <= 10)
            {
                //Console.Write(" " + sayac + " ");
				Console.WriteLine("{0,-3} {1,-3}", sayac,sayac*sayac);
				sayac++;
            }
			Console.ReadKey();

			// üstteki kod parçacığının tam tersini yazdırdık.
			// 10'dan 0'a kadar olan sayıları yazdırdı.
			int sayacc = 10;
			while (sayacc >= 0)
			{
				//Console.Write(" " + sayac + " ");
				Console.WriteLine("{0,-3} {1,-3}", sayacc, sayacc * sayacc);
				sayacc--;
			}
			Console.ReadKey();

            // do while örnek

            Console.Write("Bir sayı giriniz:");
            // klavyeden bir n değeri okıyalım. n değerine kadar olan çift sayıları yazdıralım
            // klavyeden değer okumak için convert metodu ile ToInt32 şeklinde bir tanımlama yapıyoruz.
            // böylelikle n değerine gelen değeri tam sayı olarak almış oluyorum.
            // (Console.ReadLine() ile de o satırı okuyoruz.
            // Console.ReadLine() string.
            // Convert.ToInt32(Console.ReadLine()) tamsayı.
            int n = Convert.ToInt32(Console.ReadLine());

			int i = 2;

			// herhangi bir koşula bakmaksızın kod bloğu içerisindeki kodları olduğu gibi çalıştırır.
			// koşula kod bloğu içerisindeki yaptıktan sonra bakıyor.
			do
			{
                Console.WriteLine(i);
                i = i + 2;
			} while (i <= n);
			Console.ReadKey();
		}

		public static void Cevrimler3()
		{
			for (int i = 0; i < 100; i+=5)
			{
                Console.WriteLine(i);
            }

			// forr
			for (int j = 100; j >= 0; j-=5)
			{
                Console.WriteLine(j);
			}
		}

		public static void Diziler()
		{
			// array kavramı
			// diziler büyük ya da küçük pek çok programda yaygın şekilde kullanılan temel programlama bileşenidir.
			// temel veri yapısıdır.
			// diziler sabit boyutludur. Diziler tanımlandığı anda uzunluk bilgisini bilmelidir.
			// sıfır tabanlı indisleme. 0'dan başlar ilk elemean,veri,nesne.
			// diziler tek boyutlu olduğu gibi çift boyutlu da olabilirler.

			Console.WriteLine("1. örnek");

			// dizi tanımı
			int[] numaralar;

			// başlatma
			numaralar = new int[3];

			numaralar[0] = 3;
			numaralar[1] = 5;
			numaralar[2] = 7;

			for (int i = 0; i < numaralar.Length; i++)
			{
				Console.WriteLine(numaralar[i]);
			}

			Console.ReadKey();

			Console.WriteLine("2. örnek");

			// dizi tanımını ve başlatmayı aynı yerde yapabiliriz.
			int[] numaralarr = new int[3];

			numaralarr[0] = 3;
			numaralarr[1] = 5;
			numaralarr[2] = 7;

			for (int j = 0; j < numaralarr.Length; j++)
			{
				Console.WriteLine(numaralarr[j]);
			}
			Console.ReadKey();

			Console.WriteLine("3. örnek");

			// dizi tanımını ve başlatmayı ve atamayı aynı yerde yapabiliriz.
			// int[] numaralarrr = new int[3] { 3, 5, 7};
			// int[] numaralarrr = new int[] { 3, 5, 7, 8, 6};
			int[] numaralarrr = { 3, 5, 7, 8, 10};


			for (int k = 0; k < numaralarrr.Length; k++)
			{
				Console.WriteLine(numaralarrr[k]);
			}

			Console.ReadKey();

			Console.WriteLine("indis örneği");

			int[] numaralarrrr = { 3, 5, 7, 8, 10 };

			for (int k = 0; k < numaralarrrr.Length; k++)
			{
				Console.WriteLine($"Numaralar[{k}] = " +
					$"{numaralarrrr[k]}");
			}

			Console.ReadKey();

			Console.WriteLine("4. örnek");

			// Boyut bilgisini dışarıdan alan, rakamların rastgele oluşacağı bir örnek.

			Console.WriteLine("Dizi boyutunu giriniz: ");

			int boyut = Convert.ToInt32(Console.ReadLine());

			int[] sayilar = new int[boyut];

			var r = new Random();

			for (int i = 0; i < sayilar.Length; i++)
			{
				// dizi içerisinde en az 1 en fazla 10 sayısını üretsin.
				sayilar[i] = r.Next(1, 10);
			}

			foreach (int sayi in sayilar)
			{
				Console.WriteLine($"{sayi,5} {sayi * sayi,5}");
			}

			Console.ReadKey();
		}

		public static void CokBoyutluDiziler()
		{
			Console.ReadKey();
        }

		public static void VeriTurleriAltUstLimit()
		{
			// Signed 8-bit integer
			Console.WriteLine(nameof(SByte));
            Console.WriteLine($"Alt Limit		: {SByte.MinValue,20}");
			Console.WriteLine($"Üst Limit		: {SByte.MaxValue,20}");
			Console.WriteLine($"Boyut			: {sizeof(SByte),20}");
			Console.ReadKey();

			// Unsigned 8-bit integer
			Console.WriteLine(nameof(Byte));
			Console.WriteLine($"Alt Limit		: {Byte.MinValue,20}");
			Console.WriteLine($"Üst Limit		: {Byte.MaxValue,20}");
			Console.WriteLine($"Boyut			: {sizeof(Byte),20}");
			Console.ReadKey();

			// Signed 16-bit integer
			Console.WriteLine(nameof(Int16));
			Console.WriteLine($"Alt Limit		: {Int16.MinValue,20}");
			Console.WriteLine($"Üst Limit		: {Int16.MaxValue,20}");
			Console.WriteLine($"Boyut			: {sizeof(Int16),20}");
			Console.ReadKey();

			// Unsigned 16-bit integer
			Console.WriteLine(nameof(UInt16));
			Console.WriteLine($"Alt Limit		: {UInt16.MinValue,20}");
			Console.WriteLine($"Üst Limit		: {UInt16.MaxValue,20}");
			Console.WriteLine($"Boyut			: {sizeof(UInt16),20}");
			Console.ReadKey();

			// Signed 32-bit integer
			Console.WriteLine(nameof(Int32));
			Console.WriteLine($"Alt Limit		: {Int32.MinValue,20}");
			Console.WriteLine($"Üst Limit		: {Int32.MaxValue,20}");
			Console.WriteLine($"Boyut			: {sizeof(Int32),20}");
			Console.ReadKey();

			// Unsigned 32-bit integer
			Console.WriteLine(nameof(UInt32));
			Console.WriteLine($"Alt Limit		: {UInt32.MinValue,20}");
			Console.WriteLine($"Üst Limit		: {UInt32.MaxValue,20}");
			Console.WriteLine($"Boyut			: {sizeof(UInt32),20}");
			Console.ReadKey();

			// Signed double
			Console.WriteLine(nameof(Double));
			Console.WriteLine($"Alt Limit		: {Double.MinValue,20}");
			Console.WriteLine($"Üst Limit		: {Double.MaxValue,20}");
			Console.WriteLine($"Boyut			: {sizeof(Double),20}");
			Console.ReadKey();

			Console.ReadKey();

		}
	}
}