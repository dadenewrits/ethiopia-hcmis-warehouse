
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
	public abstract class _LogFinance : SqlClientEntity
	{
		public _LogFinance()
		{
			this.QuerySource = "LogFinance";
			this.MappingName = "LogFinance";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_LogFinanceLoadAll]", parameters);
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

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_LogFinanceLoadByPrimaryKey]", parameters);
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
			
			public static SqlParameter ReceiveDocID
			{
				get
				{
					return new SqlParameter("@ReceiveDocID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter QuantityLeft
			{
				get
				{
					return new SqlParameter("@QuantityLeft", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter PreviousPricePerPack
			{
				get
				{
					return new SqlParameter("@PreviousPricePerPack", SqlDbType.Float, 0);
				}
			}
			
			public static SqlParameter NewPricePerPack
			{
				get
				{
					return new SqlParameter("@NewPricePerPack", SqlDbType.Float, 0);
				}
			}
			
			public static SqlParameter ColumnName
			{
				get
				{
					return new SqlParameter("@ColumnName", SqlDbType.VarChar, 50);
				}
			}
			
			public static SqlParameter Reason
			{
				get
				{
					return new SqlParameter("@Reason", SqlDbType.VarChar, 200);
				}
			}
			
			public static SqlParameter Date
			{
				get
				{
					return new SqlParameter("@Date", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter UserID
			{
				get
				{
					return new SqlParameter("@UserID", SqlDbType.Int, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string ID = "ID";
            public const string ReceiveDocID = "ReceiveDocID";
            public const string QuantityLeft = "QuantityLeft";
            public const string PreviousPricePerPack = "PreviousPricePerPack";
            public const string NewPricePerPack = "NewPricePerPack";
            public const string ColumnName = "ColumnName";
            public const string Reason = "Reason";
            public const string Date = "Date";
            public const string UserID = "UserID";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ID] = _LogFinance.PropertyNames.ID;
					ht[ReceiveDocID] = _LogFinance.PropertyNames.ReceiveDocID;
					ht[QuantityLeft] = _LogFinance.PropertyNames.QuantityLeft;
					ht[PreviousPricePerPack] = _LogFinance.PropertyNames.PreviousPricePerPack;
					ht[NewPricePerPack] = _LogFinance.PropertyNames.NewPricePerPack;
					ht[ColumnName] = _LogFinance.PropertyNames.ColumnName;
					ht[Reason] = _LogFinance.PropertyNames.Reason;
					ht[Date] = _LogFinance.PropertyNames.Date;
					ht[UserID] = _LogFinance.PropertyNames.UserID;

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
            public const string ReceiveDocID = "ReceiveDocID";
            public const string QuantityLeft = "QuantityLeft";
            public const string PreviousPricePerPack = "PreviousPricePerPack";
            public const string NewPricePerPack = "NewPricePerPack";
            public const string ColumnName = "ColumnName";
            public const string Reason = "Reason";
            public const string Date = "Date";
            public const string UserID = "UserID";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ID] = _LogFinance.ColumnNames.ID;
					ht[ReceiveDocID] = _LogFinance.ColumnNames.ReceiveDocID;
					ht[QuantityLeft] = _LogFinance.ColumnNames.QuantityLeft;
					ht[PreviousPricePerPack] = _LogFinance.ColumnNames.PreviousPricePerPack;
					ht[NewPricePerPack] = _LogFinance.ColumnNames.NewPricePerPack;
					ht[ColumnName] = _LogFinance.ColumnNames.ColumnName;
					ht[Reason] = _LogFinance.ColumnNames.Reason;
					ht[Date] = _LogFinance.ColumnNames.Date;
					ht[UserID] = _LogFinance.ColumnNames.UserID;

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
            public const string ReceiveDocID = "s_ReceiveDocID";
            public const string QuantityLeft = "s_QuantityLeft";
            public const string PreviousPricePerPack = "s_PreviousPricePerPack";
            public const string NewPricePerPack = "s_NewPricePerPack";
            public const string ColumnName = "s_ColumnName";
            public const string Reason = "s_Reason";
            public const string Date = "s_Date";
            public const string UserID = "s_UserID";

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

		public virtual int ReceiveDocID
	    {
			get
	        {
				return base.Getint(ColumnNames.ReceiveDocID);
			}
			set
	        {
				base.Setint(ColumnNames.ReceiveDocID, value);
			}
		}

		public virtual int QuantityLeft
	    {
			get
	        {
				return base.Getint(ColumnNames.QuantityLeft);
			}
			set
	        {
				base.Setint(ColumnNames.QuantityLeft, value);
			}
		}

		public virtual double PreviousPricePerPack
	    {
			get
	        {
				return base.Getdouble(ColumnNames.PreviousPricePerPack);
			}
			set
	        {
				base.Setdouble(ColumnNames.PreviousPricePerPack, value);
			}
		}

		public virtual double NewPricePerPack
	    {
			get
	        {
				return base.Getdouble(ColumnNames.NewPricePerPack);
			}
			set
	        {
				base.Setdouble(ColumnNames.NewPricePerPack, value);
			}
		}

		public virtual string ColumnName
	    {
			get
	        {
				return base.Getstring(ColumnNames.ColumnName);
			}
			set
	        {
				base.Setstring(ColumnNames.ColumnName, value);
			}
		}

		public virtual string Reason
	    {
			get
	        {
				return base.Getstring(ColumnNames.Reason);
			}
			set
	        {
				base.Setstring(ColumnNames.Reason, value);
			}
		}

		public virtual DateTime Date
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.Date);
			}
			set
	        {
				base.SetDateTime(ColumnNames.Date, value);
			}
		}

		public virtual int UserID
	    {
			get
	        {
				return base.Getint(ColumnNames.UserID);
			}
			set
	        {
				base.Setint(ColumnNames.UserID, value);
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

		public virtual string s_ReceiveDocID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ReceiveDocID) ? string.Empty : base.GetintAsString(ColumnNames.ReceiveDocID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ReceiveDocID);
				else
					this.ReceiveDocID = base.SetintAsString(ColumnNames.ReceiveDocID, value);
			}
		}

		public virtual string s_QuantityLeft
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.QuantityLeft) ? string.Empty : base.GetintAsString(ColumnNames.QuantityLeft);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.QuantityLeft);
				else
					this.QuantityLeft = base.SetintAsString(ColumnNames.QuantityLeft, value);
			}
		}

		public virtual string s_PreviousPricePerPack
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.PreviousPricePerPack) ? string.Empty : base.GetdoubleAsString(ColumnNames.PreviousPricePerPack);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.PreviousPricePerPack);
				else
					this.PreviousPricePerPack = base.SetdoubleAsString(ColumnNames.PreviousPricePerPack, value);
			}
		}

		public virtual string s_NewPricePerPack
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.NewPricePerPack) ? string.Empty : base.GetdoubleAsString(ColumnNames.NewPricePerPack);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.NewPricePerPack);
				else
					this.NewPricePerPack = base.SetdoubleAsString(ColumnNames.NewPricePerPack, value);
			}
		}

		public virtual string s_ColumnName
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ColumnName) ? string.Empty : base.GetstringAsString(ColumnNames.ColumnName);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ColumnName);
				else
					this.ColumnName = base.SetstringAsString(ColumnNames.ColumnName, value);
			}
		}

		public virtual string s_Reason
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Reason) ? string.Empty : base.GetstringAsString(ColumnNames.Reason);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Reason);
				else
					this.Reason = base.SetstringAsString(ColumnNames.Reason, value);
			}
		}

		public virtual string s_Date
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Date) ? string.Empty : base.GetDateTimeAsString(ColumnNames.Date);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Date);
				else
					this.Date = base.SetDateTimeAsString(ColumnNames.Date, value);
			}
		}

		public virtual string s_UserID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.UserID) ? string.Empty : base.GetintAsString(ColumnNames.UserID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.UserID);
				else
					this.UserID = base.SetintAsString(ColumnNames.UserID, value);
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

				public WhereParameter ReceiveDocID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ReceiveDocID, Parameters.ReceiveDocID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter QuantityLeft
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.QuantityLeft, Parameters.QuantityLeft);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter PreviousPricePerPack
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.PreviousPricePerPack, Parameters.PreviousPricePerPack);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter NewPricePerPack
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.NewPricePerPack, Parameters.NewPricePerPack);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ColumnName
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ColumnName, Parameters.ColumnName);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Reason
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Reason, Parameters.Reason);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Date
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Date, Parameters.Date);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter UserID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.UserID, Parameters.UserID);
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

			public WhereParameter ReceiveDocID
		    {
				get
		        {
					if(_ReceiveDocID_W == null)
	        	    {
						_ReceiveDocID_W = TearOff.ReceiveDocID;
					}
					return _ReceiveDocID_W;
				}
			}

			public WhereParameter QuantityLeft
		    {
				get
		        {
					if(_QuantityLeft_W == null)
	        	    {
						_QuantityLeft_W = TearOff.QuantityLeft;
					}
					return _QuantityLeft_W;
				}
			}

			public WhereParameter PreviousPricePerPack
		    {
				get
		        {
					if(_PreviousPricePerPack_W == null)
	        	    {
						_PreviousPricePerPack_W = TearOff.PreviousPricePerPack;
					}
					return _PreviousPricePerPack_W;
				}
			}

			public WhereParameter NewPricePerPack
		    {
				get
		        {
					if(_NewPricePerPack_W == null)
	        	    {
						_NewPricePerPack_W = TearOff.NewPricePerPack;
					}
					return _NewPricePerPack_W;
				}
			}

			public WhereParameter ColumnName
		    {
				get
		        {
					if(_ColumnName_W == null)
	        	    {
						_ColumnName_W = TearOff.ColumnName;
					}
					return _ColumnName_W;
				}
			}

			public WhereParameter Reason
		    {
				get
		        {
					if(_Reason_W == null)
	        	    {
						_Reason_W = TearOff.Reason;
					}
					return _Reason_W;
				}
			}

			public WhereParameter Date
		    {
				get
		        {
					if(_Date_W == null)
	        	    {
						_Date_W = TearOff.Date;
					}
					return _Date_W;
				}
			}

			public WhereParameter UserID
		    {
				get
		        {
					if(_UserID_W == null)
	        	    {
						_UserID_W = TearOff.UserID;
					}
					return _UserID_W;
				}
			}

			private WhereParameter _ID_W = null;
			private WhereParameter _ReceiveDocID_W = null;
			private WhereParameter _QuantityLeft_W = null;
			private WhereParameter _PreviousPricePerPack_W = null;
			private WhereParameter _NewPricePerPack_W = null;
			private WhereParameter _ColumnName_W = null;
			private WhereParameter _Reason_W = null;
			private WhereParameter _Date_W = null;
			private WhereParameter _UserID_W = null;

			public void WhereClauseReset()
			{
				_ID_W = null;
				_ReceiveDocID_W = null;
				_QuantityLeft_W = null;
				_PreviousPricePerPack_W = null;
				_NewPricePerPack_W = null;
				_ColumnName_W = null;
				_Reason_W = null;
				_Date_W = null;
				_UserID_W = null;

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

				public AggregateParameter ReceiveDocID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ReceiveDocID, Parameters.ReceiveDocID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter QuantityLeft
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.QuantityLeft, Parameters.QuantityLeft);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter PreviousPricePerPack
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.PreviousPricePerPack, Parameters.PreviousPricePerPack);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter NewPricePerPack
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.NewPricePerPack, Parameters.NewPricePerPack);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ColumnName
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ColumnName, Parameters.ColumnName);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Reason
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Reason, Parameters.Reason);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Date
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Date, Parameters.Date);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter UserID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.UserID, Parameters.UserID);
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

			public AggregateParameter ReceiveDocID
		    {
				get
		        {
					if(_ReceiveDocID_W == null)
	        	    {
						_ReceiveDocID_W = TearOff.ReceiveDocID;
					}
					return _ReceiveDocID_W;
				}
			}

			public AggregateParameter QuantityLeft
		    {
				get
		        {
					if(_QuantityLeft_W == null)
	        	    {
						_QuantityLeft_W = TearOff.QuantityLeft;
					}
					return _QuantityLeft_W;
				}
			}

			public AggregateParameter PreviousPricePerPack
		    {
				get
		        {
					if(_PreviousPricePerPack_W == null)
	        	    {
						_PreviousPricePerPack_W = TearOff.PreviousPricePerPack;
					}
					return _PreviousPricePerPack_W;
				}
			}

			public AggregateParameter NewPricePerPack
		    {
				get
		        {
					if(_NewPricePerPack_W == null)
	        	    {
						_NewPricePerPack_W = TearOff.NewPricePerPack;
					}
					return _NewPricePerPack_W;
				}
			}

			public AggregateParameter ColumnName
		    {
				get
		        {
					if(_ColumnName_W == null)
	        	    {
						_ColumnName_W = TearOff.ColumnName;
					}
					return _ColumnName_W;
				}
			}

			public AggregateParameter Reason
		    {
				get
		        {
					if(_Reason_W == null)
	        	    {
						_Reason_W = TearOff.Reason;
					}
					return _Reason_W;
				}
			}

			public AggregateParameter Date
		    {
				get
		        {
					if(_Date_W == null)
	        	    {
						_Date_W = TearOff.Date;
					}
					return _Date_W;
				}
			}

			public AggregateParameter UserID
		    {
				get
		        {
					if(_UserID_W == null)
	        	    {
						_UserID_W = TearOff.UserID;
					}
					return _UserID_W;
				}
			}

			private AggregateParameter _ID_W = null;
			private AggregateParameter _ReceiveDocID_W = null;
			private AggregateParameter _QuantityLeft_W = null;
			private AggregateParameter _PreviousPricePerPack_W = null;
			private AggregateParameter _NewPricePerPack_W = null;
			private AggregateParameter _ColumnName_W = null;
			private AggregateParameter _Reason_W = null;
			private AggregateParameter _Date_W = null;
			private AggregateParameter _UserID_W = null;

			public void AggregateClauseReset()
			{
				_ID_W = null;
				_ReceiveDocID_W = null;
				_QuantityLeft_W = null;
				_PreviousPricePerPack_W = null;
				_NewPricePerPack_W = null;
				_ColumnName_W = null;
				_Reason_W = null;
				_Date_W = null;
				_UserID_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_LogFinanceInsert]";
	
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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_LogFinanceUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_LogFinanceDelete]";
	
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

			p = cmd.Parameters.Add(Parameters.ReceiveDocID);
			p.SourceColumn = ColumnNames.ReceiveDocID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.QuantityLeft);
			p.SourceColumn = ColumnNames.QuantityLeft;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.PreviousPricePerPack);
			p.SourceColumn = ColumnNames.PreviousPricePerPack;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.NewPricePerPack);
			p.SourceColumn = ColumnNames.NewPricePerPack;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ColumnName);
			p.SourceColumn = ColumnNames.ColumnName;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Reason);
			p.SourceColumn = ColumnNames.Reason;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Date);
			p.SourceColumn = ColumnNames.Date;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.UserID);
			p.SourceColumn = ColumnNames.UserID;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
