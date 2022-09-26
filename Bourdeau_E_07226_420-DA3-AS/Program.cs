using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using MultiTiersLab1.Utils;

namespace Bourdeau_E_07226_420_DA3_AS
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            SqlConnection conn = DbUtils.GetDefaultConnection();
           
            

            
            DataSet dataset = new DataSet();
            
            SqlDataAdapter dataAdapter = new SqlDataAdapter();


            SqlCommand selectProductQuery = conn.CreateCommand();
            selectProductQuery.CommandText = "SELECT * FROM dbo.Product";

            SqlCommand insertProductQuery = conn.CreateCommand();
            insertProductQuery.CommandText = "INSERT INTO dbo.Product VALUES(@gtinCode, @qtyInStock, @name, @description);" +
                                             "SELECT * FROM dbo.Product WHERE id = SCOPE_IDENTITY();";

            SqlCommand updateProductQuery = conn.CreateCommand();
            updateProductQuery.CommandText = "INSERT INTO dbo.Product VALUES(@gtinCode, @qtyInStock, @name, @description)";

            SqlCommand deleteProductQuery = conn.CreateCommand();
            deleteProductQuery.CommandText = "DELETE FROM dbo.Product VALUES(@gtinCode, @qtyInStock, @name, @description)";

            dataAdapter.SelectCommand = selectProductQuery;
            dataAdapter.SelectCommand = insertProductQuery;
            dataAdapter.SelectCommand = updateProductQuery;
            dataAdapter.SelectCommand = deleteProductQuery;


            SqlCommand selectCustomerQuery = conn.CreateCommand();
            selectCustomerQuery.CommandText = "SELECT * FROM dbo.CUSTOMER";
            
            
            conn.Open();

            dataAdapter.Fill(dataset, "Product");

            foreach (DataTable table in dataset.Tables)
            {

                foreach (DataRow row in table.Rows)
                {

                    foreach (DataColumn column in table.Columns)
                    {
                        Console.Write($"{column}: {row[column]} - ");
                        
                    }
                    
                }
            }


        }
    }
}
