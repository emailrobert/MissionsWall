﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoSomethingWeb
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.Runtime.Serialization;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="dosomething")]
	public partial class DoSomethingDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertdosomething(dosomething instance);
    partial void Updatedosomething(dosomething instance);
    partial void Deletedosomething(dosomething instance);
    partial void Insertowner(owner instance);
    partial void Updateowner(owner instance);
    partial void Deleteowner(owner instance);
    #endregion
		
		public DoSomethingDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["dosomethingConnectionString1"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DoSomethingDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DoSomethingDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DoSomethingDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DoSomethingDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<dosomething> dosomethings
		{
			get
			{
				return this.GetTable<dosomething>();
			}
		}
		
		public System.Data.Linq.Table<owner> owners
		{
			get
			{
				return this.GetTable<owner>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.dosomething")]
	[global::System.Runtime.Serialization.DataContractAttribute()]
	public partial class dosomething : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ownerId;
		
		private System.Guid _Id;
		
		private string _contactname;
		
		private string _contactemail;
		
		private string _contactareacode;
		
		private string _contactprefix;
		
		private string _contactnumber;
		
		private string _eventtitle;
		
		private string _eventdesc;
		
		private string _eventlocation;
		
		private string _startdate;
		
		private string _starttime;
		
		private string _enddate;
		
		private string _endtime;
		
		private System.Nullable<bool> _approved;
		
		private string _submissiondate;
		
		private string _submittername;
		
		private string _submitteremail;
		
		private EntityRef<owner> _owner;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnownerIdChanging(string value);
    partial void OnownerIdChanged();
    partial void OnIdChanging(System.Guid value);
    partial void OnIdChanged();
    partial void OncontactnameChanging(string value);
    partial void OncontactnameChanged();
    partial void OncontactemailChanging(string value);
    partial void OncontactemailChanged();
    partial void OncontactareacodeChanging(string value);
    partial void OncontactareacodeChanged();
    partial void OncontactprefixChanging(string value);
    partial void OncontactprefixChanged();
    partial void OncontactnumberChanging(string value);
    partial void OncontactnumberChanged();
    partial void OneventtitleChanging(string value);
    partial void OneventtitleChanged();
    partial void OneventdescChanging(string value);
    partial void OneventdescChanged();
    partial void OneventlocationChanging(string value);
    partial void OneventlocationChanged();
    partial void OnstartdateChanging(string value);
    partial void OnstartdateChanged();
    partial void OnstarttimeChanging(string value);
    partial void OnstarttimeChanged();
    partial void OnenddateChanging(string value);
    partial void OnenddateChanged();
    partial void OnendtimeChanging(string value);
    partial void OnendtimeChanged();
    partial void OnapprovedChanging(System.Nullable<bool> value);
    partial void OnapprovedChanged();
    partial void OnsubmissiondateChanging(string value);
    partial void OnsubmissiondateChanged();
    partial void OnsubmitternameChanging(string value);
    partial void OnsubmitternameChanged();
    partial void OnsubmitteremailChanging(string value);
    partial void OnsubmitteremailChanged();
    #endregion
		
		public dosomething()
		{
			this.Initialize();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ownerId", DbType="VarChar(50)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=1)]
		public string ownerId
		{
			get
			{
				return this._ownerId;
			}
			set
			{
				if ((this._ownerId != value))
				{
					if (this._owner.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnownerIdChanging(value);
					this.SendPropertyChanging();
					this._ownerId = value;
					this.SendPropertyChanged("ownerId");
					this.OnownerIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=2)]
		public System.Guid Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_contactname", DbType="VarChar(50)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=3)]
		public string contactname
		{
			get
			{
				return this._contactname;
			}
			set
			{
				if ((this._contactname != value))
				{
					this.OncontactnameChanging(value);
					this.SendPropertyChanging();
					this._contactname = value;
					this.SendPropertyChanged("contactname");
					this.OncontactnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_contactemail", DbType="VarChar(50)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=4)]
		public string contactemail
		{
			get
			{
				return this._contactemail;
			}
			set
			{
				if ((this._contactemail != value))
				{
					this.OncontactemailChanging(value);
					this.SendPropertyChanging();
					this._contactemail = value;
					this.SendPropertyChanged("contactemail");
					this.OncontactemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_contactareacode", DbType="VarChar(3)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=5)]
		public string contactareacode
		{
			get
			{
				return this._contactareacode;
			}
			set
			{
				if ((this._contactareacode != value))
				{
					this.OncontactareacodeChanging(value);
					this.SendPropertyChanging();
					this._contactareacode = value;
					this.SendPropertyChanged("contactareacode");
					this.OncontactareacodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_contactprefix", DbType="VarChar(3)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=6)]
		public string contactprefix
		{
			get
			{
				return this._contactprefix;
			}
			set
			{
				if ((this._contactprefix != value))
				{
					this.OncontactprefixChanging(value);
					this.SendPropertyChanging();
					this._contactprefix = value;
					this.SendPropertyChanged("contactprefix");
					this.OncontactprefixChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_contactnumber", DbType="VarChar(4)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=7)]
		public string contactnumber
		{
			get
			{
				return this._contactnumber;
			}
			set
			{
				if ((this._contactnumber != value))
				{
					this.OncontactnumberChanging(value);
					this.SendPropertyChanging();
					this._contactnumber = value;
					this.SendPropertyChanged("contactnumber");
					this.OncontactnumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_eventtitle", DbType="VarChar(50)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=8)]
		public string eventtitle
		{
			get
			{
				return this._eventtitle;
			}
			set
			{
				if ((this._eventtitle != value))
				{
					this.OneventtitleChanging(value);
					this.SendPropertyChanging();
					this._eventtitle = value;
					this.SendPropertyChanged("eventtitle");
					this.OneventtitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_eventdesc", DbType="VarChar(210)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=9)]
		public string eventdesc
		{
			get
			{
				return this._eventdesc;
			}
			set
			{
				if ((this._eventdesc != value))
				{
					this.OneventdescChanging(value);
					this.SendPropertyChanging();
					this._eventdesc = value;
					this.SendPropertyChanged("eventdesc");
					this.OneventdescChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_eventlocation", DbType="VarChar(55)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=10)]
		public string eventlocation
		{
			get
			{
				return this._eventlocation;
			}
			set
			{
				if ((this._eventlocation != value))
				{
					this.OneventlocationChanging(value);
					this.SendPropertyChanging();
					this._eventlocation = value;
					this.SendPropertyChanged("eventlocation");
					this.OneventlocationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_startdate", DbType="VarChar(20)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=11)]
		public string startdate
		{
			get
			{
				return this._startdate;
			}
			set
			{
				if ((this._startdate != value))
				{
					this.OnstartdateChanging(value);
					this.SendPropertyChanging();
					this._startdate = value;
					this.SendPropertyChanged("startdate");
					this.OnstartdateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_starttime", DbType="VarChar(10)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=12)]
		public string starttime
		{
			get
			{
				return this._starttime;
			}
			set
			{
				if ((this._starttime != value))
				{
					this.OnstarttimeChanging(value);
					this.SendPropertyChanging();
					this._starttime = value;
					this.SendPropertyChanged("starttime");
					this.OnstarttimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_enddate", DbType="VarChar(20)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=13)]
		public string enddate
		{
			get
			{
				return this._enddate;
			}
			set
			{
				if ((this._enddate != value))
				{
					this.OnenddateChanging(value);
					this.SendPropertyChanging();
					this._enddate = value;
					this.SendPropertyChanged("enddate");
					this.OnenddateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_endtime", DbType="VarChar(10)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=14)]
		public string endtime
		{
			get
			{
				return this._endtime;
			}
			set
			{
				if ((this._endtime != value))
				{
					this.OnendtimeChanging(value);
					this.SendPropertyChanging();
					this._endtime = value;
					this.SendPropertyChanged("endtime");
					this.OnendtimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_approved", DbType="Bit")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=15)]
		public System.Nullable<bool> approved
		{
			get
			{
				return this._approved;
			}
			set
			{
				if ((this._approved != value))
				{
					this.OnapprovedChanging(value);
					this.SendPropertyChanging();
					this._approved = value;
					this.SendPropertyChanged("approved");
					this.OnapprovedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_submissiondate", DbType="VarChar(40)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=16)]
		public string submissiondate
		{
			get
			{
				return this._submissiondate;
			}
			set
			{
				if ((this._submissiondate != value))
				{
					this.OnsubmissiondateChanging(value);
					this.SendPropertyChanging();
					this._submissiondate = value;
					this.SendPropertyChanged("submissiondate");
					this.OnsubmissiondateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_submittername", DbType="VarChar(50)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=17)]
		public string submittername
		{
			get
			{
				return this._submittername;
			}
			set
			{
				if ((this._submittername != value))
				{
					this.OnsubmitternameChanging(value);
					this.SendPropertyChanging();
					this._submittername = value;
					this.SendPropertyChanged("submittername");
					this.OnsubmitternameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_submitteremail", DbType="VarChar(50)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=18)]
		public string submitteremail
		{
			get
			{
				return this._submitteremail;
			}
			set
			{
				if ((this._submitteremail != value))
				{
					this.OnsubmitteremailChanging(value);
					this.SendPropertyChanging();
					this._submitteremail = value;
					this.SendPropertyChanged("submitteremail");
					this.OnsubmitteremailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="owner_dosomething", Storage="_owner", ThisKey="ownerId", OtherKey="Id", IsForeignKey=true, DeleteRule="CASCADE")]
		public owner owner
		{
			get
			{
				return this._owner.Entity;
			}
			set
			{
				owner previousValue = this._owner.Entity;
				if (((previousValue != value) 
							|| (this._owner.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._owner.Entity = null;
						previousValue.dosomethings.Remove(this);
					}
					this._owner.Entity = value;
					if ((value != null))
					{
						value.dosomethings.Add(this);
						this._ownerId = value.Id;
					}
					else
					{
						this._ownerId = default(string);
					}
					this.SendPropertyChanged("owner");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void Initialize()
		{
			this._owner = default(EntityRef<owner>);
			OnCreated();
		}
		
		[global::System.Runtime.Serialization.OnDeserializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnDeserializing(StreamingContext context)
		{
			this.Initialize();
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.owner")]
	[global::System.Runtime.Serialization.DataContractAttribute()]
	public partial class owner : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Id;
		
		private string _OwnerName;
		
		private EntitySet<dosomething> _dosomethings;
		
		private bool serializing;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(string value);
    partial void OnIdChanged();
    partial void OnOwnerNameChanging(string value);
    partial void OnOwnerNameChanged();
    #endregion
		
		public owner()
		{
			this.Initialize();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=1)]
		public string Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OwnerName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=2)]
		public string OwnerName
		{
			get
			{
				return this._OwnerName;
			}
			set
			{
				if ((this._OwnerName != value))
				{
					this.OnOwnerNameChanging(value);
					this.SendPropertyChanging();
					this._OwnerName = value;
					this.SendPropertyChanged("OwnerName");
					this.OnOwnerNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="owner_dosomething", Storage="_dosomethings", ThisKey="Id", OtherKey="ownerId")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=3, EmitDefaultValue=false)]
		public EntitySet<dosomething> dosomethings
		{
			get
			{
				if ((this.serializing 
							&& (this._dosomethings.HasLoadedOrAssignedValues == false)))
				{
					return null;
				}
				return this._dosomethings;
			}
			set
			{
				this._dosomethings.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_dosomethings(dosomething entity)
		{
			this.SendPropertyChanging();
			entity.owner = this;
		}
		
		private void detach_dosomethings(dosomething entity)
		{
			this.SendPropertyChanging();
			entity.owner = null;
		}
		
		private void Initialize()
		{
			this._dosomethings = new EntitySet<dosomething>(new Action<dosomething>(this.attach_dosomethings), new Action<dosomething>(this.detach_dosomethings));
			OnCreated();
		}
		
		[global::System.Runtime.Serialization.OnDeserializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnDeserializing(StreamingContext context)
		{
			this.Initialize();
		}
		
		[global::System.Runtime.Serialization.OnSerializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnSerializing(StreamingContext context)
		{
			this.serializing = true;
		}
		
		[global::System.Runtime.Serialization.OnSerializedAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnSerialized(StreamingContext context)
		{
			this.serializing = false;
		}
	}
}
#pragma warning restore 1591
