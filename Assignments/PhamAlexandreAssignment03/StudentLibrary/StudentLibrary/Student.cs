using System;

namespace StudentLibrary
{
    [Serializable]
    public class Student
    {
        public int StudentID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Course { get; set; }
        public string Grade { get; set; }

        public Student() : this(0, string.Empty, string.Empty, string.Empty,
            string.Empty)
        { }

        public Student(int studentID, string lastName, string firstName,
            string course, string grade)
        {
            StudentID = studentID;
            LastName = lastName;
            FirstName = firstName;
            Course = course;
            Grade = grade;
        }

        public override string ToString()
        {
            return $"{StudentID},{LastName},{FirstName},{Course},{Grade}";
        }
    }
}
