using Configuration;
using DataServices.Account;
using EntityModels;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Extensions;
using System;

namespace PluginAssembly.Accounts
{
    [CrmPluginRegistration(
    message: MessageNameEnum.Create,
    entityLogicalName: Account.EntityLogicalName,
    stage: StageEnum.PreOperation,
    executionMode: ExecutionModeEnum.Synchronous,
    filteringAttributes: null,
    stepName: nameof(AnAccountPlugin),
    executionOrder: 1000,
    isolationModel: IsolationModeEnum.Sandbox
    )]
    public class AnAccountPlugin : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {

            var context = serviceProvider.GetService(typeof(IPluginExecutionContext)) as IPluginExecutionContext;

            var organizationServiceAdmin = serviceProvider.GetOrganizationService(SystemUserReference.Admin);

            var accountDataService = new AccountDataService(organizationServiceAdmin);

            var target = (context.InputParameters["Target"] as Entity).ToEntity<Account>();

            var account = accountDataService.GetById(target.Id);

            accountDataService.Update(new Account
            {
                Id = account.Id,
                Name = account.Id.ToString()
            });
        }
    }
}
