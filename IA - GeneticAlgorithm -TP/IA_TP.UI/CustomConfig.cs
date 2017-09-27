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
                LoadPreviousConfig();
            }
        }

        private void LoadPreviousConfig()
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
            this.numInternetPrice.Value = TelcoSur.Catalogue.Internet_Price;
            this.numPhonePrice.Value = TelcoSur.Catalogue.Phone_Price;
            this.numTVPrice.Value = TelcoSur.Catalogue.TV_Price;
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
                LoadPreviousConfig();
            }
        }

        private void gridCities_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
