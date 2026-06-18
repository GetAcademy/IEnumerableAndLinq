namespace IEnumerableAndLinq
{
    internal class Demo7_group_by
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

            var cityGroups = students.GroupBy(s => s.City);

            foreach (var cityGroup in cityGroups)
            {
                Console.WriteLine("* " + cityGroup.Key);
                foreach (var student in cityGroup)
                {
                    Console.WriteLine($"  {student.Name}");
                }
            }
        }
    }
}
