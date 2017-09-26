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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private System.Drawing.Pen pen1 = new System.Drawing.Pen(Color.Blue, 2F);

        private void Main_Load(object sender, EventArgs e)
        {
            CreateConfigDraw();
        }
    }
}
