namespace EntityModels
{

	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("quote")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.1.0.82")]
	public partial class Quote : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public Quote() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "quote";
		
		public const string EntityLogicalCollectionName = "quotes";
		
		public const string EntitySetName = "quotes";
		
		public const int EntityTypeCode = 1084;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>
		/// Unique identifier of the account with which the quote is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountid")]
		public Microsoft.Xrm.Sdk.EntityReference AccountId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("accountid");
			}
		}
		
		/// <summary>
		/// Unique identifier of the billing address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billto_addressid")]
		public System.Nullable<System.Guid> BillTo_AddressId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("billto_addressid");
			}
			set
			{
				this.OnPropertyChanging("BillTo_AddressId");
				this.SetAttributeValue("billto_addressid", value);
				this.OnPropertyChanged("BillTo_AddressId");
			}
		}
		
		/// <summary>
		/// Type the city for the customer's billing address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billto_city")]
		public string BillTo_City
		{
			get
			{
				return this.GetAttributeValue<string>("billto_city");
			}
			set
			{
				this.OnPropertyChanging("BillTo_City");
				this.SetAttributeValue("billto_city", value);
				this.OnPropertyChanged("BillTo_City");
			}
		}
		
		/// <summary>
		/// Shows the complete Bill To address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billto_composite")]
		public string BillTo_Composite
		{
			get
			{
				return this.GetAttributeValue<string>("billto_composite");
			}
		}
		
		/// <summary>
		/// Type the primary contact name at the customer's billing address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billto_contactname")]
		public string BillTo_ContactName
		{
			get
			{
				return this.GetAttributeValue<string>("billto_contactname");
			}
			set
			{
				this.OnPropertyChanging("BillTo_ContactName");
				this.SetAttributeValue("billto_contactname", value);
				this.OnPropertyChanged("BillTo_ContactName");
			}
		}
		
		/// <summary>
		/// Type the country or region for the customer's billing address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billto_country")]
		public string BillTo_Country
		{
			get
			{
				return this.GetAttributeValue<string>("billto_country");
			}
			set
			{
				this.OnPropertyChanging("BillTo_Country");
				this.SetAttributeValue("billto_country", value);
				this.OnPropertyChanged("BillTo_Country");
			}
		}
		
		/// <summary>
		/// Type the fax number for the customer's billing address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billto_fax")]
		public string BillTo_Fax
		{
			get
			{
				return this.GetAttributeValue<string>("billto_fax");
			}
			set
			{
				this.OnPropertyChanging("BillTo_Fax");
				this.SetAttributeValue("billto_fax", value);
				this.OnPropertyChanged("BillTo_Fax");
			}
		}
		
		/// <summary>
		/// Type the first line of the customer's billing address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billto_line1")]
		public string BillTo_Line1
		{
			get
			{
				return this.GetAttributeValue<string>("billto_line1");
			}
			set
			{
				this.OnPropertyChanging("BillTo_Line1");
				this.SetAttributeValue("billto_line1", value);
				this.OnPropertyChanged("BillTo_Line1");
			}
		}
		
		/// <summary>
		/// Type the second line of the customer's billing address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billto_line2")]
		public string BillTo_Line2
		{
			get
			{
				return this.GetAttributeValue<string>("billto_line2");
			}
			set
			{
				this.OnPropertyChanging("BillTo_Line2");
				this.SetAttributeValue("billto_line2", value);
				this.OnPropertyChanged("BillTo_Line2");
			}
		}
		
		/// <summary>
		/// Type the third line of the billing address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billto_line3")]
		public string BillTo_Line3
		{
			get
			{
				return this.GetAttributeValue<string>("billto_line3");
			}
			set
			{
				this.OnPropertyChanging("BillTo_Line3");
				this.SetAttributeValue("billto_line3", value);
				this.OnPropertyChanged("BillTo_Line3");
			}
		}
		
		/// <summary>
		/// Type a name for the customer's billing address, such as "Headquarters" or "Field office", to identify the address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billto_name")]
		public string BillTo_Name
		{
			get
			{
				return this.GetAttributeValue<string>("billto_name");
			}
			set
			{
				this.OnPropertyChanging("BillTo_Name");
				this.SetAttributeValue("billto_name", value);
				this.OnPropertyChanged("BillTo_Name");
			}
		}
		
		/// <summary>
		/// Type the ZIP Code or postal code for the billing address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billto_postalcode")]
		public string BillTo_PostalCode
		{
			get
			{
				return this.GetAttributeValue<string>("billto_postalcode");
			}
			set
			{
				this.OnPropertyChanging("BillTo_PostalCode");
				this.SetAttributeValue("billto_postalcode", value);
				this.OnPropertyChanged("BillTo_PostalCode");
			}
		}
		
		/// <summary>
		/// Type the state or province for the billing address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billto_stateorprovince")]
		public string BillTo_StateOrProvince
		{
			get
			{
				return this.GetAttributeValue<string>("billto_stateorprovince");
			}
			set
			{
				this.OnPropertyChanging("BillTo_StateOrProvince");
				this.SetAttributeValue("billto_stateorprovince", value);
				this.OnPropertyChanged("BillTo_StateOrProvince");
			}
		}
		
		/// <summary>
		/// Type the phone number for the customer's billing address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billto_telephone")]
		public string BillTo_Telephone
		{
			get
			{
				return this.GetAttributeValue<string>("billto_telephone");
			}
			set
			{
				this.OnPropertyChanging("BillTo_Telephone");
				this.SetAttributeValue("billto_telephone", value);
				this.OnPropertyChanged("BillTo_Telephone");
			}
		}
		
		/// <summary>
		/// Shows the campaign that the order was created from.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("campaignid")]
		public Microsoft.Xrm.Sdk.EntityReference CampaignId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("campaignid");
			}
			set
			{
				this.OnPropertyChanging("CampaignId");
				this.SetAttributeValue("campaignid", value);
				this.OnPropertyChanged("CampaignId");
			}
		}
		
		/// <summary>
		/// Enter the date when the quote was closed to indicate the expiration, revision, or cancellation date.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("closedon")]
		public System.Nullable<System.DateTime> ClosedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("closedon");
			}
			set
			{
				this.OnPropertyChanging("ClosedOn");
				this.SetAttributeValue("closedon", value);
				this.OnPropertyChanged("ClosedOn");
			}
		}
		
		/// <summary>
		/// Unique identifier of the contact associated with the quote.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contactid")]
		public Microsoft.Xrm.Sdk.EntityReference ContactId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("contactid");
			}
		}
		
		/// <summary>
		/// Shows who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Shows who created the record on behalf of another user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Select the customer account or contact to provide a quick link to additional customer details, such as account information, activities, and opportunities.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
		public Microsoft.Xrm.Sdk.EntityReference CustomerId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("customerid");
			}
			set
			{
				this.OnPropertyChanging("CustomerId");
				this.SetAttributeValue("customerid", value);
				this.OnPropertyChanged("CustomerId");
			}
		}
		
		/// <summary>
		/// Type additional information to describe the quote, such as the products or services offered or details about the customer's product preferences.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
		public string Description
		{
			get
			{
				return this.GetAttributeValue<string>("description");
			}
			set
			{
				this.OnPropertyChanging("Description");
				this.SetAttributeValue("description", value);
				this.OnPropertyChanged("Description");
			}
		}
		
		/// <summary>
		/// Type the discount amount for the quote if the customer is eligible for special savings.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("discountamount")]
		public Microsoft.Xrm.Sdk.Money DiscountAmount
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("discountamount");
			}
			set
			{
				this.OnPropertyChanging("DiscountAmount");
				this.SetAttributeValue("discountamount", value);
				this.OnPropertyChanged("DiscountAmount");
			}
		}
		
		/// <summary>
		/// Value of the Quote Discount Amount in base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("discountamount_base")]
		public Microsoft.Xrm.Sdk.Money DiscountAmount_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("discountamount_base");
			}
		}
		
		/// <summary>
		/// Type the discount rate that should be applied to the Detail Amount field to include additional savings for the customer in the quote.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("discountpercentage")]
		public System.Nullable<decimal> DiscountPercentage
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("discountpercentage");
			}
			set
			{
				this.OnPropertyChanging("DiscountPercentage");
				this.SetAttributeValue("discountpercentage", value);
				this.OnPropertyChanged("DiscountPercentage");
			}
		}
		
		/// <summary>
		/// Enter the date when the quote pricing is effective or was first communicated to the customer.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("effectivefrom")]
		public System.Nullable<System.DateTime> EffectiveFrom
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("effectivefrom");
			}
			set
			{
				this.OnPropertyChanging("EffectiveFrom");
				this.SetAttributeValue("effectivefrom", value);
				this.OnPropertyChanged("EffectiveFrom");
			}
		}
		
		/// <summary>
		/// Enter the expiration date or last day the quote pricing is effective for the customer.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("effectiveto")]
		public System.Nullable<System.DateTime> EffectiveTo
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("effectiveto");
			}
			set
			{
				this.OnPropertyChanging("EffectiveTo");
				this.SetAttributeValue("effectiveto", value);
				this.OnPropertyChanged("EffectiveTo");
			}
		}
		
		/// <summary>
		/// The primary email address for the entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress")]
		public string EmailAddress
		{
			get
			{
				return this.GetAttributeValue<string>("emailaddress");
			}
			set
			{
				this.OnPropertyChanging("EmailAddress");
				this.SetAttributeValue("emailaddress", value);
				this.OnPropertyChanged("EmailAddress");
			}
		}
		
		/// <summary>
		/// Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
		public System.Nullable<decimal> ExchangeRate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
			}
		}
		
		/// <summary>
		/// Enter the date a decision or order is due from the customer to indicate the expiration date of the quote.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("expireson")]
		public System.Nullable<System.DateTime> ExpiresOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("expireson");
			}
			set
			{
				this.OnPropertyChanging("ExpiresOn");
				this.SetAttributeValue("expireson", value);
				this.OnPropertyChanged("ExpiresOn");
			}
		}
		
		/// <summary>
		/// Type the cost of freight or shipping for the products included in the quote for use in calculating the Total Amount field.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("freightamount")]
		public Microsoft.Xrm.Sdk.Money FreightAmount
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("freightamount");
			}
			set
			{
				this.OnPropertyChanging("FreightAmount");
				this.SetAttributeValue("freightamount", value);
				this.OnPropertyChanged("FreightAmount");
			}
		}
		
		/// <summary>
		/// Value of the Freight Amount in base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("freightamount_base")]
		public Microsoft.Xrm.Sdk.Money FreightAmount_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("freightamount_base");
			}
		}
		
		/// <summary>
		/// Select the freight terms to make sure shipping charges are processed correctly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("freighttermscode")]
		public System.Nullable<EntityModels.quote_freighttermscode> FreightTermsCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("freighttermscode");
				if ((optionSet != null))
				{
					return ((EntityModels.quote_freighttermscode)(System.Enum.ToObject(typeof(EntityModels.quote_freighttermscode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("FreightTermsCode");
				if ((value == null))
				{
					this.SetAttributeValue("freighttermscode", null);
				}
				else
				{
					this.SetAttributeValue("freighttermscode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("FreightTermsCode");
			}
		}
		
		/// <summary>
		/// Sequence number of the import that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// Contains the date time stamp of the last on hold time.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastonholdtime")]
		public System.Nullable<System.DateTime> LastOnHoldTime
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastonholdtime");
			}
			set
			{
				this.OnPropertyChanging("LastOnHoldTime");
				this.SetAttributeValue("lastonholdtime", value);
				this.OnPropertyChanged("LastOnHoldTime");
			}
		}
		
		/// <summary>
		/// Shows who last updated the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Shows who last updated the record on behalf of another user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Customer Account associated with this Quote
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_account")]
		public Microsoft.Xrm.Sdk.EntityReference msdyn_Account
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_account");
			}
			set
			{
				this.OnPropertyChanging("msdyn_Account");
				this.SetAttributeValue("msdyn_account", value);
				this.OnPropertyChanged("msdyn_Account");
			}
		}
		
		/// <summary>
		/// Account manager responsible for the quote.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_accountmanagerid")]
		public Microsoft.Xrm.Sdk.EntityReference msdyn_AccountManagerId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_accountmanagerid");
			}
			set
			{
				this.OnPropertyChanging("msdyn_AccountManagerId");
				this.SetAttributeValue("msdyn_accountmanagerid", value);
				this.OnPropertyChanged("msdyn_AccountManagerId");
			}
		}
		
		/// <summary>
		/// Shows the estimated gross margin after accounting for non-chargeable components.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_adjustedgrossmargin")]
		public System.Nullable<decimal> msdyn_AdjustedGrossMargin
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("msdyn_adjustedgrossmargin");
			}
		}
		
		/// <summary>
		/// Shows how the quote estimation of sales value and schedule compare to customer expectations on those parameters. Possible values are 1: Within Customer expectations, 2: Not Within Customer expectations, and 0: Customer expectations Not Available.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_competitive")]
		public System.Nullable<EntityModels.msdyn_competitive> msdyn_Competitive
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("msdyn_competitive");
				if ((optionSet != null))
				{
					return ((EntityModels.msdyn_competitive)(System.Enum.ToObject(typeof(EntityModels.msdyn_competitive), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
		}
		
		/// <summary>
		/// The organizational unit in charge of the contract.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_contractorganizationalunitid")]
		public Microsoft.Xrm.Sdk.EntityReference msdyn_ContractOrganizationalUnitId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_contractorganizationalunitid");
			}
			set
			{
				this.OnPropertyChanging("msdyn_ContractOrganizationalUnitId");
				this.SetAttributeValue("msdyn_contractorganizationalunitid", value);
				this.OnPropertyChanged("msdyn_ContractOrganizationalUnitId");
			}
		}
		
		/// <summary>
		/// Shows the total customer budget for the quote, computed from all the quote lines.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_customerbudgetrollup")]
		public Microsoft.Xrm.Sdk.Money msdyn_CustomerBudgetRollUp
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("msdyn_customerbudgetrollup");
			}
		}
		
		/// <summary>
		/// Shows the value of the customer budget in the base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_customerbudgetrollup_base")]
		public Microsoft.Xrm.Sdk.Money msdyn_customerbudgetrollup_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("msdyn_customerbudgetrollup_base");
			}
		}
		
		/// <summary>
		/// Last Updated time of rollup field Customer Budget.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_customerbudgetrollup_date")]
		public System.Nullable<System.DateTime> msdyn_CustomerBudgetRollUp_Date
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("msdyn_customerbudgetrollup_date");
			}
		}
		
		/// <summary>
		/// State of rollup field Customer Budget.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_customerbudgetrollup_state")]
		public System.Nullable<int> msdyn_CustomerBudgetRollUp_State
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("msdyn_customerbudgetrollup_state");
			}
		}
		
		/// <summary>
		/// Shows how the estimated sales value on the quote compares to customer budgets. Possible values are 1: Within Customer Budget, 2: Exceeds Customer Budget, 0: Budget Estimate Not Available
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_estimatedbudget")]
		public System.Nullable<EntityModels.msdyn_budgetestimate> msdyn_EstimatedBudget
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("msdyn_estimatedbudget");
				if ((optionSet != null))
				{
					return ((EntityModels.msdyn_budgetestimate)(System.Enum.ToObject(typeof(EntityModels.msdyn_budgetestimate), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
		}
		
		/// <summary>
		/// Estimated completion date, computed from the details of each quote line.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_estimatedcompletionrollup")]
		public System.Nullable<System.DateTime> msdyn_EstimatedCompletionRollUp
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("msdyn_estimatedcompletionrollup");
			}
		}
		
		/// <summary>
		/// Last Updated time of rollup field Estimated Completion.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_estimatedcompletionrollup_date")]
		public System.Nullable<System.DateTime> msdyn_EstimatedCompletionRollUp_Date
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("msdyn_estimatedcompletionrollup_date");
			}
		}
		
		/// <summary>
		/// State of rollup field Estimated Completion.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_estimatedcompletionrollup_state")]
		public System.Nullable<int> msdyn_EstimatedCompletionRollUp_State
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("msdyn_estimatedcompletionrollup_state");
			}
		}
		
		/// <summary>
		/// The estimated cost of this quote
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_estimatedcost")]
		public Microsoft.Xrm.Sdk.Money msdyn_EstimatedCost
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("msdyn_estimatedcost");
			}
			set
			{
				this.OnPropertyChanging("msdyn_EstimatedCost");
				this.SetAttributeValue("msdyn_estimatedcost", value);
				this.OnPropertyChanged("msdyn_EstimatedCost");
			}
		}
		
		/// <summary>
		/// Value of the Estimated Cost in base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_estimatedcost_base")]
		public Microsoft.Xrm.Sdk.Money msdyn_estimatedcost_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("msdyn_estimatedcost_base");
			}
		}
		
		/// <summary>
		/// Estimated Margin of this quote
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_estimatedquotemargin")]
		public System.Nullable<decimal> msdyn_EstimatedQuoteMargin
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("msdyn_estimatedquotemargin");
			}
		}
		
		/// <summary>
		/// Shows how the estimated schedule on the quote compares to customer expectations. Possible values are 1: Estimated To Finish Early, 2: Estimated To Finish Late, 3: Estimated To Finish On Schedule, and 0: Schedule Not Available.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_estimatedschedule")]
		public System.Nullable<EntityModels.msdyn_schedule> msdyn_EstimatedSchedule
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("msdyn_estimatedschedule");
				if ((optionSet != null))
				{
					return ((EntityModels.msdyn_schedule)(System.Enum.ToObject(typeof(EntityModels.msdyn_schedule), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
		}
		
		/// <summary>
		/// Shows how the quote estimation compares to project estimation. Possible values are 0: Feasibility Not Available, 1: Feasible, and 2: Not Feasible.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_feasible")]
		public System.Nullable<EntityModels.msdyn_feasibility> msdyn_feasible
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("msdyn_feasible");
				if ((optionSet != null))
				{
					return ((EntityModels.msdyn_feasibility)(System.Enum.ToObject(typeof(EntityModels.msdyn_feasibility), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("msdyn_feasible");
				if ((value == null))
				{
					this.SetAttributeValue("msdyn_feasible", null);
				}
				else
				{
					this.SetAttributeValue("msdyn_feasible", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("msdyn_feasible");
			}
		}
		
		/// <summary>
		/// Shows the estimated gross margin without accounting for non-chargeable components.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_grossmargin")]
		public System.Nullable<decimal> msdyn_GrossMargin
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("msdyn_grossmargin");
			}
		}
		
		/// <summary>
		/// The totals of all assigned Invoice Setups
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_invoicesetuptotals")]
		public Microsoft.Xrm.Sdk.Money msdyn_InvoiceSetupTotals
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("msdyn_invoicesetuptotals");
			}
			set
			{
				this.OnPropertyChanging("msdyn_InvoiceSetupTotals");
				this.SetAttributeValue("msdyn_invoicesetuptotals", value);
				this.OnPropertyChanged("msdyn_InvoiceSetupTotals");
			}
		}
		
		/// <summary>
		/// Value of the Invoice Setup Totals in base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_invoicesetuptotals_base")]
		public Microsoft.Xrm.Sdk.Money msdyn_invoicesetuptotals_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("msdyn_invoicesetuptotals_base");
			}
		}
		
		/// <summary>
		/// Internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_ordertype")]
		public System.Nullable<EntityModels.msdyn_quote_msdyn_ordertype> msdyn_OrderType
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("msdyn_ordertype");
				if ((optionSet != null))
				{
					return ((EntityModels.msdyn_quote_msdyn_ordertype)(System.Enum.ToObject(typeof(EntityModels.msdyn_quote_msdyn_ordertype), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("msdyn_OrderType");
				if ((value == null))
				{
					this.SetAttributeValue("msdyn_ordertype", null);
				}
				else
				{
					this.SetAttributeValue("msdyn_ordertype", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("msdyn_OrderType");
			}
		}
		
		/// <summary>
		/// Shows the estimated profitability of the quote. Possible values are Profitable, Not Profitable, and Profitability not available.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_profitability")]
		public System.Nullable<EntityModels.msdyn_profitability> msdyn_Profitability
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("msdyn_profitability");
				if ((optionSet != null))
				{
					return ((EntityModels.msdyn_profitability)(System.Enum.ToObject(typeof(EntityModels.msdyn_profitability), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
		}
		
		/// <summary>
		/// The latest end date of all associated quote lines
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_quotelineenddate")]
		public System.Nullable<System.DateTime> msdyn_QuoteLineEndDate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("msdyn_quotelineenddate");
			}
			set
			{
				this.OnPropertyChanging("msdyn_QuoteLineEndDate");
				this.SetAttributeValue("msdyn_quotelineenddate", value);
				this.OnPropertyChanged("msdyn_QuoteLineEndDate");
			}
		}
		
		/// <summary>
		/// The earliest Start Date of all Quote Lines that are associated to this quote
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_quotelinestartdate")]
		public System.Nullable<System.DateTime> msdyn_QuoteLineStartDate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("msdyn_quotelinestartdate");
			}
			set
			{
				this.OnPropertyChanging("msdyn_QuoteLineStartDate");
				this.SetAttributeValue("msdyn_quotelinestartdate", value);
				this.OnPropertyChanged("msdyn_QuoteLineStartDate");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_totalamount")]
		public Microsoft.Xrm.Sdk.Money msdyn_TotalAmount
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("msdyn_totalamount");
			}
		}
		
		/// <summary>
		/// Value of the TotalAmount in base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_totalamount_base")]
		public Microsoft.Xrm.Sdk.Money msdyn_totalamount_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("msdyn_totalamount_base");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_totalchargeablecostrollup")]
		public Microsoft.Xrm.Sdk.Money msdyn_TotalChargeableCostRollup
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("msdyn_totalchargeablecostrollup");
			}
		}
		
		/// <summary>
		/// Value of the Total Chargeable Cost in base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_totalchargeablecostrollup_base")]
		public Microsoft.Xrm.Sdk.Money msdyn_totalchargeablecostrollup_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("msdyn_totalchargeablecostrollup_base");
			}
		}
		
		/// <summary>
		/// Last Updated time of rollup field Total Chargeable Cost.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_totalchargeablecostrollup_date")]
		public System.Nullable<System.DateTime> msdyn_TotalChargeableCostRollup_Date
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("msdyn_totalchargeablecostrollup_date");
			}
		}
		
		/// <summary>
		/// State of rollup field Total Chargeable Cost.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_totalchargeablecostrollup_state")]
		public System.Nullable<int> msdyn_TotalChargeableCostRollup_State
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("msdyn_totalchargeablecostrollup_state");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_totalnonchargeablecostrollup")]
		public Microsoft.Xrm.Sdk.Money msdyn_TotalNonchargeableCostRollup
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("msdyn_totalnonchargeablecostrollup");
			}
		}
		
		/// <summary>
		/// Value of the Total Non-chargeable Cost in base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_totalnonchargeablecostrollup_base")]
		public Microsoft.Xrm.Sdk.Money msdyn_totalnonchargeablecostrollup_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("msdyn_totalnonchargeablecostrollup_base");
			}
		}
		
		/// <summary>
		/// Last Updated time of rollup field Total Non-chargeable Cost.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_totalnonchargeablecostrollup_date")]
		public System.Nullable<System.DateTime> msdyn_TotalNonchargeableCostRollup_Date
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("msdyn_totalnonchargeablecostrollup_date");
			}
		}
		
		/// <summary>
		/// State of rollup field Total Non-chargeable Cost.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_totalnonchargeablecostrollup_state")]
		public System.Nullable<int> msdyn_TotalNonchargeableCostRollup_State
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("msdyn_totalnonchargeablecostrollup_state");
			}
		}
		
		/// <summary>
		/// Type a descriptive name for the quote.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string Name
		{
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			set
			{
				this.OnPropertyChanging("Name");
				this.SetAttributeValue("name", value);
				this.OnPropertyChanged("Name");
			}
		}
		
		/// <summary>
		/// Shows the duration in minutes for which the quote was on hold.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("onholdtime")]
		public System.Nullable<int> OnHoldTime
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("onholdtime");
			}
		}
		
		/// <summary>
		/// Choose the opportunity that the quote is related to for reporting and analytics.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opportunityid")]
		public Microsoft.Xrm.Sdk.EntityReference OpportunityId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("opportunityid");
			}
			set
			{
				this.OnPropertyChanging("OpportunityId");
				this.SetAttributeValue("opportunityid", value);
				this.OnPropertyChanged("OpportunityId");
			}
		}
		
		/// <summary>
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
		
		/// <summary>
		/// Owner Id
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
			set
			{
				this.OnPropertyChanging("OwnerId");
				this.SetAttributeValue("ownerid", value);
				this.OnPropertyChanged("OwnerId");
			}
		}
		
		/// <summary>
		/// Unique identifier for the business unit that owns the record
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
			}
		}
		
		/// <summary>
		/// Unique identifier for the team that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		public Microsoft.Xrm.Sdk.EntityReference OwningTeam
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
			}
		}
		
		/// <summary>
		/// Unique identifier for the user that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
		}
		
		/// <summary>
		/// Select the payment terms to indicate when the customer needs to pay the total amount.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("paymenttermscode")]
		public System.Nullable<EntityModels.quote_paymenttermscode> PaymentTermsCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("paymenttermscode");
				if ((optionSet != null))
				{
					return ((EntityModels.quote_paymenttermscode)(System.Enum.ToObject(typeof(EntityModels.quote_paymenttermscode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("PaymentTermsCode");
				if ((value == null))
				{
					this.SetAttributeValue("paymenttermscode", null);
				}
				else
				{
					this.SetAttributeValue("paymenttermscode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("PaymentTermsCode");
			}
		}
		
		/// <summary>
		/// Choose the price list associated with this record to make sure the products associated with the campaign are offered at the correct prices.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pricelevelid")]
		public Microsoft.Xrm.Sdk.EntityReference PriceLevelId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("pricelevelid");
			}
			set
			{
				this.OnPropertyChanging("PriceLevelId");
				this.SetAttributeValue("pricelevelid", value);
				this.OnPropertyChanged("PriceLevelId");
			}
		}
		
		/// <summary>
		/// Pricing error for the quote.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pricingerrorcode")]
		public System.Nullable<EntityModels.qooi_pricingerrorcode> PricingErrorCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("pricingerrorcode");
				if ((optionSet != null))
				{
					return ((EntityModels.qooi_pricingerrorcode)(System.Enum.ToObject(typeof(EntityModels.qooi_pricingerrorcode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("PricingErrorCode");
				if ((value == null))
				{
					this.SetAttributeValue("pricingerrorcode", null);
				}
				else
				{
					this.SetAttributeValue("pricingerrorcode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("PricingErrorCode");
			}
		}
		
		/// <summary>
		/// Contains the id of the process associated with the entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
		public System.Nullable<System.Guid> ProcessId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("processid");
			}
			set
			{
				this.OnPropertyChanging("ProcessId");
				this.SetAttributeValue("processid", value);
				this.OnPropertyChanged("ProcessId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the quote.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quoteid")]
		public System.Nullable<System.Guid> QuoteId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("quoteid");
			}
			set
			{
				this.OnPropertyChanging("QuoteId");
				this.SetAttributeValue("quoteid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("QuoteId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quoteid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.QuoteId = value;
			}
		}
		
		/// <summary>
		/// Shows the quote number for customer reference and searching capabilities. The number cannot be modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quotenumber")]
		public string QuoteNumber
		{
			get
			{
				return this.GetAttributeValue<string>("quotenumber");
			}
			set
			{
				this.OnPropertyChanging("QuoteNumber");
				this.SetAttributeValue("quotenumber", value);
				this.OnPropertyChanged("QuoteNumber");
			}
		}
		
		/// <summary>
		/// Enter the delivery date requested by the customer for all products in the quote.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("requestdeliveryby")]
		public System.Nullable<System.DateTime> RequestDeliveryBy
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("requestdeliveryby");
			}
			set
			{
				this.OnPropertyChanging("RequestDeliveryBy");
				this.SetAttributeValue("requestdeliveryby", value);
				this.OnPropertyChanged("RequestDeliveryBy");
			}
		}
		
		/// <summary>
		/// Shows the version number of the quote for revision history tracking.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("revisionnumber")]
		public System.Nullable<int> RevisionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("revisionnumber");
			}
		}
		
		/// <summary>
		/// Select a shipping method for deliveries sent to this address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shippingmethodcode")]
		public System.Nullable<EntityModels.quote_shippingmethodcode> ShippingMethodCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("shippingmethodcode");
				if ((optionSet != null))
				{
					return ((EntityModels.quote_shippingmethodcode)(System.Enum.ToObject(typeof(EntityModels.quote_shippingmethodcode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("ShippingMethodCode");
				if ((value == null))
				{
					this.SetAttributeValue("shippingmethodcode", null);
				}
				else
				{
					this.SetAttributeValue("shippingmethodcode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("ShippingMethodCode");
			}
		}
		
		/// <summary>
		/// Unique identifier of the shipping address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shipto_addressid")]
		public System.Nullable<System.Guid> ShipTo_AddressId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("shipto_addressid");
			}
			set
			{
				this.OnPropertyChanging("ShipTo_AddressId");
				this.SetAttributeValue("shipto_addressid", value);
				this.OnPropertyChanged("ShipTo_AddressId");
			}
		}
		
		/// <summary>
		/// Type the city for the customer's shipping address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shipto_city")]
		public string ShipTo_City
		{
			get
			{
				return this.GetAttributeValue<string>("shipto_city");
			}
			set
			{
				this.OnPropertyChanging("ShipTo_City");
				this.SetAttributeValue("shipto_city", value);
				this.OnPropertyChanged("ShipTo_City");
			}
		}
		
		/// <summary>
		/// Shows the complete Ship To address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shipto_composite")]
		public string ShipTo_Composite
		{
			get
			{
				return this.GetAttributeValue<string>("shipto_composite");
			}
		}
		
		/// <summary>
		/// Type the primary contact name at the customer's shipping address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shipto_contactname")]
		public string ShipTo_ContactName
		{
			get
			{
				return this.GetAttributeValue<string>("shipto_contactname");
			}
			set
			{
				this.OnPropertyChanging("ShipTo_ContactName");
				this.SetAttributeValue("shipto_contactname", value);
				this.OnPropertyChanged("ShipTo_ContactName");
			}
		}
		
		/// <summary>
		/// Type the country or region for the customer's shipping address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shipto_country")]
		public string ShipTo_Country
		{
			get
			{
				return this.GetAttributeValue<string>("shipto_country");
			}
			set
			{
				this.OnPropertyChanging("ShipTo_Country");
				this.SetAttributeValue("shipto_country", value);
				this.OnPropertyChanged("ShipTo_Country");
			}
		}
		
		/// <summary>
		/// Type the fax number for the customer's shipping address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shipto_fax")]
		public string ShipTo_Fax
		{
			get
			{
				return this.GetAttributeValue<string>("shipto_fax");
			}
			set
			{
				this.OnPropertyChanging("ShipTo_Fax");
				this.SetAttributeValue("shipto_fax", value);
				this.OnPropertyChanged("ShipTo_Fax");
			}
		}
		
		/// <summary>
		/// Select the freight terms to make sure shipping orders are processed correctly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shipto_freighttermscode")]
		public System.Nullable<EntityModels.quote_shipto_freighttermscode> ShipTo_FreightTermsCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("shipto_freighttermscode");
				if ((optionSet != null))
				{
					return ((EntityModels.quote_shipto_freighttermscode)(System.Enum.ToObject(typeof(EntityModels.quote_shipto_freighttermscode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("ShipTo_FreightTermsCode");
				if ((value == null))
				{
					this.SetAttributeValue("shipto_freighttermscode", null);
				}
				else
				{
					this.SetAttributeValue("shipto_freighttermscode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("ShipTo_FreightTermsCode");
			}
		}
		
		/// <summary>
		/// Type the first line of the customer's shipping address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shipto_line1")]
		public string ShipTo_Line1
		{
			get
			{
				return this.GetAttributeValue<string>("shipto_line1");
			}
			set
			{
				this.OnPropertyChanging("ShipTo_Line1");
				this.SetAttributeValue("shipto_line1", value);
				this.OnPropertyChanged("ShipTo_Line1");
			}
		}
		
		/// <summary>
		/// Type the second line of the customer's shipping address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shipto_line2")]
		public string ShipTo_Line2
		{
			get
			{
				return this.GetAttributeValue<string>("shipto_line2");
			}
			set
			{
				this.OnPropertyChanging("ShipTo_Line2");
				this.SetAttributeValue("shipto_line2", value);
				this.OnPropertyChanged("ShipTo_Line2");
			}
		}
		
		/// <summary>
		/// Type the third line of the shipping address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shipto_line3")]
		public string ShipTo_Line3
		{
			get
			{
				return this.GetAttributeValue<string>("shipto_line3");
			}
			set
			{
				this.OnPropertyChanging("ShipTo_Line3");
				this.SetAttributeValue("shipto_line3", value);
				this.OnPropertyChanged("ShipTo_Line3");
			}
		}
		
		/// <summary>
		/// Type a name for the customer's shipping address, such as "Headquarters" or "Field office",  to identify the address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shipto_name")]
		public string ShipTo_Name
		{
			get
			{
				return this.GetAttributeValue<string>("shipto_name");
			}
			set
			{
				this.OnPropertyChanging("ShipTo_Name");
				this.SetAttributeValue("shipto_name", value);
				this.OnPropertyChanged("ShipTo_Name");
			}
		}
		
		/// <summary>
		/// Type the ZIP Code or postal code for the shipping address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shipto_postalcode")]
		public string ShipTo_PostalCode
		{
			get
			{
				return this.GetAttributeValue<string>("shipto_postalcode");
			}
			set
			{
				this.OnPropertyChanging("ShipTo_PostalCode");
				this.SetAttributeValue("shipto_postalcode", value);
				this.OnPropertyChanged("ShipTo_PostalCode");
			}
		}
		
		/// <summary>
		/// Type the state or province for the shipping address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shipto_stateorprovince")]
		public string ShipTo_StateOrProvince
		{
			get
			{
				return this.GetAttributeValue<string>("shipto_stateorprovince");
			}
			set
			{
				this.OnPropertyChanging("ShipTo_StateOrProvince");
				this.SetAttributeValue("shipto_stateorprovince", value);
				this.OnPropertyChanged("ShipTo_StateOrProvince");
			}
		}
		
		/// <summary>
		/// Type the phone number for the customer's shipping address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shipto_telephone")]
		public string ShipTo_Telephone
		{
			get
			{
				return this.GetAttributeValue<string>("shipto_telephone");
			}
			set
			{
				this.OnPropertyChanging("ShipTo_Telephone");
				this.SetAttributeValue("shipto_telephone", value);
				this.OnPropertyChanged("ShipTo_Telephone");
			}
		}
		
		/// <summary>
		/// Skip Price Calculation (For Internal use)
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("skippricecalculation")]
		public System.Nullable<EntityModels.qooi_skippricecalculation> SkipPriceCalculation
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("skippricecalculation");
				if ((optionSet != null))
				{
					return ((EntityModels.qooi_skippricecalculation)(System.Enum.ToObject(typeof(EntityModels.qooi_skippricecalculation), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("SkipPriceCalculation");
				if ((value == null))
				{
					this.SetAttributeValue("skippricecalculation", null);
				}
				else
				{
					this.SetAttributeValue("skippricecalculation", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("SkipPriceCalculation");
			}
		}
		
		/// <summary>
		/// Choose the service level agreement (SLA) that you want to apply to the quote record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slaid")]
		public Microsoft.Xrm.Sdk.EntityReference SLAId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("slaid");
			}
			set
			{
				this.OnPropertyChanging("SLAId");
				this.SetAttributeValue("slaid", value);
				this.OnPropertyChanged("SLAId");
			}
		}
		
		/// <summary>
		/// Last SLA that was applied to this quote. This field is for internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slainvokedid")]
		public Microsoft.Xrm.Sdk.EntityReference SLAInvokedId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("slainvokedid");
			}
		}
		
		/// <summary>
		/// Contains the id of the stage where the entity is located.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
		public System.Nullable<System.Guid> StageId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("stageid");
			}
			set
			{
				this.OnPropertyChanging("StageId");
				this.SetAttributeValue("stageid", value);
				this.OnPropertyChanged("StageId");
			}
		}
		
		/// <summary>
		/// Shows whether the quote is draft, active, won, or closed. Only draft quotes can be edited.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<EntityModels.QuoteState> StateCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((EntityModels.QuoteState)(System.Enum.ToObject(typeof(EntityModels.QuoteState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("StateCode");
				if ((value == null))
				{
					this.SetAttributeValue("statecode", null);
				}
				else
				{
					this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("StateCode");
			}
		}
		
		/// <summary>
		/// Select the quote's status.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public System.Nullable<EntityModels.quote_statuscode> StatusCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
				if ((optionSet != null))
				{
					return ((EntityModels.quote_statuscode)(System.Enum.ToObject(typeof(EntityModels.quote_statuscode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("StatusCode");
				if ((value == null))
				{
					this.SetAttributeValue("statuscode", null);
				}
				else
				{
					this.SetAttributeValue("statuscode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("StatusCode");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
		
		/// <summary>
		/// Shows the total amount due, calculated as the sum of the products, discounts, freight, and taxes for the quote.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totalamount")]
		public Microsoft.Xrm.Sdk.Money TotalAmount
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totalamount");
			}
			set
			{
				this.OnPropertyChanging("TotalAmount");
				this.SetAttributeValue("totalamount", value);
				this.OnPropertyChanged("TotalAmount");
			}
		}
		
		/// <summary>
		/// Value of the Total Amount in base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totalamount_base")]
		public Microsoft.Xrm.Sdk.Money TotalAmount_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totalamount_base");
			}
		}
		
		/// <summary>
		/// Shows the total product amount for the quote, minus any discounts. This value is added to freight and tax amounts in the calculation for the total amount due for the quote.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totalamountlessfreight")]
		public Microsoft.Xrm.Sdk.Money TotalAmountLessFreight
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totalamountlessfreight");
			}
			set
			{
				this.OnPropertyChanging("TotalAmountLessFreight");
				this.SetAttributeValue("totalamountlessfreight", value);
				this.OnPropertyChanged("TotalAmountLessFreight");
			}
		}
		
		/// <summary>
		/// Value of the Total Pre-Freight Amount in base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totalamountlessfreight_base")]
		public Microsoft.Xrm.Sdk.Money TotalAmountLessFreight_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totalamountlessfreight_base");
			}
		}
		
		/// <summary>
		/// Shows the total discount amount, based on the discount price and rate entered on the quote.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totaldiscountamount")]
		public Microsoft.Xrm.Sdk.Money TotalDiscountAmount
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totaldiscountamount");
			}
			set
			{
				this.OnPropertyChanging("TotalDiscountAmount");
				this.SetAttributeValue("totaldiscountamount", value);
				this.OnPropertyChanged("TotalDiscountAmount");
			}
		}
		
		/// <summary>
		/// Value of the Total Discount Amount in base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totaldiscountamount_base")]
		public Microsoft.Xrm.Sdk.Money TotalDiscountAmount_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totaldiscountamount_base");
			}
		}
		
		/// <summary>
		/// Shows the sum of all existing and write-in products included on the quote, based on the specified price list and quantities.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totallineitemamount")]
		public Microsoft.Xrm.Sdk.Money TotalLineItemAmount
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totallineitemamount");
			}
			set
			{
				this.OnPropertyChanging("TotalLineItemAmount");
				this.SetAttributeValue("totallineitemamount", value);
				this.OnPropertyChanged("TotalLineItemAmount");
			}
		}
		
		/// <summary>
		/// Value of the Total Detail Amount in base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totallineitemamount_base")]
		public Microsoft.Xrm.Sdk.Money TotalLineItemAmount_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totallineitemamount_base");
			}
		}
		
		/// <summary>
		/// Shows the total of the Manual Discount amounts specified on all products included in the quote. This value is reflected in the Detail Amount field on the quote and is added to any discount amount or rate specified on the quote
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totallineitemdiscountamount")]
		public Microsoft.Xrm.Sdk.Money TotalLineItemDiscountAmount
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totallineitemdiscountamount");
			}
			set
			{
				this.OnPropertyChanging("TotalLineItemDiscountAmount");
				this.SetAttributeValue("totallineitemdiscountamount", value);
				this.OnPropertyChanged("TotalLineItemDiscountAmount");
			}
		}
		
		/// <summary>
		/// Value of the Total Line Item Discount Amount in base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totallineitemdiscountamount_base")]
		public Microsoft.Xrm.Sdk.Money TotalLineItemDiscountAmount_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totallineitemdiscountamount_base");
			}
		}
		
		/// <summary>
		/// Shows the total of the Tax amounts specified on all products included in the quote, included in the Total Amount due calculation for the quote.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totaltax")]
		public Microsoft.Xrm.Sdk.Money TotalTax
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totaltax");
			}
			set
			{
				this.OnPropertyChanging("TotalTax");
				this.SetAttributeValue("totaltax", value);
				this.OnPropertyChanged("TotalTax");
			}
		}
		
		/// <summary>
		/// Value of the Total Tax in base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totaltax_base")]
		public Microsoft.Xrm.Sdk.Money TotalTax_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totaltax_base");
			}
		}
		
		/// <summary>
		/// Choose the local currency for the record to make sure budgets are reported in the correct currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
			}
			set
			{
				this.OnPropertyChanging("TransactionCurrencyId");
				this.SetAttributeValue("transactioncurrencyid", value);
				this.OnPropertyChanged("TransactionCurrencyId");
			}
		}
		
		/// <summary>
		/// A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("traversedpath")]
		public string TraversedPath
		{
			get
			{
				return this.GetAttributeValue<string>("traversedpath");
			}
			set
			{
				this.OnPropertyChanging("TraversedPath");
				this.SetAttributeValue("traversedpath", value);
				this.OnPropertyChanged("TraversedPath");
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
		
		/// <summary>
		/// Version Number
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// Select whether the products included in the quote should be shipped to the specified address or held until the customer calls with further pick up or delivery instructions.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("willcall")]
		public System.Nullable<bool> WillCall
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("willcall");
			}
			set
			{
				this.OnPropertyChanging("WillCall");
				this.SetAttributeValue("willcall", value);
				this.OnPropertyChanged("WillCall");
			}
		}
		
		/// <summary>
		/// N:N contactquotes_association
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contactquotes_association")]
		public System.Collections.Generic.IEnumerable<EntityModels.Contact> contactquotes_association
		{
			get
			{
				return this.GetRelatedEntities<EntityModels.Contact>("contactquotes_association", null);
			}
			set
			{
				this.OnPropertyChanging("contactquotes_association");
				this.SetRelatedEntities<EntityModels.Contact>("contactquotes_association", null, value);
				this.OnPropertyChanged("contactquotes_association");
			}
		}
		
		/// <summary>
		/// N:1 lk_quote_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quote_createdonbehalfby")]
		public EntityModels.SystemUser lk_quote_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<EntityModels.SystemUser>("lk_quote_createdonbehalfby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_quote_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quote_modifiedonbehalfby")]
		public EntityModels.SystemUser lk_quote_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<EntityModels.SystemUser>("lk_quote_modifiedonbehalfby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_quotebase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quotebase_createdby")]
		public EntityModels.SystemUser lk_quotebase_createdby
		{
			get
			{
				return this.GetRelatedEntity<EntityModels.SystemUser>("lk_quotebase_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_quotebase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quotebase_modifiedby")]
		public EntityModels.SystemUser lk_quotebase_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<EntityModels.SystemUser>("lk_quotebase_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 msdyn_account_quote_Account
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_account")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_account_quote_Account")]
		public EntityModels.Account msdyn_account_quote_Account
		{
			get
			{
				return this.GetRelatedEntity<EntityModels.Account>("msdyn_account_quote_Account", null);
			}
			set
			{
				this.OnPropertyChanging("msdyn_account_quote_Account");
				this.SetRelatedEntity<EntityModels.Account>("msdyn_account_quote_Account", null, value);
				this.OnPropertyChanged("msdyn_account_quote_Account");
			}
		}
		
		/// <summary>
		/// N:1 msdyn_accountmanager_quote
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_accountmanagerid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_accountmanager_quote")]
		public EntityModels.SystemUser msdyn_accountmanager_quote
		{
			get
			{
				return this.GetRelatedEntity<EntityModels.SystemUser>("msdyn_accountmanager_quote", null);
			}
			set
			{
				this.OnPropertyChanging("msdyn_accountmanager_quote");
				this.SetRelatedEntity<EntityModels.SystemUser>("msdyn_accountmanager_quote", null, value);
				this.OnPropertyChanged("msdyn_accountmanager_quote");
			}
		}
		
		/// <summary>
		/// N:1 opportunity_quotes
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opportunityid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_quotes")]
		public EntityModels.Opportunity opportunity_quotes
		{
			get
			{
				return this.GetRelatedEntity<EntityModels.Opportunity>("opportunity_quotes", null);
			}
			set
			{
				this.OnPropertyChanging("opportunity_quotes");
				this.SetRelatedEntity<EntityModels.Opportunity>("opportunity_quotes", null, value);
				this.OnPropertyChanged("opportunity_quotes");
			}
		}
		
		/// <summary>
		/// N:1 quote_customer_accounts
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("quote_customer_accounts")]
		public EntityModels.Account quote_customer_accounts
		{
			get
			{
				return this.GetRelatedEntity<EntityModels.Account>("quote_customer_accounts", null);
			}
			set
			{
				this.OnPropertyChanging("quote_customer_accounts");
				this.SetRelatedEntity<EntityModels.Account>("quote_customer_accounts", null, value);
				this.OnPropertyChanged("quote_customer_accounts");
			}
		}
		
		/// <summary>
		/// N:1 quote_customer_contacts
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("quote_customer_contacts")]
		public EntityModels.Contact quote_customer_contacts
		{
			get
			{
				return this.GetRelatedEntity<EntityModels.Contact>("quote_customer_contacts", null);
			}
			set
			{
				this.OnPropertyChanging("quote_customer_contacts");
				this.SetRelatedEntity<EntityModels.Contact>("quote_customer_contacts", null, value);
				this.OnPropertyChanged("quote_customer_contacts");
			}
		}
		
		/// <summary>
		/// N:1 system_user_quotes
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_quotes")]
		public EntityModels.SystemUser system_user_quotes
		{
			get
			{
				return this.GetRelatedEntity<EntityModels.SystemUser>("system_user_quotes", null);
			}
		}
	}
}
