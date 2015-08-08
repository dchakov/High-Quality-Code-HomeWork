namespace StudentsAndCourses
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        public const byte MaxStudentInCourse = 29;
        private string courseName;
        private ICollection<Student> students;

        public Course(string courseName)
        {
            this.CourseName = courseName;
            this.students = new List<Student>();
        }

        public string CourseName
        {
            get
            {
                return this.courseName;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Course name cannot be null or empty");
                }

                this.courseName = value;
            }
        }

        public ICollection<Student> Students
        {
            get
            {
                return new List<Student>(this.students);
            }
        }

        public void AddStudent(Student student)
        {
            if (this.students.Contains(student))
            {
                throw new ArgumentException("Student already exist");
            }

            if (student == null)
            {
                throw new ArgumentNullException("Student cannot be null");
            }

            if (this.students.Count > MaxStudentInCourse)
            {
                throw new ArgumentOutOfRangeException("Course is full");
            }

            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student cannot be null");
            }

            if (!this.students.Contains(student))
            {
                throw new ArgumentException("No such student");
            }

            this.students.Remove(student);
        }
    }
}
