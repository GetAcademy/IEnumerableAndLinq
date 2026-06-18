namespace IEnumerableAndLinq
{
    class Student
    {
        public string Name { get; }
        public int Age { get; }
        public string City { get; }
        public bool IsActive { get; }
        public int Score { get; }

        public Student(string name, int age, string city, bool isActive, int score)
        {
            Name = name;
            Age = age;
            City = city;
            IsActive = isActive;
            Score = score;
        }
    }
  
}
