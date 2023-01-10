using ConsoleTest.Models;
using DataCommon;
using Microsoft.EntityFrameworkCore;

namespace ConsoleTest
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            //ChinookContext cnt = new ChinookContext();
            //List<Customer> musteriler = cnt.Customers.ToList();  //Listeye çevir
            //List<Customer> musteriler = cnt.Customers.Take(5).ToList();  //ilk 5i al
            //List<Customer> musteriler = cnt.Customers.Skip(5).Take(5).ToList(); //ilk beşi atla sonkai 5 i al
            //List<Customer> musteriler = cnt.Customers.Where(x=>x.FirstName=="Helena").ToList(); //custumer tablosundaki x=Her bir satır. x olmak zorundada değil.
            //List<Customer> musteriler = cnt.Customers.Where(x => x.FirstName.StartsWith("A")).ToList(); //Karakter '' ile gösterilir. String "" ile gösterilir.
            //int musterisayisi = cnt.Customers.Count();
            //var xx = cnt.Customers.Where(x => x.City == "London");
            //Customer customer = musteriler.FirstOrDefault(x=>x.City=="London"); // İlk kaydı ay kayıt yoksa null yaz.
            //customer = musteriler.Single(x => x.City == "London");             //tek kayıt döner eğer 1den fazla kayıt varsa yada hiç kayıt yoksa patlar.
            //customer = musteriler.SingleOrDefault(x => x.City == "London", new Customer { City="London"});
            //Artist eklenecek = new Artist(); // veri tabanına kayıt ekledik.
            //eklenecek.Name = "Cüneyt Arkın";
            //cnt.Artists.Add(eklenecek);
            //cnt.SaveChanges();
            //Artist degisecek = cnt.Artists.First(x => x.Name.StartsWith("Cüneyt")); //İsmi veritabanında değiştirdik.
            //degisecek.Name = "Cüneyt Cüreklibatur";
            //cnt.Artists.Update(degisecek);
            //cnt.SaveChanges();
            //Artist silinecek = cnt.Artists.First(x=>x.Name.StartsWith("Cüneyt"));
            //cnt.Artists.Remove(silinecek);
            //cnt.SaveChanges();
            //foreach (var item in musteriler)
            //{
            //    Console.WriteLine(item.FirstName);
            //}



            //Kisi k1 = new Personel();
            //k1.Ad = "Ali";
            //k1.Soyad = "Diker";
            //Kisi k2 = new Personel { Ad = "Ayşe", Soyad = "Kara" };
            //Kisi k3 = new Musteri { Ad = "Ebru", Soyad = "Demir" };
            //List<Kisi> list = new List<Kisi>();
            //list.Add(k1); list.Add(k2); list.Add(k3);
            //foreach (var item in list) // var yerine Kisi de yazılabilir çünkü zaten list kişi tipinde
            //{
            //    Console.WriteLine(item.TamAdi);
            //}
            //Urun urun = new Urun();
            //urun.Category = "Mobilya";
            //Console.WriteLine(urun.Category);
        }

        static void Main()
        {
            ChinookContext cnt = new ChinookContext();

            List<Artist> artists = cnt.Artists.Take(10).ToList();
            Console.WriteLine("Top Ten List");
            foreach (var artist in artists)
            {
                String s = String.Format("Id: {0} Name: {1}", artist.ArtistId, artist.Name);
                Console.WriteLine(s);

            }
            string secim = Console.ReadLine();
            Console.WriteLine(secim + " " + "Seçtiniz.");
            int intSecim = int.Parse(secim);

            var res = cnt.Artists.Include(x => x.Albums).ToList();

            Artist art = artists.Single(x =>x.ArtistId == intSecim);

            List<Album> albums = art.Albums.ToList();

            foreach (var album in albums)
            {
                Console.WriteLine(album.Title);
            }
            Album eklenecek = new Album(); 
            eklenecek.Title = "Yeni Kayıt";
            eklenecek.ArtistId = intSecim;
            cnt.Albums.Add(eklenecek);
            cnt.SaveChanges();

            //art.Albums.Add(new Album { Title = "Cici Album"});
        }
    }
    //class Urun
    //{
    //    public int Id { get; set; }
    //    private string category;
    //    public string Category
    //    {
    //        get { return category; }
    //        set { category = value; }
    //    }
    //}
}