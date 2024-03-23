using dao;
using Npgsql;

namespace database_exercise
{
    internal class EmployeeDAOImpl : EmployeeDAO
    {
        public int Delete(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee? Get(int id)
        {
            using NpgsqlConnection? conn = Database.GetConnection();
            Employee? employee = null;

            if (conn == null)
                return null;

            conn.OpenAsync();

            string sql = "SELECT * FROM employee";
            using var cmd = new NpgsqlCommand(sql, conn);

            using NpgsqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine("{0} {1} {2}", rdr.GetInt32(0), rdr.GetString(1), rdr.GetInt32(2));
                return null;
            }
            return null;
        }

        public List<Employee> GetAll()
        {
            using NpgsqlConnection? conn = Database.GetConnection();

            if (conn == null)
                return [];

            conn.Open();

            string sql = "SELECT * FROM employee;";
            using var cmd = new NpgsqlCommand(sql, conn);

            using NpgsqlDataReader rdr = cmd.ExecuteReader();

            List<Employee> employees = new();

            while (rdr.Read())
            {
                int id = rdr.GetInt32(0);
                string firstName = rdr.GetString(1);
                string lastName = rdr.GetString(2);
                string role = rdr.GetString(3);
                double salary = rdr.GetDouble(4);

                Employee employee = new(id, firstName, lastName, role, salary);

                employees.Add(employee);
            }

            return employees;
        }

        public int Insert(Employee employee)
        {
            throw new NotImplementedException();
        }

        public int Update(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
