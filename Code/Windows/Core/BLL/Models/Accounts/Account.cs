
// Generated by MyGeneration Version # (1.3.0.3)

using System;
using DAL;

namespace BLL
{
	public class Account : _Account
	{
       
        public void LoadByUser(int userID)
        {
            LoadFromRawSql(HCMIS.Repository.Queries.Account.SelectByUser(userID));
        }
        

    }
}
