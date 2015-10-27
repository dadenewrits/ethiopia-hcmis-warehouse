
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
	public abstract class _ProductReceivingUnitType : SqlClientEntity
	{
		public _ProductReceivingUnitType()
		{
			this.QuerySource = "ProductReceivingUnitType";
			this.MappingName = "ProductReceivingUnitType";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ProductReceivingUnitTypeLoadAll]", parameters);
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

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ProductReceivingUnitTypeLoadByPrimaryKey]", parameters);
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
			
			public static SqlParameter ProductID
			{
				get
				{
					return new SqlParameter("@ProductID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter ReceivingUnitTypeID
			{
				get
				{
					return new SqlParameter("@ReceivingUnitTypeID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter AllowFully
			{
				get
				{
					return new SqlParameter("@AllowFully", SqlDbType.Bit, 0);
				}
			}
			
			public static SqlParameter Warning
			{
				get
				{
					return new SqlParameter("@Warning", SqlDbType.Bit, 0);
				}
			}
			
			public static SqlParameter Restriction
			{
				get
				{
					return new SqlParameter("@Restriction", SqlDbType.Bit, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string ID = "ID";
            public const string ProductID = "ProductID";
            public const string ReceivingUnitTypeID = "ReceivingUnitTypeID";
            public const string AllowFully = "AllowFully";
            public const string Warning = "Warning";
            public const string Restriction = "Restriction";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ID] = _ProductReceivingUnitType.PropertyNames.ID;
					ht[ProductID] = _ProductReceivingUnitType.PropertyNames.ProductID;
					ht[ReceivingUnitTypeID] = _ProductReceivingUnitType.PropertyNames.ReceivingUnitTypeID;
					ht[AllowFully] = _ProductReceivingUnitType.PropertyNames.AllowFully;
					ht[Warning] = _ProductReceivingUnitType.PropertyNames.Warning;
					ht[Restriction] = _ProductReceivingUnitType.PropertyNames.Restriction;

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
            public const string ProductID = "ProductID";
            public const string ReceivingUnitTypeID = "ReceivingUnitTypeID";
            public const string AllowFully = "AllowFully";
            public const string Warning = "Warning";
            public const string Restriction = "Restriction";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ID] = _ProductReceivingUnitType.ColumnNames.ID;
					ht[ProductID] = _ProductReceivingUnitType.ColumnNames.ProductID;
					ht[ReceivingUnitTypeID] = _ProductReceivingUnitType.ColumnNames.ReceivingUnitTypeID;
					ht[AllowFully] = _ProductReceivingUnitType.ColumnNames.AllowFully;
					ht[Warning] = _ProductReceivingUnitType.ColumnNames.Warning;
					ht[Restriction] = _ProductReceivingUnitType.ColumnNames.Restriction;

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
            public const string ProductID = "s_ProductID";
            public const string ReceivingUnitTypeID = "s_ReceivingUnitTypeID";
            public const string AllowFully = "s_AllowFully";
            public const string Warning = "s_Warning";
            public const string Restriction = "s_Restriction";

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

		public virtual int ProductID
	    {
			get
	        {
				return base.Getint(ColumnNames.ProductID);
			}
			set
	        {
				base.Setint(ColumnNames.ProductID, value);
			}
		}

		public virtual int ReceivingUnitTypeID
	    {
			get
	        {
				return base.Getint(ColumnNames.ReceivingUnitTypeID);
			}
			set
	        {
				base.Setint(ColumnNames.ReceivingUnitTypeID, value);
			}
		}

		public virtual bool AllowFully
	    {
			get
	        {
				return base.Getbool(ColumnNames.AllowFully);
			}
			set
	        {
				base.Setbool(ColumnNames.AllowFully, value);
			}
		}

		public virtual bool Warning
	    {
			get
	        {
				return base.Getbool(ColumnNames.Warning);
			}
			set
	        {
				base.Setbool(ColumnNames.Warning, value);
			}
		}

		public virtual bool Restriction
	    {
			get
	        {
				return base.Getbool(ColumnNames.Restriction);
			}
			set
	        {
				base.Setbool(ColumnNames.Restriction, value);
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

		public virtual string s_ProductID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ProductID) ? string.Empty : base.GetintAsString(ColumnNames.ProductID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ProductID);
				else
					this.ProductID = base.SetintAsString(ColumnNames.ProductID, value);
			}
		}

		public virtual string s_ReceivingUnitTypeID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ReceivingUnitTypeID) ? string.Empty : base.GetintAsString(ColumnNames.ReceivingUnitTypeID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ReceivingUnitTypeID);
				else
					this.ReceivingUnitTypeID = base.SetintAsString(ColumnNames.ReceivingUnitTypeID, value);
			}
		}

		public virtual string s_AllowFully
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AllowFully) ? string.Empty : base.GetboolAsString(ColumnNames.AllowFully);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AllowFully);
				else
					this.AllowFully = base.SetboolAsString(ColumnNames.AllowFully, value);
			}
		}

		public virtual string s_Warning
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Warning) ? string.Empty : base.GetboolAsString(ColumnNames.Warning);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Warning);
				else
					this.Warning = base.SetboolAsString(ColumnNames.Warning, value);
			}
		}

		public virtual string s_Restriction
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Restriction) ? string.Empty : base.GetboolAsString(ColumnNames.Restriction);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Restriction);
				else
					this.Restriction = base.SetboolAsString(ColumnNames.Restriction, value);
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

				public WhereParameter ProductID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ProductID, Parameters.ProductID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ReceivingUnitTypeID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ReceivingUnitTypeID, Parameters.ReceivingUnitTypeID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter AllowFully
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AllowFully, Parameters.AllowFully);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Warning
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Warning, Parameters.Warning);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Restriction
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Restriction, Parameters.Restriction);
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

			public WhereParameter ProductID
		    {
				get
		        {
					if(_ProductID_W == null)
	        	    {
						_ProductID_W = TearOff.ProductID;
					}
					return _ProductID_W;
				}
			}

			public WhereParameter ReceivingUnitTypeID
		    {
				get
		        {
					if(_ReceivingUnitTypeID_W == null)
	        	    {
						_ReceivingUnitTypeID_W = TearOff.ReceivingUnitTypeID;
					}
					return _ReceivingUnitTypeID_W;
				}
			}

			public WhereParameter AllowFully
		    {
				get
		        {
					if(_AllowFully_W == null)
	        	    {
						_AllowFully_W = TearOff.AllowFully;
					}
					return _AllowFully_W;
				}
			}

			public WhereParameter Warning
		    {
				get
		        {
					if(_Warning_W == null)
	        	    {
						_Warning_W = TearOff.Warning;
					}
					return _Warning_W;
				}
			}

			public WhereParameter Restriction
		    {
				get
		        {
					if(_Restriction_W == null)
	        	    {
						_Restriction_W = TearOff.Restriction;
					}
					return _Restriction_W;
				}
			}

			private WhereParameter _ID_W = null;
			private WhereParameter _ProductID_W = null;
			private WhereParameter _ReceivingUnitTypeID_W = null;
			private WhereParameter _AllowFully_W = null;
			private WhereParameter _Warning_W = null;
			private WhereParameter _Restriction_W = null;

			public void WhereClauseReset()
			{
				_ID_W = null;
				_ProductID_W = null;
				_ReceivingUnitTypeID_W = null;
				_AllowFully_W = null;
				_Warning_W = null;
				_Restriction_W = null;

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

				public AggregateParameter ProductID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ProductID, Parameters.ProductID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ReceivingUnitTypeID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ReceivingUnitTypeID, Parameters.ReceivingUnitTypeID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter AllowFully
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AllowFully, Parameters.AllowFully);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Warning
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Warning, Parameters.Warning);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Restriction
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Restriction, Parameters.Restriction);
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

			public AggregateParameter ProductID
		    {
				get
		        {
					if(_ProductID_W == null)
	        	    {
						_ProductID_W = TearOff.ProductID;
					}
					return _ProductID_W;
				}
			}

			public AggregateParameter ReceivingUnitTypeID
		    {
				get
		        {
					if(_ReceivingUnitTypeID_W == null)
	        	    {
						_ReceivingUnitTypeID_W = TearOff.ReceivingUnitTypeID;
					}
					return _ReceivingUnitTypeID_W;
				}
			}

			public AggregateParameter AllowFully
		    {
				get
		        {
					if(_AllowFully_W == null)
	        	    {
						_AllowFully_W = TearOff.AllowFully;
					}
					return _AllowFully_W;
				}
			}

			public AggregateParameter Warning
		    {
				get
		        {
					if(_Warning_W == null)
	        	    {
						_Warning_W = TearOff.Warning;
					}
					return _Warning_W;
				}
			}

			public AggregateParameter Restriction
		    {
				get
		        {
					if(_Restriction_W == null)
	        	    {
						_Restriction_W = TearOff.Restriction;
					}
					return _Restriction_W;
				}
			}

			private AggregateParameter _ID_W = null;
			private AggregateParameter _ProductID_W = null;
			private AggregateParameter _ReceivingUnitTypeID_W = null;
			private AggregateParameter _AllowFully_W = null;
			private AggregateParameter _Warning_W = null;
			private AggregateParameter _Restriction_W = null;

			public void AggregateClauseReset()
			{
				_ID_W = null;
				_ProductID_W = null;
				_ReceivingUnitTypeID_W = null;
				_AllowFully_W = null;
				_Warning_W = null;
				_Restriction_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ProductReceivingUnitTypeInsert]";
	
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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ProductReceivingUnitTypeUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ProductReceivingUnitTypeDelete]";
	
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

			p = cmd.Parameters.Add(Parameters.ProductID);
			p.SourceColumn = ColumnNames.ProductID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ReceivingUnitTypeID);
			p.SourceColumn = ColumnNames.ReceivingUnitTypeID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.AllowFully);
			p.SourceColumn = ColumnNames.AllowFully;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Warning);
			p.SourceColumn = ColumnNames.Warning;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Restriction);
			p.SourceColumn = ColumnNames.Restriction;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
