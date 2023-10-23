using Microsoft.AspNetCore.Mvc;
using EmpMvc.Models;
using System.Data;
using System.Data.SqlClient;
namespace EmpMvc.Controllers;
public class ProductController:Controller
{
    public IActionResult List()
    {
        string constr = "User ID=sa;password=examlyMssql@123; server=localhost;Database=products;trusted_connection=false;Persist Security Info=False;Encrypt=False";
            SqlConnection con = new SqlConnection(constr);
            SqlCommand command = new SqlCommand("Select * from mydata", con);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            DataTable prodTable = new DataTable();
            prodTable.Load(reader);
            return View(prodTable);
    }
}