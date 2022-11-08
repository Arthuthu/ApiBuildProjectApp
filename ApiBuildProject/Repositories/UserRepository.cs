using ApiBuildProject.Connection;
using ApiBuildProject.Models;
using Dapper;
using System.Data.SqlClient;

namespace ApiBuildProject.Repositories
{
    public class UserRepository : IUserRepository
    {

        public List<UserModel> GetAllUser()
        {
            var connValue = Conexao.ConnectionValue();

            using (connValue)
            {
                List<UserModel> users = connValue.Query<UserModel>("dbo.GetAllUsers").ToList();

                return users;
            }
        }

        public UserModel GetById(int id)
        {
            var connValue = Conexao.ConnectionValue();

            using (connValue)
            {
                var user = connValue.Query<UserModel>("select * from Users WHERE id=@id", new { id }).SingleOrDefault();

                return user;
            }
        }

        public bool Create(UserModel user)
        {
            var connValue = Conexao.ConnectionValue();

            return true;
        }

        public bool Delete(int id)
        {
            var connValue = Conexao.ConnectionValue();

            return true;

        }

        public bool Update(UserModel user)
        {
            var connValue = Conexao.ConnectionValue();

            return true;
        }
    }
}
