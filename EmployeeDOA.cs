namespace database_exercise
{
    internal interface EmployeeDOA
    {
        Employee GetEmployee(int id);

        Employee[] GetEmployees();

        int save(Employee employee);

        int update(Employee employee);

        int insert(Employee employee);

        int delete(Employee employee);

    }
}
