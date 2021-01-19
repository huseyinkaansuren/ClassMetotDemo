using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkleme(Musteri musteri)
        {
            Console.WriteLine("Musteri Eklendi:" + musteri.Id);
            Console.WriteLine("Musteri Eklendi:" + musteri.Ad);
            Console.WriteLine("Musteri Eklendi:" + musteri.Soyad);
        }
        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine("Musteri Silindi:" + musteri.Id);
            Console.WriteLine("Musteri Silindi:" + musteri.Ad);
            Console.WriteLine("Musteri Silindi:" + musteri.Soyad);
        }
    }
}
