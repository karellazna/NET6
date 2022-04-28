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

        public static string PeopleAPIUrl = "https://localhost:7175";

        public static void GeneratePeople(int cnt)
        {
            RandomPersonGenerator.GetPeople(cnt);
        }

        public static void LoadPeopleFromAPI(int cnt)
        {

        }

    }
}
