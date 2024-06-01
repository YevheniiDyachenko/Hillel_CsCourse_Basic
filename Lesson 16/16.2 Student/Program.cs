namespace _16._2_Student
{
    class Program
    {
        static void Main()
        {
            // Create a list of students
            List<Student> students = new List<Student>
            {
                new() { Name = "Elena", Grade = 95, Course = "Math" },
                new() { Name = "Ivan", Grade = 85, Course = "Physics" },
                new() { Name = "Petro", Grade = 92, Course = "Math" },
                new() { Name = "Maria", Grade = 88, Course = "Physics" },
                new() { Name = "Svyatoslav", Grade = 78, Course = "Chemistry" },
                new() { Name = "Anastasia", Grade = 90, Course = "Chemistry" }
            };

            // 1. Filtering: Find all students who have a grade greater than or equal to 90.
            IEnumerable<Student> highGradesStudents = students.Where(s => s.Grade >= 90);
            PrintResults("Filtering: Students with grades >= 90",students, highGradesStudents);

            // 2. Sorting: Sort students by grade in descending order.
            IOrderedEnumerable<Student> sortedStudents = students.OrderByDescending(s => s.Grade);
            PrintResults("Sorting: Students by grade in descending order",students, sortedStudents);

            // 3. Grouping: Group students by course and display a list of students in each course.
            IEnumerable<IGrouping<string, Student>> groupedByCourse = students.GroupBy(s => s.Course);
            Console.WriteLine("Grouping: Students by courses");
            foreach (var group in groupedByCourse)
            {
                Console.WriteLine($"\nCourse: {group.Key}");
                foreach (var student in group)
                {
                    Console.WriteLine($"Name: {student.Name}, Grade: {student.Grade}");
                }
            }

            // 4. Counting: Count the number of students in each course.
            var studentCounts = students.GroupBy(s => s.Course)
                                        .Select(g => new { Course = g.Key, Count = g.Count() });
            Console.WriteLine("\nNumber of students in each course:");
            foreach (var info in studentCounts)
            {
                Console.WriteLine($"Course = {info.Course}, Count = {info.Count}");
            }
        }

        // Student class represents a student with name, grade, and course
        class Student
        {
            public string Name { get; set; }
            public int Grade { get; set; }
            public string Course { get; set; }
            
            // Override ToString method to display student information
            public override string ToString()
            {
                return $"Name: {Name}, Grade: {Grade}, Course: {Course}";
            }
        }

        // Outputting results method
        static void PrintResults<T>(string operationName, IEnumerable<T> originalItems, IEnumerable<T> resultItems)
        {
            Console.WriteLine($"\n{operationName}");
            Console.WriteLine("Original items:\n" + string.Join(",\n", originalItems));
            Console.WriteLine("Result items:\n" + string.Join(",\n", resultItems));
            Console.WriteLine("----"); 
        }
    }
}
