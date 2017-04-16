namespace MVC
{
    class Student
    {
        public string Name { get; set; }
        public int RollNo { get; set; }

        public Student(string name, int rollNo)
        {
            Name = name;
            RollNo = rollNo;
        }
    }
}
