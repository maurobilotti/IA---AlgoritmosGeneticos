﻿using System;
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
        public Logger Logger { get; internal set; }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Logger = new Logger(this.lstLogs);
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

            var centralNode = (City)selection.First().ObjectValue;
            drawingHelper.DrawCentralNodel(centralNode);

            var earnings = selection.Sum(z => ((City)z.ObjectValue).CalculateEarnings(telcoSur));
            var distance = 0.0;

            for (int i = 0; i < selection.Count; i++)
            {
                var j = i + 1;

                if (j == selection.Count)
                    j = 0;

                var city = (City)selection[i].ObjectValue;
                var otherCity = (City)selection[j].ObjectValue;

                distance += city.GetDistanceTo(otherCity);
            }

            if (selection.ToList().Count == 2)
                drawingHelper.DrawRoute((City)selection[0].ObjectValue, (City)selection[1].ObjectValue, "1");

            if (selection.ToList().Count > 2)
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
            var log = $"Fitness: {telcoSur.Solution.Fitness.ToString("0.######")}, Fiber Channel Km's: {distance.ToString("#.##")} kms, Earnings: $ {earnings.ToString("#.##")}";
            lblSolution.Text = log;
            Logger.Log(log, true);
            Logger.Log("...end.", true);
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            this.drawingHelper = new DrawingHelper(this.pictureBoxConfig);
            this.telcoSur = Config.GetBaseConfig();
            CreateUIConfig();
            btnDefaultConfig.Enabled = false;
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
