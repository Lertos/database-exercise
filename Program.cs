
using dao;
using Npgsql;
using database_exercise;

Employee employee = new(1, "Jack Jackson", "Developer I", 70000.0);

Console.WriteLine(employee.ToString());

await using NpgsqlConnection? conn = Database.GetConnection();

if (conn == null)
    return;

await conn.OpenAsync();

await using (var cmd = new NpgsqlCommand("SELECT * FROM employee", conn))
await using (var reader = await cmd.ExecuteReaderAsync())
{
    while (await reader.ReadAsync())
        Console.WriteLine(reader.GetString(1));
}