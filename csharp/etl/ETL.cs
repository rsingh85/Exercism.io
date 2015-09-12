using System.Linq;
using System.Collections.Generic;

public static class ETL
{
    public static Dictionary<string, int> Transform(Dictionary<int, IList<string>> input)
    {
        Dictionary<string, int> scores = new Dictionary<string, int>();

        input.Keys.ToList().ForEach(score => {
            input[score].ToList().ForEach(letter => {
                scores.Add(letter.ToLower(), score);
            });
        });

        return scores;
    }
}
