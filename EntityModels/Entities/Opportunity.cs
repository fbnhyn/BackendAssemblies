namespace EntityModels
{

	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("opportunity")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.1.0.82")]
	public partial class Opportunity : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public Opportunity() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "opportunity";
		
		public const string EntityLogicalCollectionName = "opportunities";
		
		public const string EntitySetName = "opportunities";
		
		public const int EntityTypeCode = 3;
		
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
		/// Internal attribute for storing customerid. Do not use this attribute directly; use parentaccountid instead.
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
		/// Shows the date and time when the opportunity was closed or canceled.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualclosedate")]
		public System.Nullable<System.DateTime> ActualCloseDate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("actualclosedate");
			}
			set
			{
				this.OnPropertyChanging("ActualCloseDate");
				this.SetAttributeValue("actualclosedate", value);
				this.OnPropertyChanged("ActualCloseDate");
			}
		}
		
		/// <summary>
		/// Type the actual revenue amount for the opportunity for reporting and analysis of estimated versus actual sales. Field defaults to the Est. Revenue value when an opportunity is won.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualvalue")]
		public Microsoft.Xrm.Sdk.Money ActualValue
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("actualvalue");
			}
			set
			{
				this.OnPropertyChanging("ActualValue");
				this.SetAttributeValue("actualvalue", value);
				this.OnPropertyChanged("ActualValue");
			}
		}
		
		/// <summary>
		/// Value of the Actual Revenue in base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualvalue_base")]
		public Microsoft.Xrm.Sdk.Money ActualValue_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("actualvalue_base");
			}
		}
		
		/// <summary>
		/// Type a value between 0 and 1,000,000,000,000 to indicate the lead's potential available budget.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("budgetamount")]
		public Microsoft.Xrm.Sdk.Money BudgetAmount
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("budgetamount");
			}
			set
			{
				this.OnPropertyChanging("BudgetAmount");
				this.SetAttributeValue("budgetamount", value);
				this.OnPropertyChanged("BudgetAmount");
			}
		}
		
		/// <summary>
		/// Value of the Budget Amount in base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("budgetamount_base")]
		public Microsoft.Xrm.Sdk.Money BudgetAmount_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("budgetamount_base");
			}
		}
		
		/// <summary>
		/// Select the likely budget status for the lead's company. This may help determine the lead rating or your sales approach.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("budgetstatus")]
		public System.Nullable<EntityModels.budgetstatus> BudgetStatus
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("budgetstatus");
				if ((optionSet != null))
				{
					return ((EntityModels.budgetstatus)(System.Enum.ToObject(typeof(EntityModels.budgetstatus), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("BudgetStatus");
				if ((value == null))
				{
					this.SetAttributeValue("budgetstatus", null);
				}
				else
				{
					this.SetAttributeValue("budgetstatus", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("BudgetStatus");
			}
		}
		
		/// <summary>
		/// Shows the campaign that the opportunity was created from. The ID is used for tracking the success of the campaign.
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
		/// Choose whether the proposal feedback has been captured for the opportunity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("captureproposalfeedback")]
		public System.Nullable<bool> CaptureProposalFeedback
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("captureproposalfeedback");
			}
			set
			{
				this.OnPropertyChanging("CaptureProposalFeedback");
				this.SetAttributeValue("captureproposalfeedback", value);
				this.OnPropertyChanged("CaptureProposalFeedback");
			}
		}
		
		/// <summary>
		/// Type a number from 0 to 100 that represents the likelihood of closing the opportunity. This can aid the sales team in their efforts to convert the opportunity in a sale.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("closeprobability")]
		public System.Nullable<int> CloseProbability
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("closeprobability");
			}
			set
			{
				this.OnPropertyChanging("CloseProbability");
				this.SetAttributeValue("closeprobability", value);
				this.OnPropertyChanged("CloseProbability");
			}
		}
		
		/// <summary>
		/// Select whether a final proposal has been completed for the opportunity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("completefinalproposal")]
		public System.Nullable<bool> CompleteFinalProposal
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("completefinalproposal");
			}
			set
			{
				this.OnPropertyChanging("CompleteFinalProposal");
				this.SetAttributeValue("completefinalproposal", value);
				this.OnPropertyChanged("CompleteFinalProposal");
			}
		}
		
		/// <summary>
		/// Select whether an internal review has been completed for this opportunity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("completeinternalreview")]
		public System.Nullable<bool> CompleteInternalReview
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("completeinternalreview");
			}
			set
			{
				this.OnPropertyChanging("CompleteInternalReview");
				this.SetAttributeValue("completeinternalreview", value);
				this.OnPropertyChanged("CompleteInternalReview");
			}
		}
		
		/// <summary>
		/// Select whether the lead confirmed interest in your offerings. This helps in determining the lead quality and the probability of it turning into an opportunity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("confirminterest")]
		public System.Nullable<bool> ConfirmInterest
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("confirminterest");
			}
			set
			{
				this.OnPropertyChanging("ConfirmInterest");
				this.SetAttributeValue("confirminterest", value);
				this.OnPropertyChanged("ConfirmInterest");
			}
		}
		
		/// <summary>
		/// Internal attribute for storing customerid. Do not use this attribute directly; use parentcontactid instead.
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
		/// Type notes about the company or organization associated with the opportunity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currentsituation")]
		public string CurrentSituation
		{
			get
			{
				return this.GetAttributeValue<string>("currentsituation");
			}
			set
			{
				this.OnPropertyChanging("CurrentSituation");
				this.SetAttributeValue("currentsituation", value);
				this.OnPropertyChanged("CurrentSituation");
			}
		}
		
		/// <summary>
		/// Select the customer account or contact to provide a quick link to additional customer details, such as address, phone number, activities, and orders.
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
		/// Type some notes about the customer's requirements, to help the sales team identify products and services that could meet their requirements.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerneed")]
		public string CustomerNeed
		{
			get
			{
				return this.GetAttributeValue<string>("customerneed");
			}
			set
			{
				this.OnPropertyChanging("CustomerNeed");
				this.SetAttributeValue("customerneed", value);
				this.OnPropertyChanged("CustomerNeed");
			}
		}
		
		/// <summary>
		/// Type notes about the customer's pain points to help the sales team identify products and services that could address these pain points.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerpainpoints")]
		public string CustomerPainPoints
		{
			get
			{
				return this.GetAttributeValue<string>("customerpainpoints");
			}
			set
			{
				this.OnPropertyChanging("CustomerPainPoints");
				this.SetAttributeValue("customerpainpoints", value);
				this.OnPropertyChanged("CustomerPainPoints");
			}
		}
		
		/// <summary>
		/// Select whether your notes include information about who makes the purchase decisions at the lead's company.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("decisionmaker")]
		public System.Nullable<bool> DecisionMaker
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("decisionmaker");
			}
			set
			{
				this.OnPropertyChanging("DecisionMaker");
				this.SetAttributeValue("decisionmaker", value);
				this.OnPropertyChanged("DecisionMaker");
			}
		}
		
		/// <summary>
		/// Type additional information to describe the opportunity, such as possible products to sell or past purchases from the customer.
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
		/// Select whether a proposal has been developed for the opportunity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("developproposal")]
		public System.Nullable<bool> DevelopProposal
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("developproposal");
			}
			set
			{
				this.OnPropertyChanging("DevelopProposal");
				this.SetAttributeValue("developproposal", value);
				this.OnPropertyChanged("DevelopProposal");
			}
		}
		
		/// <summary>
		/// Type the discount amount for the opportunity if the customer is eligible for special savings.
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
		/// Value of the Opportunity Discount Amount in base currency.
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
		/// Type the discount rate that should be applied to the Product Totals field to include additional savings for the customer in the opportunity.
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
		/// Enter the expected closing date of the opportunity to help make accurate revenue forecasts.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("estimatedclosedate")]
		public System.Nullable<System.DateTime> EstimatedCloseDate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("estimatedclosedate");
			}
			set
			{
				this.OnPropertyChanging("EstimatedCloseDate");
				this.SetAttributeValue("estimatedclosedate", value);
				this.OnPropertyChanged("EstimatedCloseDate");
			}
		}
		
		/// <summary>
		/// Type the estimated revenue amount to indicate the potential sale or value of the opportunity for revenue forecasting. This field can be either system-populated or editable based on the selection in the Revenue field.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("estimatedvalue")]
		public Microsoft.Xrm.Sdk.Money EstimatedValue
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("estimatedvalue");
			}
			set
			{
				this.OnPropertyChanging("EstimatedValue");
				this.SetAttributeValue("estimatedvalue", value);
				this.OnPropertyChanged("EstimatedValue");
			}
		}
		
		/// <summary>
		/// Value of the Est. Revenue in base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("estimatedvalue_base")]
		public Microsoft.Xrm.Sdk.Money EstimatedValue_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("estimatedvalue_base");
			}
		}
		
		/// <summary>
		/// Select whether the fit between the lead's requirements and your offerings was evaluated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("evaluatefit")]
		public System.Nullable<bool> EvaluateFit
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("evaluatefit");
			}
			set
			{
				this.OnPropertyChanging("EvaluateFit");
				this.SetAttributeValue("evaluatefit", value);
				this.OnPropertyChanged("EvaluateFit");
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
		/// Choose whether the sales team has recorded detailed notes on the proposals and the account's responses.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("filedebrief")]
		public System.Nullable<bool> FileDebrief
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("filedebrief");
			}
			set
			{
				this.OnPropertyChanging("FileDebrief");
				this.SetAttributeValue("filedebrief", value);
				this.OnPropertyChanged("FileDebrief");
			}
		}
		
		/// <summary>
		/// Enter the date and time when the final decision of the opportunity was made.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("finaldecisiondate")]
		public System.Nullable<System.DateTime> FinalDecisionDate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("finaldecisiondate");
			}
			set
			{
				this.OnPropertyChanging("FinalDecisionDate");
				this.SetAttributeValue("finaldecisiondate", value);
				this.OnPropertyChanged("FinalDecisionDate");
			}
		}
		
		/// <summary>
		/// Type the cost of freight or shipping for the products included in the opportunity for use in calculating the Total Amount field.
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
		/// Select whether information about competitors is included.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("identifycompetitors")]
		public System.Nullable<bool> IdentifyCompetitors
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("identifycompetitors");
			}
			set
			{
				this.OnPropertyChanging("IdentifyCompetitors");
				this.SetAttributeValue("identifycompetitors", value);
				this.OnPropertyChanged("IdentifyCompetitors");
			}
		}
		
		/// <summary>
		/// Select whether the customer contacts for this opportunity have been identified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("identifycustomercontacts")]
		public System.Nullable<bool> IdentifyCustomerContacts
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("identifycustomercontacts");
			}
			set
			{
				this.OnPropertyChanging("IdentifyCustomerContacts");
				this.SetAttributeValue("identifycustomercontacts", value);
				this.OnPropertyChanged("IdentifyCustomerContacts");
			}
		}
		
		/// <summary>
		/// Choose whether you have recorded who will pursue the opportunity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("identifypursuitteam")]
		public System.Nullable<bool> IdentifyPursuitTeam
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("identifypursuitteam");
			}
			set
			{
				this.OnPropertyChanging("IdentifyPursuitTeam");
				this.SetAttributeValue("identifypursuitteam", value);
				this.OnPropertyChanged("IdentifyPursuitTeam");
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
		/// Choose whether someone from the sales team contacted this lead earlier.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("initialcommunication")]
		public System.Nullable<EntityModels.initialcommunication> InitialCommunication
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("initialcommunication");
				if ((optionSet != null))
				{
					return ((EntityModels.initialcommunication)(System.Enum.ToObject(typeof(EntityModels.initialcommunication), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("InitialCommunication");
				if ((value == null))
				{
					this.SetAttributeValue("initialcommunication", null);
				}
				else
				{
					this.SetAttributeValue("initialcommunication", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("InitialCommunication");
			}
		}
		
		/// <summary>
		/// Shows the forecasted revenue for an Opportunity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("int_forecast")]
		public Microsoft.Xrm.Sdk.Money int_Forecast
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("int_forecast");
			}
			set
			{
				this.OnPropertyChanging("int_Forecast");
				this.SetAttributeValue("int_forecast", value);
				this.OnPropertyChanged("int_Forecast");
			}
		}
		
		/// <summary>
		/// Value of the Forecast in base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("int_forecast_base")]
		public Microsoft.Xrm.Sdk.Money int_forecast_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("int_forecast_base");
			}
		}
		
		/// <summary>
		/// Select whether the estimated revenue for the opportunity is calculated automatically based on the products entered or entered manually by a user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isrevenuesystemcalculated")]
		public System.Nullable<bool> IsRevenueSystemCalculated
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isrevenuesystemcalculated");
			}
			set
			{
				this.OnPropertyChanging("IsRevenueSystemCalculated");
				this.SetAttributeValue("isrevenuesystemcalculated", value);
				this.OnPropertyChanged("IsRevenueSystemCalculated");
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
		/// The account manager responsible for the opportunity.
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
		/// The organizational unit in charge of the opportunity.
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
		/// Categories used for forecasting.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_forecastcategory")]
		public System.Nullable<EntityModels.msdyn_opportunity_msdyn_forecastcategory> msdyn_forecastcategory
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("msdyn_forecastcategory");
				if ((optionSet != null))
				{
					return ((EntityModels.msdyn_opportunity_msdyn_forecastcategory)(System.Enum.ToObject(typeof(EntityModels.msdyn_opportunity_msdyn_forecastcategory), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("msdyn_forecastcategory");
				if ((value == null))
				{
					this.SetAttributeValue("msdyn_forecastcategory", null);
				}
				else
				{
					this.SetAttributeValue("msdyn_forecastcategory", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("msdyn_forecastcategory");
			}
		}
		
		/// <summary>
		/// Describes whether opportunity is opted out or not
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_gdproptout")]
		public System.Nullable<bool> msdyn_gdproptout
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("msdyn_gdproptout");
			}
			set
			{
				this.OnPropertyChanging("msdyn_gdproptout");
				this.SetAttributeValue("msdyn_gdproptout", value);
				this.OnPropertyChanged("msdyn_gdproptout");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_opportunitygrade")]
		public System.Nullable<EntityModels.msdyn_opportunitygradeoptset> msdyn_OpportunityGrade
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("msdyn_opportunitygrade");
				if ((optionSet != null))
				{
					return ((EntityModels.msdyn_opportunitygradeoptset)(System.Enum.ToObject(typeof(EntityModels.msdyn_opportunitygradeoptset), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("msdyn_OpportunityGrade");
				if ((value == null))
				{
					this.SetAttributeValue("msdyn_opportunitygrade", null);
				}
				else
				{
					this.SetAttributeValue("msdyn_opportunitygrade", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("msdyn_OpportunityGrade");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_opportunityscore")]
		public System.Nullable<int> msdyn_OpportunityScore
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("msdyn_opportunityscore");
			}
			set
			{
				this.OnPropertyChanging("msdyn_OpportunityScore");
				this.SetAttributeValue("msdyn_opportunityscore", value);
				this.OnPropertyChanged("msdyn_OpportunityScore");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_opportunityscoretrend")]
		public System.Nullable<EntityModels.msdyn_opportunityscoretrendoptset> msdyn_OpportunityScoreTrend
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("msdyn_opportunityscoretrend");
				if ((optionSet != null))
				{
					return ((EntityModels.msdyn_opportunityscoretrendoptset)(System.Enum.ToObject(typeof(EntityModels.msdyn_opportunityscoretrendoptset), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("msdyn_OpportunityScoreTrend");
				if ((value == null))
				{
					this.SetAttributeValue("msdyn_opportunityscoretrend", null);
				}
				else
				{
					this.SetAttributeValue("msdyn_opportunityscoretrend", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("msdyn_OpportunityScoreTrend");
			}
		}
		
		/// <summary>
		/// Internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_ordertype")]
		public System.Nullable<EntityModels.msdyn_opportunity_msdyn_ordertype> msdyn_OrderType
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("msdyn_ordertype");
				if ((optionSet != null))
				{
					return ((EntityModels.msdyn_opportunity_msdyn_ordertype)(System.Enum.ToObject(typeof(EntityModels.msdyn_opportunity_msdyn_ordertype), optionSet.Value)));
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
		/// Predictive score
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_predictivescoreid")]
		public Microsoft.Xrm.Sdk.EntityReference msdyn_PredictiveScoreId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_predictivescoreid");
			}
			set
			{
				this.OnPropertyChanging("msdyn_PredictiveScoreId");
				this.SetAttributeValue("msdyn_predictivescoreid", value);
				this.OnPropertyChanged("msdyn_PredictiveScoreId");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_scorehistory")]
		public string msdyn_ScoreHistory
		{
			get
			{
				return this.GetAttributeValue<string>("msdyn_scorehistory");
			}
			set
			{
				this.OnPropertyChanging("msdyn_ScoreHistory");
				this.SetAttributeValue("msdyn_scorehistory", value);
				this.OnPropertyChanged("msdyn_ScoreHistory");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_scorereasons")]
		public string msdyn_ScoreReasons
		{
			get
			{
				return this.GetAttributeValue<string>("msdyn_scorereasons");
			}
			set
			{
				this.OnPropertyChanging("msdyn_ScoreReasons");
				this.SetAttributeValue("msdyn_scorereasons", value);
				this.OnPropertyChanged("msdyn_ScoreReasons");
			}
		}
		
		/// <summary>
		/// Unique identifier for Segment associated with Opportunity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_segmentid")]
		public Microsoft.Xrm.Sdk.EntityReference msdyn_segmentid
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_segmentid");
			}
			set
			{
				this.OnPropertyChanging("msdyn_segmentid");
				this.SetAttributeValue("msdyn_segmentid", value);
				this.OnPropertyChanged("msdyn_segmentid");
			}
		}
		
		/// <summary>
		/// Unique identifier for Work Order Type associated with Opportunity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_workordertype")]
		public Microsoft.Xrm.Sdk.EntityReference msdyn_WorkOrderType
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_workordertype");
			}
			set
			{
				this.OnPropertyChanging("msdyn_WorkOrderType");
				this.SetAttributeValue("msdyn_workordertype", value);
				this.OnPropertyChanged("msdyn_WorkOrderType");
			}
		}
		
		/// <summary>
		/// Type a subject or descriptive name, such as the expected order or company name, for the opportunity.
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
		/// Choose how high the level of need is for the lead's company.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("need")]
		public System.Nullable<EntityModels.need> Need
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("need");
				if ((optionSet != null))
				{
					return ((EntityModels.need)(System.Enum.ToObject(typeof(EntityModels.need), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("Need");
				if ((value == null))
				{
					this.SetAttributeValue("need", null);
				}
				else
				{
					this.SetAttributeValue("need", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("Need");
			}
		}
		
		/// <summary>
		/// Shows the duration in minutes for which the opportunity was on hold.
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
		/// Unique identifier of the opportunity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opportunityid")]
		public System.Nullable<System.Guid> OpportunityId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("opportunityid");
			}
			set
			{
				this.OnPropertyChanging("OpportunityId");
				this.SetAttributeValue("opportunityid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("OpportunityId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opportunityid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.OpportunityId = value;
			}
		}
		
		/// <summary>
		/// Select the expected value or priority of the opportunity based on revenue, customer status, or closing probability.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opportunityratingcode")]
		public System.Nullable<EntityModels.opportunity_opportunityratingcode> OpportunityRatingCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("opportunityratingcode");
				if ((optionSet != null))
				{
					return ((EntityModels.opportunity_opportunityratingcode)(System.Enum.ToObject(typeof(EntityModels.opportunity_opportunityratingcode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("OpportunityRatingCode");
				if ((value == null))
				{
					this.SetAttributeValue("opportunityratingcode", null);
				}
				else
				{
					this.SetAttributeValue("opportunityratingcode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("OpportunityRatingCode");
			}
		}
		
		/// <summary>
		/// Choose the lead that the opportunity was created from for reporting and analytics. The field is read-only after the opportunity is created and defaults to the correct lead when an opportunity is created from a converted lead.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("originatingleadid")]
		public Microsoft.Xrm.Sdk.EntityReference OriginatingLeadId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("originatingleadid");
			}
			set
			{
				this.OnPropertyChanging("OriginatingLeadId");
				this.SetAttributeValue("originatingleadid", value);
				this.OnPropertyChanged("OriginatingLeadId");
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
		/// Choose an account to connect this opportunity to, so that the relationship is visible in reports and analytics, and to provide a quick link to additional details, such as financial information and activities.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentaccountid")]
		public Microsoft.Xrm.Sdk.EntityReference ParentAccountId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentaccountid");
			}
			set
			{
				this.OnPropertyChanging("ParentAccountId");
				this.SetAttributeValue("parentaccountid", value);
				this.OnPropertyChanged("ParentAccountId");
			}
		}
		
		/// <summary>
		/// Choose a contact to connect this opportunity to, so that the relationship is visible in reports and analytics.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentcontactid")]
		public Microsoft.Xrm.Sdk.EntityReference ParentContactId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentcontactid");
			}
			set
			{
				this.OnPropertyChanging("ParentContactId");
				this.SetAttributeValue("parentcontactid", value);
				this.OnPropertyChanged("ParentContactId");
			}
		}
		
		/// <summary>
		/// Information about whether the opportunity participates in workflow rules.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("participatesinworkflow")]
		public System.Nullable<bool> ParticipatesInWorkflow
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("participatesinworkflow");
			}
			set
			{
				this.OnPropertyChanging("ParticipatesInWorkflow");
				this.SetAttributeValue("participatesinworkflow", value);
				this.OnPropertyChanged("ParticipatesInWorkflow");
			}
		}
		
		/// <summary>
		/// Select whether the final proposal has been presented to the account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("presentfinalproposal")]
		public System.Nullable<bool> PresentFinalProposal
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("presentfinalproposal");
			}
			set
			{
				this.OnPropertyChanging("PresentFinalProposal");
				this.SetAttributeValue("presentfinalproposal", value);
				this.OnPropertyChanged("PresentFinalProposal");
			}
		}
		
		/// <summary>
		/// Select whether a proposal for the opportunity has been presented to the account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("presentproposal")]
		public System.Nullable<bool> PresentProposal
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("presentproposal");
			}
			set
			{
				this.OnPropertyChanging("PresentProposal");
				this.SetAttributeValue("presentproposal", value);
				this.OnPropertyChanged("PresentProposal");
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
		/// Pricing error for the opportunity.
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
		/// Select the priority so that preferred customers or critical issues are handled quickly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("prioritycode")]
		public System.Nullable<EntityModels.opportunity_prioritycode> PriorityCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("prioritycode");
				if ((optionSet != null))
				{
					return ((EntityModels.opportunity_prioritycode)(System.Enum.ToObject(typeof(EntityModels.opportunity_prioritycode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("PriorityCode");
				if ((value == null))
				{
					this.SetAttributeValue("prioritycode", null);
				}
				else
				{
					this.SetAttributeValue("prioritycode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("PriorityCode");
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
		/// Type notes about the proposed solution for the opportunity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("proposedsolution")]
		public string ProposedSolution
		{
			get
			{
				return this.GetAttributeValue<string>("proposedsolution");
			}
			set
			{
				this.OnPropertyChanging("ProposedSolution");
				this.SetAttributeValue("proposedsolution", value);
				this.OnPropertyChanged("ProposedSolution");
			}
		}
		
		/// <summary>
		/// Choose whether an individual or a committee will be involved in the  purchase process for the lead.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("purchaseprocess")]
		public System.Nullable<EntityModels.purchaseprocess> PurchaseProcess
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("purchaseprocess");
				if ((optionSet != null))
				{
					return ((EntityModels.purchaseprocess)(System.Enum.ToObject(typeof(EntityModels.purchaseprocess), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("PurchaseProcess");
				if ((value == null))
				{
					this.SetAttributeValue("purchaseprocess", null);
				}
				else
				{
					this.SetAttributeValue("purchaseprocess", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("PurchaseProcess");
			}
		}
		
		/// <summary>
		/// Choose how long the lead will likely take to make the purchase.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("purchasetimeframe")]
		public System.Nullable<EntityModels.purchasetimeframe> PurchaseTimeframe
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("purchasetimeframe");
				if ((optionSet != null))
				{
					return ((EntityModels.purchasetimeframe)(System.Enum.ToObject(typeof(EntityModels.purchasetimeframe), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("PurchaseTimeframe");
				if ((value == null))
				{
					this.SetAttributeValue("purchasetimeframe", null);
				}
				else
				{
					this.SetAttributeValue("purchasetimeframe", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("PurchaseTimeframe");
			}
		}
		
		/// <summary>
		/// Select whether the decision about pursuing the opportunity has been made.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pursuitdecision")]
		public System.Nullable<bool> PursuitDecision
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("pursuitdecision");
			}
			set
			{
				this.OnPropertyChanging("PursuitDecision");
				this.SetAttributeValue("pursuitdecision", value);
				this.OnPropertyChanged("PursuitDecision");
			}
		}
		
		/// <summary>
		/// Type comments about the qualification or scoring of the lead.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("qualificationcomments")]
		public string QualificationComments
		{
			get
			{
				return this.GetAttributeValue<string>("qualificationcomments");
			}
			set
			{
				this.OnPropertyChanging("QualificationComments");
				this.SetAttributeValue("qualificationcomments", value);
				this.OnPropertyChanged("QualificationComments");
			}
		}
		
		/// <summary>
		/// Type comments about the quotes associated with the opportunity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quotecomments")]
		public string QuoteComments
		{
			get
			{
				return this.GetAttributeValue<string>("quotecomments");
			}
			set
			{
				this.OnPropertyChanging("QuoteComments");
				this.SetAttributeValue("quotecomments", value);
				this.OnPropertyChanged("QuoteComments");
			}
		}
		
		/// <summary>
		/// Choose whether the proposal feedback has been captured and resolved for the opportunity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("resolvefeedback")]
		public System.Nullable<bool> ResolveFeedback
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("resolvefeedback");
			}
			set
			{
				this.OnPropertyChanging("ResolveFeedback");
				this.SetAttributeValue("resolvefeedback", value);
				this.OnPropertyChanged("ResolveFeedback");
			}
		}
		
		/// <summary>
		/// Select the sales stage of this opportunity to aid the sales team in their efforts to win this opportunity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesstage")]
		public System.Nullable<EntityModels.opportunity_salesstage> SalesStage
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("salesstage");
				if ((optionSet != null))
				{
					return ((EntityModels.opportunity_salesstage)(System.Enum.ToObject(typeof(EntityModels.opportunity_salesstage), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("SalesStage");
				if ((value == null))
				{
					this.SetAttributeValue("salesstage", null);
				}
				else
				{
					this.SetAttributeValue("salesstage", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("SalesStage");
			}
		}
		
		/// <summary>
		/// Select the sales process stage for the opportunity to indicate the probability of closing the opportunity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesstagecode")]
		public System.Nullable<EntityModels.opportunity_salesstagecode> SalesStageCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("salesstagecode");
				if ((optionSet != null))
				{
					return ((EntityModels.opportunity_salesstagecode)(System.Enum.ToObject(typeof(EntityModels.opportunity_salesstagecode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("SalesStageCode");
				if ((value == null))
				{
					this.SetAttributeValue("salesstagecode", null);
				}
				else
				{
					this.SetAttributeValue("salesstagecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("SalesStageCode");
			}
		}
		
		/// <summary>
		/// Enter the date and time of the prospecting follow-up meeting with the lead.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("schedulefollowup_prospect")]
		public System.Nullable<System.DateTime> ScheduleFollowup_Prospect
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("schedulefollowup_prospect");
			}
			set
			{
				this.OnPropertyChanging("ScheduleFollowup_Prospect");
				this.SetAttributeValue("schedulefollowup_prospect", value);
				this.OnPropertyChanged("ScheduleFollowup_Prospect");
			}
		}
		
		/// <summary>
		/// Enter the date and time of the qualifying follow-up meeting with the lead.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("schedulefollowup_qualify")]
		public System.Nullable<System.DateTime> ScheduleFollowup_Qualify
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("schedulefollowup_qualify");
			}
			set
			{
				this.OnPropertyChanging("ScheduleFollowup_Qualify");
				this.SetAttributeValue("schedulefollowup_qualify", value);
				this.OnPropertyChanged("ScheduleFollowup_Qualify");
			}
		}
		
		/// <summary>
		/// Enter the date and time of the proposal meeting for the opportunity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduleproposalmeeting")]
		public System.Nullable<System.DateTime> ScheduleProposalMeeting
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("scheduleproposalmeeting");
			}
			set
			{
				this.OnPropertyChanging("ScheduleProposalMeeting");
				this.SetAttributeValue("scheduleproposalmeeting", value);
				this.OnPropertyChanged("ScheduleProposalMeeting");
			}
		}
		
		/// <summary>
		/// Select whether a thank you note has been sent to the account for considering the proposal.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sendthankyounote")]
		public System.Nullable<bool> SendThankYouNote
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("sendthankyounote");
			}
			set
			{
				this.OnPropertyChanging("SendThankYouNote");
				this.SetAttributeValue("sendthankyounote", value);
				this.OnPropertyChanged("SendThankYouNote");
			}
		}
		
		/// <summary>
		/// Skip Price Calculation (For Internal Use)
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
		/// Choose the service level agreement (SLA) that you want to apply to the opportunity record.
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
		/// Last SLA that was applied to this opportunity. This field is for internal use only.
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
		/// Shows whether the opportunity is open, won, or lost. Won and lost opportunities are read-only and can't be edited until they are reactivated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<EntityModels.OpportunityState> StateCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((EntityModels.OpportunityState)(System.Enum.ToObject(typeof(EntityModels.OpportunityState), optionSet.Value)));
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
		/// Select the opportunity's status.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public System.Nullable<EntityModels.opportunity_statuscode> StatusCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
				if ((optionSet != null))
				{
					return ((EntityModels.opportunity_statuscode)(System.Enum.ToObject(typeof(EntityModels.opportunity_statuscode), optionSet.Value)));
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
		/// Shows the ID of the workflow step.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stepid")]
		public System.Nullable<System.Guid> StepId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("stepid");
			}
			set
			{
				this.OnPropertyChanging("StepId");
				this.SetAttributeValue("stepid", value);
				this.OnPropertyChanged("StepId");
			}
		}
		
		/// <summary>
		/// Shows the current phase in the sales pipeline for the opportunity. 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stepname")]
		public string StepName
		{
			get
			{
				return this.GetAttributeValue<string>("stepname");
			}
			set
			{
				this.OnPropertyChanging("StepName");
				this.SetAttributeValue("stepname", value);
				this.OnPropertyChanged("StepName");
			}
		}
		
		/// <summary>
		/// Number of users or conversations followed the record
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teamsfollowed")]
		public System.Nullable<int> TeamsFollowed
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("teamsfollowed");
			}
			set
			{
				this.OnPropertyChanging("TeamsFollowed");
				this.SetAttributeValue("teamsfollowed", value);
				this.OnPropertyChanged("TeamsFollowed");
			}
		}
		
		/// <summary>
		/// Select when the opportunity is likely to be closed.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timeline")]
		public System.Nullable<EntityModels.opportunity_timeline> TimeLine
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("timeline");
				if ((optionSet != null))
				{
					return ((EntityModels.opportunity_timeline)(System.Enum.ToObject(typeof(EntityModels.opportunity_timeline), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("TimeLine");
				if ((value == null))
				{
					this.SetAttributeValue("timeline", null);
				}
				else
				{
					this.SetAttributeValue("timeline", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("TimeLine");
			}
		}
		
		/// <summary>
		/// Total time spent for emails (read and write) and meetings by me in relation to the opportunity record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timespentbymeonemailandmeetings")]
		public string TimeSpentByMeOnEmailAndMeetings
		{
			get
			{
				return this.GetAttributeValue<string>("timespentbymeonemailandmeetings");
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
		/// Shows the total amount due, calculated as the sum of the products, discounts, freight, and taxes for the opportunity.
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
		/// Shows the total product amount for the opportunity, minus any discounts. This value is added to freight and tax amounts in the calculation for the total amount of the opportunity.
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
		/// Shows the total discount amount, based on the discount price and rate entered on the opportunity.
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
		/// Shows the sum of all existing and write-in products included on the opportunity, based on the specified price list and quantities.
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
		/// Shows the total of the Manual Discount amounts specified on all products included in the opportunity. This value is reflected in the Total Detail Amount field on the opportunity and is added to any discount amount or rate specified on the opportunity.
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
		/// Shows the total of the Tax amounts specified on all products included in the opportunity, included in the Total Amount field calculation for the opportunity.
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
		/// 1:N opportunity_quotes
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_quotes")]
		public System.Collections.Generic.IEnumerable<EntityModels.Quote> opportunity_quotes
		{
			get
			{
				return this.GetRelatedEntities<EntityModels.Quote>("opportunity_quotes", null);
			}
			set
			{
				this.OnPropertyChanging("opportunity_quotes");
				this.SetRelatedEntities<EntityModels.Quote>("opportunity_quotes", null, value);
				this.OnPropertyChanged("opportunity_quotes");
			}
		}
		
		/// <summary>
		/// N:1 lk_opportunity_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunity_createdonbehalfby")]
		public EntityModels.SystemUser lk_opportunity_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<EntityModels.SystemUser>("lk_opportunity_createdonbehalfby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_opportunity_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunity_modifiedonbehalfby")]
		public EntityModels.SystemUser lk_opportunity_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<EntityModels.SystemUser>("lk_opportunity_modifiedonbehalfby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_opportunitybase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunitybase_createdby")]
		public EntityModels.SystemUser lk_opportunitybase_createdby
		{
			get
			{
				return this.GetRelatedEntity<EntityModels.SystemUser>("lk_opportunitybase_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_opportunitybase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunitybase_modifiedby")]
		public EntityModels.SystemUser lk_opportunitybase_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<EntityModels.SystemUser>("lk_opportunitybase_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 msdyn_accountmanager_opportunity
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_accountmanagerid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_accountmanager_opportunity")]
		public EntityModels.SystemUser msdyn_accountmanager_opportunity
		{
			get
			{
				return this.GetRelatedEntity<EntityModels.SystemUser>("msdyn_accountmanager_opportunity", null);
			}
			set
			{
				this.OnPropertyChanging("msdyn_accountmanager_opportunity");
				this.SetRelatedEntity<EntityModels.SystemUser>("msdyn_accountmanager_opportunity", null, value);
				this.OnPropertyChanged("msdyn_accountmanager_opportunity");
			}
		}
		
		/// <summary>
		/// N:1 opportunity_customer_accounts
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_customer_accounts")]
		public EntityModels.Account opportunity_customer_accounts
		{
			get
			{
				return this.GetRelatedEntity<EntityModels.Account>("opportunity_customer_accounts", null);
			}
			set
			{
				this.OnPropertyChanging("opportunity_customer_accounts");
				this.SetRelatedEntity<EntityModels.Account>("opportunity_customer_accounts", null, value);
				this.OnPropertyChanged("opportunity_customer_accounts");
			}
		}
		
		/// <summary>
		/// N:1 opportunity_customer_contacts
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_customer_contacts")]
		public EntityModels.Contact opportunity_customer_contacts
		{
			get
			{
				return this.GetRelatedEntity<EntityModels.Contact>("opportunity_customer_contacts", null);
			}
			set
			{
				this.OnPropertyChanging("opportunity_customer_contacts");
				this.SetRelatedEntity<EntityModels.Contact>("opportunity_customer_contacts", null, value);
				this.OnPropertyChanged("opportunity_customer_contacts");
			}
		}
		
		/// <summary>
		/// N:1 opportunity_owning_user
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_owning_user")]
		public EntityModels.SystemUser opportunity_owning_user
		{
			get
			{
				return this.GetRelatedEntity<EntityModels.SystemUser>("opportunity_owning_user", null);
			}
		}
		
		/// <summary>
		/// N:1 opportunity_parent_account
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentaccountid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_parent_account")]
		public EntityModels.Account opportunity_parent_account
		{
			get
			{
				return this.GetRelatedEntity<EntityModels.Account>("opportunity_parent_account", null);
			}
			set
			{
				this.OnPropertyChanging("opportunity_parent_account");
				this.SetRelatedEntity<EntityModels.Account>("opportunity_parent_account", null, value);
				this.OnPropertyChanged("opportunity_parent_account");
			}
		}
		
		/// <summary>
		/// N:1 opportunity_parent_contact
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentcontactid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_parent_contact")]
		public EntityModels.Contact opportunity_parent_contact
		{
			get
			{
				return this.GetRelatedEntity<EntityModels.Contact>("opportunity_parent_contact", null);
			}
			set
			{
				this.OnPropertyChanging("opportunity_parent_contact");
				this.SetRelatedEntity<EntityModels.Contact>("opportunity_parent_contact", null, value);
				this.OnPropertyChanged("opportunity_parent_contact");
			}
		}
	}
}
