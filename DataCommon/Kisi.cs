namespace DataCommon
{
    public abstract class Kisi //Direkt Instance alınıp direkt kullanılamıyor.Base class olmuş oluyor. New kullanımı yapılamıyor.
    {                         //Bu classtan Inheritance eden Musteri yada Personel classlarından Instance alınabilir.
        private string ad;

        //public Kisi() { } Boş constractor. new kopya aldığımda ad soyadı boş bırakabilmemei yada sadece ad veya soyad girebilmemi sağlar.
        //public Kisi(string ad, string soyad) //Constractor. new kopya aldığımda ad ve soyad bölümlerini girmek zorundayım.
        //{                                   //Aksi için üstteki kod lazım. Zorunlu alan yapmamı sağladı
        //    Ad = ad;
        //    Soyad = soyad;
        //}
        //public String Ad { get; set; } Aşağıdaki formu sayesinde Valuemiz olur ve üzerinde işlem yapabiliriz.
        public String Ad { get => ad; set => ad = value.Trim().ToUpper(); } //Verisini okur yazarken kontrol vardır.

        //private string soyad;  ////Verisini okur yazarken kontrol vardır.
        //public string GetSoyad()
        //{
        //    return soyad;
        //}
        //public void SetSoyad(string value)
        //{
        //    soyad = value;
        //}
       
        string soyad;   //Verisini okur yazarken kontrol vardır.
        public String Soyad
        {
            get { return soyad; }
            set { soyad = value.Trim().ToUpper(); }
        }

        public String TamAdi //Properties - Özellik
        {                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                
            get
            {
                return String.Format("{0} {1}", Ad, Soyad); //Ad soyad yazdırır.
            }
        }
    }
}