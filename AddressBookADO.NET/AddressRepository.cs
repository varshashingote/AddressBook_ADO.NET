using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookADO.NET
{
    class AddressRepository
    {
        public static string connectionString = "Data Source=localhost\\SQLEXPRESS01;Initial Catalog=Address_Book_Service;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static SqlConnection sqlConnection = null;


        public static void GetAllEmployees()
        {
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                string query = "select*from Address_Book";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                AddressBook addressBook = new AddressBook();
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //model.id = Convert.ToInt32(reader["id"] == DBNull.Value ? default : reader["id"]);
                        addressBook.First_Name = reader["First_Name"] == DBNull.Value ? default : reader["First_Name"].ToString();
                        addressBook.Last_Name = reader["Last_Name"] == DBNull.Value ? default : reader["Last_Name"].ToString();
                        addressBook.Address = reader["Address"] == DBNull.Value ? default : reader["Address"].ToString();
                        addressBook.City = reader["City"] == DBNull.Value ? default : reader["City"].ToString();
                        addressBook.state = reader["state"] == DBNull.Value ? default : reader["state"].ToString();
                        addressBook.Zip_Code = Convert.ToInt32(reader["Zip_Code"] == DBNull.Value ? default : reader["Zip_Code"]);
                        addressBook.Phone_Number = Convert.ToInt64(reader["Phone_Number"] == DBNull.Value ? default : reader["Phone_Number"]);
                        addressBook.E_Mail = reader["E_Mail"] == DBNull.Value ? default : reader["E_Mail"].ToString();
                        addressBook.AddressBook_Name = reader["AddressBook_Name"] == DBNull.Value ? default : reader["AddressBook_Name"].ToString();
                        addressBook.AddressBook_Type = reader["AddressBook_Type"] == DBNull.Value ? default : reader["AddressBook_Type"].ToString();
                        Console.WriteLine("{0},{1},{3},{4},{5},{6},{7},addressBook.First_Name,addressBook.Last_Name,addressBook.Adress,addressBook.City,addressBook.State,addressBook.Zip_Code,addressBook.Phone_Number,addressBook.E_Mail,addressBook.AddressBook_Name,addressBook.AddressBook_Type");
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public static void UpdateEmployee(AddressBook addressBook)
        {
            try
            {


                sqlConnection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand("dbo.spUpdateEntries", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                sqlConnection.Open();
                command.Parameters.AddWithValue("@First_Name", addressBook.First_Name);

                command.Parameters.AddWithValue("@City", addressBook.City);
                int num = command.ExecuteNonQuery();
                if (num != 0)

                    Console.WriteLine("Employee Updated Successfully");
                else
                    Console.WriteLine("Something went Wrong");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

            finally
            {
                Console.WriteLine("jesflkpsd");
            }

        }
    }
}








