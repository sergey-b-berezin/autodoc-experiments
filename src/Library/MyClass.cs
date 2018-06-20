using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>This is namespace for all classes in my class library</summary>
namespace MyLibrary
{
    /// <summary>This is main class in my class library</summary>
    public class MyClass
    {
        /// <summary>This is very polite method that greets everyone</summary>
        /// <param name="name">Name of a person</param>
        /// <returns>Greeting for the specified person</returns>
        public string Hello(string name)
        {
            return @"Hello, {name}!";
        }
    }
}
