
// Generated by MyGeneration Version # (1.3.0.9)

using System;
using System.Collections.Generic;

namespace Proxy
{
	public class Manufacturer 
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

		private  string _Name;
		public  string Name
	    {
			get
	        {
				return _Name;
			}
			set
	        {
				_Name = value;
			}
		}

		private  string _CountryOfOrigin;
		public  string CountryOfOrigin
	    {
			get
	        {
				return _CountryOfOrigin;
			}
			set
	        {
				_CountryOfOrigin = value;
			}
		}

		private  string _PFSAManufCode;
		public  string PFSAManufCode
	    {
			get
	        {
				return _PFSAManufCode;
			}
			set
	        {
				_PFSAManufCode = value;
			}
		}

		private  string _Phone;
		public  string Phone
	    {
			get
	        {
				return _Phone;
			}
			set
	        {
				_Phone = value;
			}
		}

		private  string _Address;
		public  string Address
	    {
			get
	        {
				return _Address;
			}
			set
	        {
				_Address = value;
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
	
    //#region Web Service Getters
		
    //    public static List<Manufacturer> GetAll()
    //    {
    //        BLL.Manufacturer v = new BLL.Manufacturer();
    //        v.LoadAll();
    //        return ToList(v);
    //    }
		
    //    public static List<Manufacturer> GetUpdatesAfter(long? lastVersion,DateTime? lastUpdateTime)
    //    {
    //        BLL.Manufacturer v = new BLL.Manufacturer();
    //        if(lastVersion.HasValue && lastVersion.Value != 0)
    //        {
    //            v.LoadUpdatesAfter( lastVersion.Value );    
    //        }else if(lastUpdateTime.HasValue)
    //        {
    //            v.LoadUpdatesAfterByTime(lastUpdateTime.Value);
    //        }else
    //        {
    //            v.LoadAll();
    //        }
    //        return ToList(v);
    //    }
		
    //    public static List<int> GetDeletedIDsAfter(long LastVersion)
    //    {
    //         BLL.Manufacturer v = new BLL.Manufacturer();
    //        v.LoadDeletedIDs(LastVersion);
    //        List<int> list = new List<int>();
    //        while (!v.EOF)
    //        {
    //            list.Add((int)v.GetColumn("ID"));
    //            v.MoveNext();
    //        }
    //        return list;
    //    }
		
    //#endregion
	
	
	
	#region Utilities
	
		
	
		#endregion
		
		
		#region Web service Saving

        public static void SaveList(List<HCMIS.Desktop.DirectoryServices.Manufacturer> list)
        {
            BLL.Manufacturers bv = new BLL.Manufacturers();
            foreach (HCMIS.Desktop.DirectoryServices.Manufacturer v in list)
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
              if( v.Name != "" && v.Name != null )
				   bv.Name = v.Name;
              if( v.CountryOfOrigin != "" && v.CountryOfOrigin != null )
				   bv.CountryOfOrigin = v.CountryOfOrigin;
              if( v.PFSAManufCode != "" && v.PFSAManufCode != null )
				   bv.PFSAManufCode = v.PFSAManufCode;
              if( v.Phone != "" && v.Phone != null )
				   bv.Phone = v.Phone;
              if( v.Address != "" && v.Address != null )
				   bv.Address = v.Address;
              //if( v.IsDeleted.HasValue )
              //     bv.IsDeleted = v.IsDeleted.Value;
              //if( v.UpdateTime.HasValue )
              //     bv.UpdateTime = v.UpdateTime.Value;

                bv.Save();
            }


        }
	
	public static void DeleteList(List<int> list)
        {
            BLL.Manufacturers bv = new BLL.Manufacturers();
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
