using Dapper;
using System.Data.SqlClient;

namespace ApiBuildProject.Connection
{
    public class Conexao
    {
        public static SqlConnection ConnectionValue()
        {
            return new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Database_API;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
