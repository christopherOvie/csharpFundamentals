using System;
using System.Collections;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
internal class Program6
{
}
}*/

ArrayList a = new ArrayList();
a.Add("joe");
a.Add("doe");
a.Add("mee");
a.Add("apple");

Console.WriteLine(a[1]);

foreach(String item in a)
{
    Console.WriteLine(item);
}

Console.WriteLine(a.Contains("joe"));

Console.WriteLine("after sorting");
a.Sort();

foreach (String item in a)
{
    Console.WriteLine(item);
}