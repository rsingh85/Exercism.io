using System.Linq;

public static class Bob
{
    public static string Hey(string input)
    {
        input = input.Trim();

        if (input.IsShouting())
            return "Whoa, chill out!";

        if (input.IsQuestion())
            return "Sure.";
        
        if (input == string.Empty)
            return "Fine. Be that way!";

        return "Whatever.";
    }
}

public static class BobStringExtensions
{
    public static bool IsShouting(this string @string)
    {
        return @string.Any(c => char.IsLetter(c)) &&
                @string.Where(c => char.IsLetter(c))
                .All(c => char.IsUpper(c));
    }

    public static bool IsQuestion(this string @string)
    {
        return @string.EndsWith("?");
    }
}