using System;
using System.Collections.Generic;

namespace collectionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            for(int i = 0; i<10; i++){
                arr[i] = i;
            }
            string[] names = new string[]{"Tim","Martin","Nikki","Sara"};
            bool[] alt = new bool[10];
            for(int i = 0; i<10;i++){
                if(i%2==0){
                    alt[i] = true;
                }
                else{
                    alt[i] = false;
                }
            }
            List<string> flavors = new List<string>();
            flavors.Add("Chocolate");
            flavors.Add("Vanilla");
            flavors.Add("Strawberry");
            flavors.Add("Praline");
            flavors.Add("Lavander");
            Console.WriteLine(flavors.Count);
            Console.WriteLine(flavors[2]);
            flavors.Remove(flavors[2]);
            Console.WriteLine(flavors.Count);
            Dictionary<string,string> favorites = new Dictionary<string,string>();
            Random rand = new Random();
            for(int i =0; i<names.Length; i++){
                favorites.Add(names[i],flavors[rand.Next(0,flavors.Count)]);
            }
            foreach(var f in favorites){
                Console.WriteLine($"{f.Key} - {f.Value}");
            }
            //             Three Basic Arrays
            // Create an array to hold integer values 0 through 9
            // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            // Create an array of length 10 that alternates between true and false values, starting with true
            // List of Flavors
            // Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            // Output the length of this list after building it
            // Output the third flavor in the list, then remove this value
            // Output the new length of the list (It should just be one fewer!)
            // User Info Dictionary
            // Create a dictionary that will store both string keys as well as string values
            // Add key/value pairs to this dictionary where:
            // each key is a name from your names array
            // each value is a randomly select a flavor from your flavors list.
            // Loop through the dictionary and print out each user's name and their associated ice cream flavor
        }

    }
}
