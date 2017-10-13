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
            telcoSur.FiberChannelKmsAvailable = 800;
            telcoSur.FiberChannelKmCost = 1000;
            telcoSur.PenaltyPercent = 50;
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
                    Latitude = 200, Longitude = 70, Name = "Localidad A",
                    Demand = new UserDemand {Internet = 2400, Phone= 2000, TV = 1500 }
                },
                new Model.City
                {
                    Latitude = 250, Longitude = 300, Name = "Localidad B",
                    Demand = new UserDemand {Internet = 1000, Phone= 1600, TV = 2500 },
                },
                new Model.City
                {
                    Latitude = 900, Longitude = 170, Name = "Localidad C",
                    Demand = new UserDemand {Internet = 400, Phone= 800, TV = 3500 }
                },
                new Model.City
                {
                    Latitude = 790, Longitude = 300, Name = "Localidad D",
                    Demand = new UserDemand {Internet = 2000, Phone= 600, TV = 5500 }
                },
                new Model.City
                {
                    Latitude = 750, Longitude = 30, Name = "Localidad E",
                    Demand = new UserDemand {Internet = 800, Phone= 200, TV = 1700 }
                },
                new Model.City
                {
                    Latitude = 500, Longitude = 360, Name = "Localidad F",
                    Demand = new UserDemand {Internet = 2300, Phone= 1200, TV = 600 }
                },
                new Model.City
                {
                    Latitude = 600, Longitude = 180, Name = "Localidad G",
                    Demand = new UserDemand {Internet = 500, Phone= 1900, TV = 1800 }
                },
                new Model.City
                {
                    Latitude = 900, Longitude = 60, Name = "Localidad H",
                    Demand = new UserDemand {Internet = 5000, Phone= 600, TV = 500 }
                }
            };
        }
    }
}
