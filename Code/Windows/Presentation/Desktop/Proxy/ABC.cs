
// Generated by MyGeneration Version # (1.3.0.9)

using System;
using System.Collections.Generic;

namespace Proxy
{
	public class ABC 
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

		private  string _Value;
		public  string Value
	    {
			get
	        {
				return _Value;
			}
			set
	        {
				_Value = value;
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

		private  bool? _IsDeleted;
		public  bool? IsDeleted
	    {
			get
	        {
				return _IsDeleted;
			}
			set
	        {
				_IsDeleted = value;
			}
		}

		private  DateTime? _UpdateTime;
		public  DateTime? UpdateTime
	    {
			get
	        {
				return _UpdateTime;
			}
			set
	        {
				_UpdateTime = value;
			}
		}


	#endregion
	
	#region Web Service Getters
		
		public static List<ABC> GetAll()
        {
            BLL.ABC v = new BLL.ABC();
            v.LoadAll();
			return ToList(v);
        }
		
	
	#endregion
	
	
	
	#region Utilities
	
		public static List<ABC> ToList(BLL.ABC v){
			List<ABC> list = new List<ABC>();
            while (!v.EOF)
            {
                ABC t = new ABC();
              if(!v.IsColumnNull("ID"))
				    t.ID = v.ID;
              if(!v.IsColumnNull("Value"))
				    t.Value = v.Value;
              if(!v.IsColumnNull("Description"))
				    t.Description = v.Description;
             
				list.Add(t);
                v.MoveNext();
            }
            return list;
		}
	
		#endregion
		
		
		#region Web service Saving

        public static void SaveList(List<HCMIS.Desktop.DirectoryServices.ABC> list)
        {
            BLL.ABC bv = new BLL.ABC();
            foreach (HCMIS.Desktop.DirectoryServices.ABC v in list)
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
              if( v.Value != "" && v.Value != null )
				   bv.Value = v.Value;
              if( v.Description != "" && v.Description != null )
				   bv.Description = v.Description;
            
                bv.Save();
            }


        }
	
	public static void DeleteList(List<int> list)
        {
            BLL.ABC bv = new BLL.ABC();
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
