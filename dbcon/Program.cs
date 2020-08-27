using System;

// DbConnections C# exercise in polymorphism

namespace dbcon
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlconnection = new SqlConnection();
            sqlconnection.DbOpen("sqldbstring");
            sqlconnection.DbClose("sqldbstring");
            sqlconnection.DbOpen(null);
            sqlconnection.DbClose(null);
            sqlconnection.DbOpen("");
            sqlconnection.DbClose("");

            var oracleconnection = new OracleConnection();
            oracleconnection.DbOpen("oracledbstring");
            oracleconnection.DbClose("oracledbstring");
            oracleconnection.DbOpen(null);
            oracleconnection.DbClose(null);
            oracleconnection.DbOpen("");
            oracleconnection.DbClose("");

        }
    }
}
