using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    internal class Program
    {
        
            public bool IsAnagram(string one, string two)
            {
                if (one.ToLower().Equals(two.ToLower()))
                    return true;

                var array1 = one.ToCharArray();
                var array2 = two.ToCharArray();

                Array.Sort(array1);
                Array.Sort(array2);

                return array1 == array2;
            }
        
    }
}
