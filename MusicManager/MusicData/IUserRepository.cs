using System.Collections.Generic;
using MusicData.Models;

namespace MusicData
{
    public interface IUserRepository
    {

        IReadOnlyList<User> RetrieveUsers();

        User FetchUser(int userId);

        User GetUser(string email, string password);

        User CreateUser(string name, string email, string password);
    }
}
