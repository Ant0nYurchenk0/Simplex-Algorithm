using System.Collections.Generic;

namespace Simplex_Algorithm
{
    interface ISimplexAlgorithm
    {
        public abstract List<double> Solve(Matrix problem);
    }
}
