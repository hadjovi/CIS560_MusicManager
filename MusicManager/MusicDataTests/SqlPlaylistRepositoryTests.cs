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
    public class SqlPlaylistRepositoryTests
    {
        const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=master;Integrated Security=SSPI;";

        private static string GetTestString() => Guid.NewGuid().ToString("N");

        private IPlaylistRepository repo;
        private TransactionScope transaction;

        [TestInitialize]
        public void InitializeTest()
        {
            repo = new SqlPlaylistRepository(connectionString);

            transaction = new TransactionScope();
        }

        [TestCleanup]
        public void CleanupTest()
        {
            transaction.Dispose();
        }
        //playlist tests
        [TestMethod]
        public void CreatePlaylistShouldWork()
        {
            var playlistName = GetTestString();
            var ownerId = 1;
            var isPrivate = true;
            var isDeleted = false;

            var actual = repo.CreatePlaylist(playlistName, ownerId, isPrivate, isDeleted);

            Assert.IsNotNull(actual);
            Assert.AreEqual(playlistName, actual.PlaylistName);
            Assert.AreEqual(ownerId, actual.PlaylistOwnerID);
            Assert.AreEqual(isPrivate, actual.IsPrivate);
            Assert.AreEqual(isDeleted, actual.IsDeleted);
        }
    }
}
