using System.Text;

namespace dao
{
    internal class Employee
    {
        public int id { get; }
        public string name { get; }
        public string role { get; set; }
        public double salary { get; private set; }

        public Employee(int id, string name, string role, double salary = 0)
        {
            this.id = id; 
            this.name = name;
            this.role = role;
            this.salary = salary;
        }

        public override string? ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(id);
            sb.Append(',');
            sb.Append(name);
            sb.Append(",");
            sb.Append(role);
            sb.Append(",");
            sb.Append(salary);
            return sb.ToString();
        }
    }
}
