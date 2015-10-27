
// Generated by MyGeneration Version # (1.3.0.3)

using System;
using System.Collections.Generic;

namespace Proxy
{
	public class StoreType 
	{
	
	#region Properties
	
		private  int? _ID;
		public  int? ID
	    {
			get
	        {
				return _ID;
			}
			set
	        {
				_ID = value;
			}
		}

		private  string _TypeName;
		public  string TypeName
	    {
			get
	        {
				return _TypeName;
			}
			set
	        {
				_TypeName = value;
			}
		}

		private  string _Description;
		public  string Description
	    {
			get
	        {
				return _Description;
			}
			set
	        {
				_Description = value;
			}
		}


	#endregion
	
	#region Web Service Getters
		
		public static List<StoreType> GetAll()
        {
            BLL.Mode v = new BLL.Mode();
            v.LoadAll();
			return ToList(v);
        }
		
		
		public static List<StoreType> GetUpdatesAfter(long? lastVersion,DateTime? lastUpdateTime)
        {
            BLL.Mode v = new BLL.Mode();
            if(lastVersion.HasValue && lastVersion.Value != 0)
            {
                v.LoadUpdatesAfter( lastVersion.Value );    
            }else if(lastUpdateTime.HasValue)
            {
                v.LoadUpdatesAfterByTime(lastUpdateTime.Value);
            }else
            {
                v.LoadAll();
            }
			return ToList(v);
        }
		
        public static List<int> GetDeletedIDsAfter(long LastVersion)
        {
             BLL.Mode v = new BLL.Mode();
            v.LoadDeletedIDs(LastVersion);
            List<int> list = new List<int>();
            while (!v.EOF)
            {
                list.Add((int)v.GetColumn("ID"));
                v.MoveNext();
            }
            return list;
        }
		
	#endregion
	
	
	
	#region Utilities
	
		public static List<StoreType> ToList(BLL.Mode v){
			List<StoreType> list = new List<StoreType>();
            while (!v.EOF)
            {
                StoreType t = new StoreType();
              if(!v.IsColumnNull("ID"))
				    t.ID = v.ID;
              if(!v.IsColumnNull("TypeName"))
				    t.TypeName = v.TypeName;
              if(!v.IsColumnNull("Description"))
				    t.Description = v.Description;

				list.Add(t);
                v.MoveNext();
            }
            return list;
		}
	
		#endregion
		
		
		#region Web service Saving

        public static void SaveList(List<HCMIS.Desktop.DirectoryServices.StoreType> list)
        {
            BLL.Mode bv = new BLL.Mode();
            foreach (HCMIS.Desktop.DirectoryServices.StoreType v in list)
            {
                // try to load by primary key
                bv.LoadByPrimaryKey(v.ID.Value);

                // if the entry doesn't exist, create it
                if (bv.RowCount == 0)
                {
                    bv.AddNew();
                }
                // populate the contents of v on the to the database list
              if( v.ID.HasValue )
				   bv.ID = v.ID.Value;
              if( v.TypeName != "" && v.TypeName != null )
				   bv.TypeName = v.TypeName;
              if( v.Description != "" && v.Description != null )
				   bv.Description = v.Description;

                bv.Save();
            }


        }
	
	public static void DeleteList(List<int> list)
        {
            BLL.Mode bv = new BLL.Mode();
            foreach (int v in list)
            {
                // try to load by primary key
                bv.LoadByPrimaryKey(v);
                // if the entry doesn't exist, create it
                if (bv.RowCount > 0)
                {
                    bv.MarkAsDeleted();
					bv.Save();
                }
                // populate the contents of v on the to the database list

            }


        }
	
	
	#endregion
	}
}
