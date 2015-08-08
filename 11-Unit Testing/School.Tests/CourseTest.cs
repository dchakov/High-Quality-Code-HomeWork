namespace StudentsAndCourses.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using StudentsAndCourses;

    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        public void TestCourseCreateNewToBeValid()
        {
            Course course = new Course("financial");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestCourseNameIfIsNull()
        {
            Course course = new Course(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestCourseNameIsIfEmptyString()
        {
            Course student = new Course(string.Empty);
        }

        [TestMethod]
        public void TestCourseNameToBeSameAsArgument()
        {
            Course course = new Course("test");
            Assert.AreEqual("test", course.CourseName);
        }

        [TestMethod]
        public void TestCouresAddingStudentToBeValid()
        {
            Course course = new Course("info");
            course.AddStudent(new Student("asen", 20000));
        }

        [TestMethod]
        public void TestCourseAddingNewStudentToShouldProperlyUpdateList()
        {
            Course course = new Course("financial");
            course.AddStudent(new Student("ivan1", 10001));
            course.AddStudent(new Student("ivan2", 10002));
            Assert.AreEqual(2, course.Students.Count, "List of students is icorrect");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestCourseAddingStudentWithNull()
        {
            Course course = new Course("JS");
            course.AddStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCourseAddingStudentWithSameNameToThrow()
        {
            Course course = new Course("JS");
            Student asen = new Student("asen", 10000);
            course.AddStudent(asen);
            course.AddStudent(asen);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCourseAddingMoreThan30StudentToThrow()
        {
            Course course = new Course("HQC");
            for (int i = 0; i <= 30; i++)
            {
                course.AddStudent(new Student("asen", 10000 + i));
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestCourseRemovingStudentWithNull()
        {
            Course course = new Course("JS");
            course.RemoveStudent(null);
        }

        [TestMethod]
        public void TestCourseRemovingStudentToBeValid()
        {
            Course course = new Course("financial");
            Student ivan1 = new Student("ivan1", 10001);
            Student ivan2 = new Student("ivan2", 10002);
            course.AddStudent(ivan1);
            course.AddStudent(ivan2);
            course.RemoveStudent(ivan1);
            Assert.IsTrue(course.Students.Contains(ivan2));
            Assert.AreEqual(1, course.Students.Count, "Incorrect student remove");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCourseRemovingStudentWithNonExistingNameToThrow()
        {
            Course course = new Course("JS");
            Student asen = new Student("asen", 10000);
            Student ivan = new Student("ivan", 10001);
            course.AddStudent(asen);
            course.RemoveStudent(ivan);
        }
    }
}
