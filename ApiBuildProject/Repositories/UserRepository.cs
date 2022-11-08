using ApiBuildProject.Connection;
using ApiBuildProject.Models;
using Dapper;
using System.Data;

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
                var user = connValue.Query<UserModel>($"dbo.GetUserById @id = '{id}'").SingleOrDefault();

                return user;
            }
        }

        public bool Create(UserModel user)
        {
            var connValue = Conexao.ConnectionValue();

            using (connValue)
            {
                connValue.Execute($"Insert into Users values (@Email, @Password)", user);
            }

            return true;
        }

        public bool Delete(int id)
        {
            var connValue = Conexao.ConnectionValue();

            using (connValue)
            {
                connValue.Execute("Delete from Users Where id = @uID", new { uID = id});
            }

            return true;
        }

        public bool Update(int id, UserModel user)
        {
            var connValue = Conexao.ConnectionValue();

            using (connValue)
            {
                connValue.Execute(
                    @"Update Users set
                    Email = @Email,
                    Password = @Password
                    WHERE
                    Id = @id",
                    new
                    {
                        id = id,
                        email = user.Email,
                        password = user.Password
                    });
            }

            return true;
        }
    }
}
