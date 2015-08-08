namespace StudentsAndCourses.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using StudentsAndCourses;

    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestStudentNameIfIsNull()
        {
            Student student = new Student(null, 10001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestStudentNameIsIfEmptyString()
        {
            Student student = new Student(string.Empty, 10001);
        }

        [TestMethod]
        public void TestStudentCreateNewToBeValid()
        {
            Student student = new Student("asen", 10001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestStudentSchoolNumberGreaterThanMaxValue()
        {
            Student student = new Student("ivan", 100000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestStudentSchoolNumberSmallerThanMinValue()
        {
            Student student = new Student("ivan", 9999);
        }

        [TestMethod]
        public void TestStudentSchoolNumberIfIsInRange()
        {
            string name = "asen";
            int studentNumber = 50000;
            Student asen = new Student(name, studentNumber);
            Assert.IsTrue(10000 <= studentNumber && studentNumber <= 99999);
        }

        [TestMethod]
        public void TestStudentToString()
        {
            Student asen = new Student("asen", 10000);
            Assert.AreEqual("asen,10000", asen.ToString());
        }
    }
}
