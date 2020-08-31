using System;

namespace dbcon
{
    public class DbCommand
    {
        public string instruction = "Do this";
        public string ConnectionString = "abc123";

        public void Execute(DbConnection connection, string instruction)
        {
            if (instruction == null || instruction == "")
            {
                Console.WriteLine("An empty or null instruction can't be executed.");
            }
            else
            {
                connection.DbOpen(connection.ConnectionString);
                Console.WriteLine("Executing " + instruction);
                connection.DbClose(connection.ConnectionString);
            }
        }
    }
}