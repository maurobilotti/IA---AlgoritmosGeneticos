using IA_TP.Model;
using System;
using System.Windows.Forms;
using System.Linq;

namespace IA_TP.UI
{
    public partial class CustomConfig : Form
    {
        public CustomConfig()
        {
            InitializeComponent();            
        }

        public CustomConfig(TelcoSur telcoSur) : base()
        {
            InitializeComponent();
            this.TelcoSur = telcoSur;
            if(TelcoSur != null)
            {
                LoadConfig();
            }
        }

        private void LoadConfig()
        {
            this.gridCities.DataSource = (from x in TelcoSur.Cities.ToList()
                                          select new
                                          {
                                              x.Name,
                                              x.Latitude,
                                              x.Longitude,
                                              Phone_Demand = x.Demand.Phone,
                                              Internet_Demand = x.Demand.Internet,
                                              TV_Demand = x.Demand.TV
                                          }).ToList(); 
            this.numFiberChannelLength.Value = TelcoSur.FiberChannelKmsAvailable;
            this.numInternetPrice.Value = (decimal)TelcoSur.Catalogue.Internet_Price;
            this.numPhonePrice.Value = (decimal)TelcoSur.Catalogue.Phone_Price;
            this.numTVPrice.Value = (decimal)TelcoSur.Catalogue.TV_Price;
        }

        public TelcoSur TelcoSur { get; set; }

        private void CustomConfig_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnNewCity_Click(object sender, EventArgs e)
        {
            var frm = new NewCity();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.TelcoSur.Cities.Add(frm.City);
                LoadConfig();
            }
        }

        private void gridCities_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btnEditCity_Click(object sender, EventArgs e)
        {
            if(gridCities.SelectedRows.Count == 1)
            {
                var item = (dynamic)gridCities.CurrentRow.DataBoundItem;
                var city = new City()
                {
                    Name = item.Name,
                    Latitude = item.Latitude,
                    Longitude = item.Longitude,
                    Demand =
                    {
                        Internet = item.Internet_Demand,
                        TV = item.TV_Demand,
                        Phone = item.Phone_Demand
                    }
                };
                var frm = new NewCity(city);                
                if(frm.ShowDialog() == DialogResult.OK)
                {
                    TelcoSur.Cities[gridCities.CurrentRow.Index].Name = frm.City.Name;
                    TelcoSur.Cities[gridCities.CurrentRow.Index].Latitude = frm.City.Latitude;
                    TelcoSur.Cities[gridCities.CurrentRow.Index].Longitude = frm.City.Longitude;
                    TelcoSur.Cities[gridCities.CurrentRow.Index].Demand.Internet = frm.City.Demand.Internet;
                    TelcoSur.Cities[gridCities.CurrentRow.Index].Demand.Phone= frm.City.Demand.Phone;
                    TelcoSur.Cities[gridCities.CurrentRow.Index].Demand.TV = frm.City.Demand.TV;
                    LoadConfig();
                }
            }
        }
    }
}
