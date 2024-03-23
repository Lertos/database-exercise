
using dao;
using database_exercise;

EmployeeDAOImpl dao = new EmployeeDAOImpl();

List<Employee> employees = dao.GetAll();

foreach (Employee employee in  employees)
{
    Console.WriteLine(employee.ToString());
}

