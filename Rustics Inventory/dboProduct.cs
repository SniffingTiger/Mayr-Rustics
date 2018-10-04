using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Rustics_Inventory
{
    public class Dbo
    {
            public string[] listOfProducts = new string[0];

        public string[] PopulateListboxWithProducts()
        {
            SqlConnection con = new SqlConnection();

            SqlCommand cmd = new SqlCommand();

            SqlDataReader reader;

            con.ConnectionString = "Data Source=rusticsserver.database.windows.net;Initial Catalog=RusticsDB;User ID=MilanAdmin;Password=peshwerd1!;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            cmd.CommandText = "EXEC dbo.FullProductNameList";
            cmd.Connection = con;
            con.Open();

            reader = cmd.ExecuteReader();

            reader.Cast<string>();

            while (reader.Read())
            {
                var myString = reader.GetString(0);
                Array.Resize(ref listOfProducts, (listOfProducts.Length + 1));
                listOfProducts[listOfProducts.Length - 1] = myString;
                // TODO: complete this shit
            }

            //if (reader.Read())
            //{
            //    listOfProducts
            //    productNameTextBox.Text = reader["ProductName"].ToString();
            //    reader.Close();
            //}
            con.Close();

            return listOfProducts;
        }
    }
}