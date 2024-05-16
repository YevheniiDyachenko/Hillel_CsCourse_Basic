using System.Text;

namespace UkrainianStringUtilsLib;

public static class UkrainianStringUtils
{
    // 1. Method for counting the number of vowels
    public static int CountVowels(string? input)
    {
        int vowelsCount = 0;
        foreach (char ch in input)
        {
            if (IsVowel(ch))
            {
                vowelsCount++;
            }
        }
        return vowelsCount;
    }
    
    // Check if the character is a vowel
    private static bool IsVowel(char ch)
    {
        ch = char.ToLower(ch);
        return "аеєиіїоуюя".Contains(ch);
    }

    // 2. Method for counting the number of consonant letters
    public static int CountConsonants(string? input)
    {
        int consonantsCount = 0;

        foreach (char ch in input)
        {
            if (IsConsonant(ch))
            {
                consonantsCount++;
            }
        }

        return consonantsCount;
    }
    
    // Check if the character is a consonant
    private static bool IsConsonant(char ch)
    {
        ch = char.ToLower(ch); 
        return "бвгґджзйклмнпрстфхцчшщ".Contains(ch);
    }

    // 3. Method for wrapping a string
    public static string ReverseString(string? input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    // 4. Method for removing duplicates
    public static string RemoveDuplicates(string? input)
    {
        StringBuilder result = new StringBuilder();
        
        foreach (char ch in input)
        {
            // Check if the character is not already in the result string
            if (result.ToString().IndexOf(ch) == -1) 
            {
                result.Append(ch);
            }
        }

        return result.ToString();

    }

    // 5. Method for removing punctuation
    public static string RemovePunctuation(string? input)
    {
        StringBuilder result = new StringBuilder();

        foreach (char ch in input)
        {
            if (!IsPunctuation(ch))
            {
                result.Append(ch);
            }
        }

        return result.ToString();
    }
    
    // Check if the character is a punctuation
    private static bool IsPunctuation(char ch)
    {
        return "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~".Contains(ch);
    }
}
