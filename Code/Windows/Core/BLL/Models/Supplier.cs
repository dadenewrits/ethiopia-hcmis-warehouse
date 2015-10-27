
// Generated by MyGeneration Version # (1.3.0.3)

using System;
using System.ComponentModel.Design;
using System.Data;
using DAL;

namespace BLL
{
	public class Supplier : _Supplier
	{
        public static class CONSTANTS
        {
            public const int RETURNED_FROM_FACILITY = 1;
            public const int HOME_OFFICE = 2;
        }


        /// <summary>
        /// Gets the name of the supplier by.
        /// </summary>
        /// <param name="companyName">Name of the company.</param>
        /// <returns></returns>
	    public DataTable GetSupplierByName(string companyName)
        {
            this.FlushData();
            this.Where.WhereClauseReset();
            this.Where.CompanyName.Value = companyName;
            this.Query.Load();
            return this.DataTable;
        }

        public DataTable GetHubHeadOffice()
        {
            var supplier = new Supplier();
            var query = HCMIS.Repository.Queries.Supplier.SelectGetHubHeadOffice();

            supplier.LoadFromRawSql(query);
            return supplier.DataTable;
        }
        /// <summary>
        /// Gets the suppliers with transaction.
        /// </summary>
        /// <returns></returns>
        public DataTable GetSuppliersWithTransaction()
        {
            this.FlushData();
            this.LoadFromRawSql(HCMIS.Repository.Queries.Supplier.SelectGetSuppliersWithTransaction());
            return this.DataTable;
        }

        /// <summary>
        /// Gets the suppliers with country info.
        /// </summary>
        /// <returns></returns>
        public DataTable GetSuppliersWithCountry()
        {
            this.FlushData();
            this.LoadFromRawSql(HCMIS.Repository.Queries.Supplier.SelectGetAllSuppliersWithCountry());
            return this.DataTable;
        }
	  

	    /// <summary>
        /// Gets all suppliers for.
        /// </summary>
        /// <param name="ItemID">The item ID.</param>
        /// <param name="unitID">The unit ID.</param>
        /// <returns></returns>
        public static DataTable GetAllSuppliersFor(int ItemID,int unitID)
        {
            Supplier supp = new Supplier();
            string query = HCMIS.Repository.Queries.Supplier.SelectGetAllSuppliersFor(ItemID, unitID);
            supp.LoadFromRawSql(query);
            return supp.DataTable;
        }

	  

	    public static DataTable GetList()
        {
            Supplier supp = new Supplier();
            string query = HCMIS.Repository.Queries.Supplier.SelectGetList();
            supp.LoadFromRawSql(query);
            return supp.DataTable;
        }

	    public bool IsHubHomeOffice(int supplierID)
	    {
            string query = HCMIS.Repository.Queries.Supplier.SelectIsHomeOffice(supplierID,"HUB");
            this.LoadFromRawSql(query);
	        return this.RowCount > 1;
	    }

        public bool IsHubHomeOffice()
        {
            string query = HCMIS.Repository.Queries.Supplier.SelectIsHomeOffice(this.ID, "HUB");
            this.LoadFromRawSql(query);
            return this.RowCount > 1;
        }

        public bool IsVaccineHomeOffice(int supplierID)
        {
            string query = HCMIS.Repository.Queries.Supplier.SelectIsHomeOffice(supplierID, "VAC");
            this.LoadFromRawSql(query);
            return this.RowCount > 1;
        }

        public bool IsVaccineHomeOffice()
        {
            string query = HCMIS.Repository.Queries.Supplier.SelectIsHomeOffice(this.ID, "VAC");
            this.LoadFromRawSql(query);
            return this.RowCount > 1;
        }

	    public int GetHubHomeOfficeSupplierID()
	    {
            var supplier = new Supplier();
            string query = HCMIS.Repository.Queries.Supplier.SelectHomeOffice("HUB");
            supplier.LoadFromRawSql(query);
            return Convert.ToInt32(supplier.DataTable.Rows[0]["SupplierID"]);
	    }

        public int GetVaccineHomeOfficeSupplierID()
        {
            var supplier = new Supplier();
            string query = HCMIS.Repository.Queries.Supplier.SelectHomeOffice("VAC");
            supplier.LoadFromRawSql(query);
            return Convert.ToInt32(supplier.DataTable.Rows[0]["SupplierID"]);
        }

        public void LoadByRowGuid(Guid rowguid)
        {
            this.Where.Rowguid.Value = rowguid;
            this.Query.Load();
        }

	    public static DataTable GetDirectVendorSuppliers()
	    {
            var supp = new Supplier();
            string query = HCMIS.Repository.Queries.Supplier.SelectDirectDeliverySuppliers();
            supp.LoadFromRawSql(query);
            return supp.DataTable;
	    }

	    public static DataTable GetSuppliersByPOType(int poTypeID)
	    {
	        var supplier = new Supplier();
	        string query = HCMIS.Repository.Queries.Supplier.SelectSuppliersByPOType(poTypeID);
	        supplier.LoadFromRawSql(query);
	        return supplier.DataTable;
	    }
	}
}
