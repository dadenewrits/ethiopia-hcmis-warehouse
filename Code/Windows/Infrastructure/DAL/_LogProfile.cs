
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
	public abstract class _LogProfile : SqlClientEntity
	{
		public _LogProfile()
		{
			this.QuerySource = "LogProfile";
			this.MappingName = "LogProfile";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_LogProfileLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int LogID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.LogID, LogID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_LogProfileLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter LogID
			{
				get
				{
					return new SqlParameter("@LogID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Page
			{
				get
				{
					return new SqlParameter("@Page", SqlDbType.NText, 1073741823);
				}
			}
			
			public static SqlParameter Action
			{
				get
				{
					return new SqlParameter("@Action", SqlDbType.NText, 1073741823);
				}
			}
			
			public static SqlParameter OperationID
			{
				get
				{
					return new SqlParameter("@OperationID", SqlDbType.UniqueIdentifier, 0);
				}
			}
			
			public static SqlParameter EndTime
			{
				get
				{
					return new SqlParameter("@EndTime", SqlDbType.DateTime, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string LogID = "LogID";
            public const string Page = "Page";
            public const string Action = "Action";
            public const string OperationID = "OperationID";
            public const string EndTime = "EndTime";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[LogID] = _LogProfile.PropertyNames.LogID;
					ht[Page] = _LogProfile.PropertyNames.Page;
					ht[Action] = _LogProfile.PropertyNames.Action;
					ht[OperationID] = _LogProfile.PropertyNames.OperationID;
					ht[EndTime] = _LogProfile.PropertyNames.EndTime;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string LogID = "LogID";
            public const string Page = "Page";
            public const string Action = "Action";
            public const string OperationID = "OperationID";
            public const string EndTime = "EndTime";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[LogID] = _LogProfile.ColumnNames.LogID;
					ht[Page] = _LogProfile.ColumnNames.Page;
					ht[Action] = _LogProfile.ColumnNames.Action;
					ht[OperationID] = _LogProfile.ColumnNames.OperationID;
					ht[EndTime] = _LogProfile.ColumnNames.EndTime;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string LogID = "s_LogID";
            public const string Page = "s_Page";
            public const string Action = "s_Action";
            public const string OperationID = "s_OperationID";
            public const string EndTime = "s_EndTime";

		}
		#endregion		
		
		#region Properties
	
		public virtual int LogID
	    {
			get
	        {
				return base.Getint(ColumnNames.LogID);
			}
			set
	        {
				base.Setint(ColumnNames.LogID, value);
			}
		}

		public virtual string Page
	    {
			get
	        {
				return base.Getstring(ColumnNames.Page);
			}
			set
	        {
				base.Setstring(ColumnNames.Page, value);
			}
		}

		public virtual string Action
	    {
			get
	        {
				return base.Getstring(ColumnNames.Action);
			}
			set
	        {
				base.Setstring(ColumnNames.Action, value);
			}
		}

		public virtual Guid OperationID
	    {
			get
	        {
				return base.GetGuid(ColumnNames.OperationID);
			}
			set
	        {
				base.SetGuid(ColumnNames.OperationID, value);
			}
		}

		public virtual DateTime EndTime
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.EndTime);
			}
			set
	        {
				base.SetDateTime(ColumnNames.EndTime, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_LogID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.LogID) ? string.Empty : base.GetintAsString(ColumnNames.LogID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.LogID);
				else
					this.LogID = base.SetintAsString(ColumnNames.LogID, value);
			}
		}

		public virtual string s_Page
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Page) ? string.Empty : base.GetstringAsString(ColumnNames.Page);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Page);
				else
					this.Page = base.SetstringAsString(ColumnNames.Page, value);
			}
		}

		public virtual string s_Action
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Action) ? string.Empty : base.GetstringAsString(ColumnNames.Action);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Action);
				else
					this.Action = base.SetstringAsString(ColumnNames.Action, value);
			}
		}

		public virtual string s_OperationID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.OperationID) ? string.Empty : base.GetGuidAsString(ColumnNames.OperationID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.OperationID);
				else
					this.OperationID = base.SetGuidAsString(ColumnNames.OperationID, value);
			}
		}

		public virtual string s_EndTime
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.EndTime) ? string.Empty : base.GetDateTimeAsString(ColumnNames.EndTime);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.EndTime);
				else
					this.EndTime = base.SetDateTimeAsString(ColumnNames.EndTime, value);
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
				
				
				public WhereParameter LogID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.LogID, Parameters.LogID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Page
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Page, Parameters.Page);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Action
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Action, Parameters.Action);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter OperationID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.OperationID, Parameters.OperationID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter EndTime
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.EndTime, Parameters.EndTime);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter LogID
		    {
				get
		        {
					if(_LogID_W == null)
	        	    {
						_LogID_W = TearOff.LogID;
					}
					return _LogID_W;
				}
			}

			public WhereParameter Page
		    {
				get
		        {
					if(_Page_W == null)
	        	    {
						_Page_W = TearOff.Page;
					}
					return _Page_W;
				}
			}

			public WhereParameter Action
		    {
				get
		        {
					if(_Action_W == null)
	        	    {
						_Action_W = TearOff.Action;
					}
					return _Action_W;
				}
			}

			public WhereParameter OperationID
		    {
				get
		        {
					if(_OperationID_W == null)
	        	    {
						_OperationID_W = TearOff.OperationID;
					}
					return _OperationID_W;
				}
			}

			public WhereParameter EndTime
		    {
				get
		        {
					if(_EndTime_W == null)
	        	    {
						_EndTime_W = TearOff.EndTime;
					}
					return _EndTime_W;
				}
			}

			private WhereParameter _LogID_W = null;
			private WhereParameter _Page_W = null;
			private WhereParameter _Action_W = null;
			private WhereParameter _OperationID_W = null;
			private WhereParameter _EndTime_W = null;

			public void WhereClauseReset()
			{
				_LogID_W = null;
				_Page_W = null;
				_Action_W = null;
				_OperationID_W = null;
				_EndTime_W = null;

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
				
				
				public AggregateParameter LogID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.LogID, Parameters.LogID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Page
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Page, Parameters.Page);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Action
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Action, Parameters.Action);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter OperationID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.OperationID, Parameters.OperationID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter EndTime
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.EndTime, Parameters.EndTime);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter LogID
		    {
				get
		        {
					if(_LogID_W == null)
	        	    {
						_LogID_W = TearOff.LogID;
					}
					return _LogID_W;
				}
			}

			public AggregateParameter Page
		    {
				get
		        {
					if(_Page_W == null)
	        	    {
						_Page_W = TearOff.Page;
					}
					return _Page_W;
				}
			}

			public AggregateParameter Action
		    {
				get
		        {
					if(_Action_W == null)
	        	    {
						_Action_W = TearOff.Action;
					}
					return _Action_W;
				}
			}

			public AggregateParameter OperationID
		    {
				get
		        {
					if(_OperationID_W == null)
	        	    {
						_OperationID_W = TearOff.OperationID;
					}
					return _OperationID_W;
				}
			}

			public AggregateParameter EndTime
		    {
				get
		        {
					if(_EndTime_W == null)
	        	    {
						_EndTime_W = TearOff.EndTime;
					}
					return _EndTime_W;
				}
			}

			private AggregateParameter _LogID_W = null;
			private AggregateParameter _Page_W = null;
			private AggregateParameter _Action_W = null;
			private AggregateParameter _OperationID_W = null;
			private AggregateParameter _EndTime_W = null;

			public void AggregateClauseReset()
			{
				_LogID_W = null;
				_Page_W = null;
				_Action_W = null;
				_OperationID_W = null;
				_EndTime_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_LogProfileInsert]";
	
			CreateParameters(cmd);
			    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_LogProfileUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_LogProfileDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.LogID);
			p.SourceColumn = ColumnNames.LogID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.LogID);
			p.SourceColumn = ColumnNames.LogID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Page);
			p.SourceColumn = ColumnNames.Page;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Action);
			p.SourceColumn = ColumnNames.Action;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.OperationID);
			p.SourceColumn = ColumnNames.OperationID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.EndTime);
			p.SourceColumn = ColumnNames.EndTime;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
