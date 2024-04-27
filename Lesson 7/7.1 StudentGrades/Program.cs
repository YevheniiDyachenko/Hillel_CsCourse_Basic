using System;
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

            // Getting the student's name
            Console.Write("Enter the student's name: ");
            name = Console.ReadLine();

            // Initialize the starting marks
            InitializeData();
            
            // Main menu
            while (true)
            {
                int input = MultipleChoice(true, new ShopMenu());
                switch ((ShopMenu)input)
                {
                    case ShopMenu.AddMarks:
                        Console.WriteLine($"\nYour choice: {ShopMenu.AddMarks}");
                        AddMarks();
                        break;
                    case ShopMenu.AverageMarks:
                        Console.WriteLine($"\nYour choice: {ShopMenu.AverageMarks}");
                        CalculateAverageMark();
                        break;
                    case ShopMenu.ShowMarks:
                        Console.WriteLine($"\nYour choice: {ShopMenu.ShowMarks}");
                        PrintAllMarks();
                        break;
                    case ShopMenu.Exit:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong choice. Please try again");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
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
            Console.WriteLine("\n Enter the subject number  \n 1 - Math \n 2 - History \n 3 - Language ");
            int subject = int.Parse(Console.ReadLine());

            Console.Write("\n Enter the mark:");
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
            
            Console.Write("Mark for student  ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{name}");
            Console.ResetColor();
            Console.WriteLine($", for subject {subject} added successfully.");
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

        // Multiple choice menu
        public static int MultipleChoice(bool canCancel, Enum userEnum, int spacingPerLine = 18, int optionsPerLine = 2,
            int startX = 1, int startY = 1)
        {
            int currentSelection = 0;
            ConsoleKey key;
            Console.CursorVisible = false;
            int length = Enum.GetValues(userEnum.GetType()).Length;
            do
            {
                Console.Clear();
                
                Console.Write("For student ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{name}");
                Console.ResetColor();
                Console.WriteLine(", select an option from the following Menu:");
                
                for (int i = 0; i < length; i++)
                {
                    Console.SetCursorPosition(startX + (i % optionsPerLine) * spacingPerLine, startY + i / optionsPerLine);

                    if (i == currentSelection)
                        Console.ForegroundColor = ConsoleColor.Red;

                    Console.Write(Enum.Parse(userEnum.GetType(), i.ToString()));

                    Console.ResetColor();
                }

                key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        {
                            if (currentSelection % optionsPerLine > 0)
                                currentSelection--;
                            break;
                        }
                    case ConsoleKey.RightArrow:
                        {
                            if (currentSelection % optionsPerLine < optionsPerLine - 1)
                                currentSelection++;
                            break;
                        }
                    case ConsoleKey.UpArrow:
                        {
                            if (currentSelection >= optionsPerLine)
                                currentSelection -= optionsPerLine;
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            if (currentSelection + optionsPerLine < length)
                                currentSelection += optionsPerLine;
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            if (canCancel)
                                return -1;
                            break;
                        }
                }
            } while (key != ConsoleKey.Enter);

            Console.CursorVisible = true;

            return currentSelection;
        }

        enum ShopMenu
        {
            AddMarks, AverageMarks, ShowMarks, Exit
        }
    }
}
