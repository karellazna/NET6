using ConsoleTest.Data;
using ConsoleTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class PeopleDataset
    {
        public static List<Person> People = new List<Person>();

        public static void GeneratePeople(int cnt)
        {
            for(int i = 0; i < cnt; i++)
            {
                People.Add(RandomPersonGenerator.GetRandomPerson());
            }
        }

    }
}
