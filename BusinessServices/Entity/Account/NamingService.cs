using DataServices.Account;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessServices.Entity.Account
{
    public class NamingService
    {
        private readonly AccountDataService accountDataService;

        public NamingService(IOrganizationService organizationService)
        {
            accountDataService = new AccountDataService(organizationService);
        }

        public string SetName(EntityModels.Account account)
        {
            account.Name = account.Id.ToString();
            return account.Name;
        }
    }
}
