
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
	public abstract class _Period : SqlClientEntity
	{
		public _Period()
		{
			this.QuerySource = "Period";
			this.MappingName = "Period";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_PeriodLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int PeriodID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.PeriodID, PeriodID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_PeriodLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter PeriodID
			{
				get
				{
					return new SqlParameter("@PeriodID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter FiscalYearID
			{
				get
				{
					return new SqlParameter("@FiscalYearID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter StartDate
			{
				get
				{
					return new SqlParameter("@StartDate", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter EndDate
			{
				get
				{
					return new SqlParameter("@EndDate", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter Rowguid
			{
				get
				{
					return new SqlParameter("@Rowguid", SqlDbType.UniqueIdentifier, 0);
				}
			}
			
			public static SqlParameter PeriodCode
			{
				get
				{
					return new SqlParameter("@PeriodCode", SqlDbType.NVarChar, 5);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string PeriodID = "PeriodID";
            public const string FiscalYearID = "FiscalYearID";
            public const string StartDate = "StartDate";
            public const string EndDate = "EndDate";
            public const string Rowguid = "rowguid";
            public const string PeriodCode = "PeriodCode";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[PeriodID] = _Period.PropertyNames.PeriodID;
					ht[FiscalYearID] = _Period.PropertyNames.FiscalYearID;
					ht[StartDate] = _Period.PropertyNames.StartDate;
					ht[EndDate] = _Period.PropertyNames.EndDate;
					ht[Rowguid] = _Period.PropertyNames.Rowguid;
					ht[PeriodCode] = _Period.PropertyNames.PeriodCode;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string PeriodID = "PeriodID";
            public const string FiscalYearID = "FiscalYearID";
            public const string StartDate = "StartDate";
            public const string EndDate = "EndDate";
            public const string Rowguid = "Rowguid";
            public const string PeriodCode = "PeriodCode";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[PeriodID] = _Period.ColumnNames.PeriodID;
					ht[FiscalYearID] = _Period.ColumnNames.FiscalYearID;
					ht[StartDate] = _Period.ColumnNames.StartDate;
					ht[EndDate] = _Period.ColumnNames.EndDate;
					ht[Rowguid] = _Period.ColumnNames.Rowguid;
					ht[PeriodCode] = _Period.ColumnNames.PeriodCode;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string PeriodID = "s_PeriodID";
            public const string FiscalYearID = "s_FiscalYearID";
            public const string StartDate = "s_StartDate";
            public const string EndDate = "s_EndDate";
            public const string Rowguid = "s_Rowguid";
            public const string PeriodCode = "s_PeriodCode";

		}
		#endregion		
		
		#region Properties
	
		public virtual int PeriodID
	    {
			get
	        {
				return base.Getint(ColumnNames.PeriodID);
			}
			set
	        {
				base.Setint(ColumnNames.PeriodID, value);
			}
		}

		public virtual int FiscalYearID
	    {
			get
	        {
				return base.Getint(ColumnNames.FiscalYearID);
			}
			set
	        {
				base.Setint(ColumnNames.FiscalYearID, value);
			}
		}

		public virtual DateTime StartDate
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.StartDate);
			}
			set
	        {
				base.SetDateTime(ColumnNames.StartDate, value);
			}
		}

		public virtual DateTime EndDate
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.EndDate);
			}
			set
	        {
				base.SetDateTime(ColumnNames.EndDate, value);
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

		public virtual string PeriodCode
	    {
			get
	        {
				return base.Getstring(ColumnNames.PeriodCode);
			}
			set
	        {
				base.Setstring(ColumnNames.PeriodCode, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_PeriodID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.PeriodID) ? string.Empty : base.GetintAsString(ColumnNames.PeriodID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.PeriodID);
				else
					this.PeriodID = base.SetintAsString(ColumnNames.PeriodID, value);
			}
		}

		public virtual string s_FiscalYearID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.FiscalYearID) ? string.Empty : base.GetintAsString(ColumnNames.FiscalYearID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.FiscalYearID);
				else
					this.FiscalYearID = base.SetintAsString(ColumnNames.FiscalYearID, value);
			}
		}

		public virtual string s_StartDate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.StartDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.StartDate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.StartDate);
				else
					this.StartDate = base.SetDateTimeAsString(ColumnNames.StartDate, value);
			}
		}

		public virtual string s_EndDate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.EndDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.EndDate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.EndDate);
				else
					this.EndDate = base.SetDateTimeAsString(ColumnNames.EndDate, value);
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

		public virtual string s_PeriodCode
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.PeriodCode) ? string.Empty : base.GetstringAsString(ColumnNames.PeriodCode);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.PeriodCode);
				else
					this.PeriodCode = base.SetstringAsString(ColumnNames.PeriodCode, value);
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
				
				
				public WhereParameter PeriodID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.PeriodID, Parameters.PeriodID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter FiscalYearID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.FiscalYearID, Parameters.FiscalYearID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter StartDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.StartDate, Parameters.StartDate);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter EndDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.EndDate, Parameters.EndDate);
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

				public WhereParameter PeriodCode
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.PeriodCode, Parameters.PeriodCode);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter PeriodID
		    {
				get
		        {
					if(_PeriodID_W == null)
	        	    {
						_PeriodID_W = TearOff.PeriodID;
					}
					return _PeriodID_W;
				}
			}

			public WhereParameter FiscalYearID
		    {
				get
		        {
					if(_FiscalYearID_W == null)
	        	    {
						_FiscalYearID_W = TearOff.FiscalYearID;
					}
					return _FiscalYearID_W;
				}
			}

			public WhereParameter StartDate
		    {
				get
		        {
					if(_StartDate_W == null)
	        	    {
						_StartDate_W = TearOff.StartDate;
					}
					return _StartDate_W;
				}
			}

			public WhereParameter EndDate
		    {
				get
		        {
					if(_EndDate_W == null)
	        	    {
						_EndDate_W = TearOff.EndDate;
					}
					return _EndDate_W;
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

			public WhereParameter PeriodCode
		    {
				get
		        {
					if(_PeriodCode_W == null)
	        	    {
						_PeriodCode_W = TearOff.PeriodCode;
					}
					return _PeriodCode_W;
				}
			}

			private WhereParameter _PeriodID_W = null;
			private WhereParameter _FiscalYearID_W = null;
			private WhereParameter _StartDate_W = null;
			private WhereParameter _EndDate_W = null;
			private WhereParameter _Rowguid_W = null;
			private WhereParameter _PeriodCode_W = null;

			public void WhereClauseReset()
			{
				_PeriodID_W = null;
				_FiscalYearID_W = null;
				_StartDate_W = null;
				_EndDate_W = null;
				_Rowguid_W = null;
				_PeriodCode_W = null;

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
				
				
				public AggregateParameter PeriodID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.PeriodID, Parameters.PeriodID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter FiscalYearID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.FiscalYearID, Parameters.FiscalYearID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter StartDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.StartDate, Parameters.StartDate);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter EndDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.EndDate, Parameters.EndDate);
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

				public AggregateParameter PeriodCode
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.PeriodCode, Parameters.PeriodCode);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter PeriodID
		    {
				get
		        {
					if(_PeriodID_W == null)
	        	    {
						_PeriodID_W = TearOff.PeriodID;
					}
					return _PeriodID_W;
				}
			}

			public AggregateParameter FiscalYearID
		    {
				get
		        {
					if(_FiscalYearID_W == null)
	        	    {
						_FiscalYearID_W = TearOff.FiscalYearID;
					}
					return _FiscalYearID_W;
				}
			}

			public AggregateParameter StartDate
		    {
				get
		        {
					if(_StartDate_W == null)
	        	    {
						_StartDate_W = TearOff.StartDate;
					}
					return _StartDate_W;
				}
			}

			public AggregateParameter EndDate
		    {
				get
		        {
					if(_EndDate_W == null)
	        	    {
						_EndDate_W = TearOff.EndDate;
					}
					return _EndDate_W;
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

			public AggregateParameter PeriodCode
		    {
				get
		        {
					if(_PeriodCode_W == null)
	        	    {
						_PeriodCode_W = TearOff.PeriodCode;
					}
					return _PeriodCode_W;
				}
			}

			private AggregateParameter _PeriodID_W = null;
			private AggregateParameter _FiscalYearID_W = null;
			private AggregateParameter _StartDate_W = null;
			private AggregateParameter _EndDate_W = null;
			private AggregateParameter _Rowguid_W = null;
			private AggregateParameter _PeriodCode_W = null;

			public void AggregateClauseReset()
			{
				_PeriodID_W = null;
				_FiscalYearID_W = null;
				_StartDate_W = null;
				_EndDate_W = null;
				_Rowguid_W = null;
				_PeriodCode_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_PeriodInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.PeriodID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_PeriodUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_PeriodDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.PeriodID);
			p.SourceColumn = ColumnNames.PeriodID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.PeriodID);
			p.SourceColumn = ColumnNames.PeriodID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.FiscalYearID);
			p.SourceColumn = ColumnNames.FiscalYearID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.StartDate);
			p.SourceColumn = ColumnNames.StartDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.EndDate);
			p.SourceColumn = ColumnNames.EndDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Rowguid);
			p.SourceColumn = ColumnNames.Rowguid;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.PeriodCode);
			p.SourceColumn = ColumnNames.PeriodCode;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
