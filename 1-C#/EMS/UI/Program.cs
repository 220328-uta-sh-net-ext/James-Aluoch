using UI;
//let's call Employee

Employee emp = new Employee();
//emp.firstName = "Yunus";
//emp.lastName = "Khan";
//Employee.planet = "Mars"; //constant cannot be changed


//Console.WriteLine($"Employee Id-{emp.id}\nEmployee Name  {emp.firstName}\nPlanet  {Employee.planet}");

Console.WriteLine("Please enter first name of the employee:");
var firstName = Console.ReadLine();
Console.WriteLine("Please enter last name of the employee:");
var lastName = Console.ReadLine();
Console.WriteLine("Please enter the id of the employee:");
var id = Console.ReadLine();
Console.WriteLine("Please submit working hours of the employee:");
var hours = float.Parse(Console.ReadLine());

emp.DoTask(firstName, lastName, id, hours);

//emp.DoTask(emp.firstName, emp.lastName, emp.id, 9);
//emp.DoTask("Sheen", "Joseph", "298", 7);
