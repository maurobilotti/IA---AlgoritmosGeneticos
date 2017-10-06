﻿using System.Collections.Generic;

namespace IA_TP.Model
{
    public class TelcoSur
    {
        public List<City> Cities { get; set; }
        public int FiberChannelKmsAvailable { get; set; }
        public double FiberChannelKmCost { get; set; }        
        public Catalogue Catalogue { get; set; }
    }
}
