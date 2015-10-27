
// Generated by MyGeneration Version # (1.3.0.3)

using System;
using System.Data;
using DAL;

namespace BLL
{
    /// <summary>
    /// Supply category logic
    /// </summary>
	public class SupplyCategory : _SupplyCategory
	{

        /// <summary>
        /// Gets list of categories
        /// this appends U on the ID
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllSupplyCategories()
        {
            string query = HCMIS.Repository.Queries.SupplyCategory.SelectGetAllSupplyCategories();
            this.LoadFromRawSql(query);
            return this.DataTable;
        }
	}
}
