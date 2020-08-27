using System;

namespace dbcon
{
    public abstract class DbConnections
    {
        public string ConnectionString;
        public TimeSpan Timout;

        public abstract void DbOpen(string connection);
        public abstract void DbClose(string connection);        
    }

    public class SqlConnection : DbConnections
    {
        public override void DbOpen(string connection)
        {
            if (connection == null)
            {
                Console.WriteLine("Can't open an SQL db with a null ConnectionString.");
            }
            else if (connection == "")
            {
                Console.WriteLine("Can't open an SQL db with an empty ConnctionString.");
            }
            else
            {
                Console.WriteLine("Open SQL db " + connection + ".");
            }
        }

        public override void DbClose(string connection)
        {
            if (connection == null)
            {
                Console.WriteLine("Can't close an SQL db with a null ConnectionString.");
            }
            else if (connection == "")
            {
                Console.WriteLine("Can't close an SQL db with an empty ConnctionString.");
            }
            else
            {
                Console.WriteLine("Close SQL db " + connection + ".");
            }
        }
    }


    public class OracleConnection : DbConnections
    {
        public override void DbOpen(string connection)
        {
            if (connection == null)
            {
                Console.WriteLine("Can't open an Oracle db with a null ConnectionString.");
            }
            else if (connection == "")
            {
                Console.WriteLine("Can't open an Oracle db with an empty ConnctionString.");
            }
            else
            {
                Console.WriteLine("Open Oracle db " + connection + ".");
            }
        }

        public override void DbClose(string connection)
        {
            if (connection == null)
            {
                Console.WriteLine("Can't close an Oracle db with a null ConnectionString.");
            }
            else if (connection == "")
            {
                Console.WriteLine("Can't close an Oracle db with an empty ConnctionString.");
            }
            else
            {
                Console.WriteLine("Close Oracle db " + connection + ".");
            }
        }
    }
}