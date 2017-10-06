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
    public partial class GeneticAlgorithmConfig : Form
    {
        public GeneticAlgorithmConfig()
        {
            InitializeComponent();
        }

        public GeneticAlgorithmParameters Parameters { get; private set; }

        private void btnRunGA_Click(object sender, EventArgs e)
        {
            this.Parameters = new GeneticAlgorithmParameters((int)numElitismPercentage.Value, (double)numCrossoverProbability.Value, (double)numMutationProbability.Value, (int)numGenerationStop.Value,
                (int)numPopulation.Value, (int)numChromosomeMaxLength.Value);
            this.DialogResult = DialogResult.OK;
        }
    }
}
