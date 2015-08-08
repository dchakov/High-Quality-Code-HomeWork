namespace StudentsAndCourses
{
    using System;

    public class Student
    {
        public const int StudentNumberMinValue = 10000;
        public const int StudentNumberMaxValue = 99999;
        private string name;
        private int schoolNumber;

        public Student(string name, int schoolNumber)
        {
            this.Name = name;
            this.SchoolNumber = schoolNumber;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Student name cannot be null or empty");
                }

                this.name = value;
            }
        }

        public int SchoolNumber
        {
            get
            {
                return this.schoolNumber;
            }

            private set
            {
                if (value < StudentNumberMinValue || value > StudentNumberMaxValue)
                {
                    throw new ArgumentOutOfRangeException("School number must be between 10000 and 99999");
                }

                this.schoolNumber = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0},{1}", this.Name, this.SchoolNumber);
        }
    }
}
