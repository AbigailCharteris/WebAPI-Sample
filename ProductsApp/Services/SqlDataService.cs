using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace ProductsApp.Services
{
    public class SqlDataService
    {

        private readonly ConnectionStringSettings sqlConn = ConfigurationManager.ConnectionStrings["SQLConnection"];
        private const string sqlSproc = "sp_GetProducts";

        public ProductsApp.Models.Product MyProperty
        {
            get
            {

                return new Models.Product();
            }
        }


        private void GetData(string custId)
        {

            using (var sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConnection"].ToString()))
            {
                var cmd = new SqlCommand(sqlSproc, sqlConn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@CustomerID", System.Data.SqlDbType.NChar).Value = custId;

                sqlConn.Open();
                var result = cmd.ExecuteReader();
            }
        }

    }
}