using IA_TP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IA_TP.UI
{
    public partial class NewCity : Form
    {
        public NewCity()
        {
            InitializeComponent();
        }

        public NewCity(City city)
        {
            InitializeComponent();
            this.City = city;
            LoadPreviousConfig();
        }

        private void LoadPreviousConfig()
        {
            this.txtCityName.Text = this.City.Name;
            this.numLatitude.Value = this.City.Latitude;
            this.numLongitude.Value = this.City.Longitude;
            this.numPhoneDemand.Value = this.City.Demand.Phone;
            this.numInternetDemand.Value = this.City.Demand.Internet;
            this.numTVDemand.Value = this.City.Demand.TV;
        }

        public City City { get; set; }

        private void NewCity_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveCity_Click(object sender, EventArgs e)
        {
            if (txtCityName.Text == "")
            {
                MessageBox.Show("You must fill the city name. Try to not use an existing one.");
                return;
            }                

            this.City = new City();
            this.City.Name = txtCityName.Text;
            this.City.Latitude = (int)this.numLatitude.Value;
            this.City.Longitude = (int)this.numLongitude.Value;
            this.City.Demand.Phone = (int)numPhoneDemand.Value;
            this.City.Demand.Internet = (int)numInternetDemand.Value;
            this.City.Demand.TV = (int)numTVDemand.Value;
            DialogResult = DialogResult.OK;
        }        
    }
}
