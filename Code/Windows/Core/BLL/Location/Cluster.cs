
// Generated by MyGeneration Version # (1.3.0.3)

using System;
using System.Data;
using DAL;

namespace BLL
{
	public class Cluster : _Cluster
	{
	    public static DataTable GetClusterStatus()
        {
            var cluster = new BLL.Cluster();
            string query = HCMIS.Repository.Queries.Cluster.SelectClusterStatus();
            cluster.LoadFromRawSql(query);
            return cluster.DataTable;
        }
	}
}
