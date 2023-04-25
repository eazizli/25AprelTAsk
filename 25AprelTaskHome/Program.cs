using Microsoft.Data.SqlClient;
using System.Data.SqlTypes;

internal class Program
{
    const string CONNECTION_STRING = "Server=VICTUS-IJ4RAPV;Database=EmployeeManagementDb;Trusted_Connection=True;TrustServerCertificate=True;";
    private static void Main(string[] args)
    {
       CreateCompanyTable();
    }
    public static void CreateCompanyTable()
    {
        using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
        {
            connection.Open();

            string query = "CREATE TABLE  CreateCompanyTable (Id int primary key identity(1,1),Name nvarchar(100))";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
               int result= command.ExecuteNonQuery();
                Console.WriteLine(result+"yarandi");
            }
        }

    }
    public static void InsertCompanyTable(string name)
    {
        using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
        {
            connection.Open();
            string query = "INSERT into CreateCompanyTable (Name) VALUES(@name)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                int result= command.ExecuteNonQuery();
            }


        }
    }
    public static void CreateEmployeeTable()
    {
        using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
        {
            connection.Open();

            string query = "CREATE TABLE  CreateEmployeeTable (Id int primary key identity(1,1),Name nvarchar(100),Surname nvarchar(100),CompanyId int)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                int result = command.ExecuteNonQuery();
                Console.WriteLine(result + "yarandi");
            }
        }
    }
    public static void InsertEmployeeTable()
    {
        using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
        {
            connection.Open();
            string query = "INSERT into CreateEmployeeTable (Name,Surname,CompanyId) VALUES(@name,@surname,@companyid)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                int result = command.ExecuteNonQuery();
            }


        }
    }


}