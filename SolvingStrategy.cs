using System.Collections.Generic;

namespace Simplex_Algorithm
{
    class SolvingStrategy
    {
        private ISimplexAlgorithm strategy;
        internal ISimplexAlgorithm Strategy { get => strategy; set => strategy = value; }
        public List<double> Solve(Matrix problem)
        {
            return strategy.Solve(problem);
        }
    }
}
