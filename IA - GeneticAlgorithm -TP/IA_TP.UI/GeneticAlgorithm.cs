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
        public TelcoSur TelcoSur { get; internal set; }
        public Logger Logger { get; internal set; }
        public int Population { get; private set; }
        public int ChromosomeMaxLength { get; private set; }

        public GeneticAlgorithm(TelcoSur telcoSur, GeneticAlgorithmParameters parameters)
        {
            this.TelcoSur = telcoSur;
            this.elitismPercentage = parameters.ElitismPercentage;
            this.crossoverProbability = parameters.CrossoverProbability;
            this.mutationProbability = parameters.MutationProbability;
            this.generationExpected = parameters.GenerationExpected;
            this.Population = parameters.Population;
            this.ChromosomeMaxLength = parameters.ChrmosomeMaxLength;
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
                var chromosomeLength = 0;
                while (chromosomeLength < ChromosomeMaxLength)
                {
                    City city = null;

                    var index = rnd.Next(0, TelcoSur.Cities.Count);
                    city = TelcoSur.Cities[index];

                    if (chromosome.Genes.Any(z => ((City)z.ObjectValue).Name == city.Name))
                        continue;

                    var gene = new Gene(city);
                    chromosome.Genes.Add(gene);
                    chromosome.Genes.ShuffleFast(rnd);
                    chromosomeLength++;
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
        }

        private bool Terminate(Population population, int currentGeneration, long currentEvaluation)
        {
            return currentGeneration > this.generationExpected;
        }

        private void ga_OnRunComplete(object sender, GaEventArgs e)
        {
            Logger.Log("====================================================================================================================");
            var fittest = e.Population.GetTop(1)[0];
            var result = fittest.Genes.GroupBy(p => ((City)p.ObjectValue).Name)
                .Select(g => g.First())
                .ToList();
            Logger.Log($"Chromosome selected with fitness: {fittest.Fitness}");
            foreach (var gene in result)
            {
                Logger.Log($"########> {((City)gene.ObjectValue).Name}");
            }

            this.TelcoSur.Solution = fittest;
        }

        //return result must be between 0.0 and 1.0
        private double CalculateAssessment(Chromosome chromosome)
        {
            var genes = chromosome.Genes.GroupBy(p => ((City)p.ObjectValue).Name)
               .Select(g => g.First())
               .ToList();

            Logger.Log("Chromosome with: ");

            var distance = 0.0;
            var earnings = 0.0;

            for (int i = 0; i < genes.Count; i++)
            {
                var j = i + 1;

                if (j == genes.Count)
                    j = 0;

                var city = (City)genes[i].ObjectValue;
                Logger.Log($"------> City Name: {city.Name}, " +
                  $"Location: ({city.Latitude}, {city.Longitude}), " +
                  $"Demand: (TV: {city.Demand.TV}, Internet: {city.Demand.Internet}, Phone: {city.Demand.Phone})");

                var otherCity = (City)genes[j].ObjectValue;

                distance += city.GetDistanceTo(otherCity);

                earnings += city.CalculateEarnings(TelcoSur);
            }


            Logger.Log($">>>>>>>> Chromosome distance is {distance.ToString("#.##")} kms");

            var balance = earnings - (distance * this.TelcoSur.FiberChannelKmCost);

            //if the kms used for the chromosome is bigger than the km's available. Then this chromosome should have a penalty       
            if (TelcoSur.FiberChannelKmsAvailable < distance)
                balance = balance * TelcoSur.PenaltyPercent * 0.01;

            var assessment = 1 - (100000 / (balance < 100000 ? 100000 : balance));
            Logger.Log($"$$$$$$> Chromosome earnings: $ {balance.ToString("#.##")}");
            Logger.Log($"//////> Chromosome kms in use: $ {distance} kms");
            Logger.Log($"======> Chromosome assessment: {assessment}");

            Logger.Log("--------------------------------------------------------------------------------------------------------------");

            return assessment;
        }
    }
}
