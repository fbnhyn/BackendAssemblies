using CodeActivityAssembly;
using EntityModels;
using FakeXrmEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace CodeActivityAssemblyTests
{
    [TestClass]
    public class AnAccountCodeActivityTest
    {
        private readonly XrmFakedContext xrmFakedContext;
        private XrmFakedWorkflowContext workflowContext;

        public AnAccountCodeActivityTest()
        {
            xrmFakedContext = new XrmFakedContext();
            workflowContext = xrmFakedContext.GetDefaultWorkflowContext();
        }

        [TestMethod]
        public void UnitTest()
        {
            var account = new Account
            {
                Id = Guid.NewGuid()
            };

            xrmFakedContext.Initialize(account);

            workflowContext.PrimaryEntityId = account.Id;
            workflowContext.PrimaryEntityName = account.LogicalName;

            var result = xrmFakedContext.ExecuteCodeActivity<AnAccountCodeActivity>(account);

            var accountReference = result[nameof(AnAccountCodeActivity.AccountReference)] as EntityReference;

            Assert.AreEqual(account.Id, accountReference.Id);
        }
    }
}
