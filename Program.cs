using System;
using System.Collections.Generic;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
			var names = new List<string> {"Rolando", "Diego", "Dana" };
			foreach (var name in names)
			{
				Console.WriteLine($"Hello {name.ToUpper ()}!");
			}
        }
    }
}
