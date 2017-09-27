using System;
using System.Drawing;
using System.Windows.Forms;
using IA_TP.Model;
using System.Linq;

namespace IA_TP.UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private DrawingHelper drawingHelper;
        private TelcoSur telcoSur;
        private ToolTip toolTipCity = new ToolTip();
        bool cityIsShown = false;

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void CreateUIConfig()
        {
            foreach (var city in telcoSur.Cities)
            {
                drawingHelper.DrawCity(city);
            }

            //drawingHelper.DrawRoute(telcoSur.Cities[0], telcoSur.Cities[3], "1");
            //drawingHelper.DrawRoute(telcoSur.Cities[3], telcoSur.Cities[1], "2");
            //drawingHelper.DrawRoute(telcoSur.Cities[1], telcoSur.Cities[2], "3");            
            //drawingHelper.DrawRoute(telcoSur.Cities[2], telcoSur.Cities[4], "4");
            //drawingHelper.DrawRoute(telcoSur.Cities[4], telcoSur.Cities[5], "5");
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            this.drawingHelper = new DrawingHelper(this.pictureBoxConfig);
            this.telcoSur = Config.GetBaseConfig();
            CreateUIConfig();
        }

        private void pictureBoxConfig_MouseClick(object sender, MouseEventArgs e)
        {
            var x = e.X;
            var y = e.Y;

            if (this.telcoSur == null || this.telcoSur.Cities == null)
                return;

            var city = this.telcoSur.Cities.FirstOrDefault(z => (x <= z.Latitude + 15 && x >= z.Latitude - 15) && (y <= z.Longitude + 15 && y >= z.Longitude - 15));
            if (city != null)
            {
                string demandDescription = $"TV: {city.Demand.TV}, Internet: {city.Demand.Internet}, Phone: {city.Demand.Phone}";
                toolTipCity.Show(demandDescription, pictureBoxConfig, e.Location);                
            }
            else
            {
                toolTipCity.Hide(pictureBoxConfig);
            }
        }

        private void btnCustomConfig_Click(object sender, EventArgs e)
        {
            var frm = new CustomConfig(telcoSur);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.telcoSur = frm.TelcoSur;
                CreateUIConfig();
            }
        }

        //private void pictureBoxConfig_MouseLeave(object sender, EventArgs e)
        //{
        //    toolTipCity.Hide(this);
        //    cityIsShown = false;
        //}
    }
}
