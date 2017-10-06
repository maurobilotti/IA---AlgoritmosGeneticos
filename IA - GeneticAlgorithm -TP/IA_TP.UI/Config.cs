using IA_TP.Model;
using System;
using System.Collections.Generic;

namespace IA_TP.UI
{
    public static class Config
    {
        public static TelcoSur GetBaseConfig()
        {
            TelcoSur telcoSur = new TelcoSur();
            telcoSur.Cities = BuildBaseCities();
            telcoSur.Catalogue = BuildBaseCatalogue();
            telcoSur.FiberChannelKmsAvailable = 600;
            telcoSur.FiberChannelKmCost = 1000;            
            return telcoSur;
        }

        private static Catalogue BuildBaseCatalogue()
        {
            return new Catalogue
            {
                Phone_Price = 100,
                Internet_Price = 95,
                TV_Price = 110
            };
        }

        private static List<Model.City> BuildBaseCities()
        {
            //X <= 1000
            //Y <= 400
            return new List<Model.City>
            {
                new Model.City
                {
                    Latitude = 700, Longitude = 200, Name = "Localidad A",
                    Demand = new UserDemand {Internet = 2400, Phone= 4000, TV = 1500 }
                },
                new Model.City
                {
                    Latitude = 840, Longitude = 120, Name = "Localidad B",
                    Demand = new UserDemand {Internet = 5000, Phone= 5000, TV = 500 },
                },
                new Model.City
                {
                    Latitude = 300, Longitude = 80, Name = "Localidad C",
                    Demand = new UserDemand {Internet = 1, Phone= 1, TV = 1 }
                },
                new Model.City
                {
                    Latitude = 900, Longitude = 250, Name = "Localidad D",
                    Demand = new UserDemand {Internet = 5000, Phone= 600, TV = 100 }
                },
                new Model.City
                {
                    Latitude = 700, Longitude = 250, Name = "Localidad E",
                    Demand = new UserDemand {Internet = 5000, Phone= 5000, TV = 500 }
                },
                new Model.City
                {
                    Latitude = 400, Longitude = 50, Name = "Localidad F",
                    Demand = new UserDemand {Internet = 1, Phone= 1, TV = 1 }
                },
                new Model.City
                {
                    Latitude = 60, Longitude = 100, Name = "Localidad G",
                    Demand = new UserDemand {Internet = 20000, Phone= 200000, TV = 200000 }
                }
            };
        }
    }
}
