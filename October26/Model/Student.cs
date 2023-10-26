namespace October26.Model
{
    public  class Student
    {
        public Student(string name, string surname, int age, Group group)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Group = group;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Group Group { get; set; }
        
        
        public Result[] Results { get; set; }

    }
}
