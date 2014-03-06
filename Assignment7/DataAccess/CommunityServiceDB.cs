using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace Assignment7.DataAccess
{
    public class CommunityServiceDB
    {
        SqlConnection connect;
        public CommunityServiceDB()
        {
            connect= new SqlConnection(ConfigurationManager.ConnectionStrings["CommunityAssistConnectionString"].ConnectionString);
        
        }
        public DataTable getServices()
        {
            string sql = "select servicename, servicedescription from communityservice";
            SqlCommand cmd = new SqlCommand(sql, connect);
            SqlDataReader reader;
            DataTable table= new DataTable();
            connect.Open();
            reader = cmd.ExecuteReader();
            table.Load(reader);
            reader.Dispose();
            connect.Close();
            
            return table;
            
        }

    }

}