using System;
using System.Collections.Generic;
using System.Transactions;
using DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicData;
using MusicData.Models;

namespace MusicDataTests
{
    [TestClass]
    public class SqlUserRepositoryTests
    {
        const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=master;Integrated Security=SSPI;";

        private static string GetTestString() => Guid.NewGuid().ToString("N");

        private IUserRepository repo;
        private TransactionScope transaction;
       
        [TestInitialize]
        public void InitializeTest()
        {
            repo = new SqlUserRepository(connectionString);

            transaction = new TransactionScope();
        }

        [TestCleanup]
        public void CleanupTest()
        {
            transaction.Dispose();
        }

        [TestMethod]
        public void CreateUserShouldWork()
        {
            var name = GetTestString();
            var email = $"{GetTestString()}@test.com";
            var password = GetTestString();

            var actual = repo.CreateUser(name, email, password);

            Assert.IsNotNull(actual);
            Assert.AreEqual(name, actual.Name);
            Assert.AreEqual(email, actual.Email);
            Assert.AreEqual(password, actual.Password);
        }

        [TestMethod]
        public void RetrieveUsersShouldWork()
        {
            var user = new User(1, "Ben", "ben@ben.com", "passwordB560");

            var expected = new Dictionary<int, User>
            {
                {user.UserID, user }
            };

            var actual = repo.RetrieveUsers();

            var matchCount = 0;

            foreach(var a in actual)
            {
                if (!expected.ContainsKey(a.UserID))
                    continue;
              
                AssertUsersAreEqual(expected[a.UserID], a);
                matchCount += 1;
            }

            Assert.AreEqual(expected.Count, matchCount, "Not all returned.");
        }

        private static void AssertUsersAreEqual(User expected, User actual)
        {
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Email, actual.Email);
            Assert.AreEqual(expected.Password, actual.Password);
        }
    }
}