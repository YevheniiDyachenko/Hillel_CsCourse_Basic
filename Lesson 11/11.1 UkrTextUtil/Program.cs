using UkrainianStringUtilsLib;

namespace _11._1_UkrTextUtil;

class Program
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.Unicode;
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine("Введіть текст українською мовою:"); 
        string? text = Console.ReadLine();
        Console.WriteLine("Ваш текст: " + text);

        // Counting the number of vowels
        int vowelsCount = UkrainianStringUtils.CountVowels(text);
        Console.WriteLine($"Кількість голосних: {vowelsCount}");

        // Counting the number of consonants
        int consonantsCount = UkrainianStringUtils.CountConsonants(text);
        Console.WriteLine($"Кількість приголосних: {consonantsCount}");

        // String wrapping
        string reversedText = UkrainianStringUtils.ReverseString(text);
        Console.WriteLine($"Обернений рядок: {reversedText}");

        // Removing duplicate characters
        string textWithoutDuplicates = UkrainianStringUtils.RemoveDuplicates(text);
        Console.WriteLine($"Рядок без дублікатів: {textWithoutDuplicates}");

        // Remove punctuation marks
        string textWithoutPunctuation = UkrainianStringUtils.RemovePunctuation(text);
        Console.WriteLine($"Рядок без пунктуації: {textWithoutPunctuation}");
    }
}