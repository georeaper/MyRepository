using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString =
            "User=SYSDBA;" +
            "Password=masterkey;" +
            "Database=CRM_PROJECT.FDB;" +
            "DataSource=localhost;" +
            "Port=3050;" +
            "Dialect=3;" +
            "Charset=ISO8859_1;" +
            "Role=;" +
            "Connection lifetime=100;" +
            "Pooling=true;" +
            "MinPoolSize=0;" +
            "MaxPoolSize=50;" +
            "Packet Size=8192;" +
            "ServerType=0";

            FbConnection myConnection1 = new FbConnection(connectionString);
            FbConnection myConnection2 = new FbConnection(connectionString);
            FbConnection myConnection3 = new FbConnection(connectionString);
            DateTime dat = DateTime.Now;
            try
            {
                // Open two connections.
                Console.WriteLine("Open two connections.");
                myConnection1.Open();
                myConnection2.Open();

                // Now there are two connections in the pool that matches the connection string.
                // Return the both connections to the pool.
                Console.WriteLine("Return both of the connections to the pool.");
                myConnection1.Close();
                myConnection2.Close();

                // Get a connection out of the pool.
                Console.WriteLine("Open a connection from the pool.");
                myConnection1.Open();

                // Get a second connection out of the pool.
                Console.WriteLine("Open a second connection from the pool.");
                myConnection2.Open();

                // Open a third connection.
                Console.WriteLine("Open a third connection.");
                myConnection3.Open();

                // Return the all connections to the pool.
                Console.WriteLine("Return all three connections to the pool.");
                myConnection1.Close();
                myConnection2.Close();
                myConnection3.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("\nToday is {0:d} at {0:T}.", dat);
                Console.Write("\nPress any key to continue... ");
                Console.ReadLine();
            }
        }
    }
}
