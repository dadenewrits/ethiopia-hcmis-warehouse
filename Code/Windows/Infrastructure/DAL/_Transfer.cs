
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
	public abstract class _Transfer : SqlClientEntity
	{
		public _Transfer()
		{
			this.QuerySource = "Transfer";
			this.MappingName = "Transfer";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_TransferLoadAll]", parameters);
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

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_TransferLoadByPrimaryKey]", parameters);
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
			
			public static SqlParameter OrderID
			{
				get
				{
					return new SqlParameter("@OrderID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter FromStoreID
			{
				get
				{
					return new SqlParameter("@FromStoreID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter ToStoreID
			{
				get
				{
					return new SqlParameter("@ToStoreID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter FromPhysicalStoreID
			{
				get
				{
					return new SqlParameter("@FromPhysicalStoreID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter ToPhysicalStoreID
			{
				get
				{
					return new SqlParameter("@ToPhysicalStoreID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter TransferTypeID
			{
				get
				{
					return new SqlParameter("@TransferTypeID", SqlDbType.Int, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string ID = "ID";
            public const string OrderID = "OrderID";
            public const string FromStoreID = "FromStoreID";
            public const string ToStoreID = "ToStoreID";
            public const string FromPhysicalStoreID = "FromPhysicalStoreID";
            public const string ToPhysicalStoreID = "ToPhysicalStoreID";
            public const string TransferTypeID = "TransferTypeID";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ID] = _Transfer.PropertyNames.ID;
					ht[OrderID] = _Transfer.PropertyNames.OrderID;
					ht[FromStoreID] = _Transfer.PropertyNames.FromStoreID;
					ht[ToStoreID] = _Transfer.PropertyNames.ToStoreID;
					ht[FromPhysicalStoreID] = _Transfer.PropertyNames.FromPhysicalStoreID;
					ht[ToPhysicalStoreID] = _Transfer.PropertyNames.ToPhysicalStoreID;
					ht[TransferTypeID] = _Transfer.PropertyNames.TransferTypeID;

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
            public const string OrderID = "OrderID";
            public const string FromStoreID = "FromStoreID";
            public const string ToStoreID = "ToStoreID";
            public const string FromPhysicalStoreID = "FromPhysicalStoreID";
            public const string ToPhysicalStoreID = "ToPhysicalStoreID";
            public const string TransferTypeID = "TransferTypeID";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ID] = _Transfer.ColumnNames.ID;
					ht[OrderID] = _Transfer.ColumnNames.OrderID;
					ht[FromStoreID] = _Transfer.ColumnNames.FromStoreID;
					ht[ToStoreID] = _Transfer.ColumnNames.ToStoreID;
					ht[FromPhysicalStoreID] = _Transfer.ColumnNames.FromPhysicalStoreID;
					ht[ToPhysicalStoreID] = _Transfer.ColumnNames.ToPhysicalStoreID;
					ht[TransferTypeID] = _Transfer.ColumnNames.TransferTypeID;

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
            public const string OrderID = "s_OrderID";
            public const string FromStoreID = "s_FromStoreID";
            public const string ToStoreID = "s_ToStoreID";
            public const string FromPhysicalStoreID = "s_FromPhysicalStoreID";
            public const string ToPhysicalStoreID = "s_ToPhysicalStoreID";
            public const string TransferTypeID = "s_TransferTypeID";

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

		public virtual int OrderID
	    {
			get
	        {
				return base.Getint(ColumnNames.OrderID);
			}
			set
	        {
				base.Setint(ColumnNames.OrderID, value);
			}
		}

		public virtual int FromStoreID
	    {
			get
	        {
				return base.Getint(ColumnNames.FromStoreID);
			}
			set
	        {
				base.Setint(ColumnNames.FromStoreID, value);
			}
		}

		public virtual int ToStoreID
	    {
			get
	        {
				return base.Getint(ColumnNames.ToStoreID);
			}
			set
	        {
				base.Setint(ColumnNames.ToStoreID, value);
			}
		}

		public virtual int FromPhysicalStoreID
	    {
			get
	        {
				return base.Getint(ColumnNames.FromPhysicalStoreID);
			}
			set
	        {
				base.Setint(ColumnNames.FromPhysicalStoreID, value);
			}
		}

		public virtual int ToPhysicalStoreID
	    {
			get
	        {
				return base.Getint(ColumnNames.ToPhysicalStoreID);
			}
			set
	        {
				base.Setint(ColumnNames.ToPhysicalStoreID, value);
			}
		}

		public virtual int TransferTypeID
	    {
			get
	        {
				return base.Getint(ColumnNames.TransferTypeID);
			}
			set
	        {
				base.Setint(ColumnNames.TransferTypeID, value);
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

		public virtual string s_OrderID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.OrderID) ? string.Empty : base.GetintAsString(ColumnNames.OrderID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.OrderID);
				else
					this.OrderID = base.SetintAsString(ColumnNames.OrderID, value);
			}
		}

		public virtual string s_FromStoreID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.FromStoreID) ? string.Empty : base.GetintAsString(ColumnNames.FromStoreID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.FromStoreID);
				else
					this.FromStoreID = base.SetintAsString(ColumnNames.FromStoreID, value);
			}
		}

		public virtual string s_ToStoreID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ToStoreID) ? string.Empty : base.GetintAsString(ColumnNames.ToStoreID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ToStoreID);
				else
					this.ToStoreID = base.SetintAsString(ColumnNames.ToStoreID, value);
			}
		}

		public virtual string s_FromPhysicalStoreID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.FromPhysicalStoreID) ? string.Empty : base.GetintAsString(ColumnNames.FromPhysicalStoreID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.FromPhysicalStoreID);
				else
					this.FromPhysicalStoreID = base.SetintAsString(ColumnNames.FromPhysicalStoreID, value);
			}
		}

		public virtual string s_ToPhysicalStoreID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ToPhysicalStoreID) ? string.Empty : base.GetintAsString(ColumnNames.ToPhysicalStoreID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ToPhysicalStoreID);
				else
					this.ToPhysicalStoreID = base.SetintAsString(ColumnNames.ToPhysicalStoreID, value);
			}
		}

		public virtual string s_TransferTypeID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.TransferTypeID) ? string.Empty : base.GetintAsString(ColumnNames.TransferTypeID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.TransferTypeID);
				else
					this.TransferTypeID = base.SetintAsString(ColumnNames.TransferTypeID, value);
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

				public WhereParameter OrderID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.OrderID, Parameters.OrderID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter FromStoreID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.FromStoreID, Parameters.FromStoreID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ToStoreID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ToStoreID, Parameters.ToStoreID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter FromPhysicalStoreID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.FromPhysicalStoreID, Parameters.FromPhysicalStoreID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ToPhysicalStoreID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ToPhysicalStoreID, Parameters.ToPhysicalStoreID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter TransferTypeID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.TransferTypeID, Parameters.TransferTypeID);
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

			public WhereParameter OrderID
		    {
				get
		        {
					if(_OrderID_W == null)
	        	    {
						_OrderID_W = TearOff.OrderID;
					}
					return _OrderID_W;
				}
			}

			public WhereParameter FromStoreID
		    {
				get
		        {
					if(_FromStoreID_W == null)
	        	    {
						_FromStoreID_W = TearOff.FromStoreID;
					}
					return _FromStoreID_W;
				}
			}

			public WhereParameter ToStoreID
		    {
				get
		        {
					if(_ToStoreID_W == null)
	        	    {
						_ToStoreID_W = TearOff.ToStoreID;
					}
					return _ToStoreID_W;
				}
			}

			public WhereParameter FromPhysicalStoreID
		    {
				get
		        {
					if(_FromPhysicalStoreID_W == null)
	        	    {
						_FromPhysicalStoreID_W = TearOff.FromPhysicalStoreID;
					}
					return _FromPhysicalStoreID_W;
				}
			}

			public WhereParameter ToPhysicalStoreID
		    {
				get
		        {
					if(_ToPhysicalStoreID_W == null)
	        	    {
						_ToPhysicalStoreID_W = TearOff.ToPhysicalStoreID;
					}
					return _ToPhysicalStoreID_W;
				}
			}

			public WhereParameter TransferTypeID
		    {
				get
		        {
					if(_TransferTypeID_W == null)
	        	    {
						_TransferTypeID_W = TearOff.TransferTypeID;
					}
					return _TransferTypeID_W;
				}
			}

			private WhereParameter _ID_W = null;
			private WhereParameter _OrderID_W = null;
			private WhereParameter _FromStoreID_W = null;
			private WhereParameter _ToStoreID_W = null;
			private WhereParameter _FromPhysicalStoreID_W = null;
			private WhereParameter _ToPhysicalStoreID_W = null;
			private WhereParameter _TransferTypeID_W = null;

			public void WhereClauseReset()
			{
				_ID_W = null;
				_OrderID_W = null;
				_FromStoreID_W = null;
				_ToStoreID_W = null;
				_FromPhysicalStoreID_W = null;
				_ToPhysicalStoreID_W = null;
				_TransferTypeID_W = null;

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

				public AggregateParameter OrderID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.OrderID, Parameters.OrderID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter FromStoreID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.FromStoreID, Parameters.FromStoreID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ToStoreID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ToStoreID, Parameters.ToStoreID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter FromPhysicalStoreID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.FromPhysicalStoreID, Parameters.FromPhysicalStoreID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ToPhysicalStoreID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ToPhysicalStoreID, Parameters.ToPhysicalStoreID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter TransferTypeID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.TransferTypeID, Parameters.TransferTypeID);
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

			public AggregateParameter OrderID
		    {
				get
		        {
					if(_OrderID_W == null)
	        	    {
						_OrderID_W = TearOff.OrderID;
					}
					return _OrderID_W;
				}
			}

			public AggregateParameter FromStoreID
		    {
				get
		        {
					if(_FromStoreID_W == null)
	        	    {
						_FromStoreID_W = TearOff.FromStoreID;
					}
					return _FromStoreID_W;
				}
			}

			public AggregateParameter ToStoreID
		    {
				get
		        {
					if(_ToStoreID_W == null)
	        	    {
						_ToStoreID_W = TearOff.ToStoreID;
					}
					return _ToStoreID_W;
				}
			}

			public AggregateParameter FromPhysicalStoreID
		    {
				get
		        {
					if(_FromPhysicalStoreID_W == null)
	        	    {
						_FromPhysicalStoreID_W = TearOff.FromPhysicalStoreID;
					}
					return _FromPhysicalStoreID_W;
				}
			}

			public AggregateParameter ToPhysicalStoreID
		    {
				get
		        {
					if(_ToPhysicalStoreID_W == null)
	        	    {
						_ToPhysicalStoreID_W = TearOff.ToPhysicalStoreID;
					}
					return _ToPhysicalStoreID_W;
				}
			}

			public AggregateParameter TransferTypeID
		    {
				get
		        {
					if(_TransferTypeID_W == null)
	        	    {
						_TransferTypeID_W = TearOff.TransferTypeID;
					}
					return _TransferTypeID_W;
				}
			}

			private AggregateParameter _ID_W = null;
			private AggregateParameter _OrderID_W = null;
			private AggregateParameter _FromStoreID_W = null;
			private AggregateParameter _ToStoreID_W = null;
			private AggregateParameter _FromPhysicalStoreID_W = null;
			private AggregateParameter _ToPhysicalStoreID_W = null;
			private AggregateParameter _TransferTypeID_W = null;

			public void AggregateClauseReset()
			{
				_ID_W = null;
				_OrderID_W = null;
				_FromStoreID_W = null;
				_ToStoreID_W = null;
				_FromPhysicalStoreID_W = null;
				_ToPhysicalStoreID_W = null;
				_TransferTypeID_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_TransferInsert]";
	
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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_TransferUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_TransferDelete]";
	
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

			p = cmd.Parameters.Add(Parameters.OrderID);
			p.SourceColumn = ColumnNames.OrderID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.FromStoreID);
			p.SourceColumn = ColumnNames.FromStoreID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ToStoreID);
			p.SourceColumn = ColumnNames.ToStoreID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.FromPhysicalStoreID);
			p.SourceColumn = ColumnNames.FromPhysicalStoreID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ToPhysicalStoreID);
			p.SourceColumn = ColumnNames.ToPhysicalStoreID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.TransferTypeID);
			p.SourceColumn = ColumnNames.TransferTypeID;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
