using submodulestest;
using System;

namespace mainmodule
{
    class Program
    {
        static void Main(string[] args)
        {
            var temp = new Class1("dew","test1");
            Console.WriteLine(temp.GetFullname());
        }
    }
}
