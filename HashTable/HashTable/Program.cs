using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class Progaram
    {
        static void Main()
        {
            var HashTable = new HashTable<Person>(100);
            var person = new Person() { Name = "Том", Age = 19, Gender = 0 };
            HashTable.Add(new Person() { Name = "Петя", Age = 20, Gender = 0 });
            HashTable.Add(new Person() { Name = "Саша", Age = 35, Gender = 0 });
            HashTable.Add(person);

            Console.WriteLine(new Person() { Name = "Том", Age = 19, Gender = 0 });
            Console.WriteLine(HashTable.Search(person));
            Console.ReadLine();

            HashTable.Delete(person);
            Console.WriteLine(HashTable.Search(person));
            Console.ReadLine();

        }
    }
}
