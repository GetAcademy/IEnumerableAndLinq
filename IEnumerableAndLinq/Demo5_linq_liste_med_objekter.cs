namespace IEnumerableAndLinq
{
    internal class Demo5_linq_liste_med_objekter
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

            var activeStudentsFromLarvik = 
                students
                .Where(student => student.IsActive)
                .Where(student => student.City == "Larvik")
                .OrderBy(student => student.Name)
                .Select(student => new StudentSummary(
                    student.Name,
                    $"Poengsum: {student.Score}"
                ));

            foreach (var student in activeStudentsFromLarvik)
            {
                Console.WriteLine($"{student.Name} - {student.Description}");
            }

        }
    }

}
