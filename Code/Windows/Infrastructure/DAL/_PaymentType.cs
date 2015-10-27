
/*
'===============================================================================
'  Generated From - CSharp_dOOdads_BusinessEntity.vbgen
' 
'  ** IMPORTANT  ** 
'  How to Generate your stored procedures:
' 
'  SQL        = SQL_StoredProcs.vbgen
'  ACCESS     = Access_StoredProcs.vbgen
'  ORACLE     = Oracle_StoredProcs.vbgen
'  FIREBIRD   = FirebirdStoredProcs.vbgen
'  POSTGRESQL = PostgreSQL_StoredProcs.vbgen
'
'  The supporting base class SqlClientEntity is in the Architecture directory in "dOOdads".
'  
'  This object is 'abstract' which means you need to inherit from it to be able
'  to instantiate it.  This is very easilly done. You can override properties and
'  methods in your derived class, this allows you to regenerate this class at any
'  time and not worry about overwriting custom code. 
'
'  NEVER EDIT THIS FILE.
'
'  public class YourObject :  _YourObject
'  {
'
'  }
'
'===============================================================================
*/

// Generated by MyGeneration Version # (1.2.0.7)

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Specialized;

using MyGeneration.dOOdads;

namespace DAL
{
	public abstract class _PaymentType : SqlClientEntity
	{
		public _PaymentType()
		{
			this.QuerySource = "PaymentType";
			this.MappingName = "PaymentType";

		}	

		//=================================================================
		//  public Overrides void AddNew()
		//=================================================================
		//
		//=================================================================
		public override void AddNew()
		{
			base.AddNew();
			
		}
		
		
		public override void FlushData()
		{
			this._whereClause = null;
			this._aggregateClause = null;
			base.FlushData();
		}
		
		//=================================================================
		//  	public Function LoadAll() As Boolean
		//=================================================================
		//  Loads all of the records in the database, and sets the currentRow to the first row
		//=================================================================
		public bool LoadAll() 
		{
			ListDictionary parameters = null;
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_PaymentTypeLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int ID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.ID, ID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_PaymentTypeLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter ID
			{
				get
				{
					return new SqlParameter("@ID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Name
			{
				get
				{
					return new SqlParameter("@Name", SqlDbType.NVarChar, 50);
				}
			}
			
			public static SqlParameter Description
			{
				get
				{
					return new SqlParameter("@Description", SqlDbType.Text, 2147483647);
				}
			}
			
			public static SqlParameter IsActive
			{
				get
				{
					return new SqlParameter("@IsActive", SqlDbType.Bit, 0);
				}
			}
			
			public static SqlParameter Rowguid
			{
				get
				{
					return new SqlParameter("@Rowguid", SqlDbType.UniqueIdentifier, 0);
				}
			}
			
			public static SqlParameter IsSystemPaymentType
			{
				get
				{
					return new SqlParameter("@IsSystemPaymentType", SqlDbType.Bit, 0);
				}
			}
			
			public static SqlParameter CreatedDate
			{
				get
				{
					return new SqlParameter("@CreatedDate", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter ModifiedDate
			{
				get
				{
					return new SqlParameter("@ModifiedDate", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter ModifiedBy
			{
				get
				{
					return new SqlParameter("@ModifiedBy", SqlDbType.NVarChar, 50);
				}
			}
			
			public static SqlParameter PaymentTypeCode
			{
				get
				{
					return new SqlParameter("@PaymentTypeCode", SqlDbType.NVarChar, 5);
				}
			}
			
			public static SqlParameter SN
			{
				get
				{
					return new SqlParameter("@SN", SqlDbType.Int, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string ID = "ID";
            public const string Name = "Name";
            public const string Description = "Description";
            public const string IsActive = "IsActive";
            public const string Rowguid = "rowguid";
            public const string IsSystemPaymentType = "IsSystemPaymentType";
            public const string CreatedDate = "CreatedDate";
            public const string ModifiedDate = "ModifiedDate";
            public const string ModifiedBy = "ModifiedBy";
            public const string PaymentTypeCode = "PaymentTypeCode";
            public const string SN = "SN";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ID] = _PaymentType.PropertyNames.ID;
					ht[Name] = _PaymentType.PropertyNames.Name;
					ht[Description] = _PaymentType.PropertyNames.Description;
					ht[IsActive] = _PaymentType.PropertyNames.IsActive;
					ht[Rowguid] = _PaymentType.PropertyNames.Rowguid;
					ht[IsSystemPaymentType] = _PaymentType.PropertyNames.IsSystemPaymentType;
					ht[CreatedDate] = _PaymentType.PropertyNames.CreatedDate;
					ht[ModifiedDate] = _PaymentType.PropertyNames.ModifiedDate;
					ht[ModifiedBy] = _PaymentType.PropertyNames.ModifiedBy;
					ht[PaymentTypeCode] = _PaymentType.PropertyNames.PaymentTypeCode;
					ht[SN] = _PaymentType.PropertyNames.SN;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string ID = "ID";
            public const string Name = "Name";
            public const string Description = "Description";
            public const string IsActive = "IsActive";
            public const string Rowguid = "Rowguid";
            public const string IsSystemPaymentType = "IsSystemPaymentType";
            public const string CreatedDate = "CreatedDate";
            public const string ModifiedDate = "ModifiedDate";
            public const string ModifiedBy = "ModifiedBy";
            public const string PaymentTypeCode = "PaymentTypeCode";
            public const string SN = "SN";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ID] = _PaymentType.ColumnNames.ID;
					ht[Name] = _PaymentType.ColumnNames.Name;
					ht[Description] = _PaymentType.ColumnNames.Description;
					ht[IsActive] = _PaymentType.ColumnNames.IsActive;
					ht[Rowguid] = _PaymentType.ColumnNames.Rowguid;
					ht[IsSystemPaymentType] = _PaymentType.ColumnNames.IsSystemPaymentType;
					ht[CreatedDate] = _PaymentType.ColumnNames.CreatedDate;
					ht[ModifiedDate] = _PaymentType.ColumnNames.ModifiedDate;
					ht[ModifiedBy] = _PaymentType.ColumnNames.ModifiedBy;
					ht[PaymentTypeCode] = _PaymentType.ColumnNames.PaymentTypeCode;
					ht[SN] = _PaymentType.ColumnNames.SN;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string ID = "s_ID";
            public const string Name = "s_Name";
            public const string Description = "s_Description";
            public const string IsActive = "s_IsActive";
            public const string Rowguid = "s_Rowguid";
            public const string IsSystemPaymentType = "s_IsSystemPaymentType";
            public const string CreatedDate = "s_CreatedDate";
            public const string ModifiedDate = "s_ModifiedDate";
            public const string ModifiedBy = "s_ModifiedBy";
            public const string PaymentTypeCode = "s_PaymentTypeCode";
            public const string SN = "s_SN";

		}
		#endregion		
		
		#region Properties
	
		public virtual int ID
	    {
			get
	        {
				return base.Getint(ColumnNames.ID);
			}
			set
	        {
				base.Setint(ColumnNames.ID, value);
			}
		}

		public virtual string Name
	    {
			get
	        {
				return base.Getstring(ColumnNames.Name);
			}
			set
	        {
				base.Setstring(ColumnNames.Name, value);
			}
		}

		public virtual string Description
	    {
			get
	        {
				return base.Getstring(ColumnNames.Description);
			}
			set
	        {
				base.Setstring(ColumnNames.Description, value);
			}
		}

		public virtual bool IsActive
	    {
			get
	        {
				return base.Getbool(ColumnNames.IsActive);
			}
			set
	        {
				base.Setbool(ColumnNames.IsActive, value);
			}
		}

		public virtual Guid Rowguid
	    {
			get
	        {
				return base.GetGuid(ColumnNames.Rowguid);
			}
			set
	        {
				base.SetGuid(ColumnNames.Rowguid, value);
			}
		}

		public virtual bool IsSystemPaymentType
	    {
			get
	        {
				return base.Getbool(ColumnNames.IsSystemPaymentType);
			}
			set
	        {
				base.Setbool(ColumnNames.IsSystemPaymentType, value);
			}
		}

		public virtual DateTime CreatedDate
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.CreatedDate);
			}
			set
	        {
				base.SetDateTime(ColumnNames.CreatedDate, value);
			}
		}

		public virtual DateTime ModifiedDate
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.ModifiedDate);
			}
			set
	        {
				base.SetDateTime(ColumnNames.ModifiedDate, value);
			}
		}

		public virtual string ModifiedBy
	    {
			get
	        {
				return base.Getstring(ColumnNames.ModifiedBy);
			}
			set
	        {
				base.Setstring(ColumnNames.ModifiedBy, value);
			}
		}

		public virtual string PaymentTypeCode
	    {
			get
			{
			   return base.Getstring(ColumnNames.PaymentTypeCode);
			}
			set
	        {
				base.Setstring(ColumnNames.PaymentTypeCode, value);
			}
		}

		public virtual int SN
	    {
			get
	        {
				return base.Getint(ColumnNames.SN);
			}
			set
	        {
				base.Setint(ColumnNames.SN, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_ID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ID) ? string.Empty : base.GetintAsString(ColumnNames.ID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ID);
				else
					this.ID = base.SetintAsString(ColumnNames.ID, value);
			}
		}

		public virtual string s_Name
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Name) ? string.Empty : base.GetstringAsString(ColumnNames.Name);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Name);
				else
					this.Name = base.SetstringAsString(ColumnNames.Name, value);
			}
		}

		public virtual string s_Description
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Description) ? string.Empty : base.GetstringAsString(ColumnNames.Description);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Description);
				else
					this.Description = base.SetstringAsString(ColumnNames.Description, value);
			}
		}

		public virtual string s_IsActive
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.IsActive) ? string.Empty : base.GetboolAsString(ColumnNames.IsActive);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.IsActive);
				else
					this.IsActive = base.SetboolAsString(ColumnNames.IsActive, value);
			}
		}

		public virtual string s_Rowguid
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Rowguid) ? string.Empty : base.GetGuidAsString(ColumnNames.Rowguid);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Rowguid);
				else
					this.Rowguid = base.SetGuidAsString(ColumnNames.Rowguid, value);
			}
		}

		public virtual string s_IsSystemPaymentType
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.IsSystemPaymentType) ? string.Empty : base.GetboolAsString(ColumnNames.IsSystemPaymentType);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.IsSystemPaymentType);
				else
					this.IsSystemPaymentType = base.SetboolAsString(ColumnNames.IsSystemPaymentType, value);
			}
		}

		public virtual string s_CreatedDate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CreatedDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.CreatedDate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CreatedDate);
				else
					this.CreatedDate = base.SetDateTimeAsString(ColumnNames.CreatedDate, value);
			}
		}

		public virtual string s_ModifiedDate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ModifiedDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.ModifiedDate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ModifiedDate);
				else
					this.ModifiedDate = base.SetDateTimeAsString(ColumnNames.ModifiedDate, value);
			}
		}

		public virtual string s_ModifiedBy
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ModifiedBy) ? string.Empty : base.GetstringAsString(ColumnNames.ModifiedBy);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ModifiedBy);
				else
					this.ModifiedBy = base.SetstringAsString(ColumnNames.ModifiedBy, value);
			}
		}

		public virtual string s_PaymentTypeCode
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.PaymentTypeCode) ? string.Empty : base.GetstringAsString(ColumnNames.PaymentTypeCode);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.PaymentTypeCode);
				else
					this.PaymentTypeCode = base.SetstringAsString(ColumnNames.PaymentTypeCode, value);
			}
		}

		public virtual string s_SN
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.SN) ? string.Empty : base.GetintAsString(ColumnNames.SN);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.SN);
				else
					this.SN = base.SetintAsString(ColumnNames.SN, value);
			}
		}


		#endregion		
	
		#region Where Clause
		public class WhereClause
		{
			public WhereClause(BusinessEntity entity)
			{
				this._entity = entity;
			}
			
			public TearOffWhereParameter TearOff
			{
				get
				{
					if(_tearOff == null)
					{
						_tearOff = new TearOffWhereParameter(this);
					}

					return _tearOff;
				}
			}

			#region WhereParameter TearOff's
			public class TearOffWhereParameter
			{
				public TearOffWhereParameter(WhereClause clause)
				{
					this._clause = clause;
				}
				
				
				public WhereParameter ID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ID, Parameters.ID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Name
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Name, Parameters.Name);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Description
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Description, Parameters.Description);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter IsActive
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.IsActive, Parameters.IsActive);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Rowguid
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Rowguid, Parameters.Rowguid);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter IsSystemPaymentType
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.IsSystemPaymentType, Parameters.IsSystemPaymentType);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter CreatedDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CreatedDate, Parameters.CreatedDate);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ModifiedDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ModifiedDate, Parameters.ModifiedDate);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ModifiedBy
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ModifiedBy, Parameters.ModifiedBy);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter PaymentTypeCode
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.PaymentTypeCode, Parameters.PaymentTypeCode);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter SN
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.SN, Parameters.SN);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter ID
		    {
				get
		        {
					if(_ID_W == null)
	        	    {
						_ID_W = TearOff.ID;
					}
					return _ID_W;
				}
			}

			public WhereParameter Name
		    {
				get
		        {
					if(_Name_W == null)
	        	    {
						_Name_W = TearOff.Name;
					}
					return _Name_W;
				}
			}

			public WhereParameter Description
		    {
				get
		        {
					if(_Description_W == null)
	        	    {
						_Description_W = TearOff.Description;
					}
					return _Description_W;
				}
			}

			public WhereParameter IsActive
		    {
				get
		        {
					if(_IsActive_W == null)
	        	    {
						_IsActive_W = TearOff.IsActive;
					}
					return _IsActive_W;
				}
			}

			public WhereParameter Rowguid
		    {
				get
		        {
					if(_Rowguid_W == null)
	        	    {
						_Rowguid_W = TearOff.Rowguid;
					}
					return _Rowguid_W;
				}
			}

			public WhereParameter IsSystemPaymentType
		    {
				get
		        {
					if(_IsSystemPaymentType_W == null)
	        	    {
						_IsSystemPaymentType_W = TearOff.IsSystemPaymentType;
					}
					return _IsSystemPaymentType_W;
				}
			}

			public WhereParameter CreatedDate
		    {
				get
		        {
					if(_CreatedDate_W == null)
	        	    {
						_CreatedDate_W = TearOff.CreatedDate;
					}
					return _CreatedDate_W;
				}
			}

			public WhereParameter ModifiedDate
		    {
				get
		        {
					if(_ModifiedDate_W == null)
	        	    {
						_ModifiedDate_W = TearOff.ModifiedDate;
					}
					return _ModifiedDate_W;
				}
			}

			public WhereParameter ModifiedBy
		    {
				get
		        {
					if(_ModifiedBy_W == null)
	        	    {
						_ModifiedBy_W = TearOff.ModifiedBy;
					}
					return _ModifiedBy_W;
				}
			}

			public WhereParameter PaymentTypeCode
		    {
				get
		        {
					if(_PaymentTypeCode_W == null)
	        	    {
						_PaymentTypeCode_W = TearOff.PaymentTypeCode;
					}
					return _PaymentTypeCode_W;
				}
			}

			public WhereParameter SN
		    {
				get
		        {
					if(_SN_W == null)
	        	    {
						_SN_W = TearOff.SN;
					}
					return _SN_W;
				}
			}

			private WhereParameter _ID_W = null;
			private WhereParameter _Name_W = null;
			private WhereParameter _Description_W = null;
			private WhereParameter _IsActive_W = null;
			private WhereParameter _Rowguid_W = null;
			private WhereParameter _IsSystemPaymentType_W = null;
			private WhereParameter _CreatedDate_W = null;
			private WhereParameter _ModifiedDate_W = null;
			private WhereParameter _ModifiedBy_W = null;
			private WhereParameter _PaymentTypeCode_W = null;
			private WhereParameter _SN_W = null;

			public void WhereClauseReset()
			{
				_ID_W = null;
				_Name_W = null;
				_Description_W = null;
				_IsActive_W = null;
				_Rowguid_W = null;
				_IsSystemPaymentType_W = null;
				_CreatedDate_W = null;
				_ModifiedDate_W = null;
				_ModifiedBy_W = null;
				_PaymentTypeCode_W = null;
				_SN_W = null;

				this._entity.Query.FlushWhereParameters();

			}
	
			private BusinessEntity _entity;
			private TearOffWhereParameter _tearOff;
			
		}
	
		public WhereClause Where
		{
			get
			{
				if(_whereClause == null)
				{
					_whereClause = new WhereClause(this);
				}
		
				return _whereClause;
			}
		}
		
		private WhereClause _whereClause = null;	
		#endregion
	
		#region Aggregate Clause
		public class AggregateClause
		{
			public AggregateClause(BusinessEntity entity)
			{
				this._entity = entity;
			}
			
			public TearOffAggregateParameter TearOff
			{
				get
				{
					if(_tearOff == null)
					{
						_tearOff = new TearOffAggregateParameter(this);
					}

					return _tearOff;
				}
			}

			#region AggregateParameter TearOff's
			public class TearOffAggregateParameter
			{
				public TearOffAggregateParameter(AggregateClause clause)
				{
					this._clause = clause;
				}
				
				
				public AggregateParameter ID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ID, Parameters.ID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Name
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Name, Parameters.Name);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Description
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Description, Parameters.Description);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter IsActive
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.IsActive, Parameters.IsActive);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Rowguid
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Rowguid, Parameters.Rowguid);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter IsSystemPaymentType
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.IsSystemPaymentType, Parameters.IsSystemPaymentType);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter CreatedDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CreatedDate, Parameters.CreatedDate);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ModifiedDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ModifiedDate, Parameters.ModifiedDate);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ModifiedBy
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ModifiedBy, Parameters.ModifiedBy);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter PaymentTypeCode
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.PaymentTypeCode, Parameters.PaymentTypeCode);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter SN
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.SN, Parameters.SN);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter ID
		    {
				get
		        {
					if(_ID_W == null)
	        	    {
						_ID_W = TearOff.ID;
					}
					return _ID_W;
				}
			}

			public AggregateParameter Name
		    {
				get
		        {
					if(_Name_W == null)
	        	    {
						_Name_W = TearOff.Name;
					}
					return _Name_W;
				}
			}

			public AggregateParameter Description
		    {
				get
		        {
					if(_Description_W == null)
	        	    {
						_Description_W = TearOff.Description;
					}
					return _Description_W;
				}
			}

			public AggregateParameter IsActive
		    {
				get
		        {
					if(_IsActive_W == null)
	        	    {
						_IsActive_W = TearOff.IsActive;
					}
					return _IsActive_W;
				}
			}

			public AggregateParameter Rowguid
		    {
				get
		        {
					if(_Rowguid_W == null)
	        	    {
						_Rowguid_W = TearOff.Rowguid;
					}
					return _Rowguid_W;
				}
			}

			public AggregateParameter IsSystemPaymentType
		    {
				get
		        {
					if(_IsSystemPaymentType_W == null)
	        	    {
						_IsSystemPaymentType_W = TearOff.IsSystemPaymentType;
					}
					return _IsSystemPaymentType_W;
				}
			}

			public AggregateParameter CreatedDate
		    {
				get
		        {
					if(_CreatedDate_W == null)
	        	    {
						_CreatedDate_W = TearOff.CreatedDate;
					}
					return _CreatedDate_W;
				}
			}

			public AggregateParameter ModifiedDate
		    {
				get
		        {
					if(_ModifiedDate_W == null)
	        	    {
						_ModifiedDate_W = TearOff.ModifiedDate;
					}
					return _ModifiedDate_W;
				}
			}

			public AggregateParameter ModifiedBy
		    {
				get
		        {
					if(_ModifiedBy_W == null)
	        	    {
						_ModifiedBy_W = TearOff.ModifiedBy;
					}
					return _ModifiedBy_W;
				}
			}

			public AggregateParameter PaymentTypeCode
		    {
				get
		        {
					if(_PaymentTypeCode_W == null)
	        	    {
						_PaymentTypeCode_W = TearOff.PaymentTypeCode;
					}
					return _PaymentTypeCode_W;
				}
			}

			public AggregateParameter SN
		    {
				get
		        {
					if(_SN_W == null)
	        	    {
						_SN_W = TearOff.SN;
					}
					return _SN_W;
				}
			}

			private AggregateParameter _ID_W = null;
			private AggregateParameter _Name_W = null;
			private AggregateParameter _Description_W = null;
			private AggregateParameter _IsActive_W = null;
			private AggregateParameter _Rowguid_W = null;
			private AggregateParameter _IsSystemPaymentType_W = null;
			private AggregateParameter _CreatedDate_W = null;
			private AggregateParameter _ModifiedDate_W = null;
			private AggregateParameter _ModifiedBy_W = null;
			private AggregateParameter _PaymentTypeCode_W = null;
			private AggregateParameter _SN_W = null;

			public void AggregateClauseReset()
			{
				_ID_W = null;
				_Name_W = null;
				_Description_W = null;
				_IsActive_W = null;
				_Rowguid_W = null;
				_IsSystemPaymentType_W = null;
				_CreatedDate_W = null;
				_ModifiedDate_W = null;
				_ModifiedBy_W = null;
				_PaymentTypeCode_W = null;
				_SN_W = null;

				this._entity.Query.FlushAggregateParameters();

			}
	
			private BusinessEntity _entity;
			private TearOffAggregateParameter _tearOff;
			
		}
	
		public AggregateClause Aggregate
		{
			get
			{
				if(_aggregateClause == null)
				{
					_aggregateClause = new AggregateClause(this);
				}
		
				return _aggregateClause;
			}
		}
		
		private AggregateClause _aggregateClause = null;	
		#endregion
	
		protected override IDbCommand GetInsertCommand() 
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_PaymentTypeInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.ID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_PaymentTypeUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_PaymentTypeDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.ID);
			p.SourceColumn = ColumnNames.ID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.ID);
			p.SourceColumn = ColumnNames.ID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Name);
			p.SourceColumn = ColumnNames.Name;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Description);
			p.SourceColumn = ColumnNames.Description;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.IsActive);
			p.SourceColumn = ColumnNames.IsActive;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Rowguid);
			p.SourceColumn = ColumnNames.Rowguid;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.IsSystemPaymentType);
			p.SourceColumn = ColumnNames.IsSystemPaymentType;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.CreatedDate);
			p.SourceColumn = ColumnNames.CreatedDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ModifiedDate);
			p.SourceColumn = ColumnNames.ModifiedDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ModifiedBy);
			p.SourceColumn = ColumnNames.ModifiedBy;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.PaymentTypeCode);
			p.SourceColumn = ColumnNames.PaymentTypeCode;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.SN);
			p.SourceColumn = ColumnNames.SN;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
