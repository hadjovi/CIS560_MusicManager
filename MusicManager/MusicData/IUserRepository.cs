using System.Collections.Generic;
using MusicData.Models;

namespace MusicData
{
    public interface IUserRepository
    {

        IReadOnlyList<User> RetrieveUsers();

        User FetchPerson(int userId);

        User GetUser(string email);

        User CreateUser(string name, string email, string password);
    }
}
