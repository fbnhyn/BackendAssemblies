namespace EntityModels
{

	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("account")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.1.0.82")]
	public partial class Account : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public Account() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "account";
		
		public const string EntityLogicalCollectionName = "accounts";
		
		public const string EntitySetName = "accounts";
		
		public const int EntityTypeCode = 1;
		
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
		/// Select a category to indicate whether the customer account is standard or preferred.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountcategorycode")]
		public System.Nullable<EntityModels.account_accountcategorycode> AccountCategoryCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("accountcategorycode");
				if ((optionSet != null))
				{
					return ((EntityModels.account_accountcategorycode)(System.Enum.ToObject(typeof(EntityModels.account_accountcategorycode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("AccountCategoryCode");
				if ((value == null))
				{
					this.SetAttributeValue("accountcategorycode", null);
				}
				else
				{
					this.SetAttributeValue("accountcategorycode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("AccountCategoryCode");
			}
		}
		
		/// <summary>
		/// Select a classification code to indicate the potential value of the customer account based on the projected return on investment, cooperation level, sales cycle length or other criteria.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountclassificationcode")]
		public System.Nullable<EntityModels.account_accountclassificationcode> AccountClassificationCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("accountclassificationcode");
				if ((optionSet != null))
				{
					return ((EntityModels.account_accountclassificationcode)(System.Enum.ToObject(typeof(EntityModels.account_accountclassificationcode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("AccountClassificationCode");
				if ((value == null))
				{
					this.SetAttributeValue("accountclassificationcode", null);
				}
				else
				{
					this.SetAttributeValue("accountclassificationcode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("AccountClassificationCode");
			}
		}
		
		/// <summary>
		/// Unique identifier of the account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountid")]
		public System.Nullable<System.Guid> AccountId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("accountid");
			}
			set
			{
				this.OnPropertyChanging("AccountId");
				this.SetAttributeValue("accountid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("AccountId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.AccountId = value;
			}
		}
		
		/// <summary>
		/// Type an ID number or code for the account to quickly search and identify the account in system views.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountnumber")]
		public string AccountNumber
		{
			get
			{
				return this.GetAttributeValue<string>("accountnumber");
			}
			set
			{
				this.OnPropertyChanging("AccountNumber");
				this.SetAttributeValue("accountnumber", value);
				this.OnPropertyChanged("AccountNumber");
			}
		}
		
		/// <summary>
		/// Select a rating to indicate the value of the customer account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountratingcode")]
		public System.Nullable<EntityModels.account_accountratingcode> AccountRatingCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("accountratingcode");
				if ((optionSet != null))
				{
					return ((EntityModels.account_accountratingcode)(System.Enum.ToObject(typeof(EntityModels.account_accountratingcode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("AccountRatingCode");
				if ((value == null))
				{
					this.SetAttributeValue("accountratingcode", null);
				}
				else
				{
					this.SetAttributeValue("accountratingcode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("AccountRatingCode");
			}
		}
		
		/// <summary>
		/// Unique identifier for address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_addressid")]
		public System.Nullable<System.Guid> Address1_AddressId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("address1_addressid");
			}
			set
			{
				this.OnPropertyChanging("Address1_AddressId");
				this.SetAttributeValue("address1_addressid", value);
				this.OnPropertyChanged("Address1_AddressId");
			}
		}
		
		/// <summary>
		/// Select the primary address type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_addresstypecode")]
		public System.Nullable<EntityModels.account_address1_addresstypecode> Address1_AddressTypeCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_addresstypecode");
				if ((optionSet != null))
				{
					return ((EntityModels.account_address1_addresstypecode)(System.Enum.ToObject(typeof(EntityModels.account_address1_addresstypecode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("Address1_AddressTypeCode");
				if ((value == null))
				{
					this.SetAttributeValue("address1_addresstypecode", null);
				}
				else
				{
					this.SetAttributeValue("address1_addresstypecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("Address1_AddressTypeCode");
			}
		}
		
		/// <summary>
		/// Type the city for the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_city")]
		public string Address1_City
		{
			get
			{
				return this.GetAttributeValue<string>("address1_city");
			}
			set
			{
				this.OnPropertyChanging("Address1_City");
				this.SetAttributeValue("address1_city", value);
				this.OnPropertyChanged("Address1_City");
			}
		}
		
		/// <summary>
		/// Shows the complete primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_composite")]
		public string Address1_Composite
		{
			get
			{
				return this.GetAttributeValue<string>("address1_composite");
			}
		}
		
		/// <summary>
		/// Type the country or region for the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_country")]
		public string Address1_Country
		{
			get
			{
				return this.GetAttributeValue<string>("address1_country");
			}
			set
			{
				this.OnPropertyChanging("Address1_Country");
				this.SetAttributeValue("address1_country", value);
				this.OnPropertyChanged("Address1_Country");
			}
		}
		
		/// <summary>
		/// Type the county for the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_county")]
		public string Address1_County
		{
			get
			{
				return this.GetAttributeValue<string>("address1_county");
			}
			set
			{
				this.OnPropertyChanging("Address1_County");
				this.SetAttributeValue("address1_county", value);
				this.OnPropertyChanged("Address1_County");
			}
		}
		
		/// <summary>
		/// Type the fax number associated with the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_fax")]
		public string Address1_Fax
		{
			get
			{
				return this.GetAttributeValue<string>("address1_fax");
			}
			set
			{
				this.OnPropertyChanging("Address1_Fax");
				this.SetAttributeValue("address1_fax", value);
				this.OnPropertyChanged("Address1_Fax");
			}
		}
		
		/// <summary>
		/// Select the freight terms for the primary address to make sure shipping orders are processed correctly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_freighttermscode")]
		public System.Nullable<EntityModels.account_address1_freighttermscode> Address1_FreightTermsCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_freighttermscode");
				if ((optionSet != null))
				{
					return ((EntityModels.account_address1_freighttermscode)(System.Enum.ToObject(typeof(EntityModels.account_address1_freighttermscode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("Address1_FreightTermsCode");
				if ((value == null))
				{
					this.SetAttributeValue("address1_freighttermscode", null);
				}
				else
				{
					this.SetAttributeValue("address1_freighttermscode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("Address1_FreightTermsCode");
			}
		}
		
		/// <summary>
		/// Type the latitude value for the primary address for use in mapping and other applications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_latitude")]
		public System.Nullable<double> Address1_Latitude
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address1_latitude");
			}
			set
			{
				this.OnPropertyChanging("Address1_Latitude");
				this.SetAttributeValue("address1_latitude", value);
				this.OnPropertyChanged("Address1_Latitude");
			}
		}
		
		/// <summary>
		/// Type the first line of the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line1")]
		public string Address1_Line1
		{
			get
			{
				return this.GetAttributeValue<string>("address1_line1");
			}
			set
			{
				this.OnPropertyChanging("Address1_Line1");
				this.SetAttributeValue("address1_line1", value);
				this.OnPropertyChanged("Address1_Line1");
			}
		}
		
		/// <summary>
		/// Type the second line of the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line2")]
		public string Address1_Line2
		{
			get
			{
				return this.GetAttributeValue<string>("address1_line2");
			}
			set
			{
				this.OnPropertyChanging("Address1_Line2");
				this.SetAttributeValue("address1_line2", value);
				this.OnPropertyChanged("Address1_Line2");
			}
		}
		
		/// <summary>
		/// Type the third line of the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line3")]
		public string Address1_Line3
		{
			get
			{
				return this.GetAttributeValue<string>("address1_line3");
			}
			set
			{
				this.OnPropertyChanging("Address1_Line3");
				this.SetAttributeValue("address1_line3", value);
				this.OnPropertyChanged("Address1_Line3");
			}
		}
		
		/// <summary>
		/// Type the longitude value for the primary address for use in mapping and other applications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_longitude")]
		public System.Nullable<double> Address1_Longitude
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address1_longitude");
			}
			set
			{
				this.OnPropertyChanging("Address1_Longitude");
				this.SetAttributeValue("address1_longitude", value);
				this.OnPropertyChanged("Address1_Longitude");
			}
		}
		
		/// <summary>
		/// Type a descriptive name for the primary address, such as Corporate Headquarters.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_name")]
		public string Address1_Name
		{
			get
			{
				return this.GetAttributeValue<string>("address1_name");
			}
			set
			{
				this.OnPropertyChanging("Address1_Name");
				this.SetAttributeValue("address1_name", value);
				this.OnPropertyChanged("Address1_Name");
			}
		}
		
		/// <summary>
		/// Type the ZIP Code or postal code for the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_postalcode")]
		public string Address1_PostalCode
		{
			get
			{
				return this.GetAttributeValue<string>("address1_postalcode");
			}
			set
			{
				this.OnPropertyChanging("Address1_PostalCode");
				this.SetAttributeValue("address1_postalcode", value);
				this.OnPropertyChanged("Address1_PostalCode");
			}
		}
		
		/// <summary>
		/// Type the post office box number of the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_postofficebox")]
		public string Address1_PostOfficeBox
		{
			get
			{
				return this.GetAttributeValue<string>("address1_postofficebox");
			}
			set
			{
				this.OnPropertyChanging("Address1_PostOfficeBox");
				this.SetAttributeValue("address1_postofficebox", value);
				this.OnPropertyChanged("Address1_PostOfficeBox");
			}
		}
		
		/// <summary>
		/// Type the name of the main contact at the account's primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_primarycontactname")]
		public string Address1_PrimaryContactName
		{
			get
			{
				return this.GetAttributeValue<string>("address1_primarycontactname");
			}
			set
			{
				this.OnPropertyChanging("Address1_PrimaryContactName");
				this.SetAttributeValue("address1_primarycontactname", value);
				this.OnPropertyChanged("Address1_PrimaryContactName");
			}
		}
		
		/// <summary>
		/// Select a shipping method for deliveries sent to this address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_shippingmethodcode")]
		public System.Nullable<EntityModels.account_address1_shippingmethodcode> Address1_ShippingMethodCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_shippingmethodcode");
				if ((optionSet != null))
				{
					return ((EntityModels.account_address1_shippingmethodcode)(System.Enum.ToObject(typeof(EntityModels.account_address1_shippingmethodcode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("Address1_ShippingMethodCode");
				if ((value == null))
				{
					this.SetAttributeValue("address1_shippingmethodcode", null);
				}
				else
				{
					this.SetAttributeValue("address1_shippingmethodcode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("Address1_ShippingMethodCode");
			}
		}
		
		/// <summary>
		/// Type the state or province of the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_stateorprovince")]
		public string Address1_StateOrProvince
		{
			get
			{
				return this.GetAttributeValue<string>("address1_stateorprovince");
			}
			set
			{
				this.OnPropertyChanging("Address1_StateOrProvince");
				this.SetAttributeValue("address1_stateorprovince", value);
				this.OnPropertyChanged("Address1_StateOrProvince");
			}
		}
		
		/// <summary>
		/// Type the main phone number associated with the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone1")]
		public string Address1_Telephone1
		{
			get
			{
				return this.GetAttributeValue<string>("address1_telephone1");
			}
			set
			{
				this.OnPropertyChanging("Address1_Telephone1");
				this.SetAttributeValue("address1_telephone1", value);
				this.OnPropertyChanged("Address1_Telephone1");
			}
		}
		
		/// <summary>
		/// Type a second phone number associated with the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone2")]
		public string Address1_Telephone2
		{
			get
			{
				return this.GetAttributeValue<string>("address1_telephone2");
			}
			set
			{
				this.OnPropertyChanging("Address1_Telephone2");
				this.SetAttributeValue("address1_telephone2", value);
				this.OnPropertyChanged("Address1_Telephone2");
			}
		}
		
		/// <summary>
		/// Type a third phone number associated with the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone3")]
		public string Address1_Telephone3
		{
			get
			{
				return this.GetAttributeValue<string>("address1_telephone3");
			}
			set
			{
				this.OnPropertyChanging("Address1_Telephone3");
				this.SetAttributeValue("address1_telephone3", value);
				this.OnPropertyChanged("Address1_Telephone3");
			}
		}
		
		/// <summary>
		/// Type the UPS zone of the primary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_upszone")]
		public string Address1_UPSZone
		{
			get
			{
				return this.GetAttributeValue<string>("address1_upszone");
			}
			set
			{
				this.OnPropertyChanging("Address1_UPSZone");
				this.SetAttributeValue("address1_upszone", value);
				this.OnPropertyChanged("Address1_UPSZone");
			}
		}
		
		/// <summary>
		/// Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_utcoffset")]
		public System.Nullable<int> Address1_UTCOffset
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("address1_utcoffset");
			}
			set
			{
				this.OnPropertyChanging("Address1_UTCOffset");
				this.SetAttributeValue("address1_utcoffset", value);
				this.OnPropertyChanged("Address1_UTCOffset");
			}
		}
		
		/// <summary>
		/// Unique identifier for address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_addressid")]
		public System.Nullable<System.Guid> Address2_AddressId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("address2_addressid");
			}
			set
			{
				this.OnPropertyChanging("Address2_AddressId");
				this.SetAttributeValue("address2_addressid", value);
				this.OnPropertyChanged("Address2_AddressId");
			}
		}
		
		/// <summary>
		/// Select the secondary address type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_addresstypecode")]
		public System.Nullable<EntityModels.account_address2_addresstypecode> Address2_AddressTypeCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_addresstypecode");
				if ((optionSet != null))
				{
					return ((EntityModels.account_address2_addresstypecode)(System.Enum.ToObject(typeof(EntityModels.account_address2_addresstypecode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("Address2_AddressTypeCode");
				if ((value == null))
				{
					this.SetAttributeValue("address2_addresstypecode", null);
				}
				else
				{
					this.SetAttributeValue("address2_addresstypecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("Address2_AddressTypeCode");
			}
		}
		
		/// <summary>
		/// Type the city for the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_city")]
		public string Address2_City
		{
			get
			{
				return this.GetAttributeValue<string>("address2_city");
			}
			set
			{
				this.OnPropertyChanging("Address2_City");
				this.SetAttributeValue("address2_city", value);
				this.OnPropertyChanged("Address2_City");
			}
		}
		
		/// <summary>
		/// Shows the complete secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_composite")]
		public string Address2_Composite
		{
			get
			{
				return this.GetAttributeValue<string>("address2_composite");
			}
		}
		
		/// <summary>
		/// Type the country or region for the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_country")]
		public string Address2_Country
		{
			get
			{
				return this.GetAttributeValue<string>("address2_country");
			}
			set
			{
				this.OnPropertyChanging("Address2_Country");
				this.SetAttributeValue("address2_country", value);
				this.OnPropertyChanged("Address2_Country");
			}
		}
		
		/// <summary>
		/// Type the county for the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_county")]
		public string Address2_County
		{
			get
			{
				return this.GetAttributeValue<string>("address2_county");
			}
			set
			{
				this.OnPropertyChanging("Address2_County");
				this.SetAttributeValue("address2_county", value);
				this.OnPropertyChanged("Address2_County");
			}
		}
		
		/// <summary>
		/// Type the fax number associated with the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_fax")]
		public string Address2_Fax
		{
			get
			{
				return this.GetAttributeValue<string>("address2_fax");
			}
			set
			{
				this.OnPropertyChanging("Address2_Fax");
				this.SetAttributeValue("address2_fax", value);
				this.OnPropertyChanged("Address2_Fax");
			}
		}
		
		/// <summary>
		/// Select the freight terms for the secondary address to make sure shipping orders are processed correctly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_freighttermscode")]
		public System.Nullable<EntityModels.account_address2_freighttermscode> Address2_FreightTermsCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_freighttermscode");
				if ((optionSet != null))
				{
					return ((EntityModels.account_address2_freighttermscode)(System.Enum.ToObject(typeof(EntityModels.account_address2_freighttermscode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("Address2_FreightTermsCode");
				if ((value == null))
				{
					this.SetAttributeValue("address2_freighttermscode", null);
				}
				else
				{
					this.SetAttributeValue("address2_freighttermscode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("Address2_FreightTermsCode");
			}
		}
		
		/// <summary>
		/// Type the latitude value for the secondary address for use in mapping and other applications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_latitude")]
		public System.Nullable<double> Address2_Latitude
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address2_latitude");
			}
			set
			{
				this.OnPropertyChanging("Address2_Latitude");
				this.SetAttributeValue("address2_latitude", value);
				this.OnPropertyChanged("Address2_Latitude");
			}
		}
		
		/// <summary>
		/// Type the first line of the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line1")]
		public string Address2_Line1
		{
			get
			{
				return this.GetAttributeValue<string>("address2_line1");
			}
			set
			{
				this.OnPropertyChanging("Address2_Line1");
				this.SetAttributeValue("address2_line1", value);
				this.OnPropertyChanged("Address2_Line1");
			}
		}
		
		/// <summary>
		/// Type the second line of the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line2")]
		public string Address2_Line2
		{
			get
			{
				return this.GetAttributeValue<string>("address2_line2");
			}
			set
			{
				this.OnPropertyChanging("Address2_Line2");
				this.SetAttributeValue("address2_line2", value);
				this.OnPropertyChanged("Address2_Line2");
			}
		}
		
		/// <summary>
		/// Type the third line of the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line3")]
		public string Address2_Line3
		{
			get
			{
				return this.GetAttributeValue<string>("address2_line3");
			}
			set
			{
				this.OnPropertyChanging("Address2_Line3");
				this.SetAttributeValue("address2_line3", value);
				this.OnPropertyChanged("Address2_Line3");
			}
		}
		
		/// <summary>
		/// Type the longitude value for the secondary address for use in mapping and other applications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_longitude")]
		public System.Nullable<double> Address2_Longitude
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address2_longitude");
			}
			set
			{
				this.OnPropertyChanging("Address2_Longitude");
				this.SetAttributeValue("address2_longitude", value);
				this.OnPropertyChanged("Address2_Longitude");
			}
		}
		
		/// <summary>
		/// Type a descriptive name for the secondary address, such as Corporate Headquarters.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_name")]
		public string Address2_Name
		{
			get
			{
				return this.GetAttributeValue<string>("address2_name");
			}
			set
			{
				this.OnPropertyChanging("Address2_Name");
				this.SetAttributeValue("address2_name", value);
				this.OnPropertyChanged("Address2_Name");
			}
		}
		
		/// <summary>
		/// Type the ZIP Code or postal code for the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_postalcode")]
		public string Address2_PostalCode
		{
			get
			{
				return this.GetAttributeValue<string>("address2_postalcode");
			}
			set
			{
				this.OnPropertyChanging("Address2_PostalCode");
				this.SetAttributeValue("address2_postalcode", value);
				this.OnPropertyChanged("Address2_PostalCode");
			}
		}
		
		/// <summary>
		/// Type the post office box number of the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_postofficebox")]
		public string Address2_PostOfficeBox
		{
			get
			{
				return this.GetAttributeValue<string>("address2_postofficebox");
			}
			set
			{
				this.OnPropertyChanging("Address2_PostOfficeBox");
				this.SetAttributeValue("address2_postofficebox", value);
				this.OnPropertyChanged("Address2_PostOfficeBox");
			}
		}
		
		/// <summary>
		/// Type the name of the main contact at the account's secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_primarycontactname")]
		public string Address2_PrimaryContactName
		{
			get
			{
				return this.GetAttributeValue<string>("address2_primarycontactname");
			}
			set
			{
				this.OnPropertyChanging("Address2_PrimaryContactName");
				this.SetAttributeValue("address2_primarycontactname", value);
				this.OnPropertyChanged("Address2_PrimaryContactName");
			}
		}
		
		/// <summary>
		/// Select a shipping method for deliveries sent to this address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_shippingmethodcode")]
		public System.Nullable<EntityModels.account_address2_shippingmethodcode> Address2_ShippingMethodCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_shippingmethodcode");
				if ((optionSet != null))
				{
					return ((EntityModels.account_address2_shippingmethodcode)(System.Enum.ToObject(typeof(EntityModels.account_address2_shippingmethodcode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("Address2_ShippingMethodCode");
				if ((value == null))
				{
					this.SetAttributeValue("address2_shippingmethodcode", null);
				}
				else
				{
					this.SetAttributeValue("address2_shippingmethodcode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("Address2_ShippingMethodCode");
			}
		}
		
		/// <summary>
		/// Type the state or province of the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_stateorprovince")]
		public string Address2_StateOrProvince
		{
			get
			{
				return this.GetAttributeValue<string>("address2_stateorprovince");
			}
			set
			{
				this.OnPropertyChanging("Address2_StateOrProvince");
				this.SetAttributeValue("address2_stateorprovince", value);
				this.OnPropertyChanged("Address2_StateOrProvince");
			}
		}
		
		/// <summary>
		/// Type the main phone number associated with the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone1")]
		public string Address2_Telephone1
		{
			get
			{
				return this.GetAttributeValue<string>("address2_telephone1");
			}
			set
			{
				this.OnPropertyChanging("Address2_Telephone1");
				this.SetAttributeValue("address2_telephone1", value);
				this.OnPropertyChanged("Address2_Telephone1");
			}
		}
		
		/// <summary>
		/// Type a second phone number associated with the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone2")]
		public string Address2_Telephone2
		{
			get
			{
				return this.GetAttributeValue<string>("address2_telephone2");
			}
			set
			{
				this.OnPropertyChanging("Address2_Telephone2");
				this.SetAttributeValue("address2_telephone2", value);
				this.OnPropertyChanged("Address2_Telephone2");
			}
		}
		
		/// <summary>
		/// Type a third phone number associated with the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone3")]
		public string Address2_Telephone3
		{
			get
			{
				return this.GetAttributeValue<string>("address2_telephone3");
			}
			set
			{
				this.OnPropertyChanging("Address2_Telephone3");
				this.SetAttributeValue("address2_telephone3", value);
				this.OnPropertyChanged("Address2_Telephone3");
			}
		}
		
		/// <summary>
		/// Type the UPS zone of the secondary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_upszone")]
		public string Address2_UPSZone
		{
			get
			{
				return this.GetAttributeValue<string>("address2_upszone");
			}
			set
			{
				this.OnPropertyChanging("Address2_UPSZone");
				this.SetAttributeValue("address2_upszone", value);
				this.OnPropertyChanged("Address2_UPSZone");
			}
		}
		
		/// <summary>
		/// Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_utcoffset")]
		public System.Nullable<int> Address2_UTCOffset
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("address2_utcoffset");
			}
			set
			{
				this.OnPropertyChanging("Address2_UTCOffset");
				this.SetAttributeValue("address2_utcoffset", value);
				this.OnPropertyChanged("Address2_UTCOffset");
			}
		}
		
		/// <summary>
		/// For system use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging30")]
		public Microsoft.Xrm.Sdk.Money Aging30
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging30");
			}
		}
		
		/// <summary>
		/// The base currency equivalent of the aging 30 field.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging30_base")]
		public Microsoft.Xrm.Sdk.Money Aging30_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging30_base");
			}
		}
		
		/// <summary>
		/// For system use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging60")]
		public Microsoft.Xrm.Sdk.Money Aging60
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging60");
			}
		}
		
		/// <summary>
		/// The base currency equivalent of the aging 60 field.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging60_base")]
		public Microsoft.Xrm.Sdk.Money Aging60_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging60_base");
			}
		}
		
		/// <summary>
		/// For system use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging90")]
		public Microsoft.Xrm.Sdk.Money Aging90
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging90");
			}
		}
		
		/// <summary>
		/// The base currency equivalent of the aging 90 field.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging90_base")]
		public Microsoft.Xrm.Sdk.Money Aging90_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging90_base");
			}
		}
		
		/// <summary>
		/// Select the legal designation or other business type of the account for contracts or reporting purposes.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businesstypecode")]
		public System.Nullable<EntityModels.account_businesstypecode> BusinessTypeCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("businesstypecode");
				if ((optionSet != null))
				{
					return ((EntityModels.account_businesstypecode)(System.Enum.ToObject(typeof(EntityModels.account_businesstypecode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("BusinessTypeCode");
				if ((value == null))
				{
					this.SetAttributeValue("businesstypecode", null);
				}
				else
				{
					this.SetAttributeValue("businesstypecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("BusinessTypeCode");
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
		/// Shows the external party who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdbyexternalparty")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedByExternalParty
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdbyexternalparty");
			}
		}
		
		/// <summary>
		/// Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.
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
		/// Type the credit limit of the account. This is a useful reference when you address invoice and accounting issues with the customer.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("creditlimit")]
		public Microsoft.Xrm.Sdk.Money CreditLimit
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("creditlimit");
			}
			set
			{
				this.OnPropertyChanging("CreditLimit");
				this.SetAttributeValue("creditlimit", value);
				this.OnPropertyChanged("CreditLimit");
			}
		}
		
		/// <summary>
		/// Shows the credit limit converted to the system's default base currency for reporting purposes.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("creditlimit_base")]
		public Microsoft.Xrm.Sdk.Money CreditLimit_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("creditlimit_base");
			}
		}
		
		/// <summary>
		/// Select whether the credit for the account is on hold. This is a useful reference while addressing the invoice and accounting issues with the customer.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("creditonhold")]
		public System.Nullable<bool> CreditOnHold
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("creditonhold");
			}
			set
			{
				this.OnPropertyChanging("CreditOnHold");
				this.SetAttributeValue("creditonhold", value);
				this.OnPropertyChanged("CreditOnHold");
			}
		}
		
		/// <summary>
		/// Select the size category or range of the account for segmentation and reporting purposes.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customersizecode")]
		public System.Nullable<EntityModels.account_customersizecode> CustomerSizeCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("customersizecode");
				if ((optionSet != null))
				{
					return ((EntityModels.account_customersizecode)(System.Enum.ToObject(typeof(EntityModels.account_customersizecode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("CustomerSizeCode");
				if ((value == null))
				{
					this.SetAttributeValue("customersizecode", null);
				}
				else
				{
					this.SetAttributeValue("customersizecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("CustomerSizeCode");
			}
		}
		
		/// <summary>
		/// Select the category that best describes the relationship between the account and your organization.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customertypecode")]
		public System.Nullable<EntityModels.account_customertypecode> CustomerTypeCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("customertypecode");
				if ((optionSet != null))
				{
					return ((EntityModels.account_customertypecode)(System.Enum.ToObject(typeof(EntityModels.account_customertypecode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("CustomerTypeCode");
				if ((value == null))
				{
					this.SetAttributeValue("customertypecode", null);
				}
				else
				{
					this.SetAttributeValue("customertypecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("CustomerTypeCode");
			}
		}
		
		/// <summary>
		/// Choose the default price list associated with the account to make sure the correct product prices for this customer are applied in sales opportunities, quotes, and orders.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultpricelevelid")]
		public Microsoft.Xrm.Sdk.EntityReference DefaultPriceLevelId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("defaultpricelevelid");
			}
			set
			{
				this.OnPropertyChanging("DefaultPriceLevelId");
				this.SetAttributeValue("defaultpricelevelid", value);
				this.OnPropertyChanged("DefaultPriceLevelId");
			}
		}
		
		/// <summary>
		/// Type additional information to describe the account, such as an excerpt from the company's website.
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
		/// Select whether the account allows bulk email sent through campaigns. If Do Not Allow is selected, the account can be added to marketing lists, but is excluded from email.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotbulkemail")]
		public System.Nullable<bool> DoNotBulkEMail
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotbulkemail");
			}
			set
			{
				this.OnPropertyChanging("DoNotBulkEMail");
				this.SetAttributeValue("donotbulkemail", value);
				this.OnPropertyChanged("DoNotBulkEMail");
			}
		}
		
		/// <summary>
		/// Select whether the account allows bulk postal mail sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the account can be added to marketing lists, but will be excluded from the postal mail.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotbulkpostalmail")]
		public System.Nullable<bool> DoNotBulkPostalMail
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotbulkpostalmail");
			}
			set
			{
				this.OnPropertyChanging("DoNotBulkPostalMail");
				this.SetAttributeValue("donotbulkpostalmail", value);
				this.OnPropertyChanged("DoNotBulkPostalMail");
			}
		}
		
		/// <summary>
		/// Select whether the account allows direct email sent from Microsoft Dynamics 365.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotemail")]
		public System.Nullable<bool> DoNotEMail
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotemail");
			}
			set
			{
				this.OnPropertyChanging("DoNotEMail");
				this.SetAttributeValue("donotemail", value);
				this.OnPropertyChanged("DoNotEMail");
			}
		}
		
		/// <summary>
		/// Select whether the account allows faxes. If Do Not Allow is selected, the account will be excluded from fax activities distributed in marketing campaigns.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotfax")]
		public System.Nullable<bool> DoNotFax
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotfax");
			}
			set
			{
				this.OnPropertyChanging("DoNotFax");
				this.SetAttributeValue("donotfax", value);
				this.OnPropertyChanged("DoNotFax");
			}
		}
		
		/// <summary>
		/// Select whether the account allows phone calls. If Do Not Allow is selected, the account will be excluded from phone call activities distributed in marketing campaigns.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotphone")]
		public System.Nullable<bool> DoNotPhone
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotphone");
			}
			set
			{
				this.OnPropertyChanging("DoNotPhone");
				this.SetAttributeValue("donotphone", value);
				this.OnPropertyChanged("DoNotPhone");
			}
		}
		
		/// <summary>
		/// Select whether the account allows direct mail. If Do Not Allow is selected, the account will be excluded from letter activities distributed in marketing campaigns.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotpostalmail")]
		public System.Nullable<bool> DoNotPostalMail
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotpostalmail");
			}
			set
			{
				this.OnPropertyChanging("DoNotPostalMail");
				this.SetAttributeValue("donotpostalmail", value);
				this.OnPropertyChanged("DoNotPostalMail");
			}
		}
		
		/// <summary>
		/// Select whether the account accepts marketing materials, such as brochures or catalogs.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotsendmm")]
		public System.Nullable<bool> DoNotSendMM
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotsendmm");
			}
			set
			{
				this.OnPropertyChanging("DoNotSendMM");
				this.SetAttributeValue("donotsendmm", value);
				this.OnPropertyChanged("DoNotSendMM");
			}
		}
		
		/// <summary>
		/// Type the primary email address for the account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress1")]
		public string EMailAddress1
		{
			get
			{
				return this.GetAttributeValue<string>("emailaddress1");
			}
			set
			{
				this.OnPropertyChanging("EMailAddress1");
				this.SetAttributeValue("emailaddress1", value);
				this.OnPropertyChanged("EMailAddress1");
			}
		}
		
		/// <summary>
		/// Type the secondary email address for the account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress2")]
		public string EMailAddress2
		{
			get
			{
				return this.GetAttributeValue<string>("emailaddress2");
			}
			set
			{
				this.OnPropertyChanging("EMailAddress2");
				this.SetAttributeValue("emailaddress2", value);
				this.OnPropertyChanged("EMailAddress2");
			}
		}
		
		/// <summary>
		/// Type an alternate email address for the account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress3")]
		public string EMailAddress3
		{
			get
			{
				return this.GetAttributeValue<string>("emailaddress3");
			}
			set
			{
				this.OnPropertyChanging("EMailAddress3");
				this.SetAttributeValue("emailaddress3", value);
				this.OnPropertyChanged("EMailAddress3");
			}
		}
		
		/// <summary>
		/// Shows the default image for the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage")]
		public byte[] EntityImage
		{
			get
			{
				return this.GetAttributeValue<byte[]>("entityimage");
			}
			set
			{
				this.OnPropertyChanging("EntityImage");
				this.SetAttributeValue("entityimage", value);
				this.OnPropertyChanged("EntityImage");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_timestamp")]
		public System.Nullable<long> EntityImage_Timestamp
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("entityimage_timestamp");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_url")]
		public string EntityImage_URL
		{
			get
			{
				return this.GetAttributeValue<string>("entityimage_url");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimageid")]
		public System.Nullable<System.Guid> EntityImageId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("entityimageid");
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
		/// Type the fax number for the account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fax")]
		public string Fax
		{
			get
			{
				return this.GetAttributeValue<string>("fax");
			}
			set
			{
				this.OnPropertyChanging("Fax");
				this.SetAttributeValue("fax", value);
				this.OnPropertyChanged("Fax");
			}
		}
		
		/// <summary>
		/// Information about whether to allow following email activity like opens, attachment views and link clicks for emails sent to the account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("followemail")]
		public System.Nullable<bool> FollowEmail
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("followemail");
			}
			set
			{
				this.OnPropertyChanging("FollowEmail");
				this.SetAttributeValue("followemail", value);
				this.OnPropertyChanged("FollowEmail");
			}
		}
		
		/// <summary>
		/// Type the URL for the account's FTP site to enable users to access data and share documents.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ftpsiteurl")]
		public string FtpSiteURL
		{
			get
			{
				return this.GetAttributeValue<string>("ftpsiteurl");
			}
			set
			{
				this.OnPropertyChanging("FtpSiteURL");
				this.SetAttributeValue("ftpsiteurl", value);
				this.OnPropertyChanged("FtpSiteURL");
			}
		}
		
		/// <summary>
		/// Unique identifier of the data import or data migration that created this record.
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
		/// Select the account's primary industry for use in marketing segmentation and demographic analysis.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("industrycode")]
		public System.Nullable<EntityModels.account_industrycode> IndustryCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("industrycode");
				if ((optionSet != null))
				{
					return ((EntityModels.account_industrycode)(System.Enum.ToObject(typeof(EntityModels.account_industrycode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("IndustryCode");
				if ((value == null))
				{
					this.SetAttributeValue("industrycode", null);
				}
				else
				{
					this.SetAttributeValue("industrycode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("IndustryCode");
			}
		}
		
		/// <summary>
		/// Contains the date and time stamp of the last on hold time.
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
		/// Shows the date when the account was last included in a marketing campaign or quick campaign.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastusedincampaign")]
		public System.Nullable<System.DateTime> LastUsedInCampaign
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastusedincampaign");
			}
			set
			{
				this.OnPropertyChanging("LastUsedInCampaign");
				this.SetAttributeValue("lastusedincampaign", value);
				this.OnPropertyChanged("LastUsedInCampaign");
			}
		}
		
		/// <summary>
		/// Type the market capitalization of the account to identify the company's equity, used as an indicator in financial performance analysis.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("marketcap")]
		public Microsoft.Xrm.Sdk.Money MarketCap
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("marketcap");
			}
			set
			{
				this.OnPropertyChanging("MarketCap");
				this.SetAttributeValue("marketcap", value);
				this.OnPropertyChanged("MarketCap");
			}
		}
		
		/// <summary>
		/// Shows the market capitalization converted to the system's default base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("marketcap_base")]
		public Microsoft.Xrm.Sdk.Money MarketCap_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("marketcap_base");
			}
		}
		
		/// <summary>
		/// Whether is only for marketing
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("marketingonly")]
		public System.Nullable<bool> MarketingOnly
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("marketingonly");
			}
			set
			{
				this.OnPropertyChanging("MarketingOnly");
				this.SetAttributeValue("marketingonly", value);
				this.OnPropertyChanged("MarketingOnly");
			}
		}
		
		/// <summary>
		/// Shows the master account that the account was merged with.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("masterid")]
		public Microsoft.Xrm.Sdk.EntityReference MasterId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("masterid");
			}
		}
		
		/// <summary>
		/// Shows whether the account has been merged with another account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("merged")]
		public System.Nullable<bool> Merged
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("merged");
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
		/// Shows the external party who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedbyexternalparty")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedByExternalParty
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedbyexternalparty");
			}
		}
		
		/// <summary>
		/// Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.
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
		/// Shows who created the record on behalf of another user.
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
		/// Reference to an other account to be used for billing (only to be used if billing account differs)
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_billingaccount")]
		public Microsoft.Xrm.Sdk.EntityReference msdyn_BillingAccount
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_billingaccount");
			}
			set
			{
				this.OnPropertyChanging("msdyn_BillingAccount");
				this.SetAttributeValue("msdyn_billingaccount", value);
				this.OnPropertyChanged("msdyn_BillingAccount");
			}
		}
		
		/// <summary>
		/// External Account ID from other systems.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_externalaccountid")]
		public string msdyn_externalaccountid
		{
			get
			{
				return this.GetAttributeValue<string>("msdyn_externalaccountid");
			}
			set
			{
				this.OnPropertyChanging("msdyn_externalaccountid");
				this.SetAttributeValue("msdyn_externalaccountid", value);
				this.OnPropertyChanged("msdyn_externalaccountid");
			}
		}
		
		/// <summary>
		/// Describes whether account is opted out or not
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
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_preferredresource")]
		public Microsoft.Xrm.Sdk.EntityReference msdyn_PreferredResource
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_preferredresource");
			}
			set
			{
				this.OnPropertyChanging("msdyn_PreferredResource");
				this.SetAttributeValue("msdyn_preferredresource", value);
				this.OnPropertyChanged("msdyn_PreferredResource");
			}
		}
		
		/// <summary>
		/// Sales Acceleration Insights ID
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_salesaccelerationinsightid")]
		public Microsoft.Xrm.Sdk.EntityReference msdyn_salesaccelerationinsightid
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_salesaccelerationinsightid");
			}
			set
			{
				this.OnPropertyChanging("msdyn_salesaccelerationinsightid");
				this.SetAttributeValue("msdyn_salesaccelerationinsightid", value);
				this.OnPropertyChanged("msdyn_salesaccelerationinsightid");
			}
		}
		
		/// <summary>
		/// Default Sales Tax Code
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_salestaxcode")]
		public Microsoft.Xrm.Sdk.EntityReference msdyn_SalesTaxCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_salestaxcode");
			}
			set
			{
				this.OnPropertyChanging("msdyn_SalesTaxCode");
				this.SetAttributeValue("msdyn_salestaxcode", value);
				this.OnPropertyChanged("msdyn_SalesTaxCode");
			}
		}
		
		/// <summary>
		/// Unique identifier for Segment associated with account.
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
		/// The Service Territory this account belongs to. This is used to optimize scheduling and routing
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_serviceterritory")]
		public Microsoft.Xrm.Sdk.EntityReference msdyn_ServiceTerritory
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_serviceterritory");
			}
			set
			{
				this.OnPropertyChanging("msdyn_ServiceTerritory");
				this.SetAttributeValue("msdyn_serviceterritory", value);
				this.OnPropertyChanged("msdyn_ServiceTerritory");
			}
		}
		
		/// <summary>
		/// Select whether the account is tax exempt.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_taxexempt")]
		public System.Nullable<bool> msdyn_TaxExempt
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("msdyn_taxexempt");
			}
			set
			{
				this.OnPropertyChanging("msdyn_TaxExempt");
				this.SetAttributeValue("msdyn_taxexempt", value);
				this.OnPropertyChanged("msdyn_TaxExempt");
			}
		}
		
		/// <summary>
		/// Shows the government tax exempt number.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_taxexemptnumber")]
		public string msdyn_TaxExemptNumber
		{
			get
			{
				return this.GetAttributeValue<string>("msdyn_taxexemptnumber");
			}
			set
			{
				this.OnPropertyChanging("msdyn_TaxExemptNumber");
				this.SetAttributeValue("msdyn_taxexemptnumber", value);
				this.OnPropertyChanged("msdyn_TaxExemptNumber");
			}
		}
		
		/// <summary>
		/// Enter the travel charge to include on work orders. This value will be multiplied by the travel charge type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_travelcharge")]
		public Microsoft.Xrm.Sdk.Money msdyn_TravelCharge
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("msdyn_travelcharge");
			}
			set
			{
				this.OnPropertyChanging("msdyn_TravelCharge");
				this.SetAttributeValue("msdyn_travelcharge", value);
				this.OnPropertyChanged("msdyn_TravelCharge");
			}
		}
		
		/// <summary>
		/// Value of the Travel Charge in base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_travelcharge_base")]
		public Microsoft.Xrm.Sdk.Money msdyn_travelcharge_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("msdyn_travelcharge_base");
			}
		}
		
		/// <summary>
		/// Specify how travel is charged for this account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_travelchargetype")]
		public System.Nullable<EntityModels.msdyn_travelchargetype> msdyn_TravelChargeType
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("msdyn_travelchargetype");
				if ((optionSet != null))
				{
					return ((EntityModels.msdyn_travelchargetype)(System.Enum.ToObject(typeof(EntityModels.msdyn_travelchargetype), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("msdyn_TravelChargeType");
				if ((value == null))
				{
					this.SetAttributeValue("msdyn_travelchargetype", null);
				}
				else
				{
					this.SetAttributeValue("msdyn_travelchargetype", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("msdyn_TravelChargeType");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_workhourtemplate")]
		public Microsoft.Xrm.Sdk.EntityReference msdyn_workhourtemplate
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_workhourtemplate");
			}
			set
			{
				this.OnPropertyChanging("msdyn_workhourtemplate");
				this.SetAttributeValue("msdyn_workhourtemplate", value);
				this.OnPropertyChanged("msdyn_workhourtemplate");
			}
		}
		
		/// <summary>
		/// Shows the default instructions to show on new work orders.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_workorderinstructions")]
		public string msdyn_WorkOrderInstructions
		{
			get
			{
				return this.GetAttributeValue<string>("msdyn_workorderinstructions");
			}
			set
			{
				this.OnPropertyChanging("msdyn_WorkOrderInstructions");
				this.SetAttributeValue("msdyn_workorderinstructions", value);
				this.OnPropertyChanged("msdyn_WorkOrderInstructions");
			}
		}
		
		/// <summary>
		/// Captures the facebook id
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyusd_facebook")]
		public string msdyusd_Facebook
		{
			get
			{
				return this.GetAttributeValue<string>("msdyusd_facebook");
			}
			set
			{
				this.OnPropertyChanging("msdyusd_Facebook");
				this.SetAttributeValue("msdyusd_facebook", value);
				this.OnPropertyChanged("msdyusd_Facebook");
			}
		}
		
		/// <summary>
		/// Capture the twitter id
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyusd_twitter")]
		public string msdyusd_Twitter
		{
			get
			{
				return this.GetAttributeValue<string>("msdyusd_twitter");
			}
			set
			{
				this.OnPropertyChanging("msdyusd_Twitter");
				this.SetAttributeValue("msdyusd_twitter", value);
				this.OnPropertyChanged("msdyusd_Twitter");
			}
		}
		
		/// <summary>
		/// Type the company or business name.
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
		/// Type the number of employees that work at the account for use in marketing segmentation and demographic analysis.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("numberofemployees")]
		public System.Nullable<int> NumberOfEmployees
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("numberofemployees");
			}
			set
			{
				this.OnPropertyChanging("NumberOfEmployees");
				this.SetAttributeValue("numberofemployees", value);
				this.OnPropertyChanged("NumberOfEmployees");
			}
		}
		
		/// <summary>
		/// Shows how long, in minutes, that the record was on hold.
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
		/// Number of open opportunities against an account and its child accounts.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opendeals")]
		public System.Nullable<int> OpenDeals
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("opendeals");
			}
		}
		
		/// <summary>
		/// Last Updated time of rollup field Open Deals.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opendeals_date")]
		public System.Nullable<System.DateTime> OpenDeals_Date
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("opendeals_date");
			}
		}
		
		/// <summary>
		/// State of rollup field Open Deals.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opendeals_state")]
		public System.Nullable<int> OpenDeals_State
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("opendeals_state");
			}
		}
		
		/// <summary>
		/// Sum of open revenue against an account and its child accounts.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("openrevenue")]
		public Microsoft.Xrm.Sdk.Money OpenRevenue
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("openrevenue");
			}
		}
		
		/// <summary>
		/// Value of the Open Revenue in base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("openrevenue_base")]
		public Microsoft.Xrm.Sdk.Money OpenRevenue_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("openrevenue_base");
			}
		}
		
		/// <summary>
		/// Last Updated time of rollup field Open Revenue.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("openrevenue_date")]
		public System.Nullable<System.DateTime> OpenRevenue_Date
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("openrevenue_date");
			}
		}
		
		/// <summary>
		/// State of rollup field Open Revenue.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("openrevenue_state")]
		public System.Nullable<int> OpenRevenue_State
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("openrevenue_state");
			}
		}
		
		/// <summary>
		/// Shows the lead that the account was created from if the account was created by converting a lead in Microsoft Dynamics 365. This is used to relate the account to data on the originating lead for use in reporting and analytics.
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
		/// Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.
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
		/// Select the account's ownership structure, such as public or private.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownershipcode")]
		public System.Nullable<EntityModels.account_ownershipcode> OwnershipCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("ownershipcode");
				if ((optionSet != null))
				{
					return ((EntityModels.account_ownershipcode)(System.Enum.ToObject(typeof(EntityModels.account_ownershipcode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("OwnershipCode");
				if ((value == null))
				{
					this.SetAttributeValue("ownershipcode", null);
				}
				else
				{
					this.SetAttributeValue("ownershipcode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("OwnershipCode");
			}
		}
		
		/// <summary>
		/// Shows the business unit that the record owner belongs to.
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
		/// Unique identifier of the team who owns the account.
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
		/// Unique identifier of the user who owns the account.
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
		/// Choose the parent account associated with this account to show parent and child businesses in reporting and analytics.
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
		/// For system use only. Legacy Microsoft Dynamics CRM 3.0 workflow data.
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
		/// Select the payment terms to indicate when the customer needs to pay the total amount.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("paymenttermscode")]
		public System.Nullable<EntityModels.account_paymenttermscode> PaymentTermsCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("paymenttermscode");
				if ((optionSet != null))
				{
					return ((EntityModels.account_paymenttermscode)(System.Enum.ToObject(typeof(EntityModels.account_paymenttermscode), optionSet.Value)));
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
		/// Select the preferred day of the week for service appointments.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredappointmentdaycode")]
		public System.Nullable<EntityModels.account_preferredappointmentdaycode> PreferredAppointmentDayCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredappointmentdaycode");
				if ((optionSet != null))
				{
					return ((EntityModels.account_preferredappointmentdaycode)(System.Enum.ToObject(typeof(EntityModels.account_preferredappointmentdaycode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("PreferredAppointmentDayCode");
				if ((value == null))
				{
					this.SetAttributeValue("preferredappointmentdaycode", null);
				}
				else
				{
					this.SetAttributeValue("preferredappointmentdaycode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("PreferredAppointmentDayCode");
			}
		}
		
		/// <summary>
		/// Select the preferred time of day for service appointments.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredappointmenttimecode")]
		public System.Nullable<EntityModels.account_preferredappointmenttimecode> PreferredAppointmentTimeCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredappointmenttimecode");
				if ((optionSet != null))
				{
					return ((EntityModels.account_preferredappointmenttimecode)(System.Enum.ToObject(typeof(EntityModels.account_preferredappointmenttimecode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("PreferredAppointmentTimeCode");
				if ((value == null))
				{
					this.SetAttributeValue("preferredappointmenttimecode", null);
				}
				else
				{
					this.SetAttributeValue("preferredappointmenttimecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("PreferredAppointmentTimeCode");
			}
		}
		
		/// <summary>
		/// Select the preferred method of contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredcontactmethodcode")]
		public System.Nullable<EntityModels.account_preferredcontactmethodcode> PreferredContactMethodCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredcontactmethodcode");
				if ((optionSet != null))
				{
					return ((EntityModels.account_preferredcontactmethodcode)(System.Enum.ToObject(typeof(EntityModels.account_preferredcontactmethodcode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("PreferredContactMethodCode");
				if ((value == null))
				{
					this.SetAttributeValue("preferredcontactmethodcode", null);
				}
				else
				{
					this.SetAttributeValue("preferredcontactmethodcode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("PreferredContactMethodCode");
			}
		}
		
		/// <summary>
		/// Choose the account's preferred service facility or equipment to make sure services are scheduled correctly for the customer.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredequipmentid")]
		public Microsoft.Xrm.Sdk.EntityReference PreferredEquipmentId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("preferredequipmentid");
			}
			set
			{
				this.OnPropertyChanging("PreferredEquipmentId");
				this.SetAttributeValue("preferredequipmentid", value);
				this.OnPropertyChanged("PreferredEquipmentId");
			}
		}
		
		/// <summary>
		/// Choose the account's preferred service for reference when you schedule service activities.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredserviceid")]
		public Microsoft.Xrm.Sdk.EntityReference PreferredServiceId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("preferredserviceid");
			}
			set
			{
				this.OnPropertyChanging("PreferredServiceId");
				this.SetAttributeValue("preferredserviceid", value);
				this.OnPropertyChanged("PreferredServiceId");
			}
		}
		
		/// <summary>
		/// Choose the preferred service representative for reference when you schedule service activities for the account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredsystemuserid")]
		public Microsoft.Xrm.Sdk.EntityReference PreferredSystemUserId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("preferredsystemuserid");
			}
			set
			{
				this.OnPropertyChanging("PreferredSystemUserId");
				this.SetAttributeValue("preferredsystemuserid", value);
				this.OnPropertyChanged("PreferredSystemUserId");
			}
		}
		
		/// <summary>
		/// Choose the primary contact for the account to provide quick access to contact details.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primarycontactid")]
		public Microsoft.Xrm.Sdk.EntityReference PrimaryContactId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("primarycontactid");
			}
			set
			{
				this.OnPropertyChanging("PrimaryContactId");
				this.SetAttributeValue("primarycontactid", value);
				this.OnPropertyChanged("PrimaryContactId");
			}
		}
		
		/// <summary>
		/// Primary Satori ID for Account
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primarysatoriid")]
		public string PrimarySatoriId
		{
			get
			{
				return this.GetAttributeValue<string>("primarysatoriid");
			}
			set
			{
				this.OnPropertyChanging("PrimarySatoriId");
				this.SetAttributeValue("primarysatoriid", value);
				this.OnPropertyChanged("PrimarySatoriId");
			}
		}
		
		/// <summary>
		/// Primary Twitter ID for Account
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primarytwitterid")]
		public string PrimaryTwitterId
		{
			get
			{
				return this.GetAttributeValue<string>("primarytwitterid");
			}
			set
			{
				this.OnPropertyChanging("PrimaryTwitterId");
				this.SetAttributeValue("primarytwitterid", value);
				this.OnPropertyChanged("PrimaryTwitterId");
			}
		}
		
		/// <summary>
		/// Shows the ID of the process.
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
		/// Type the annual revenue for the account, used as an indicator in financial performance analysis.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("revenue")]
		public Microsoft.Xrm.Sdk.Money Revenue
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("revenue");
			}
			set
			{
				this.OnPropertyChanging("Revenue");
				this.SetAttributeValue("revenue", value);
				this.OnPropertyChanged("Revenue");
			}
		}
		
		/// <summary>
		/// Shows the annual revenue converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("revenue_base")]
		public Microsoft.Xrm.Sdk.Money Revenue_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("revenue_base");
			}
		}
		
		/// <summary>
		/// Type the number of shares available to the public for the account. This number is used as an indicator in financial performance analysis.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sharesoutstanding")]
		public System.Nullable<int> SharesOutstanding
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("sharesoutstanding");
			}
			set
			{
				this.OnPropertyChanging("SharesOutstanding");
				this.SetAttributeValue("sharesoutstanding", value);
				this.OnPropertyChanged("SharesOutstanding");
			}
		}
		
		/// <summary>
		/// Select a shipping method for deliveries sent to the account's address to designate the preferred carrier or other delivery option.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shippingmethodcode")]
		public System.Nullable<EntityModels.account_shippingmethodcode> ShippingMethodCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("shippingmethodcode");
				if ((optionSet != null))
				{
					return ((EntityModels.account_shippingmethodcode)(System.Enum.ToObject(typeof(EntityModels.account_shippingmethodcode), optionSet.Value)));
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
		/// Type the Standard Industrial Classification (SIC) code that indicates the account's primary industry of business, for use in marketing segmentation and demographic analysis.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sic")]
		public string SIC
		{
			get
			{
				return this.GetAttributeValue<string>("sic");
			}
			set
			{
				this.OnPropertyChanging("SIC");
				this.SetAttributeValue("sic", value);
				this.OnPropertyChanged("SIC");
			}
		}
		
		/// <summary>
		/// Choose the service level agreement (SLA) that you want to apply to the Account record.
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
		/// Last SLA that was applied to this case. This field is for internal use only.
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
		/// Shows the ID of the stage.
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
		/// Shows whether the account is active or inactive. Inactive accounts are read-only and can't be edited unless they are reactivated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<EntityModels.AccountState> StateCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((EntityModels.AccountState)(System.Enum.ToObject(typeof(EntityModels.AccountState), optionSet.Value)));
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
		/// Select the account's status.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public System.Nullable<EntityModels.account_statuscode> StatusCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
				if ((optionSet != null))
				{
					return ((EntityModels.account_statuscode)(System.Enum.ToObject(typeof(EntityModels.account_statuscode), optionSet.Value)));
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
		/// Type the stock exchange at which the account is listed to track their stock and financial performance of the company.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stockexchange")]
		public string StockExchange
		{
			get
			{
				return this.GetAttributeValue<string>("stockexchange");
			}
			set
			{
				this.OnPropertyChanging("StockExchange");
				this.SetAttributeValue("stockexchange", value);
				this.OnPropertyChanged("StockExchange");
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
		/// Type the main phone number for this account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone1")]
		public string Telephone1
		{
			get
			{
				return this.GetAttributeValue<string>("telephone1");
			}
			set
			{
				this.OnPropertyChanging("Telephone1");
				this.SetAttributeValue("telephone1", value);
				this.OnPropertyChanged("Telephone1");
			}
		}
		
		/// <summary>
		/// Type a second phone number for this account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone2")]
		public string Telephone2
		{
			get
			{
				return this.GetAttributeValue<string>("telephone2");
			}
			set
			{
				this.OnPropertyChanging("Telephone2");
				this.SetAttributeValue("telephone2", value);
				this.OnPropertyChanged("Telephone2");
			}
		}
		
		/// <summary>
		/// Type a third phone number for this account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone3")]
		public string Telephone3
		{
			get
			{
				return this.GetAttributeValue<string>("telephone3");
			}
			set
			{
				this.OnPropertyChanging("Telephone3");
				this.SetAttributeValue("telephone3", value);
				this.OnPropertyChanged("Telephone3");
			}
		}
		
		/// <summary>
		/// Select a region or territory for the account for use in segmentation and analysis.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("territorycode")]
		public System.Nullable<EntityModels.account_territorycode> TerritoryCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("territorycode");
				if ((optionSet != null))
				{
					return ((EntityModels.account_territorycode)(System.Enum.ToObject(typeof(EntityModels.account_territorycode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("TerritoryCode");
				if ((value == null))
				{
					this.SetAttributeValue("territorycode", null);
				}
				else
				{
					this.SetAttributeValue("territorycode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("TerritoryCode");
			}
		}
		
		/// <summary>
		/// Choose the sales region or territory for the account to make sure the account is assigned to the correct representative and for use in segmentation and analysis.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("territoryid")]
		public Microsoft.Xrm.Sdk.EntityReference TerritoryId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("territoryid");
			}
			set
			{
				this.OnPropertyChanging("TerritoryId");
				this.SetAttributeValue("territoryid", value);
				this.OnPropertyChanged("TerritoryId");
			}
		}
		
		/// <summary>
		/// Type the stock exchange symbol for the account to track financial performance of the company. You can click the code entered in this field to access the latest trading information from MSN Money.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("tickersymbol")]
		public string TickerSymbol
		{
			get
			{
				return this.GetAttributeValue<string>("tickersymbol");
			}
			set
			{
				this.OnPropertyChanging("TickerSymbol");
				this.SetAttributeValue("tickersymbol", value);
				this.OnPropertyChanged("TickerSymbol");
			}
		}
		
		/// <summary>
		/// Total time spent for emails (read and write) and meetings by me in relation to account record.
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
		/// For internal use only.
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
		/// Version number of the account.
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
		/// Type the account's website URL to get quick details about the company profile.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("websiteurl")]
		public string WebSiteURL
		{
			get
			{
				return this.GetAttributeValue<string>("websiteurl");
			}
			set
			{
				this.OnPropertyChanging("WebSiteURL");
				this.SetAttributeValue("websiteurl", value);
				this.OnPropertyChanged("WebSiteURL");
			}
		}
		
		/// <summary>
		/// Type the phonetic spelling of the company name, if specified in Japanese, to make sure the name is pronounced correctly in phone calls and other communications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yominame")]
		public string YomiName
		{
			get
			{
				return this.GetAttributeValue<string>("yominame");
			}
			set
			{
				this.OnPropertyChanging("YomiName");
				this.SetAttributeValue("yominame", value);
				this.OnPropertyChanged("YomiName");
			}
		}
		
		/// <summary>
		/// 1:N account_master_account
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_master_account", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<EntityModels.Account> Referencedaccount_master_account
		{
			get
			{
				return this.GetRelatedEntities<EntityModels.Account>("account_master_account", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			set
			{
				this.OnPropertyChanging("Referencedaccount_master_account");
				this.SetRelatedEntities<EntityModels.Account>("account_master_account", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedaccount_master_account");
			}
		}
		
		/// <summary>
		/// 1:N account_parent_account
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_parent_account", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<EntityModels.Account> Referencedaccount_parent_account
		{
			get
			{
				return this.GetRelatedEntities<EntityModels.Account>("account_parent_account", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			set
			{
				this.OnPropertyChanging("Referencedaccount_parent_account");
				this.SetRelatedEntities<EntityModels.Account>("account_parent_account", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedaccount_parent_account");
			}
		}
		
		/// <summary>
		/// 1:N contact_customer_accounts
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_customer_accounts")]
		public System.Collections.Generic.IEnumerable<EntityModels.Contact> contact_customer_accounts
		{
			get
			{
				return this.GetRelatedEntities<EntityModels.Contact>("contact_customer_accounts", null);
			}
			set
			{
				this.OnPropertyChanging("contact_customer_accounts");
				this.SetRelatedEntities<EntityModels.Contact>("contact_customer_accounts", null, value);
				this.OnPropertyChanged("contact_customer_accounts");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_account_account_BillingAccount
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_account_account_BillingAccount", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<EntityModels.Account> Referencedmsdyn_account_account_BillingAccount
		{
			get
			{
				return this.GetRelatedEntities<EntityModels.Account>("msdyn_account_account_BillingAccount", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			set
			{
				this.OnPropertyChanging("Referencedmsdyn_account_account_BillingAccount");
				this.SetRelatedEntities<EntityModels.Account>("msdyn_account_account_BillingAccount", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedmsdyn_account_account_BillingAccount");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_account_quote_Account
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_account_quote_Account")]
		public System.Collections.Generic.IEnumerable<EntityModels.Quote> msdyn_account_quote_Account
		{
			get
			{
				return this.GetRelatedEntities<EntityModels.Quote>("msdyn_account_quote_Account", null);
			}
			set
			{
				this.OnPropertyChanging("msdyn_account_quote_Account");
				this.SetRelatedEntities<EntityModels.Quote>("msdyn_account_quote_Account", null, value);
				this.OnPropertyChanged("msdyn_account_quote_Account");
			}
		}
		
		/// <summary>
		/// 1:N opportunity_customer_accounts
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_customer_accounts")]
		public System.Collections.Generic.IEnumerable<EntityModels.Opportunity> opportunity_customer_accounts
		{
			get
			{
				return this.GetRelatedEntities<EntityModels.Opportunity>("opportunity_customer_accounts", null);
			}
			set
			{
				this.OnPropertyChanging("opportunity_customer_accounts");
				this.SetRelatedEntities<EntityModels.Opportunity>("opportunity_customer_accounts", null, value);
				this.OnPropertyChanged("opportunity_customer_accounts");
			}
		}
		
		/// <summary>
		/// 1:N opportunity_parent_account
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_parent_account")]
		public System.Collections.Generic.IEnumerable<EntityModels.Opportunity> opportunity_parent_account
		{
			get
			{
				return this.GetRelatedEntities<EntityModels.Opportunity>("opportunity_parent_account", null);
			}
			set
			{
				this.OnPropertyChanging("opportunity_parent_account");
				this.SetRelatedEntities<EntityModels.Opportunity>("opportunity_parent_account", null, value);
				this.OnPropertyChanged("opportunity_parent_account");
			}
		}
		
		/// <summary>
		/// 1:N quote_customer_accounts
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("quote_customer_accounts")]
		public System.Collections.Generic.IEnumerable<EntityModels.Quote> quote_customer_accounts
		{
			get
			{
				return this.GetRelatedEntities<EntityModels.Quote>("quote_customer_accounts", null);
			}
			set
			{
				this.OnPropertyChanging("quote_customer_accounts");
				this.SetRelatedEntities<EntityModels.Quote>("quote_customer_accounts", null, value);
				this.OnPropertyChanged("quote_customer_accounts");
			}
		}
		
		/// <summary>
		/// N:1 account_master_account
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("masterid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_master_account", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public EntityModels.Account Referencingaccount_master_account
		{
			get
			{
				return this.GetRelatedEntity<EntityModels.Account>("account_master_account", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
		}
		
		/// <summary>
		/// N:1 account_parent_account
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentaccountid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_parent_account", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public EntityModels.Account Referencingaccount_parent_account
		{
			get
			{
				return this.GetRelatedEntity<EntityModels.Account>("account_parent_account", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
			set
			{
				this.OnPropertyChanging("Referencingaccount_parent_account");
				this.SetRelatedEntity<EntityModels.Account>("account_parent_account", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
				this.OnPropertyChanged("Referencingaccount_parent_account");
			}
		}
		
		/// <summary>
		/// N:1 account_primary_contact
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primarycontactid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_primary_contact")]
		public EntityModels.Contact account_primary_contact
		{
			get
			{
				return this.GetRelatedEntity<EntityModels.Contact>("account_primary_contact", null);
			}
			set
			{
				this.OnPropertyChanging("account_primary_contact");
				this.SetRelatedEntity<EntityModels.Contact>("account_primary_contact", null, value);
				this.OnPropertyChanged("account_primary_contact");
			}
		}
		
		/// <summary>
		/// N:1 lk_accountbase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_accountbase_createdby")]
		public EntityModels.SystemUser lk_accountbase_createdby
		{
			get
			{
				return this.GetRelatedEntity<EntityModels.SystemUser>("lk_accountbase_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_accountbase_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_accountbase_createdonbehalfby")]
		public EntityModels.SystemUser lk_accountbase_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<EntityModels.SystemUser>("lk_accountbase_createdonbehalfby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_accountbase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_accountbase_modifiedby")]
		public EntityModels.SystemUser lk_accountbase_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<EntityModels.SystemUser>("lk_accountbase_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_accountbase_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_accountbase_modifiedonbehalfby")]
		public EntityModels.SystemUser lk_accountbase_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<EntityModels.SystemUser>("lk_accountbase_modifiedonbehalfby", null);
			}
		}
		
		/// <summary>
		/// N:1 msdyn_account_account_BillingAccount
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_billingaccount")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_account_account_BillingAccount", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public EntityModels.Account Referencingmsdyn_account_account_BillingAccount
		{
			get
			{
				return this.GetRelatedEntity<EntityModels.Account>("msdyn_account_account_BillingAccount", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
			set
			{
				this.OnPropertyChanging("Referencingmsdyn_account_account_BillingAccount");
				this.SetRelatedEntity<EntityModels.Account>("msdyn_account_account_BillingAccount", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
				this.OnPropertyChanged("Referencingmsdyn_account_account_BillingAccount");
			}
		}
		
		/// <summary>
		/// N:1 system_user_accounts
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredsystemuserid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_accounts")]
		public EntityModels.SystemUser system_user_accounts
		{
			get
			{
				return this.GetRelatedEntity<EntityModels.SystemUser>("system_user_accounts", null);
			}
			set
			{
				this.OnPropertyChanging("system_user_accounts");
				this.SetRelatedEntity<EntityModels.SystemUser>("system_user_accounts", null, value);
				this.OnPropertyChanged("system_user_accounts");
			}
		}
		
		/// <summary>
		/// N:1 user_accounts
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_accounts")]
		public EntityModels.SystemUser user_accounts
		{
			get
			{
				return this.GetRelatedEntity<EntityModels.SystemUser>("user_accounts", null);
			}
		}
	}
}
