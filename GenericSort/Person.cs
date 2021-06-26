using System;


namespace GenericSort
{
    /// <summary>
    /// Person class
    /// Creates a person object with following properties
    /// </summary>
    public class Person : IComparable
    {
        private int id;
        private static int numberOfPersons = 0;

        /// <summary>
        /// A string representing the firstname of the person
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// A string representing the lastname of the person
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// An integer representing the age of the person
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// A string representing the phone number of the person
        /// </summary>
        /// <value>Phone number</value>
        public string Phone { get; set; }

        /// <summary>
        /// Holds the person objects representing the parents of a given person
        /// </summary>
        public Parents parents; 

        /// <summary>
        /// Constructs a new person object
        /// </summary>
        /// <param name="firstName">A string</param>
        /// <param name="lastName">A string</param>
        /// <param name="age">An Integer</param>
        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            numberOfPersons++;
            this.id = numberOfPersons;
        }

        /// <summary>
        /// Computes the full name of a person
        /// </summary>
        /// <returns>The full name of the person</returns>
        public string GetFullName()
        {
            return LastName + " " + FirstName;
        }

        /// <summary>
        /// Gets the id of person
        /// </summary>
        /// <returns>The id of the person</returns>
        public int GetId()
        {
            return id;
        }

        /// <summary>
        /// Gets the number of person objects that have been created
        /// </summary>
        /// <returns>Number of person object create</returns>
        public static int GetNumberOfPersons()
        {
            return numberOfPersons;
        }

        /// <summary>
        /// Adds the father and mother object to a person
        /// </summary>
        /// <param name="father">Person: Representing the father</param>
        /// <param name="mother">Person: Representing the mother</param>
        public void AddParents(Person father, Person mother) {
            parents = new Parents(father, mother);
        }

        /// <summary>
        /// Gets the name of a person's father
        /// </summary>
        /// <returns>The father's name</returns>
        public string GetFathersName()
        {
            return parents.Father.GetFullName();
        }

        /// <summary>
        /// Gets the name of a person's mother
        /// </summary>
        /// <returns>The mothers's name</returns>
        public string GetMothersName()
        {
            return parents.Mother.GetFullName();
        }

        /// <summary>
        /// Compares two Person objects by their first name
        /// </summary>
        public int CompareTo(object obj) {
            if(obj == null) return 1;
            Person nextPerson = obj as Person;
            if(nextPerson == null)  throw new ArgumentException("Object doesn't have a first name");
            return FirstName.CompareTo(nextPerson.FirstName);
        }
    }
    
    /// <summary>
    /// Parents Struct
    /// Holds the father and mother object
    /// </summary>
    public struct Parents
    {
        /// <summary>
        /// Constructs a parents object
        /// </summary>
        /// <param name="father">A person object representing the father</param>
        /// <param name="mother">A person object representing the mother</param>
        public Parents(Person father, Person mother)
        {
            Father = father;
            Mother = mother;
        }

        /// <summary>
        /// A person object representing the father 
        /// </summary>
        /// <value>A person object</value>
        public Person Father { get; }

        /// <summary>
        /// A person object representing the mother
        /// </summary>
        /// <value>A person object</value>
        public Person Mother { get; }
    }
}