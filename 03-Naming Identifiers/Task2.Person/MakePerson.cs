namespace PersonClass
{
    public class Person
    {
        public Person()
        {
        }

        public Gender Gender { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public Person MakePerson(int age)
        {
            Person newPerson = new Person();

            newPerson.Age = age;
            if (age % 2 == 0)
            {
                newPerson.Name = "Man";
                newPerson.Gender = Gender.Male;
            }
            else
            {
                newPerson.Name = "Woman";
                newPerson.Gender = Gender.Female;
            }

            return newPerson;
        }
    }
}
