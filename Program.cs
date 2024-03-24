
using dao;
using database_exercise;

EmployeeDAOImpl dao = new EmployeeDAOImpl();

//Testing Insert
Console.WriteLine("===Insert");
Employee newEmployee = new Employee("Fae", "Faerie", "Manager", 120000);

dao.Insert(newEmployee);

//Testing GetAll
Console.WriteLine("===GetAll");
List<Employee> employees = dao.GetAll();
int newEmployeeId = -1;

foreach (Employee employee in employees)
{
    Console.WriteLine(employee.ToString());

    if (employee.firstName == "Fae")
        newEmployeeId = employee.id;
}

if (newEmployeeId == -1)
    return;

//Testing Get
Console.WriteLine("===Get");
Employee? singleEmployee = dao.Get(newEmployeeId);

if (singleEmployee != null)
    Console.WriteLine(singleEmployee.ToString());

//Testing Delete
Console.WriteLine("===Delete");

if (singleEmployee != null)
    dao.Delete(singleEmployee);
