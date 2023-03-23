using EntityModels;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Workflow;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeActivityAssembly
{
    public class AnAccountCodeActivity : CodeActivity
    {
        [Output("AccountReference")]
        [ReferenceTarget(Account.EntityLogicalName)]
        public OutArgument<EntityReference> AccountReference { get; set; }
        protected override void Execute(CodeActivityContext context)
        {
            IWorkflowContext workflowContext = context.GetExtension<IWorkflowContext>();
            AccountReference.Set(context, new EntityReference(workflowContext.PrimaryEntityName, workflowContext.PrimaryEntityId));
        }
    }
}
