


using HomeTask_Indexer_Exception;
using System.Data;

DataList<Person> employee = new();
employee.Add(new Person { Id = 1, Name = "Haci", Surname = "Ahmadov" });
employee.Add(new Person { Id = 2, Name = "Mimi", Surname = "Ismayilova" });
employee.Add(new Person { Id = 3, Name = "Ali", Surname = "Aslanov" });


var employees = employee.GetById(3);

foreach (Person item in employees)
{
    Console.WriteLine($"{item.Name} - {item.Surname}");
}


var employees2 = employee.Delete(1);
foreach (Person item in employees)
{

    Console.WriteLine($"{item.Name} - {item.Surname}");

}