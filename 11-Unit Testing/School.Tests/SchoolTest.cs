namespace StudentsAndCourses.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using StudentsAndCourses;

    [TestClass]
    public class SchoolTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestSchoolNameIsNull()
        {
            School school = new School(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestSchoolNameIsEmptyString()
        {
            School school = new School(string.Empty);
        }

        [TestMethod]
        public void TestSchoolCreateNewToBeValid()
        {
            School school = new School("OMG");
        }

        [TestMethod]
        public void TestSchoolNameToBeSameAsArgument()
        {
            School school = new School("OMG");
            Assert.AreEqual("OMG", school.SchoolName);
        }

        [TestMethod]
        public void TestSchoolAddingCourseToBeValid()
        {
            School school = new School("OMG");
            school.AddCourse(new Course("JS"));
        }

        [TestMethod]
        public void TestSchoolAddingNewCourseShouldProperlyUpdateList()
        {
            School school = new School("OMG");
            school.AddCourse(new Course("JS-OOP"));
            school.AddCourse(new Course("JS-Basic"));
            Assert.AreEqual(2, school.Courses.Count, "List of courses is icorrect");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSchoolAddingCourseWithSameNameToThrow()
        {
            School school = new School("OMG");
            Course js = new Course("JS-OOP");
            school.AddCourse(js);
            school.AddCourse(js);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestSchoolAddingCoursetWithNull()
        {
            School school = new School("OMG");
            school.AddCourse(null);
        }
    }
}
