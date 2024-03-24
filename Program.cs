
using dao;
using database_exercise;

//Testing GetAll
EmployeeDAOImpl dao = new EmployeeDAOImpl();

List<Employee> employees = dao.GetAll();

foreach (Employee employee in  employees)
{
    Console.WriteLine(employee.ToString());
}

//Testing Get
Employee? singleEmployee = dao.Get(1);

if (singleEmployee != null)
    Console.WriteLine(singleEmployee.ToString());

//Testing Insert
Employee newEmployee = new Employee("Fae", "Faerie", "Manager", 120000);

dao.Insert(newEmployee);
