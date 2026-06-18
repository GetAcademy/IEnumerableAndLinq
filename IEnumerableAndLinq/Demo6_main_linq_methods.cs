using System.Text;

namespace IEnumerableAndLinq
{
    internal class Demo6_main_linq_methods
    {
        public static void Run()
        {
            var students = new List<Student>
            {
                new("Ada", 24, "Larvik", true, 92),
                new("Bjørn", 31, "Sandefjord", true, 68),
                new("Cecilie", 19, "Larvik", false, 74),
                new("Daniel", 27, "Tønsberg", true, 81),
                new("Elin", 35, "Larvik", true, 56),
                new("Farid", 22, "Skien", false, 88),
            };

            var isSomeoneFromSkien = students.Any(s => s.City == "Skien");
            var firstFromLarvik = students.First(s => s.City == "Larvik");
            var firstFromOslo = students.FirstOrDefault(s => s.City == "Oslo");
            var countFromLarvik = students.Count(s => s.City == "Larvik");
            var studentsFromLarvik = students.Where(s => s.City == "Larvik");
            var descriptions = students.Select(s => $"{s.Name} {s.City}");
        }

        private static IEnumerable<Student> StudentsFromLarvik(IEnumerable<Student> students)
        {
            var list = new List<Student>();
            foreach (var student in students)
            {
                if (student.City == "Larvik")  list.Add(student);
            }
            return list;
        }

        private static string Descriptions(IEnumerable<Student> students)
        {
            var text = new StringBuilder();
            foreach (var student in students)
            {
                text.AppendLine($"{student.Name} {student.City}");
            }

            return text.ToString();
        }

        private static bool IsSomeoneFromSkien(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                if (student.City == "Skien") return true;
            }

            return false;
        }

        private static Student? FirstOrDefaultFromLarvik(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                if (student.City == "Larvik") return student;
            }

            return null;
        }

        private static int CountFromLarvik(IEnumerable<Student> students)
        {
            var count = 0;
            foreach (var student in students)
            {
                if (student.City == "Larvik") return count++;
            }

            return count;
        }
    }
}
