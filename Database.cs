using Npgsql;

namespace database_exercise
{
    internal class Database
    {
        private static string host = "";
        private static string username = "";
        private static string password = "";
        private static string database = "";

        private Database() { }

        public static NpgsqlConnection GetConnection()
        {
            NpgsqlConnection connection = new NpgsqlConnection($"Host={host};Username={username};Password={password};Database={database};");

            return connection;
        }
    }
}
