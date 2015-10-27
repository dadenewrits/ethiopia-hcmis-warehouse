
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
	public abstract class _ReceivingUnitHub : SqlClientEntity
	{
		public _ReceivingUnitHub()
		{
			this.QuerySource = "ReceivingUnitHub";
			this.MappingName = "ReceivingUnitHub";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ReceivingUnitHubLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int ReceivingUnitHubID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.ReceivingUnitHubID, ReceivingUnitHubID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ReceivingUnitHubLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter ReceivingUnitHubID
			{
				get
				{
					return new SqlParameter("@ReceivingUnitHubID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter ReceivingUnitID
			{
				get
				{
					return new SqlParameter("@ReceivingUnitID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter HubID
			{
				get
				{
					return new SqlParameter("@HubID", SqlDbType.Int, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string ReceivingUnitHubID = "ReceivingUnitHubID";
            public const string ReceivingUnitID = "ReceivingUnitID";
            public const string HubID = "HubID";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ReceivingUnitHubID] = _ReceivingUnitHub.PropertyNames.ReceivingUnitHubID;
					ht[ReceivingUnitID] = _ReceivingUnitHub.PropertyNames.ReceivingUnitID;
					ht[HubID] = _ReceivingUnitHub.PropertyNames.HubID;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string ReceivingUnitHubID = "ReceivingUnitHubID";
            public const string ReceivingUnitID = "ReceivingUnitID";
            public const string HubID = "HubID";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ReceivingUnitHubID] = _ReceivingUnitHub.ColumnNames.ReceivingUnitHubID;
					ht[ReceivingUnitID] = _ReceivingUnitHub.ColumnNames.ReceivingUnitID;
					ht[HubID] = _ReceivingUnitHub.ColumnNames.HubID;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string ReceivingUnitHubID = "s_ReceivingUnitHubID";
            public const string ReceivingUnitID = "s_ReceivingUnitID";
            public const string HubID = "s_HubID";

		}
		#endregion		
		
		#region Properties
	
		public virtual int ReceivingUnitHubID
	    {
			get
	        {
				return base.Getint(ColumnNames.ReceivingUnitHubID);
			}
			set
	        {
				base.Setint(ColumnNames.ReceivingUnitHubID, value);
			}
		}

		public virtual int ReceivingUnitID
	    {
			get
	        {
				return base.Getint(ColumnNames.ReceivingUnitID);
			}
			set
	        {
				base.Setint(ColumnNames.ReceivingUnitID, value);
			}
		}

		public virtual int HubID
	    {
			get
	        {
				return base.Getint(ColumnNames.HubID);
			}
			set
	        {
				base.Setint(ColumnNames.HubID, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_ReceivingUnitHubID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ReceivingUnitHubID) ? string.Empty : base.GetintAsString(ColumnNames.ReceivingUnitHubID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ReceivingUnitHubID);
				else
					this.ReceivingUnitHubID = base.SetintAsString(ColumnNames.ReceivingUnitHubID, value);
			}
		}

		public virtual string s_ReceivingUnitID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ReceivingUnitID) ? string.Empty : base.GetintAsString(ColumnNames.ReceivingUnitID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ReceivingUnitID);
				else
					this.ReceivingUnitID = base.SetintAsString(ColumnNames.ReceivingUnitID, value);
			}
		}

		public virtual string s_HubID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.HubID) ? string.Empty : base.GetintAsString(ColumnNames.HubID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.HubID);
				else
					this.HubID = base.SetintAsString(ColumnNames.HubID, value);
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
				
				
				public WhereParameter ReceivingUnitHubID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ReceivingUnitHubID, Parameters.ReceivingUnitHubID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ReceivingUnitID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ReceivingUnitID, Parameters.ReceivingUnitID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter HubID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.HubID, Parameters.HubID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter ReceivingUnitHubID
		    {
				get
		        {
					if(_ReceivingUnitHubID_W == null)
	        	    {
						_ReceivingUnitHubID_W = TearOff.ReceivingUnitHubID;
					}
					return _ReceivingUnitHubID_W;
				}
			}

			public WhereParameter ReceivingUnitID
		    {
				get
		        {
					if(_ReceivingUnitID_W == null)
	        	    {
						_ReceivingUnitID_W = TearOff.ReceivingUnitID;
					}
					return _ReceivingUnitID_W;
				}
			}

			public WhereParameter HubID
		    {
				get
		        {
					if(_HubID_W == null)
	        	    {
						_HubID_W = TearOff.HubID;
					}
					return _HubID_W;
				}
			}

			private WhereParameter _ReceivingUnitHubID_W = null;
			private WhereParameter _ReceivingUnitID_W = null;
			private WhereParameter _HubID_W = null;

			public void WhereClauseReset()
			{
				_ReceivingUnitHubID_W = null;
				_ReceivingUnitID_W = null;
				_HubID_W = null;

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
				
				
				public AggregateParameter ReceivingUnitHubID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ReceivingUnitHubID, Parameters.ReceivingUnitHubID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ReceivingUnitID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ReceivingUnitID, Parameters.ReceivingUnitID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter HubID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.HubID, Parameters.HubID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter ReceivingUnitHubID
		    {
				get
		        {
					if(_ReceivingUnitHubID_W == null)
	        	    {
						_ReceivingUnitHubID_W = TearOff.ReceivingUnitHubID;
					}
					return _ReceivingUnitHubID_W;
				}
			}

			public AggregateParameter ReceivingUnitID
		    {
				get
		        {
					if(_ReceivingUnitID_W == null)
	        	    {
						_ReceivingUnitID_W = TearOff.ReceivingUnitID;
					}
					return _ReceivingUnitID_W;
				}
			}

			public AggregateParameter HubID
		    {
				get
		        {
					if(_HubID_W == null)
	        	    {
						_HubID_W = TearOff.HubID;
					}
					return _HubID_W;
				}
			}

			private AggregateParameter _ReceivingUnitHubID_W = null;
			private AggregateParameter _ReceivingUnitID_W = null;
			private AggregateParameter _HubID_W = null;

			public void AggregateClauseReset()
			{
				_ReceivingUnitHubID_W = null;
				_ReceivingUnitID_W = null;
				_HubID_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ReceivingUnitHubInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.ReceivingUnitHubID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ReceivingUnitHubUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ReceivingUnitHubDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.ReceivingUnitHubID);
			p.SourceColumn = ColumnNames.ReceivingUnitHubID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.ReceivingUnitHubID);
			p.SourceColumn = ColumnNames.ReceivingUnitHubID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ReceivingUnitID);
			p.SourceColumn = ColumnNames.ReceivingUnitID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.HubID);
			p.SourceColumn = ColumnNames.HubID;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
