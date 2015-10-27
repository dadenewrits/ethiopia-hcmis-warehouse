
// Generated by MyGeneration Version # (1.3.0.3)

using System;
using System.Data;
using DAL;

namespace BLL
{

    /// <summary>
    /// Reasons of LossAndAdjustment
    /// this is practically, reason for loss and adjustment
    /// 
    /// </summary>
	public class LossAndAdjustmentReason : _LossAndAdjustmentReason
	{
        /// <summary>
        /// Gets list of LossAndAdjustment reasons that are currently being used 
        /// First timee the application runs, this returns empty.
        /// </summary>
        /// <returns></returns>
	    public DataTable GetAvailableReasons()
        {
            this.FlushData();
            this.LoadFromRawSql(HCMIS.Repository.Queries.LossAndAdjustmentReason.SelectGetAvailableReasons());
            return this.DataTable;
        }

        public string GetReasonByID(int reasonid)
        { 
            LossAndAdjustmentReason l=new LossAndAdjustmentReason();
            l.LoadFromRawSql(HCMIS.Repository.Queries.LossAndAdjustmentReason.SelectAvailableReasonsById(reasonid));
            return l.Reason;
        }
	}
}
