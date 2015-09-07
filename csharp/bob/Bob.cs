using System.Linq;

public static class Bob
{
    public static string Hey(string input)
    {
        input = input.Trim();

        if (input == string.Empty)
            return "Fine. Be that way!";

        if (!input.Any(c => char.IsLower(c)) && input.Any(c => char.IsLetter(c)))
            return "Whoa, chill out!";

        if (input.EndsWith("?"))
            return "Sure.";
        
        else
            return "Whatever.";
    }
}