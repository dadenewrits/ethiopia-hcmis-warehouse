
// Generated by MyGeneration Version # (1.3.0.3)

using System;
using DAL;

namespace BLL
{
	public class UserPaymentType : _UserPaymentType
	{
		public UserPaymentType()
		{
		
		}

        /// <summary>
        /// Loads the by user ID.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        public void LoadByUserID(int userID)
        {
            string query = HCMIS.Repository.Queries.UserPaymentType.SelectLoadByUserID(userID);
            this.LoadFromRawSql(query);
        }

	   

	    /// <summary>
        /// Generates the matrix for A new user.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        public void GenerateMatrixForANewUser(int userID)
        {
            BLL.PaymentType paymentType = new PaymentType();
            paymentType.LoadAll();
            while (!paymentType.EOF)
            {
                BLL.UserPaymentType usrPayment = new UserPaymentType();
                usrPayment.AddNew();
                usrPayment.UserID = userID;
                usrPayment.PaymentTypeID = paymentType.ID;
                usrPayment.CanAccess = false;
                usrPayment.IsDefault = false;
                usrPayment.Save();
                paymentType.MoveNext();
            }
        }


        /// <summary>
        /// Makes the default.
        /// </summary>
        public void MakeDefault()
        {
            int id = this.ID;
            int userID = this.UserID;
            int paymentTypeID = this.PaymentTypeID;
            this.FlushData();

            string query = HCMIS.Repository.Queries.UserPaymentType.UpdateMakeDefault(userID, paymentTypeID);
            this.LoadFromRawSql(query);
            query = HCMIS.Repository.Queries.UserPaymentType.UpdateUserPaymentTypeMakeDefault(userID, paymentTypeID);
            this.LoadFromRawSql(query);
            this.LoadByPrimaryKey(id);
        }

	   
	}
}
