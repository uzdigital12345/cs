using System;
using System.Collections.Generic;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> names =new List<string>();
            var names = generateArray();
            
            names = sortArray(donames);

            printArray(names);

                     
        }

        static List generateArray()
        {
            Console.WriteLine("Please, enter your surnames: ");

            var names = new List<string>();

            bool isEmpty = false;

            while(!isEmpty) // (!string.IsNullOrWhiteSpace(name = Console.ReadLine()))
            {
                string name = Console.ReadLine();
                isEmpty = string.IsNullOrWhiteSpace(name);

                if(!isEmpty)
                    names.Add(name);
            }
            return names;
        }


        static List<String> sortArray(List<String> names)
        {
            String temp;
            
            for (int i = 0; i < names.Count; i++)
            {
                for (int j = i+1; j < names.Count; j++)
                {
                    int result=string.CompareOrdinal(names[i],names[j]);
                    if (result>0)
                    {
                    temp=names[i];
                    names[i]=names[j];
                    names[j]=temp;
                    }
                }
                
            }
            return names;
        }

        static void printArray(List<String> names)
        {
            Console.WriteLine();
            Console.WriteLine("Entered surnames: ");
            int index = 0;
            foreach(string name in List.names)
            {
                Console.WriteLine($"{++index}. {name}");
            }
        }
    }
}
