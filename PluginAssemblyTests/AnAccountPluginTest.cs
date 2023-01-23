using EntityModels;
using FakeXrmEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PluginAssembly.Accounts;
using System;
using System.Linq;

namespace PluginAssemblyTests
{
    [TestClass]
    public class AnAccountPluginTest
    {
        private readonly XrmFakedContext _context;

        public AnAccountPluginTest()
        {
            _context = new XrmFakedContext();
        }

        [TestMethod]
        public void UnitTest()
        {
            var account = new Account { Id = Guid.NewGuid() };

            _context.Initialize(account);

            _context.ExecutePluginWithTarget<AnAccountPlugin>(account);

            Assert.AreEqual(_context.CreateQuery<Account>().Single(a => a.Id == account.Id).Name, account.Id.ToString());

        }
    }
}
