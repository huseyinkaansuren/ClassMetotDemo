using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();//Müşteri objesi oluşturma
            musteri1.Id = 1534846;
            musteri1.Ad = "Kaan";
            musteri1.Soyad = "Süren";
            MusteriManager musterimanager = new MusteriManager();//Müşteri manager objesi oluşturma

            musterimanager.MusteriEkleme(musteri1);//Müşteri ekleme
            musterimanager.MusteriSilme(musteri1);//Müşteri Silme
        }
    }
}
