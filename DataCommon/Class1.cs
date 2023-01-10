namespace DataCommon
{
    public enum BildirimTuru
    {
        sms,
        email
    }
   public interface IBildirilebilir //Interface olduğu için adlandırırken başına I eklemek düsturdur.
    {
        public BildirimTuru BildirimTercihi { get; }
    }
    public class Class1
    {
    }
    public class Musteri : Kisi, IBildirilebilir
    {
        public List<Adres> Adresler { get; set; } //Müsterinin birden cok adresi olabilir.
        public BildirimTuru BildirimTercihi { get { return BildirimTuru.email; } } //IBildiri inheritance etmek için bu parça olmak zorundadır.
    }
    public class Personel : Kisi
    {
        public String SicilNo { get; set; }
        public int Bolum { get; set; }
        public Adres EvAdresi { get; set; }
    }
    public class sms
    {

    }
    public class Email
    {

    }
    public class Urun
    {
        //public int Kodu { get; set; }
        //2
        //private int kodu;
        //public int Kodu { get => kodu; set => kodu = value; }

        // 1
        //private int kodu;
        //public int GetKodu()
        //{
        //    return kodu;
        //}
        //public void SetKodu(int value)
        //{
        //    kodu = value;
        //}
    }
}