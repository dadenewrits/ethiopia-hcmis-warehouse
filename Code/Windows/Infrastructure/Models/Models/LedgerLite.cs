using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HCMIS.Concrete.Models
{
    [Table("LedgerLite")]
    public class Ledger
    {
        [Key]
        public int ID { get; set; }

        public int ItemID { get; set; }
        public int UnitID { get; set; }
        public int ManufacturerID { get; set; }
        public int AccountID { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitCost { get; set; }
        public decimal Margin { get; set; }
        public decimal SellingPrice { get; set; }
    }
}
