using System;

namespace GenericSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorting integers: ");
            int[] arr = {5, 1, 3, 2, 1, 8, 10, 4, -1, 2, 30, 3};
            Console.WriteLine("Unsorted Array: ");
            foreach(int x in arr) {
                Console.WriteLine(x);
            }


            InsertionSort<int>.Sort(arr);
            Console.WriteLine();
            Console.WriteLine("Sorted Array: ");
            foreach(int x in arr) {
                Console.WriteLine(x);
            }

            Console.WriteLine();
            Console.WriteLine();
            Person[] persons = {
                new Person("Samuel", "Tobi", 15),
                new Person("Tope", "Tobi", 12),
                new Person("Sola", "Tobi", 18),
                new Person("Ade", "Tobi", 21),
                new Person("Kopoke", "Tobi", 34),
            };
            foreach(Person x in persons) {
                Console.WriteLine(x.FirstName);
            }

            Console.WriteLine();
            InsertionSort<Person>.Sort(persons);
            foreach(Person x in persons) {
                Console.WriteLine(x.FirstName);
            }
            
        }
    }
}
