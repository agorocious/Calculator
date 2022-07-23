using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
     public class Person
    {
         public string Name { get; set; }
      public   int Age { get; set; }
        public void Talk()
        {
            Console.WriteLine(Age);
        }

    }
}
