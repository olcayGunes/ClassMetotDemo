namespace ClassMetotDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			// Musteri classından 5 adet musteri nesnesi oluşturuyoruz.
			Musteri musteri1 = new Musteri { Id = 1, Ad = "Olcay", Soyad = "Güneş", HesapNo = "1111111" };
			Musteri musteri2 = new Musteri { Id = 2, Ad = "Ahmet", Soyad = "Ercan", HesapNo = "1111122" };
			Musteri musteri3 = new Musteri { Id = 3, Ad = "Mehmet", Soyad = "Demir", HesapNo = "1312312" };
			Musteri musteri4 = new Musteri { Id = 4, Ad = "Ali", Soyad = "Yılmaz", HesapNo = "1451111" };
			Musteri musteri5 = new Musteri { Id = 5, Ad = "Mustafa", Soyad = "Türkmen", HesapNo = "1654111" };

			// Oluşturduğumuz musteri nesnelerinden bir dizi oluşturup nesneleri içine atıyoruz.(Listelemede kullanmak için)
			Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4, musteri5 };

			// MusteriManager classının bir örneğini oluşturuyoruz.
			MusteriManager musteriManager = new MusteriManager();
			musteriManager.Listele(musteriler);

			musteriManager.Ekle(musteri1);

			musteriManager.Sil(musteri4);
		}
	}
}
