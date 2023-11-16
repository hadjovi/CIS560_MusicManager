using MusicData.Models;
using System;
using System.Collections.Generic;
using DataAccess;
using MusicData.DataDelegates;

namespace MusicData
{
    public class SqlUserRepository : IUserRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlUserRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }
        public User CreateUser(string name, string email, string password)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(name));

            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(email));

            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(password));

            var d = new CreateUserDataDelegate(name, email, password);
            return executor.ExecuteNonQuery(d);
        }

        public User FetchPerson(int userId)
        {
            var d = new FetchUserDataDelegate(userId);
            return executor.ExecuteReader(d);
        }

        public User GetUser(string email)
        {
            var d = new GetUserDataDelegate(email);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<User> RetrieveUsers()
        {
            return executor.ExecuteReader(new RetrieveUsersDataDelegate());
        }
    }
}
