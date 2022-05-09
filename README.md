# LINQ 
## What is LINQ?
-  LINQ - stands for  Language Integrated Query
-   Used in C# and Visual Basic .NET to  Query Data Sources where query means requesting information stored within a database management system. LINQ queries return results as objects.
-  Used to Query:
-  1 Collections
-  2 ADO.NET Datasets
-  3 XML Docs
-  4 Web Services
-  5 MS SQL Server
-  6 Other Databases
-  7 LINQ returns queries as objects
## Why do we need LINQ? 
- It allows as to retrieve data from different sources and formats
- It is integrated in C# and VB.NET thereby eliminating mismatch between programming languages and databases
- It provides single querying interface for different types of data sources
## How is LINQ used?
- Obtain datasource
- Create query
- Execute a query
- Used to query different datasource
- Used by Collections
- ADO.NET Datasets
- XML Docs
- Web Services
- SQL Database
- Other Data sources
## The building blocks of LINQ are:
- extension method
- lambda expression
- anonymous type 
- expression tree
- query expression
## Why are LINQ significant?
- Familiar language- developers do not have to learn a new language for each type of data source or format.
- less coding-reduces the amount of coding as compared to more traditional approach
- Rreadable code- LINQ makes code more readable so other developers can understand and maintain.
- Standardize way of queries multiple data sources-the same LINQ syntax  can be used to query multiple data sources.
- Compile time safety of quesries -provides type checking of objects at compile time
- IntelliSense support-LINQ provides IntelliSense for generic collections.
- Shaping data - you can retrieve data in different shapes
```
Example: LINQ Query to Array
// Data source
string[] names = {"George", "david", "Nick", "Donald" };

// LINQ Query 
var myLinqQuery = from name in names
                where name.Contains('a')
                select name;
    
// Query execution
foreach(var name in myLinqQuery)
    Console.Write(name + " ");
   ```
# LINQ API
## What is LINQ API?
- LINQ API is a query syntax kit at the language level in C# and VB.NET to retieve data from different data sources(database).
- LINQ API is includes two main static classes.
-  1 Enumerable 
-  2 Queryable
- Enumerable class includes extension methods for the  classes that implement IEnumerable<T> Interface
 - Queryable class includes extension methods for the classes that implement IQueryable<T> Interface
 -  Examples of Enumerable class inludes extension methods are in memory collection i.e List,Dictionary,Queue,Hashset,SortedList,LinkedList
 - Examples of Queryable class inludes extension methods for remote queries i.e LINQ to SQL,LINQ to Amazon,PLINQ,EntityFramework and LDAP
  ## LINQ QUERY SNYAX
  -There two ways to write LINQ query to IEnumable Collection or IQueryable data sources.
  -  1  Query syntax or query expression syntax
  -  2 Method syntax or method Entesion syntax or Fluent
```
   LINQ Query Syntax 
  
  from <range variable> in <IEnumerable<T> or IQueryable<T> Collection>

<Standard Query Operators> <lambda expression>

<select or groupBy operator> <result formation>
  
  Example: LINQ Query Syntax in C#
// string collection
IList<string> stringList = new List<string>() { 
    "C# Tutorials",
    "VB.NET Tutorials",
    "Learn C++",
    "MVC Tutorials" ,
    "Java" 
};

// LINQ Query Syntax
var result = from s in stringList
            where s.Contains("Tutorials") 
            select s;
```
 **Points to Remember :**
- 1 As name suggest, Query Syntax is same like SQL (Structure Query Language) syntax.
- 2.Query Syntax starts with from clause and can be end with Select or GroupBy clause.
- 3 Use various other opertors like filtering, joining, grouping, sorting operators to construct the desired result.
- 4 Implicitly typed variable - var can be used to hold the result of the LINQ query
 **INQ method syntax**
  - Method syntax (also known as fluent syntax) uses extension methods included in the Enumerable or Queryable static class, similar to how you would call the --extension method of any class.
  - LINQ Method Syntax
 ```
 var result = stringList.Where(s => s.Contains("Tutorials"));

 - LINQ Method Syntax to find out teenager students
  ``
 var teenAgerStudents = studentList.Where(s => s.Age > 12 && s.Age < 20)
                                  .ToList<Student>();
 ```
  **Points to Remember** :
- 1 As name suggest, Method Syntax is like calling extension method.
- 2 LINQ Method Syntax aka Fluent syntax because it allows series of extension methods call.
- 3 Implicitly typed variable - var can be used to hold the result of the LINQ query.
  
 **Lambda Expresion**
  -What is lambda expresion?
  -A lambda expression is a convenient way of defining an anonymous (unnamed) function that can be passed around as a variable or as 
  -a parameter to a method call. Many LINQ methods take a function (called a delegate) as a parameter.
 - an example of what a lambda expression looks like:
```
Func<int, int> multiplyByFive = num => num * 5;
// Returns 35
int result = multiplyByFive(7);
-The expression num => num * 5 is a lambda expression. The => operator is called the "lambda operator". In this example, num is an input parameter to the anonymous --- function, and the return value of this function is num * 5. So when multiplyByFive is called with a parameter of 7, the result is 7 * 5, or 35.
```
 ## Standard Query Operators 
 **What are standard query Operators?**
  -A set of extension methods forming a query pattern is known as LINQ Standard Query Operators.
  -As building blocks of LINQ query expressions, these operators offer a range of query capabilities like filtering, sorting, projection, aggregation,etc
  ## LINQ standard query operators can be categorized into the following ones on the basis of their functionality.
 - 1 Filtering Operators
  - 2 Join Operators
  - 3 Projection Operations
  - 4 Sorting Operators
 - 5 Grouping Operators
 - 6 Conversions
 - 7 Concatenation
 - 8 Aggregation
- 9 Quantifier Operations
- 10 Partition Operations
- 11 Generation Operations
- 12 Set Operations
- 13 Equality
- 14 Element Operators <br>
  
  **Filtering Operators**
  - Filtering is an operation to restrict the result set such that it has only selected elements satisfying a particular condition.
  -Examples of operators
  - WHERE which Filter values based on a predicate function
  -Example: Where clause - LINQ query syntax C#
```
IList<Student> studentList = new List<Student>() { 
        new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
        new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 } 
    };

var filteredResult = from s in studentList
                    where s.Age > 12 && s.Age < 20
                    select s.StudentName;
  -OfType	Filter values based on their ability to be as a specified type
   -Example: OfType operator in C#
IList mixedList = new ArrayList();
mixedList.Add(0);
mixedList.Add("One");
mixedList.Add("Two");
mixedList.Add(3);
mixedList.Add(new Student() { StudentID = 1, StudentName = "Bill" });

var stringResult = from s in mixedList.OfType<string>()
                select s;

var intResult = from s in mixedList.OfType<int>()
                select s;
```
  **Join Operators**
  -The Join operator joins two sequences (collections) based on a key and returns a resulted sequence.<br>
  **GroupJoin**
  - The GroupJoin operator joins two sequences based on keys and returns groups of sequences. It is like Left Outer Join of SQL.<br>
  - The Join operator operates on two collections, inner collection & outer collection.<br>
  - It returns a new collection that contains elements from both the collections -  which satisfies specified expression. It is the same as inner join of SQL.
   - Example: Join operator C#
```
IList<string> strList1 = new List<string>() { 
    "One", 
    "Two", 
    "Three", 
    "Four"
};

IList<string> strList2 = new List<string>() { 
    "One", 
    "Two", 
    "Five", 
    "Six"
};

var innerJoin = strList1.Join(strList2,
                      str1 => str1, 
                      str2 => str2, 
                      (str1, str2) => str1);
  -Example: GroupJoin in Method syntax C#
IList<Student> studentList = new List<Student>() { 
    new Student() { StudentID = 1, StudentName = "John", StandardID =1 },
    new Student() { StudentID = 2, StudentName = "Moin", StandardID =1 },
    new Student() { StudentID = 3, StudentName = "Bill", StandardID =2 },
    new Student() { StudentID = 4, StudentName = "Ram",  StandardID =2 },
    new Student() { StudentID = 5, StudentName = "Ron" } 
};

IList<Standard> standardList = new List<Standard>() { 
    new Standard(){ StandardID = 1, StandardName="Standard 1"},
    new Standard(){ StandardID = 2, StandardName="Standard 2"},
    new Standard(){ StandardID = 3, StandardName="Standard 3"}
};

var groupJoin = standardList.GroupJoin(studentList,  //inner sequence
                                std => std.StandardID, //outerKeySelector 
                                s => s.StandardID,     //innerKeySelector
                                (std, studentsGroup) => new // resultSelector 
                                {
                                    Students = studentsGroup,
                                    StandarFulldName = std.StandardName
                                });

foreach (var item in groupJoin)
{ 
    Console.WriteLine(item.StandarFulldName );

    foreach(var stud in item.Students)
        Console.WriteLine(stud.StudentName);
}
 ```
 ***Projection Operations**
- Projection is an operation in which an object is transformed into an altogether new form with only specific properties.
  -examples Select and SelectMany
  -  Select-The operator projects values on basis of a transform function
  -  Selectmany -The operator project the sequences of values which are based on a transform function as well as flattens them into a single sequence
 ```
 Example:
-Let us understand the select projection operator with some examples. Here we are going to use a console application. So first create a console application with the -name LINQDemo (you can give any meaningful name). Then add a new class file with the name Employee.cs. Once you add the Employee.cs class file, then copy and paste the -following in it.

using System.Collections.Generic;
namespace LINQDemo
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee {ID = 101, FirstName = "Preety", LastName = "Tiwary", Salary = 60000 },
                new Employee {ID = 102, FirstName = "Priyanka", LastName = "Dewangan", Salary = 70000 },
                new Employee {ID = 103, FirstName = "Hina", LastName = "Sharma", Salary = 80000 },
                new Employee {ID = 104, FirstName = "Anurag", LastName = "Mohanty", Salary = 90000 },
                new Employee {ID = 105, FirstName = "Sambit", LastName = "Satapathy", Salary = 100000 },
                new Employee {ID = 106, FirstName = "Sushanta", LastName = "Jena", Salary = 160000 }
            };
            return employees;
        }
    }
}
-As you can see we have created the Employee class with the following four properties such as ID, FirstName, LastName, and Salary. We also created one static method -which will return the list of employees which will act as our data source. Let us discuss some examples to understand the LINQ Select Operator
 ```
  **Sorting Operators**
  -A sorting operator arranges the elements of the collection in ascending or descending order. LINQ includes following sorting operators.
  -  1 OrderBy-Sorts the elements in the collection based on specified fields in ascending or decending order.
  -  2 OrderByDesecending -Sorts the collection based on specified fields in descending order. Only valid in method syntax.
```
  Example: OrderBy in Query Syntax C#
IList<Student> studentList = new List<Student>() { 
    new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
    new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
    new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
    new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 } 
};

var orderByResult = from s in studentList
                   orderby s.StudentName 
                   select s;

var orderByDescendingResult = from s in studentList
                   orderby s.StudentName descending
                   select s;
  ``
  ``
  Example: OrderByDescending C#
IList<Student> studentList = new List<Student>() { 
    new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
    new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
    new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
    new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 } 
};

var studentsInDescOrder = studentList.OrderByDescending(s => s.StudentName);
 ```
  **Grouping Operators**
  -In LINQ, grouping operators pick the elements of the sequence or collection which contains common attributes and serve them in a group
  -  1 GroupBy-The GroupBy operator returns groups of elements based on some key value. Each group is represented by IGrouping<TKey, TElement> object.
  -  2 ToLookup -ToLookup is the same as GroupBy; the only difference is the execution of GroupBy is deferred whereas ToLookup execution is immediate.
```
  Example: GroupBy in Query syntax C#
IList<Student> studentList = new List<Student>() { 
        new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
        new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
        new Student() { StudentID = 5, StudentName = "Abram" , Age = 21 } 
    };

var groupedResult = from s in studentList
                    group s by s.Age;

//iterate each group        
foreach (var ageGroup in groupedResult)
{
    Console.WriteLine("Age Group: {0}", ageGroup .Key); //Each group has a key 
             
    foreach(Student s in ageGroup) // Each group has inner collection
        Console.WriteLine("Student Name: {0}", s.StudentName);
}
 ```
  **ToLookup**
- ToLookup is the same as GroupBy; the only difference is GroupBy execution is deferred, whereas ToLookup execution is immediate. Also, ToLookup is only applicable in - Method syntax. ToLookup is not supported in the query syntax.
  
```
  Example: ToLookup in method syntax C#
IList<Student> studentList = new List<Student>() { 
        new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
        new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
        new Student() { StudentID = 5, StudentName = "Abram" , Age = 21 } 
    };

var lookupResult = studentList.ToLookup(s => s.age);

foreach (var group in lookupResult)
{
    Console.WriteLine("Age Group: {0}", group.Key);  //Each group has a key 
             
    foreach(Student s in group)  //Each group has a inner collection  
        Console.WriteLine("Student Name: {0}", s.StudentName);
}
        
  ```
  **Coversion**
  -The Conversion operators in LINQ are useful in converting the type of the elements in a sequence (collection). 
  -There are three types of conversion operators: 
  -  1 As operators (AsEnumerable and AsQueryable), 
  -  2 To operators (ToArray, ToDictionary, ToList and ToLookup), and
  -  3 Casting operators (Cast and OfType
  -AsEnumerable	-Returns the input sequence as IEnumerable<t>
  -AsEnumerable & AsQueryable
 -- The AsEnumerable and AsQueryable methods cast or convert a source object to IEnumerable<T> or IQueryable<T> respectively.
```
  Example: AsEnumerable & AsQueryable operator in C#:
class Program
{

    static void ReportTypeProperties<T>(T obj)
    {
        Console.WriteLine("Compile-time type: {0}", typeof(T).Name);
        Console.WriteLine("Actual type: {0}", obj.GetType().Name);
    }

    static void Main(string[] args)
    {
        Student[] studentArray = { 
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 } ,
            };   
            
        ReportTypeProperties( studentArray);
        ReportTypeProperties(studentArray.AsEnumerable());
        ReportTypeProperties(studentArray.AsQueryable());   
    }
}
 ```
**To Operators: ToArray(), ToList(), ToDictionary()**
  -  As the name suggests, ToArray(), ToList(), ToDictionary() method converts a source object into an array, List or Dictionary respectively.
  -  To operators force the execution of the query. It forces the remote query provider to execute a query and get the result from the underlying data source e.g. SQL Server database.
 ```
  Example: ToArray & ToList in C#
IList<string> strList = new List<string>() { 
                                            "One", 
                                            "Two", 
                                            "Three", 
                                            "Four", 
                                            "Three" 
                                            };

string[] strArray = strList.ToArray<string>();// converts List to Array

IList<string> list = strArray.ToList<string>(); // converts array into list
 ```
  
  **Cast**
 - Cast does the same thing as AsEnumerable<T>. It cast the source object into IEnumerable<T>.
 
  ^^Concatenation**
  -The concatenation is a process in which one sequence is appended into another sequence. In LINQ, the concatenation operation contains only one 
  -operator that is known as Concat. It is used to append two same types of sequences or collections and return a new sequence or collection.
  ** Aggregation**
  -In LINQ, aggregation functions are those functions which are used to calculate a single value from the collection of the values.
  
 ** Following is the list of the methods that are used to perform aggregation operations:**
  
- 1 Aggregate	-It performs, a custom aggregation operation on the values of a collection.
- 2 Average	-It calculates the average value of a collection of values.
- 3 Count	-It counts the elements in a collection, optionally only those elements that satisfy a predicate function.
- 4 LongCount-	It counts the elements in a large collection, optionally only those elements that satisfy a predicate function.
- 5 Max	-It determines the maximum value in a collection.
 - 6 Min-	It determines the minimum value in a collection.
- 7 Sum	-It calculates the sum of the values in a collection.
  ##Quantifiers operations**
  **What are Quantifiers operations?**
  -In LINQ, quantifier operators are used to returning a boolean value which shows that whether some or all elements satisfies the given condition.
  **There are 3 Quantifiers operations that can be used in LINQ:**
-  1 All – used to determine whether all the elements in a sequence satisfy a condition.
-  2 Any - used to determine whether any elements in a sequence satisfy a condition.
-  3 Contains - used to determine whether a sequence contains a specified element.
  
**Partition Operations** 
  -Partitioning in LINQ refers to the operation of dividing an input sequence into two sections, without rearranging the elements, and then returning one of the sections.
  -Examples are:
  - 1 Skip-Skips some specified number of elements within a sequence and returns the remaining ones
  - 2 SkipWhile-Same as that of Skip with the only exception that number of elements to skip are specified by a Boolean condition
  - 3 Take-Take a specified number of elements from a sequence and skip the remaining ones
  - 4 TakeWhile-Same as that of Take except the fact that number of elements to take are specified by a Boolean condition
  **Generation Operations**
  -LINQ includes generation operators DefaultIfEmpty, Empty, Range & Repeat. The Empty, Range & Repeat methods are
  -not extension methods for IEnumerable or IQueryable but they are simply static methods defined in a static class Enumerable.
  -Examples 
  - 1 DefaultIfEmpty	-When applied to an empty sequence, generate a default element within a sequence
  - 2 Empty-Returns an empty sequence of values and is the most simplest generational operator
  - 3 Range-Generates a collection having a sequence of integers or numbers
  - 4 Repeat-Generates a sequence containing repeated values of a specific length
  
  
 **Set Operations **
  -Set operations in LINQ refer to query operations that produce a result set that is based on the presence or absence of equivalent 
  -elements within the same or separate collections (or sets)
  -Examples 
  - 1 Distinct-	Results a list of unique values from a collection by filtering duplicate data if any	
 - 2 Except	-Compares the values of two collections and return the ones from one collection who are not in the other collection	
- 3 Intersect-	Returns the set of values found to be identical in two separate collections	
- 4 Union-	Combines content of two different collections into a single list that too without any duplicate content
  
  **Equality**
 ##What are Equality?
  -In LINQ, the equality operation contains only one operator that is known as SequenceEqual. It is used to check whether the given elements in 
  -the sequence or ---collection are equal or not. If the given sequences or collections are equal then it returns true otherwise return false.
  
  **Element Operators**
  -In LINQ, element operators are used to returning the first and last element of the list or single element from the collection or a specific element based on the index value from the collection.
  **There are eight types of element operators in LINQ.**
- 1 ElementAt
- 2 ElementAtOrDefault.
- 3 First.
- 4 FirstOrDefault.
- 5 Single.
- 6 SingleOrDefault.
- 7 Last.
- 8 LastOrDefault.
  
