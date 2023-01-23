using Microsoft.Xrm.Sdk;

namespace DataServices.Account
{
    public sealed class AccountDataService : CoreDataService<EntityModels.Account>
    {
        public AccountDataService(IOrganizationService organizationService) : base(organizationService)
        {
        }
    }
}