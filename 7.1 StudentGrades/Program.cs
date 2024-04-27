using System.Text;

namespace _7._1_StudentGrades
{
    class Program
    {
        static string name;
        static int[] marksMath;
        static int[] marksHistory;
        static int[] marksLanguage;

        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            InitializeData(); // Ініціалізуємо початкові дані

            Console.Write("Введіть ім'я студента: ");
            name = Console.ReadLine();

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
                        CalculateAverageMark();
                        break;
                    case "3":
                        PrintAllMarks();
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

        //Initializing the first values of marks
        private static void InitializeData()
        {
            marksMath = new int[] { 80, 96, 94 };
            marksHistory = new int[] { 74, 83, 69 };
            marksLanguage = new int[] { 97, 78, 90 };
        }

        //Adding new marks to the arrays
        private static void AddMarks()
        {
            Console.Write("Choose a subject (1-math, 2-history,3-language): ");
            int subject = int.Parse(Console.ReadLine());

            Console.Write("Enter the mark:");
            int mark = int.Parse(Console.ReadLine());


            switch (subject)
            {
                case 1:
                    Array.Resize(ref marksMath, marksMath.Length + 1);
                    marksMath[^1] = mark;
                    break;
                case 2:
                    Array.Resize(ref marksHistory, marksHistory.Length + 1);
                    marksHistory[^1] = mark;
                    break;
                case 3:
                    Array.Resize(ref marksLanguage, marksLanguage.Length + 1);
                    marksLanguage[^1] = mark;
                    break;
                default:
                    Console.WriteLine("Unknown subject.");
                    break;
            }

            Console.WriteLine($"Mark for student {name} for subject {subject} added successfully.");
        }

        //Calculating the average mark
        private static void CalculateAverageMark()
        {
            double avgMath = CalculateAverageMark(marksMath);
            double avgHistory = CalculateAverageMark(marksHistory);
            double avgLanguage = CalculateAverageMark(marksLanguage);

            Console.WriteLine($"Average mark in math: {avgMath}");
            Console.WriteLine($"Average mark in history: {avgHistory}");
            Console.WriteLine($"Average mark in the language: {avgLanguage}");
            double totalAvg = (avgMath + avgHistory + avgLanguage) / 3;
            Console.WriteLine($"Average marks in all subjects: {totalAvg}");
        }

        //Calculating the average mark for a specific subject
        static double CalculateAverageMark(int[] marks)
        {
            double sum = 0;
            int count = 0;

            foreach (int mark in marks)
            {
                sum += mark;
                count++;
            }

            return sum / count;
        }

        // Printing all marks of all subjects to the console
        private static void PrintAllMarks()
        {
            PrintMarks("math", marksMath);
            PrintMarks("history", marksHistory);
            PrintMarks("language", marksLanguage);
        }
        
        // Printing marks of a specific subject to the console
        private static void PrintMarks(string subject, int[] marks)
        {
            Console.Write($"Marks in {subject}: ");
            foreach (int mark in marks)
            {
                Console.Write(mark + " ");
            }
            Console.WriteLine();
        }
    }
}