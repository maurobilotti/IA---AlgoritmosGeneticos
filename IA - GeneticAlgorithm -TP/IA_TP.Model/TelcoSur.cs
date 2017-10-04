using System.Collections.Generic;

namespace IA_TP.Model
{
    public class TelcoSur
    {
        public List<City> Cities { get; set; }
        public int FiberChannelKmsAvailable { get; set; }
        public decimal Income { get; set; }
        public Catalogue Catalogue { get; set; }
    }
}
