using System;
using System.Drawing;
using System.Windows.Forms;
using IA_TP.Model;
using System.Linq;
using System.Collections.Generic;
using GAF;

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

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void CreateUIConfig()
        {            
            foreach (var city in telcoSur.Cities)
            {
                drawingHelper.DrawCity(city);
            }

            if (telcoSur != null)
            {
                btnRun.Enabled = true;
                btnRedraw.Enabled = true;
            }
        }

        private void ShowSolution(TelcoSur telcoSur)
        {
            var selection = telcoSur.Solution.Genes.GroupBy(p => ((City)p.ObjectValue).Name)
                .Select(g => g.First())
                .ToList();
            
            var earnings = telcoSur.Solution.Genes.Sum(z => ((City)z.ObjectValue).CalculateAssessment(telcoSur));

            if(selection.ToList().Count == 2)
                drawingHelper.DrawRoute((City)selection[0].ObjectValue, (City)selection[1].ObjectValue, "1");

            if(selection.ToList().Count > 2)
            {
                for (int i = 0; i < selection.Count; i++)
                {
                    var j = i + 1;

                    if (j == selection.Count)
                    {
                        drawingHelper.DrawRoute((City)selection[i].ObjectValue, (City)selection[0].ObjectValue, j.ToString());
                        break;
                    }

                    drawingHelper.DrawRoute((City)selection[i].ObjectValue, (City)selection[j].ObjectValue, j.ToString());
                }
            }

            lblSolution.Text = $"Fitness: {telcoSur.Solution.Fitness}, Fiber Channel Km's: {telcoSur.FiberChannelKmsInUse} kms, Earnings: $ {earnings.ToString("#.##")}";
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

        private void btnRedraw_Click(object sender, EventArgs e)
        {
            CreateUIConfig();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            CreateUIConfig();

            var frm = new GeneticAlgorithmConfig(this.telcoSur.Cities.Count);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var ga = new GeneticAlgorithm(telcoSur, frm.Parameters);
                ga.Logger = new Logger(this.lstLogs);
                ga.Run();
                ShowSolution(ga.TelcoSur);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.lstLogs.Items.Clear();
        }
    }
}
