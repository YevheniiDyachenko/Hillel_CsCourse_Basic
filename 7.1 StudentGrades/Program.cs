using System.Text;

namespace _7._1_StudentGrades
{
    class Program
{
    static int[] marksMath;
    static int[] marksHistory;
    static int[] marksLanguage;

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        
        InitializeData(); // Ініціалізуємо початкові дані

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("1. Add grade");
            Console.WriteLine("2. Calculate the average grade");
            Console.WriteLine("3. Show all grades");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddMarks();
                    break;
                case "2":
                    CalculateAverage();
                    break;
                case "3":
                    ShowAllMarks();
                    break;
                case "4":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Невірний вибір. Будь ласка, спробуйте ще раз.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void InitializeData()
    {
        // Імітована ініціалізація початкових даних
        marksMath = new int[] { 85, 90, 92 };
        marksHistory = new int[] { 75, 80, 88 };
        marksLanguage = new int[] { 95, 88, 90 };
    }

    static void AddMarks()
    {
        Console.Write("Введіть предмет (математика, історія, мова): ");
        string subject = Console.ReadLine().ToLower();

        Console.Write("Введіть оцінку: ");
        int mark = int.Parse(Console.ReadLine());

        switch (subject)
        {
            case "математика":
                Array.Resize(ref marksMath, marksMath.Length + 1);
                marksMath[marksMath.Length - 1] = mark;
                break;
            case "історія":
                Array.Resize(ref marksHistory, marksHistory.Length + 1);
                marksHistory[marksHistory.Length - 1] = mark;
                break;
            case "мова":
                Array.Resize(ref marksLanguage, marksLanguage.Length + 1);
                marksLanguage[marksLanguage.Length - 1] = mark;
                break;
            default:
                Console.WriteLine("Невірно введено предмет.");
                break;
        }

        Console.WriteLine("Оцінка додана успішно.");
    }

    static void CalculateAverage()
    {
        double avgMath = marksMath.Length > 0 ? CalculateAverage(marksMath) : 0;
        double avgHistory = marksHistory.Length > 0 ? CalculateAverage(marksHistory) : 0;
        double avgLanguage = marksLanguage.Length > 0 ? CalculateAverage(marksLanguage) : 0;

        double totalAvg = (avgMath + avgHistory + avgLanguage) / 3;
        Console.WriteLine($"Середня оцінка: {totalAvg:F2}");
    }

    static double CalculateAverage(int[] marks)
    {
        double sum = 0;
        foreach (int mark in marks)
        {
            sum += mark;
        }
        return sum / marks.Length;
    }

    static void ShowAllMarks()
    {
        Console.WriteLine("Оцінки з математики:");
        foreach (int mark in marksMath)
        {
            Console.Write(mark + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Оцінки з історії:");
        foreach (int mark in marksHistory)
        {
            Console.Write(mark + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Оцінки з мови:");
        foreach (int mark in marksLanguage)
        {
            Console.Write(mark + " ");
        }
        Console.WriteLine();
    }
}
}

