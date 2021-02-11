using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
	class MusteriManager
	{
		public void Ekle(Musteri musteri)
		{
			Console.WriteLine(musteri.Ad+" "+musteri.Soyad+" isimli müşteri sisteme eklenmiştir.");
		}

		public void Sil(Musteri musteri)
		{
			Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " isimli müşteri sistemden silinmiştir.");
		}

		public void Listele(Musteri[] musteriler)
		{
			foreach (var musteri in musteriler)
			{
				Console.WriteLine("Müşteri Adı		: " + musteri.Ad);
				Console.WriteLine("Müşteri Soyadı		: " + musteri.Soyad);
				Console.WriteLine("Müşteri Hesap No	: " + musteri.HesapNo);
				Console.WriteLine("-----------------------------------------");
			}
		}
	}
}
