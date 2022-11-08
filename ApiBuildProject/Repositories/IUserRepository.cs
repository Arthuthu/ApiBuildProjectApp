using ApiBuildProject.Models;

namespace ApiBuildProject.Repositories
{
    public interface IUserRepository
    {
        bool Create(UserModel user);
        bool Delete(int id);
        List<UserModel> GetAllUser();
        UserModel GetById(int id);
        bool Update(UserModel user);
    }
}