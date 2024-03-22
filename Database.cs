using Npgsql;

namespace database_exercise
{
    internal class Database
    {
        private static string host = "localhost";
        private static int port = 5432;
        private static string username = "test_user";
        private static string password = "password";
        private static string database = "corporate";

        private Database() { }

        public static NpgsqlConnection? GetConnection()
        {
            NpgsqlConnection? connection = null;

            try
            {
                connection = new NpgsqlConnection($"Host={host};Port={port};Username={username};Password={password};Database={database};");

            }
            catch (Exception ex )
            {
                Console.WriteLine(ex.Message);
            }

            return connection;
        }
    }
}
