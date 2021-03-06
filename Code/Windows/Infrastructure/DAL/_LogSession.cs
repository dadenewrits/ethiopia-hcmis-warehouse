
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
	public abstract class _LogSession : SqlClientEntity
	{
		public _LogSession()
		{
			this.QuerySource = "LogSession";
			this.MappingName = "LogSession";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_LogSessionLoadAll]", parameters);
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

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_LogSessionLoadByPrimaryKey]", parameters);
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
			
			public static SqlParameter SessionID
			{
				get
				{
					return new SqlParameter("@SessionID", SqlDbType.UniqueIdentifier, 0);
				}
			}
			
			public static SqlParameter EndTime
			{
				get
				{
					return new SqlParameter("@EndTime", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter IPAddress
			{
				get
				{
					return new SqlParameter("@IPAddress", SqlDbType.NText, 1073741823);
				}
			}
			
			public static SqlParameter VPNIP
			{
				get
				{
					return new SqlParameter("@VPNIP", SqlDbType.NText, 1073741823);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string LogID = "LogID";
            public const string SessionID = "SessionID";
            public const string EndTime = "EndTime";
            public const string IPAddress = "IPAddress";
            public const string VPNIP = "VPNIP";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[LogID] = _LogSession.PropertyNames.LogID;
					ht[SessionID] = _LogSession.PropertyNames.SessionID;
					ht[EndTime] = _LogSession.PropertyNames.EndTime;
					ht[IPAddress] = _LogSession.PropertyNames.IPAddress;
					ht[VPNIP] = _LogSession.PropertyNames.VPNIP;

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
            public const string SessionID = "SessionID";
            public const string EndTime = "EndTime";
            public const string IPAddress = "IPAddress";
            public const string VPNIP = "VPNIP";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[LogID] = _LogSession.ColumnNames.LogID;
					ht[SessionID] = _LogSession.ColumnNames.SessionID;
					ht[EndTime] = _LogSession.ColumnNames.EndTime;
					ht[IPAddress] = _LogSession.ColumnNames.IPAddress;
					ht[VPNIP] = _LogSession.ColumnNames.VPNIP;

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
            public const string SessionID = "s_SessionID";
            public const string EndTime = "s_EndTime";
            public const string IPAddress = "s_IPAddress";
            public const string VPNIP = "s_VPNIP";

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

		public virtual Guid SessionID
	    {
			get
	        {
				return base.GetGuid(ColumnNames.SessionID);
			}
			set
	        {
				base.SetGuid(ColumnNames.SessionID, value);
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

		public virtual string IPAddress
	    {
			get
	        {
				return base.Getstring(ColumnNames.IPAddress);
			}
			set
	        {
				base.Setstring(ColumnNames.IPAddress, value);
			}
		}

		public virtual string VPNIP
	    {
			get
	        {
				return base.Getstring(ColumnNames.VPNIP);
			}
			set
	        {
				base.Setstring(ColumnNames.VPNIP, value);
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

		public virtual string s_SessionID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.SessionID) ? string.Empty : base.GetGuidAsString(ColumnNames.SessionID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.SessionID);
				else
					this.SessionID = base.SetGuidAsString(ColumnNames.SessionID, value);
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

		public virtual string s_IPAddress
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.IPAddress) ? string.Empty : base.GetstringAsString(ColumnNames.IPAddress);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.IPAddress);
				else
					this.IPAddress = base.SetstringAsString(ColumnNames.IPAddress, value);
			}
		}

		public virtual string s_VPNIP
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.VPNIP) ? string.Empty : base.GetstringAsString(ColumnNames.VPNIP);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.VPNIP);
				else
					this.VPNIP = base.SetstringAsString(ColumnNames.VPNIP, value);
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

				public WhereParameter SessionID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.SessionID, Parameters.SessionID);
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

				public WhereParameter IPAddress
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.IPAddress, Parameters.IPAddress);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter VPNIP
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.VPNIP, Parameters.VPNIP);
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

			public WhereParameter SessionID
		    {
				get
		        {
					if(_SessionID_W == null)
	        	    {
						_SessionID_W = TearOff.SessionID;
					}
					return _SessionID_W;
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

			public WhereParameter IPAddress
		    {
				get
		        {
					if(_IPAddress_W == null)
	        	    {
						_IPAddress_W = TearOff.IPAddress;
					}
					return _IPAddress_W;
				}
			}

			public WhereParameter VPNIP
		    {
				get
		        {
					if(_VPNIP_W == null)
	        	    {
						_VPNIP_W = TearOff.VPNIP;
					}
					return _VPNIP_W;
				}
			}

			private WhereParameter _LogID_W = null;
			private WhereParameter _SessionID_W = null;
			private WhereParameter _EndTime_W = null;
			private WhereParameter _IPAddress_W = null;
			private WhereParameter _VPNIP_W = null;

			public void WhereClauseReset()
			{
				_LogID_W = null;
				_SessionID_W = null;
				_EndTime_W = null;
				_IPAddress_W = null;
				_VPNIP_W = null;

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

				public AggregateParameter SessionID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.SessionID, Parameters.SessionID);
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

				public AggregateParameter IPAddress
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.IPAddress, Parameters.IPAddress);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter VPNIP
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.VPNIP, Parameters.VPNIP);
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

			public AggregateParameter SessionID
		    {
				get
		        {
					if(_SessionID_W == null)
	        	    {
						_SessionID_W = TearOff.SessionID;
					}
					return _SessionID_W;
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

			public AggregateParameter IPAddress
		    {
				get
		        {
					if(_IPAddress_W == null)
	        	    {
						_IPAddress_W = TearOff.IPAddress;
					}
					return _IPAddress_W;
				}
			}

			public AggregateParameter VPNIP
		    {
				get
		        {
					if(_VPNIP_W == null)
	        	    {
						_VPNIP_W = TearOff.VPNIP;
					}
					return _VPNIP_W;
				}
			}

			private AggregateParameter _LogID_W = null;
			private AggregateParameter _SessionID_W = null;
			private AggregateParameter _EndTime_W = null;
			private AggregateParameter _IPAddress_W = null;
			private AggregateParameter _VPNIP_W = null;

			public void AggregateClauseReset()
			{
				_LogID_W = null;
				_SessionID_W = null;
				_EndTime_W = null;
				_IPAddress_W = null;
				_VPNIP_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_LogSessionInsert]";
	
			CreateParameters(cmd);
			    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_LogSessionUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_LogSessionDelete]";
	
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

			p = cmd.Parameters.Add(Parameters.SessionID);
			p.SourceColumn = ColumnNames.SessionID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.EndTime);
			p.SourceColumn = ColumnNames.EndTime;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.IPAddress);
			p.SourceColumn = ColumnNames.IPAddress;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.VPNIP);
			p.SourceColumn = ColumnNames.VPNIP;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
