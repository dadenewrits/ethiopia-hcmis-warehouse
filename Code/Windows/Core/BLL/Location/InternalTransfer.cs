
// Generated by MyGeneration Version # (1.3.0.3)

using System.Data;
using DAL;
using HCMIS.Repository;


namespace BLL
{
    /// <summary>
    /// Contains Internal Item Movement logic
    /// </summary>
	public class InternalTransfer : _InternalTransfer
	{
        
        /// <summary>
        /// Gets a new print number for Pick Face location replenishment.
        /// </summary>
        /// <returns></returns>
        public static int GetNewPrintNumber()
        {
            InternalTransfer it = new InternalTransfer();
            it.LoadFromRawSql(HCMIS.Repository.Queries.InternalTransfer.SelectGetNewPrintNumber());
            if (it.IsColumnNull("ID"))
                return 0;
            return it.ID ;
        }

        

        /// <summary>
        /// Gets all replenishments performed, This is filtered by type
        /// the type could be, pick face replenishment, movment to quaranteen etc...
        /// Print number is introduced to idenitfy if the item has already been printed or not
        /// It is now clear if the print number is not empty, it has not been printed
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static DataView GetAllTransfers(string type)
        {
            if (type == "Transfer")
            {
                return GetStoreTransfer();
            }
                var query = HCMIS.Repository.Queries.InternalTransfer.SelectGetAllTransfers(type);
                InternalTransfer it = new InternalTransfer();
                it.LoadFromRawSql(query);
                return it.DefaultView;
          
        }

        

        /// <summary>
        /// Gets the store transfer.
        /// </summary>
        /// <returns></returns>
        public static DataView GetStoreTransfer()
        {

            string query = HCMIS.Repository.Queries.InternalTransfer.SelectGetStoreTransfer();
            InternalTransfer it = new InternalTransfer();
            it.LoadFromRawSql(query);
            return it.DefaultView;
        }

       
	}
}
