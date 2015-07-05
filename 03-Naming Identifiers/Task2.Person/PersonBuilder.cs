namespace PersonClass
{
    using System;

    public class PersonBuilder
    {
        public static void Main()
        {
            Person firstMale = new Person();
            firstMale = firstMale.MakePerson(2);
            Console.WriteLine(firstMale.Name);
            Console.WriteLine(firstMale.Gender);

            Person secondFemale = new Person();
            secondFemale = secondFemale.MakePerson(3);
            Console.WriteLine(secondFemale.Name);
            Console.WriteLine(secondFemale.Gender);
        }
    }
}
