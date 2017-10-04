using IA_TP.Model;
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
            using (Font myFont = new Font("Arial", 9))
            {
                graph.DrawString(city.Name, myFont, Brushes.Yellow, new Point(city.Latitude - 15, city.Longitude - 15));
            }
        }

        public void DrawRoute(Model.City city1, Model.City city2, string route = "")
        {
            //graph = pictureBox.CreateGraphics();
            graph.DrawLine(pen, city1.Latitude + 10, city1.Longitude + 10, city2.Latitude + 10, city2.Longitude + 10);
            if (string.IsNullOrWhiteSpace(route))
                return;

            using (Font myFont = new Font("Arial", 15))
            {
                var latitude = (city1.Latitude + city2.Latitude) / 2;
                var longitude = (city1.Longitude + city2.Longitude) / 2;
                graph.DrawString(route, myFont, Brushes.Yellow, new Point(latitude + 10, longitude + 10));
            }
        }        
    }
}
