using System.Collections.Generic;

namespace Exercism.Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add any code here to debug the Exercism.csharp classes

            var old = new Dictionary<int, IList<string>> { { 1, new List<string> { "A", "E", "I", "O", "U" } } };
            var expected = new Dictionary<string, int> { { "a", 1 }, { "e", 1 }, { "i", 1 }, { "o", 1 }, { "u", 1 } };
            ETL.Transform(old);
        }
    }
}
