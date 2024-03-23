using System.Text;

namespace dao
{
    internal class Employee
    {
        public int id { get; }
        public string firstName { get; }
        public string lastName { get; }
        public string role { get; set; }
        public double salary { get; private set; }

        public Employee(int id, string firstName, string lastName, string role, double salary = 0)
        {
            this.id = id; 
            this.firstName = firstName;
            this.lastName = lastName;
            this.role = role;
            this.salary = salary;
        }

        public override string? ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(id);
            sb.Append(',');
            sb.Append(firstName);
            sb.Append(",");
            sb.Append(lastName);
            sb.Append(",");
            sb.Append(role);
            sb.Append(",");
            sb.Append(salary);
            return sb.ToString();
        }
    }
}
