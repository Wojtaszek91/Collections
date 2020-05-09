using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            // adding elements
            dict.Add("John", 20);
            dict.Add("Anna", 25);
            dict.Add("Merry", 18);

            // using foreach loop
            Console.WriteLine("Foreach loop:");
            foreach (var member in dict)
            {
                Console.WriteLine($"Name : {member.Key} Age : {member.Value}");
            }

            // using for loop
            Console.WriteLine("For Loop:");
            for (int i = 0; i < dict.Count; i++)
            {
                Console.WriteLine($"Name : {dict.Keys.ElementAt(i)} Age : {dict.Values.ElementAt(i)}");
            }

            // indivudual 
            Console.WriteLine("Individual acess:");
            Console.WriteLine(dict["John"]);

            // tryGetValue
            Console.WriteLine("Try get value :");
            int value;
            if (dict.TryGetValue("Merry", out value)) Console.WriteLine("Memeber age is : " + value);
            else Console.WriteLine("Member not found");
            if (dict.TryGetValue("Kayle", out value)) Console.WriteLine("Memeber age is : " + value);
            else Console.WriteLine("Member not found");

            // Compare
            Console.WriteLine("Comparing:");
            Console.WriteLine(dict.Keys.ElementAt(1).Equals("Anna"));
            Console.WriteLine(dict.Keys.ElementAt(1).Equals("anna"));
            Console.WriteLine(dict.Keys.ElementAt(2) == "Merry");
            Console.WriteLine(dict.Keys.ElementAt(2) == "merry");


            // Removes element
            dict.Remove("Anna");
            
            Console.WriteLine("Remove \"Anna\" :");
            foreach(var member in dict)
            {
                Console.WriteLine(member);
            }
        }
    }
}
