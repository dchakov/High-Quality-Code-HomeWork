namespace StudentsAndCourses
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        private string schoolName;
        private ICollection<Course> courses;

        public School(string schoolName)
        {
            this.SchoolName = schoolName;
            this.courses = new List<Course>();
        }

        public string SchoolName
        {
            get
            { 
                return this.schoolName;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("School name cannot be null or empty");
                }

                this.schoolName = value;
            }
        }

        public ICollection<Course> Courses
        {
            get
            {
                return new List<Course>(this.courses);
            }
        }

        public void AddCourse(Course course)
        {
            if (this.courses.Contains(course))
            {
                throw new ArgumentException("Course already exist");
            }

            if (course == null)
            {
                throw new ArgumentNullException("Course cannot be null");
            }

            this.courses.Add(course);
        }
    }
}
