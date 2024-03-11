using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> strings = new List<string>
        {
            "chirag",
            "aayush",
            "himanshu"
        };

        var Characters =(from str in strings
                         from charac in str
                         select charac)
                         .Distinct()
                         .OrderBy(c => c);

        foreach (var character in Characters)
        {
            Console.WriteLine(character);
        }
    }
}
