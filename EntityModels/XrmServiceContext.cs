namespace EntityModels
{

	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.1.0.82")]
	public partial class XrmServiceContext : Microsoft.Xrm.Sdk.Client.OrganizationServiceContext
	{
		
		/// <summary>
		/// Constructor.
		/// </summary>
		public XrmServiceContext(Microsoft.Xrm.Sdk.IOrganizationService service) : 
				base(service)
		{
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="EntityModels.Account"/> entities.
		/// </summary>
		public System.Linq.IQueryable<EntityModels.Account> AccountSet
		{
			get
			{
				return this.CreateQuery<EntityModels.Account>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="EntityModels.Contact"/> entities.
		/// </summary>
		public System.Linq.IQueryable<EntityModels.Contact> ContactSet
		{
			get
			{
				return this.CreateQuery<EntityModels.Contact>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="EntityModels.Opportunity"/> entities.
		/// </summary>
		public System.Linq.IQueryable<EntityModels.Opportunity> OpportunitySet
		{
			get
			{
				return this.CreateQuery<EntityModels.Opportunity>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="EntityModels.Quote"/> entities.
		/// </summary>
		public System.Linq.IQueryable<EntityModels.Quote> QuoteSet
		{
			get
			{
				return this.CreateQuery<EntityModels.Quote>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="EntityModels.Role"/> entities.
		/// </summary>
		public System.Linq.IQueryable<EntityModels.Role> RoleSet
		{
			get
			{
				return this.CreateQuery<EntityModels.Role>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="EntityModels.SystemUser"/> entities.
		/// </summary>
		public System.Linq.IQueryable<EntityModels.SystemUser> SystemUserSet
		{
			get
			{
				return this.CreateQuery<EntityModels.SystemUser>();
			}
		}
	}
}
