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
            /*
                Localidad A: 550 clientes potenciales
                    125 Clientes requieres servicio de Cable
                    75 Clientes Requieren servicio de Internet
                    350 Clientes Requieren servicio de Telefonía
                Localidad B: 732 clientes potenciales
                    250 Clientes requieres servicio de Cable
                    182 Clientes Requieren servicio de Internet
                    300 Clientes Requieren servicio de Telefonía
                Localidad C: 145 clientes potenciales
                    100 Clientes requieres servicio de Cable
                    25 Clientes Requieren servicio de Internet
                    20 Clientes Requieren servicio de Telefonía
                Localidad D: 133 clientes potenciales
                    15 Clientes requieres servicio de Cable
                    100 Clientes Requieren servicio de Internet
                    18 Clientes Requieren servicio de Telefonía
                Localidad E: 233 clientes potenciales
                    73 Clientes requieres servicio de Cable
                    130 Clientes Requieren servicio de Internet
                    30 Clientes Requieren servicio de Telefonía

             */
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
                    Demand = new UserDemand {Internet = 5000, Phone= 600, TV = 500 },
                },
                new Model.City
                {
                    Latitude = 900, Longitude = 170, Name = "Localidad C",
                    Demand = new UserDemand {Internet = 5000, Phone= 600, TV = 500 }
                },
                new Model.City
                {
                    Latitude = 790, Longitude = 300, Name = "Localidad D",
                    Demand = new UserDemand {Internet = 5000, Phone= 600, TV = 500 }
                },
                new Model.City
                {
                    Latitude = 750, Longitude = 30, Name = "Localidad E",
                    Demand = new UserDemand {Internet = 5000, Phone= 600, TV = 500 }
                },
                new Model.City
                {
                    Latitude = 500, Longitude = 360, Name = "Localidad F",
                    Demand = new UserDemand {Internet = 5000, Phone= 600, TV = 500 }
                },
                new Model.City
                {
                    Latitude = 600, Longitude = 180, Name = "Localidad G",
                    Demand = new UserDemand {Internet = 5000, Phone= 600, TV = 500 }
                },
                new Model.City
                {
                    Latitude = 900, Longitude = 60, Name = "Localidad H",
                    Demand = new UserDemand {Internet = 5000, Phone= 600, TV = 500 }
                },
                new Model.City
                {
                    Latitude = 500, Longitude = 360, Name = "Localidad I",
                    Demand = new UserDemand {Internet = 5000, Phone= 600, TV = 500 }
                },
                new Model.City
                {
                    Latitude = 100, Longitude = 80, Name = "Localidad J",
                    Demand = new UserDemand {Internet = 5000, Phone= 600, TV = 500 }
                },
            };
        }
    }
}
