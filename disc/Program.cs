// See https://aka.ms/new-console-template for more information

using System.Data.SqlClient;
using System;
using System.Data;
ShowDisconnect();
//AddRecord();
//Show();
void ShowDisconnect()
{
    string connectionString = "User ID=sa;password=examlyMssql@123; server=localhost;Database=products;trusted_connection=false;Persist Security Info=False;Encrypt=False";
    string cmdtext = "insert into mydata values(@Id, @Name, @Price, @Stock)";
    SqlConnection connection = null;
    SqlDataAdapter adapter = null;
    DataSet ds = null;
    DataTable mdTable = null;
    try{
        ds = new DataSet();
        connection = new SqlConnection(connectionString);
        adapter = new SqlDataAdapter("select * from mydata", connection);
        adapter.Fill(ds, "md");
        mdTable = ds.Tables["md"];
        System.Console.WriteLine($"Rows = {mdTable.Rows.Count}");
        System.Console.WriteLine($"Columns = {mdTable.Columns.Count}");
        foreach(DataRow row in mdTable.Rows)
        {
            System.Console.WriteLine($"{row["Id"]} -- {row["Name"]} -- {row["Price"]} -- {row["Stock"]}");
        }
    }
    catch(Exception ex)
    {
        System.Console.WriteLine(ex.Message);
    }
}

void AddRecord()
{
    string connectionString = "User ID=sa;password=examlyMssql@123; server=localhost;Database=products;trusted_connection=false;Persist Security Info=False;Encrypt=False";
    string cmdtext = "insert into mydata values(@Id, @Name, @Price, @Stock)";
    System.Console.WriteLine("Enter ID");
    int Id = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Enter Item name");
    string Name = Console.ReadLine();
    System.Console.WriteLine("Enter Price");
    int Price = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Enter stock");
    int Stock = Convert.ToInt32(Console.ReadLine());
    SqlConnection con = null;
    SqlCommand command = null;
    try{
        con =  new (connectionString);
        command = new SqlCommand(cmdtext, con);
        command.Parameters.AddWithValue("@Id", Id);
        command.Parameters.AddWithValue("@Name", Name);
        command.Parameters.AddWithValue("@Price", Price);
        command.Parameters.AddWithValue("@Stock", Stock);
        con.Open();
        command.ExecuteNonQuery();
        System.Console.WriteLine("Record Added");
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally{con.Close();}
}
void Show(){
    string connectionString = "User ID=sa;password=examlyMssql@123; server=localhost;Database=products;trusted_connection=false;Persist Security Info=False;Encrypt=False";

    string cmdtext = "select * from mydata";

    try{
        SqlConnection con = new SqlConnection(connectionString);
        con.Open();
        System.Console.WriteLine("Connection Opened Successfully");
        SqlCommand command = new SqlCommand(cmdtext, con);
        SqlDataReader reader = command.ExecuteReader();
        while(reader.Read())
        {
            System.Console.WriteLine($"{reader["Id"]} --- {reader["Name"]} --- {reader["Price"]} --- {reader["Stock"]}");
        }
        con.Close();
    }

    catch(Exception ex){
        System.Console.WriteLine("error" +ex.Message);
    }
}
