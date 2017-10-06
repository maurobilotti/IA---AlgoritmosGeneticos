namespace IA_TP.UI
{
    public class GeneticAlgorithmParameters
    {
        public int ElitismPercentage { get; set; }
        public double CrossoverProbability { get; set; }
        public double MutationProbability { get; set; }
        public int GenerationExpected { get; set; }
        public int Population { get; private set; }
        public int ChromosomeMaxLength { get; private set; }

        public GeneticAlgorithmParameters(int elitism, double crossOver, double mutation, int generationExpected, int population, int chromosomeMaxLength)
        {            
            this.ElitismPercentage = elitism;
            this.CrossoverProbability = crossOver;
            this.MutationProbability = mutation;
            this.GenerationExpected = generationExpected;
            this.Population = population;
            this.ChromosomeMaxLength = chromosomeMaxLength;
        }
    }
}
