using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCommon
{
    public enum AdresTipi
    {
        ev=1,
        iş=2
    }
    public class Adres
    {
        //const int evAdresi = 1;
        //const int isAdresi = 2;
        public AdresTipi Turu { get; set; }
        public string Adi { get; set; }
        public string Satir1 { get; set; }
        public string Satir2 { get; set; }
        public int Sehir { get; set; }
    }
}
