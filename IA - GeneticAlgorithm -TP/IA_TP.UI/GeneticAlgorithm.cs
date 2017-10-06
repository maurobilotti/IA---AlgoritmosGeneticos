using GAF;
using GAF.Extensions;
using GAF.Operators;
using IA_TP.Model;
using System.Linq;

namespace IA_TP.UI
{
    public class GeneticAlgorithm
    {
        private int elitismPercentage;
        private double crossoverProbability;
        private double mutationProbability;
        private int generationExpected;
        private TelcoSur telcoSur;
        public Logger Logger { get; internal set; }
        public int Population { get; private set; }
        public int ChoromosomeMaxLength { get; private set; }

        public GeneticAlgorithm(TelcoSur telcoSur, GeneticAlgorithmParameters parameters)
        {
            this.telcoSur = telcoSur;
            this.elitismPercentage = parameters.ElitismPercentage;
            this.crossoverProbability = parameters.CrossoverProbability;
            this.mutationProbability = parameters.MutationProbability;
            this.generationExpected = parameters.GenerationExpected;
            this.Population = parameters.Population;
            this.ChoromosomeMaxLength = parameters.ChromosomeMaxLength;
        }

        public void Run()
        {
            Logger.Log("Running genetic algorithm...");
            Logger.Log($"Population size (amount of choromosomes): {Population}");
            var population = new Population();
            //create the chromosomes



            for (int i = 0; i <= Population; i++)
            {
                var chromosome = new Chromosome();
                var rnd = GAF.Threading.RandomProvider.GetThreadRandom();                
                for (int j = 0; j < this.ChoromosomeMaxLength; j++)
                {
                    bool nextCityNotFound = true;
                    City city = null;
                    while (nextCityNotFound)
                    {
                        var index = rnd.Next(0, telcoSur.Cities.Count);
                        city = telcoSur.Cities[index];

                        if (chromosome.Genes.Any(z => (City)z.ObjectValue == city))
                            continue;

                        nextCityNotFound = false;
                    }   

                    Logger.Log($"Creating gene for city: {city.Name}");
                    var gene = new Gene(city);
                    Logger.Log($"Gene binary: {gene.BinaryValue}, Gene type: {gene.GeneType}");
                    chromosome.Genes.Add(gene);
                    chromosome.Genes.ShuffleFast(rnd);
                }

                population.Solutions.Add(chromosome);
            }

            //create the elite operator
            var elite = new Elite(this.elitismPercentage);

            //create the crossover operator
            var crossover = new Crossover(this.crossoverProbability)
            {
                CrossoverType = CrossoverType.SinglePoint
            };

            //create the mutation operator
            var mutate = new SwapMutate(this.mutationProbability);

            //create the GA
            var ga = new GAF.GeneticAlgorithm(population, CalculateFitness);

            //hook up to some useful events
            ga.OnGenerationComplete += ga_OnGenerationComplete;
            ga.OnRunComplete += ga_OnRunComplete;

            //add the operators
            ga.Operators.Add(elite);
            ga.Operators.Add(crossover);
            ga.Operators.Add(mutate);

            //run the GA
            ga.Run(Terminate);
        }

        /*
         * Solutions from the population are passed to this fitness function by the GAF. 
         * The value returned by the fitness function should be set to a real number between 0 and 1.0, 
         * the higher the value, the fitter the solution. 
         */
        public double CalculateFitness(Chromosome chromosome)
        {
            return CalculateAssessment(chromosome);
        }

        private void ga_OnGenerationComplete(object sender, GaEventArgs e)
        {
            var fittest = e.Population.GetTop(1)[0];
            var distanceToTravel = CalculateAssessment(fittest);
            //Console.WriteLine("Generation: {0}, Fitness: {1}, Distance: {2}", e.Generation, fittest.Fitness, distanceToTravel);
        }

        private bool Terminate(Population population, int currentGeneration, long currentEvaluation)
        {
            return currentGeneration > this.generationExpected;
        }

        private void ga_OnRunComplete(object sender, GaEventArgs e)
        {
            var fittest = e.Population.GetTop(1)[0];
            //foreach (var gene in fittest.Genes)
            //{
            //    Console.WriteLine(((City)gene.ObjectValue).Name);
            //}
        }

        //return result must be between 0.0 and 1.0
        private double CalculateAssessment(Chromosome chromosome)
        {
            var chromosomeAssessment = 0.0;
            City previousCity = null;
                  
            foreach (var gene in chromosome.Genes)
            {
                var city = (City)gene.ObjectValue;

                chromosomeAssessment += city.CalculateAssessment(telcoSur);
            }

            return 1 - (100000 / chromosomeAssessment);
        }
    }
}
