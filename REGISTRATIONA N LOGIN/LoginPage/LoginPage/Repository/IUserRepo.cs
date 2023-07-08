using LoginPage.DB.Entities;
using LoginPage.Models;

namespace LoginPage.Repository
{
    public interface IUserRepo
    {
        void RegisterUser(UserRegistration userRegistration);
        bool Login(string email, string password);
        //List<UserRegistration> GetAllAccounUsers();
    }
}
