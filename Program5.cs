using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    internal class Program5
    {
    }
}*/

String[] a = { "john", "mike", "peter", "tre" };
int[] b = { 6, 8, 9, 9 };
Console.WriteLine(a[1]);

for(int i=0; i<a.Length; i++)
{
    Console.WriteLine(a[i]);
    if(a[i] == "peter")
    {
        Console.WriteLine("match found");
    }
    break;
   /* else
    *//*{
        Console.WriteLine("MATCH NOT Found");
    }*/
}
