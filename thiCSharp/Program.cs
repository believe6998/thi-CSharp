using System;
using System.Text.RegularExpressions;
using thiCSharp.entity;

namespace thiCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            var people = new People("Marry", true, 25);
            Console.WriteLine(
                people.Gender ? "Name = {0}, Gender = Male, Age = {1}" : "Name = {0}, Gender = Female, Age = {1}",
                people.Name, people.Age);
            people.Age += 10;
            Console.WriteLine(
                people.Gender ? "Name = {0}, Gender = Male, Age = {1}" : "Name = {0}, Gender = Female, Age = {1}",
                people.Name, people.Age);
            //2
            Console.WriteLine("Enter a String");
            var str = Console.ReadLine();
            Console.WriteLine("Enter a word to search");
            var word = Console.ReadLine();
            var count = Regex.Matches(str, word).Count;
            Console.WriteLine("Word found {0} times in the string", count);
        }
    }
}