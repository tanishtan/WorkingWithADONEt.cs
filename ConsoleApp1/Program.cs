using System.Data.SqlClient;

public class TestClass
{
    static void Main()
    {
        var connStr = "Server=tcp:tanishdbserver.database.windows.net,1433;Initial Catalog=TanishDB;Persist Security Info=False;User ID=tanishdbadmin;Password=Tanish@2002;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
        SqlConnection con = new SqlConnection();


        con.ConnectionString = connStr;
        con.Open();

        var cmd = con.CreateCommand();
        cmd.CommandText = "Select * from Employee";

        var reader = cmd.ExecuteReader(); // Use SqlCommand.ExecuteReader

        while (reader.Read())
        {
            Console.WriteLine("{0}, {1}, {2}", reader[0], reader[1], reader[2]);
        }
        con.Close();
    }
}
