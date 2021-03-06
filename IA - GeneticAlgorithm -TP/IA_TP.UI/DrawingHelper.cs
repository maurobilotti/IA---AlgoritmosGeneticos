﻿using IA_TP.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IA_TP.UI
{
    public class DrawingHelper
    {
        private System.Drawing.Pen pen = new System.Drawing.Pen(Color.White, 2F);
        private System.Drawing.Graphics graph;
        PictureBox pictureBox;
        public DrawingHelper(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
            graph = pictureBox.CreateGraphics();            
        }
        /// <summary>
        /// (X, Y)
        /// </summary>
        /// <param name="latitude"></param>
        /// <param name="longitud"></param>
        public void DrawCity(Model.City city)
        {
            graph.DrawEllipse(pen, city.Latitude, city.Longitude, 20, 20);
            graph.FillEllipse(Brushes.Red, new Rectangle(new Point(city.Latitude, city.Longitude), new Size(20, 20)));
            using (Font myFont = new Font("Arial", 9, FontStyle.Bold))
            {
                graph.DrawString(city.Name, myFont, Brushes.Yellow, new Point(city.Latitude - 15, city.Longitude - 15));
            }            
        }

        public void DrawRoute(Model.City city1, Model.City city2, string route = "")
        {
            graph.DrawLine(pen, city1.Latitude + 10, city1.Longitude + 10, city2.Latitude + 10, city2.Longitude + 10);
            if (string.IsNullOrWhiteSpace(route))
                return;

            using (Font myFont = new Font("Arial", 16, FontStyle.Bold))
            {
                var x = (city1.Latitude + city2.Latitude) / 2;
                var y = (city1.Longitude + city2.Longitude) / 2;
                graph.DrawString(route, myFont, Brushes.Yellow, new Point(x + 10, y + 10));                
            }

            using (Font myFont = new Font("Arial", 8, FontStyle.Italic))
            {
                var distance = city1.GetDistanceTo(city2);
                var x = (city1.Latitude + city2.Latitude) / 2;
                var y = (city1.Longitude + city2.Longitude) / 2;
                graph.DrawString(distance.ToString("#.#") + "kms", myFont, Brushes.Yellow, new Point(x + 25, y + 25));
            }
        }      
        
        public void DrawCentralNodel(Model.City centralNode)
        {
            graph.DrawEllipse(pen, centralNode.Latitude, centralNode.Longitude, 20, 20);
            graph.FillEllipse(Brushes.GreenYellow, new Rectangle(new Point(centralNode.Latitude, centralNode.Longitude), new Size(20, 20)));
            using (Font myFont = new Font("Arial", 10, FontStyle.Bold))
            {
                graph.DrawString("Central Node", myFont, Brushes.Orange, new Point(centralNode.Latitude + 15, centralNode.Longitude + 15));
            }
        }  
    }
}
