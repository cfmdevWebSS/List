/*
C# - List<T>
The List<T> is a collection of strongly typed objects that can be accessed by index and having methods for sorting, searching, and modifying list. 
It is the generic version of the ArrayList that comes under System.Collection.Generic namespace.

List<T> Characteristics:
List<T> equivalent of the ArrayList, which implements IList<T>.
It comes under System.Collections.Generic namespace.
List<T> can contain elements of the specified type. It provides compile-time type checking and doesn't perform boxing-unboxing because it is generic.
Elements can be added using the Add(), AddRange() methods or collection-initializer syntax.
Elements can be accessed by passing an index e.g. myList[0]. Indexes start from zero.
List<T> performs faster and less error-prone than the ArrayList.

Creating a List
The List<T> is a generic collection, so you need to specify a type parameter for the type of data it can store. 
The following example shows how to create list and add elements.
*/

//Example: Adding elements in List

List<int> primeNumbers = new List<int>();
primeNumbers.Add(1); // adding elements using add() method
primeNumbers.Add(3);
primeNumbers.Add(5);
primeNumbers.Add(7);
primeNumbers.Add(11);
primeNumbers.Add(13);
primeNumbers.Add(17);

foreach(int primeNumber in primeNumbers)
{
    Console.WriteLine("A few of the prime numbers: {0}", primeNumber);
}

Console.WriteLine();

var cities = new List<string>();
cities.Add("New York");
cities.Add("London");
cities.Add("Mumbai");
cities.Add("Chicago");
cities.Add(null);// nulls are allowed for reference type list

Console.WriteLine();

foreach(string city in cities)
{
    Console.WriteLine("A few of the great cities: {0}", city);
}

Console.WriteLine();

//adding elements using collection-initializer syntax
var bigCities = new List<string>()
{
    "New York",
    "London",
    "Mumbai",
    "Chicago",
    "San Francisco",
    "Berlin",
    "Kiev"
};

foreach(string city in bigCities)
{
    Console.WriteLine("A few of the great big cities: {0}", city);
}

Console.WriteLine();
/*
In the above example, List<int> primeNumbers = new List<int>(); creates a list of int type. 
In the same way, cities and bigCities are string type list. 
You can then add elements in a list using the Add() method or the collection-initializer syntax.

You can also add elements of the custom classes using the collection-initializer syntax. 
The following adds objects of the Student class in the List<Student>.
*/

//Example: Add Custom Class Objects in List
var students = new List<Student>() 
{
    new Student(){ Id = 1, Name="Bill"},
    new Student(){ Id = 2, Name="Steve"},
    new Student(){ Id = 3, Name="Ram"},
    new Student(){ Id = 4, Name="Abdul"}
};

/*
Use the AddRange() method to add all the elements from an array or another collection to List.

AddRange() signature: void AddRange(IEnumerable<T> collection)
*/

//Example: Add Arrays in List
string[] cities2 = new string[3] { "Mumbai", "London", "New York" };

var popularCities = new List<string>();

// adding an array in a List
popularCities.AddRange(cities2);

var favouriteCities = new List<string>();

// adding a List 
favouriteCities.AddRange(popularCities);

/*Accessing a List
A list can be accessed by an index, a for/foreach loop, and using LINQ queries. 
Indexes of a list start from zero. Pass an index in the square brackets to access individual list items, same as array. 
Use a foreach or for loop to iterate a List<T> collection.
*/
//Example: Accessing List
List<int> numbers = new List<int>() { 1, 2, 5, 7, 8, 10 };
Console.WriteLine(numbers[0]); // prints 1
Console.WriteLine(numbers[1]); // prints 2
Console.WriteLine(numbers[2]); // prints 5
Console.WriteLine(numbers[3]); // prints 7

// using foreach LINQ method
numbers.ForEach(num => Console.WriteLine(num + ", "));//prints 1, 2, 5, 7, 8, 10,

// using for loop
for (int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers[i]);
}
Console.WriteLine();
/*
Accessing a List using LINQ
The List<T> implements the IEnumerable interface. So, we can query a list using LINQ query syntax or method syntax, as shown below.
*/

//Example: LINQ Query on List
var students2 = new List<Student>() {
                new Student(){ Id = 1, Name="Bill"},
                new Student(){ Id = 2, Name="Steve"},
                new Student(){ Id = 3, Name="Ram"},
                new Student(){ Id = 4, Name="Abdul"}
            };

//get all students whose name is Bill
var result = from s in students2
             where s.Name == "Bill"
             select s;

foreach (var student in result)
{
    Console.WriteLine(student.Id + ", " + student.Name);
}

Console.WriteLine();

/*
Insert Elements in List
Use the Insert() method inserts an element into the List<T> collection at the specified index.

Insert() signature:void Insert(int index, T item);
*/

//Example: Insert elements into List
var numbers22 = new List<int>() { 10, 20, 30, 40 };

numbers22.Insert(1, 11);// inserts 11 at 1st index: after 10.

foreach (var num in numbers22)
{
    Console.WriteLine(num);
}

/*
Remove Elements from List
Use the Remove() method to remove the first occurrence of the specified element in the List<T> collection. 
Use the RemoveAt() method to remove an element from the specified index. 
If no element at the specified index, then the ArgumentOutOfRangeException will be thrown.

Remove() signature: bool Remove(T item)

RemoveAt() signature: void RemoveAt(int index)
*/

Console.WriteLine();

//Example: Remove elements from List
var numbers33 = new List<int>() { 10, 20, 30, 40, 10 };

numbers33.Remove(10); // removes the first 10 from a list

numbers33.RemoveAt(2); //removes the 3rd element (index starts from 0)

//numbers33.RemoveAt(10); //throws ArgumentOutOfRangeException

foreach (int el in numbers33)
{
    Console.WriteLine(el); //prints 20 30
}

Console.WriteLine();

//Check Elements in List
//Use the Contains() method to determine whether an element is in the List<T> or not.

//Example: Contains()
var numbers44 = new List<int>() { 10, 20, 30, 40 };
Console.WriteLine(numbers44.Contains(10));// returns true
Console.WriteLine(numbers44.Contains(11)); // returns false
Console.WriteLine(numbers44.Contains(20)); // returns true



class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}




