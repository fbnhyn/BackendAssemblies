using BusinessServices.Entity.Account;
using FakeXrmEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BusinessServicesTests.Entity.Account
{
    [TestClass]
    public class NamingServiceTest
    {
        private readonly XrmFakedContext xrmFakedContext;
        private readonly NamingService sut;

        public NamingServiceTest()
        {
            xrmFakedContext = new XrmFakedContext();
            sut = new NamingService(xrmFakedContext.GetOrganizationService());
        }

        [TestMethod]
        public void SetNameTest()
        {
            var account = new EntityModels.Account
            {
                Id = Guid.NewGuid()
            };

            var accountName = sut.SetName(account);

            Assert.AreEqual(accountName, account.Id.ToString());

        }
    }
}
