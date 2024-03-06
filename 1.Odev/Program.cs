using System.Diagnostics.Metrics;

namespace _1.Odev
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Soru1
			Console.Write("Bir sipariş numarası giriniz: ");
			int orderNo = int.Parse(Console.ReadLine());

			switch (orderNo)
			{
				case 1:
					Console.WriteLine("Siparişteki ürün : Casper Excalibur");
					break;

				case 2:
					Console.WriteLine("Siparişteki ürün : Asus TUF");
					break;

				case 3:
					Console.WriteLine("Siparişteki ürün : Lenovo Thinkpad");
					break;

				case 4:
					Console.WriteLine("Siparişteki ürün : Dell Inspiron");
					break;

				default:
					Console.WriteLine("Lütfen geçerli bir sipariş numarası giriniz.");
					break;
			}
			#endregion
			#region Soru2
			Console.Write("Kaç ürün satın almak istiyorsunuz? : ");
			int count = int.Parse(Console.ReadLine());
			int sum = 0, price;

			for (int i = 1; i <= count; i++)
			{
				Console.Write(i + ". ürünün fiyatını giriniz: ");
				price = int.Parse(Console.ReadLine());
				sum += price;
			}

			Console.WriteLine("Toplam alışveriş tutarı: " + sum);
			#endregion
			#region Soru3
			While Döngüsü : For döngüsü ile aynı mantıkta çalışır. Sayacın değeri döngüye girmeden ilk başta atanır, arttırma işlemi de döngünün içerisinde yapılır. Parantez içerisindeki koşul devam edene kadar döngü devam eder.

			int sum = 0, i = 0;
			while (i < 100)
			{
				sum += i;
				i++;
			}
			Console.WriteLine("1-100 arası sayıların toplamı: " + sum);

			Do While Döngüsü: While döngüsü gibi çalışır fakat her koşulda döngü bir kez çalışacaktır ve koşul kontrolü döngünün sonunda yapılır.

			int sum = 0, count = 0;

			do
			{
				count++;
				sum += count;
			} while (count < 100);

			Console.WriteLine("Toplam: " + sum + ", Sayaç: " + count);


			#endregion
			#region Soru4
			Random rnd = new Random();
			int random = rnd.Next(1, 10);

			Console.Write("Sayı tahmin oyunu için 1 ile 10 arasında bir değer giriniz: ");
			int value = int.Parse(Console.ReadLine());

			while (value != random)
			{
				Console.Write("Bilemediniz. Tekrar bir sayı giriniz: ");
				value = int.Parse(Console.ReadLine());
			}
			Console.WriteLine("Tebrikler! Doğru bildiniz.");
			#endregion
			#region Soru5
			int num = 28, sum = 0;
			for (int i = 1; i < num; i++)
			{
				if (num % i == 0)
				{
					sum += i;
				}
			}
			if (sum == num)
			{
				Console.WriteLine("Sayı mükemmel sayıdır.");
			}
			else
			{
				Console.WriteLine("Sayı mükemmel sayı değildir.");
			}
			#endregion
			#region Soru6
			String Metotlar
			Length Metodu: Metnin uzunluğunu gösterir.
			string name = "Dila Zeren Yılmaz";
			Console.WriteLine("Orjinal metin: " + name);
			Console.WriteLine("-------------------------");
			int length = name.Length;
			Console.WriteLine("Length Metodu");
			Console.WriteLine("Metnin uzunluğu: " + length);
			Console.WriteLine("-------------------------");
			ToLower Metodu: Metnin tüm karakterlerini küçük harf yapar.
			Console.WriteLine("ToLower Metodu");
			name = name.ToLower();
			Console.WriteLine(name);
			Console.WriteLine("-------------------------");
			ToUpper metodu: Metnin tüm karakterlerini büyük harf yapar.
			Console.WriteLine("ToUpper Metodu");
			name = name.ToUpper();
			Console.WriteLine(name);
			Console.WriteLine("-------------------------");
			Compare Metodu: İki metni karşılaştırıp metinler aynıysa 0 farklıysa - 1 veya 1 döner.
			Console.WriteLine("Compare Metodu");
			string name2 = "dila zeren yılmaz";
			int isSame = String.Compare(name, name2);
			if (isSame == 0)
			{
				Console.WriteLine("Metinler aynıdır.");
			}
			Console.WriteLine("Metinler farklıdır." + isSame);
			Concat Metodu: Metinleri birleştirmek için kullanılır.
			string metin1 = "dila";
			string metin2 = "yılmaz";
			string yeni_metin = string.Concat(metin1, metin2);
			Console.WriteLine(yeni_metin);
			Console.WriteLine("-------------------------");
			IsNullOrEmpty Metodu: String türündeki değişkenin içeriğinin boş olup olmadığını kontrol eden metottur.
			bool sonuc = String.IsNullOrEmpty(metin1);
			#endregion
			#region Soru7
			Console.Write("Öğrenci sayısı giriniz: ");
			int num = int.Parse(Console.ReadLine());
			string name, surname;
			double grade1, grade2, grade3;

			for (int i = 1; i <= num; i++)
			{
				Console.Write("Öğrencinin adını giriniz: ");
				name = Console.ReadLine();

				Console.Write("Öğrencinin soyadını giriniz: ");
				surname = Console.ReadLine();

				Console.Write("Öğrencinin 1. sınav notunu giriniz: ");
				grade1 = double.Parse(Console.ReadLine());

				Console.Write("Öğrencinin 2. sınav notunu giriniz: ");
				grade2 = double.Parse(Console.ReadLine());

				Console.Write("Öğrencinin 3. sınav notunu giriniz: ");
				grade3 = double.Parse(Console.ReadLine());

				Console.WriteLine(name + " " + surname + " adlı öğrencinin not ortalaması: " + (grade1 + grade2 + grade3) / 3);
			}
			#endregion
		}
	}
}
