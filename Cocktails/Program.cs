using System;
using System.Collections.Generic;
using System.Linq;
using Cocktails.Objects;

namespace Cocktails
{
    class Program
    {
        static void Main(string[] args)
        {
            

            CreateDataObjects createDataObjects = new CreateDataObjects();

            Console.WriteLine("1. Create");
            Console.WriteLine("2. Delete");
            Console.WriteLine("3. Edit");
            int s = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("Hello World!");
        }
    }
}
