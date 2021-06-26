using System;
using Xunit;
using GenericSort;

namespace GenericSort.Tests
{
    public class GenericSortTest
    {
        [Fact]
        public void Sorts_A_Single_Element_Int_Array()
        {
            int[] arr = {1};
            GenericSort.InsertionSort<int>.Sort(arr);
            Assert.Equal(arr[0], 1);
            Assert.Equal(arr.Length, 1);
        }

        [Fact]
        public void Sorts_A_Single_Element_Reference_Array() 
        {
            Person[] persons = {
                new Person("Samuel", "Tobi", 15),
            };
            GenericSort.InsertionSort<Person>.Sort(persons);
            Assert.Equal(persons[0].FirstName, "Samuel");
            Assert.Equal(persons.Length, 1);
        }

        [Fact]
        public void Leaves_Sorted_Array_Sorted()
        {
            int[] arr = {1, 5};
            GenericSort.InsertionSort<int>.Sort(arr);
            Assert.Equal(arr[0], 1);
            Assert.Equal(arr[1], 5);
            Assert.Equal(arr.Length, 2);
        }

        [Fact]
        public void Sorts_2_Elements_Int_Array()
        {
            int[] arr = {6, 5};
            GenericSort.InsertionSort<int>.Sort(arr);
            Assert.Equal(arr[0], 5);
            Assert.Equal(arr[1], 6);
            Assert.Equal(arr.Length, 2);
        }
    }
}
