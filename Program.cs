using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knowledgecheck2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many Dogs do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine() ?? "0");

            var recordList = new List<Dog>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                Console.WriteLine("What's the name of your Dog?");
                string DogName = Console.ReadLine() ?? "";

                Console.WriteLine("Is your Dog a Pug? (Y/N)");
                bool isPug = Console.ReadLine() == "Y" ? true : false;


                var Dog = new Dog(isPug, DogName);

                recordList.Add(Dog);
            }

            recordList.ForEach(x => Console.WriteLine(x));

        }
    }
}