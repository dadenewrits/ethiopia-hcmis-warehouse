
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
    public abstract class _InstitutionType : SqlClientEntity
    {
        public _InstitutionType()
        {
            this.QuerySource = "InstitutionType";
            this.MappingName = "InstitutionType";

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

            return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_InstitutionTypeLoadAll]", parameters);
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


            return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_InstitutionTypeLoadByPrimaryKey]", parameters);
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
                    return new SqlParameter("@Description", SqlDbType.NVarChar, 50);
                }
            }

            public static SqlParameter Rowguid
            {
                get
                {
                    return new SqlParameter("@Rowguid", SqlDbType.UniqueIdentifier, 0);
                }
            }

            public static SqlParameter InstitutionParentTypeGuid
            {
                get
                {
                    return new SqlParameter("@InstitutionParentTypeGuid", SqlDbType.UniqueIdentifier, 0);
                }
            }

            public static SqlParameter IsActive
            {
                get
                {
                    return new SqlParameter("@IsActive", SqlDbType.Bit, 0);
                }
            }

            public static SqlParameter InstitutionParentTypeID
            {
                get
                {
                    return new SqlParameter("@InstitutionParentTypeID", SqlDbType.Int, 0);
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
            public const string Rowguid = "rowguid";
            public const string InstitutionParentTypeGuid = "InstitutionParentTypeGuid";
            public const string IsActive = "IsActive";
            public const string InstitutionParentTypeID = "InstitutionParentTypeID";

            static public string ToPropertyName(string columnName)
            {
                if (ht == null)
                {
                    ht = new Hashtable();

                    ht[ID] = _InstitutionType.PropertyNames.ID;
                    ht[Name] = _InstitutionType.PropertyNames.Name;
                    ht[Description] = _InstitutionType.PropertyNames.Description;
                    ht[Rowguid] = _InstitutionType.PropertyNames.Rowguid;
                    ht[InstitutionParentTypeGuid] = _InstitutionType.PropertyNames.InstitutionParentTypeGuid;
                    ht[IsActive] = _InstitutionType.PropertyNames.IsActive;
                    ht[InstitutionParentTypeID] = _InstitutionType.PropertyNames.InstitutionParentTypeID;

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
            public const string Rowguid = "Rowguid";
            public const string InstitutionParentTypeGuid = "InstitutionParentTypeGuid";
            public const string IsActive = "IsActive";
            public const string InstitutionParentTypeID = "InstitutionParentTypeID";

            static public string ToColumnName(string propertyName)
            {
                if (ht == null)
                {
                    ht = new Hashtable();

                    ht[ID] = _InstitutionType.ColumnNames.ID;
                    ht[Name] = _InstitutionType.ColumnNames.Name;
                    ht[Description] = _InstitutionType.ColumnNames.Description;
                    ht[Rowguid] = _InstitutionType.ColumnNames.Rowguid;
                    ht[InstitutionParentTypeGuid] = _InstitutionType.ColumnNames.InstitutionParentTypeGuid;
                    ht[IsActive] = _InstitutionType.ColumnNames.IsActive;
                    ht[InstitutionParentTypeID] = _InstitutionType.ColumnNames.InstitutionParentTypeID;

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
            public const string Rowguid = "s_Rowguid";
            public const string InstitutionParentTypeGuid = "s_InstitutionParentTypeGuid";
            public const string IsActive = "s_IsActive";
            public const string InstitutionParentTypeID = "s_InstitutionParentTypeID";

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

        public virtual Guid InstitutionParentTypeGuid
        {
            get
            {
                return base.GetGuid(ColumnNames.InstitutionParentTypeGuid);
            }
            set
            {
                base.SetGuid(ColumnNames.InstitutionParentTypeGuid, value);
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

        public virtual int InstitutionParentTypeID
        {
            get
            {
                return base.Getint(ColumnNames.InstitutionParentTypeID);
            }
            set
            {
                base.Setint(ColumnNames.InstitutionParentTypeID, value);
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
                if (string.Empty == value)
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
                if (string.Empty == value)
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
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Description);
                else
                    this.Description = base.SetstringAsString(ColumnNames.Description, value);
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
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Rowguid);
                else
                    this.Rowguid = base.SetGuidAsString(ColumnNames.Rowguid, value);
            }
        }

        public virtual string s_InstitutionParentTypeGuid
        {
            get
            {
                return this.IsColumnNull(ColumnNames.InstitutionParentTypeGuid) ? string.Empty : base.GetGuidAsString(ColumnNames.InstitutionParentTypeGuid);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.InstitutionParentTypeGuid);
                else
                    this.InstitutionParentTypeGuid = base.SetGuidAsString(ColumnNames.InstitutionParentTypeGuid, value);
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
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.IsActive);
                else
                    this.IsActive = base.SetboolAsString(ColumnNames.IsActive, value);
            }
        }

        public virtual string s_InstitutionParentTypeID
        {
            get
            {
                return this.IsColumnNull(ColumnNames.InstitutionParentTypeID) ? string.Empty : base.GetintAsString(ColumnNames.InstitutionParentTypeID);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.InstitutionParentTypeID);
                else
                    this.InstitutionParentTypeID = base.SetintAsString(ColumnNames.InstitutionParentTypeID, value);
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
                    if (_tearOff == null)
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

                public WhereParameter Rowguid
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Rowguid, Parameters.Rowguid);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter InstitutionParentTypeGuid
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.InstitutionParentTypeGuid, Parameters.InstitutionParentTypeGuid);
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

                public WhereParameter InstitutionParentTypeID
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.InstitutionParentTypeID, Parameters.InstitutionParentTypeID);
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
                    if (_ID_W == null)
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
                    if (_Name_W == null)
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
                    if (_Description_W == null)
                    {
                        _Description_W = TearOff.Description;
                    }
                    return _Description_W;
                }
            }

            public WhereParameter Rowguid
            {
                get
                {
                    if (_Rowguid_W == null)
                    {
                        _Rowguid_W = TearOff.Rowguid;
                    }
                    return _Rowguid_W;
                }
            }

            public WhereParameter InstitutionParentTypeGuid
            {
                get
                {
                    if (_InstitutionParentTypeGuid_W == null)
                    {
                        _InstitutionParentTypeGuid_W = TearOff.InstitutionParentTypeGuid;
                    }
                    return _InstitutionParentTypeGuid_W;
                }
            }

            public WhereParameter IsActive
            {
                get
                {
                    if (_IsActive_W == null)
                    {
                        _IsActive_W = TearOff.IsActive;
                    }
                    return _IsActive_W;
                }
            }

            public WhereParameter InstitutionParentTypeID
            {
                get
                {
                    if (_InstitutionParentTypeID_W == null)
                    {
                        _InstitutionParentTypeID_W = TearOff.InstitutionParentTypeID;
                    }
                    return _InstitutionParentTypeID_W;
                }
            }

            private WhereParameter _ID_W = null;
            private WhereParameter _Name_W = null;
            private WhereParameter _Description_W = null;
            private WhereParameter _Rowguid_W = null;
            private WhereParameter _InstitutionParentTypeGuid_W = null;
            private WhereParameter _IsActive_W = null;
            private WhereParameter _InstitutionParentTypeID_W = null;

            public void WhereClauseReset()
            {
                _ID_W = null;
                _Name_W = null;
                _Description_W = null;
                _Rowguid_W = null;
                _InstitutionParentTypeGuid_W = null;
                _IsActive_W = null;
                _InstitutionParentTypeID_W = null;

                this._entity.Query.FlushWhereParameters();

            }

            private BusinessEntity _entity;
            private TearOffWhereParameter _tearOff;

        }

        public WhereClause Where
        {
            get
            {
                if (_whereClause == null)
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
                    if (_tearOff == null)
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

                public AggregateParameter Rowguid
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Rowguid, Parameters.Rowguid);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter InstitutionParentTypeGuid
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.InstitutionParentTypeGuid, Parameters.InstitutionParentTypeGuid);
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

                public AggregateParameter InstitutionParentTypeID
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.InstitutionParentTypeID, Parameters.InstitutionParentTypeID);
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
                    if (_ID_W == null)
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
                    if (_Name_W == null)
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
                    if (_Description_W == null)
                    {
                        _Description_W = TearOff.Description;
                    }
                    return _Description_W;
                }
            }

            public AggregateParameter Rowguid
            {
                get
                {
                    if (_Rowguid_W == null)
                    {
                        _Rowguid_W = TearOff.Rowguid;
                    }
                    return _Rowguid_W;
                }
            }

            public AggregateParameter InstitutionParentTypeGuid
            {
                get
                {
                    if (_InstitutionParentTypeGuid_W == null)
                    {
                        _InstitutionParentTypeGuid_W = TearOff.InstitutionParentTypeGuid;
                    }
                    return _InstitutionParentTypeGuid_W;
                }
            }

            public AggregateParameter IsActive
            {
                get
                {
                    if (_IsActive_W == null)
                    {
                        _IsActive_W = TearOff.IsActive;
                    }
                    return _IsActive_W;
                }
            }

            public AggregateParameter InstitutionParentTypeID
            {
                get
                {
                    if (_InstitutionParentTypeID_W == null)
                    {
                        _InstitutionParentTypeID_W = TearOff.InstitutionParentTypeID;
                    }
                    return _InstitutionParentTypeID_W;
                }
            }

            private AggregateParameter _ID_W = null;
            private AggregateParameter _Name_W = null;
            private AggregateParameter _Description_W = null;
            private AggregateParameter _Rowguid_W = null;
            private AggregateParameter _InstitutionParentTypeGuid_W = null;
            private AggregateParameter _IsActive_W = null;
            private AggregateParameter _InstitutionParentTypeID_W = null;

            public void AggregateClauseReset()
            {
                _ID_W = null;
                _Name_W = null;
                _Description_W = null;
                _Rowguid_W = null;
                _InstitutionParentTypeGuid_W = null;
                _IsActive_W = null;
                _InstitutionParentTypeID_W = null;

                this._entity.Query.FlushAggregateParameters();

            }

            private BusinessEntity _entity;
            private TearOffAggregateParameter _tearOff;

        }

        public AggregateClause Aggregate
        {
            get
            {
                if (_aggregateClause == null)
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
            cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_InstitutionTypeInsert]";

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
            cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_InstitutionTypeUpdate]";

            CreateParameters(cmd);

            return cmd;
        }

        protected override IDbCommand GetDeleteCommand()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_InstitutionTypeDelete]";

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

            p = cmd.Parameters.Add(Parameters.Rowguid);
            p.SourceColumn = ColumnNames.Rowguid;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.InstitutionParentTypeGuid);
            p.SourceColumn = ColumnNames.InstitutionParentTypeGuid;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.IsActive);
            p.SourceColumn = ColumnNames.IsActive;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.InstitutionParentTypeID);
            p.SourceColumn = ColumnNames.InstitutionParentTypeID;
            p.SourceVersion = DataRowVersion.Current;


            return cmd;
        }
    }
}


