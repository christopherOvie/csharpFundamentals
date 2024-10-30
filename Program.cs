// See https://aka.ms/new-console-template for more information
using CSharpFundamentals;
using System;

namespace CSharpFunamentals
{
    class Program : Program4
    {
        String name;
        String lastName;
        public Program(String name)
        {
           this.name = name;
            }

        public Program(String firstname,String lastName)
        {
            this.lastName = lastName;
        }
        public void  getName()
        {
            Console.WriteLine("my name is  "+ this.name);

        }
        static void Main(string[] args)
        {
           
            Program p = new Program("john");
            Program p2 = new Program("john","Mike");
            p.getData();
            p.SetData();
             p.getName();
           // String name = "peter";
        }

        /*// Method that returns a string "Hello World"
        static string getValues()
        {
            return "Hello World";
        }*/

        void getData()
        {
            Console.WriteLine("I am inside the method");
        }
    }
}
//p.getData();
/*Console.WriteLine("Hello, World!");

int a = 5;
Console.WriteLine("number is " + a);

String name = "peter";
Console.WriteLine("name is " + name);*/

//Console.WriteLine($" my Name is {name}");

//var age = "23";

//Console.WriteLine($"age is {age}");
//age = "67";

//Console.WriteLine($"age is {age}");

//Double c = 8.9;

//Console.WriteLine($"c is {c}");

//dynamic height = 13.2;
//height = 6;
//Console.WriteLine($"height is {height}");

