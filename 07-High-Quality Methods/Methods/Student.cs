namespace Methods
{
    using System;

    public class Student
    {
        private string firstName;
        private string lastName;
        private string otherInfo;
        
        public Student()
        {
        }

        public Student(string firstName, string lastName, string otherInfo)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.OtherInfo = otherInfo;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name cannot be null or empty");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name cannot be null or empty");
                }

                this.lastName = value;
            }
        }

        public string OtherInfo
        {
            get
            {
                return this.otherInfo;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Other info cannot be null or empty");
                }

                this.otherInfo = value;
            }
        }

        public bool IsOlderThan(Student other)
        {
            if (!(other is Student))
            {
                throw new ArgumentException("Argumet is not an instnce of Student");
            }

            if (string.IsNullOrEmpty(other.OtherInfo))
            {
                throw new ArgumentNullException("Other student otherInfo is null or empty");
            }

            DateTime firstStudentBirthday = this.GetBirthdayFromOtherInfo(this);
            DateTime secondStudentBirthday = this.GetBirthdayFromOtherInfo(other);
               
            return firstStudentBirthday < secondStudentBirthday;
        }

        public DateTime GetBirthdayFromOtherInfo(Student student)
        {
            DateTime birthday = DateTime.Parse(student.OtherInfo.Substring(student.OtherInfo.Length - 10));
            return birthday;
        }
    }
}
