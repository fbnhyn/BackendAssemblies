using Configuration;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginAssembly.Account
{
    public class AnAccountPlugin : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            var organizationService = serviceProvider.GetOrganizationService(SystemUserReference.Admin);
        }
    }
}
