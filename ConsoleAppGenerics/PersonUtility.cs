using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGenerics
{
    internal class PersonUtility
    {
        public List<Person> People { get; set; }

        public PersonUtility()
        {
            People = new List<Person>();
        }
        public void InsertPerson(Person person)
        {
            this.People.Add(person);
        }
        public void DisplayPeople()
        {
            foreach (Person item in this.People)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
