using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace Zplussolution
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void txtSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MSI\MSSQLSERVER01;Initial Catalog=Zplussolution;Integrated Security=True");
            string str = " ";
            str = "insert into Zplussolution(EmployeeName,EmployeeID,Designation,CityName,MobileNumber)"
                + "values('" + txtName.Text + "','" + txtID.Text + "','" + txtDesignation.Text + "','" + txtCity.Text + "','" + txtNumber.Text + "')";
            
            con.Open();

            SqlCommand cmd = new SqlCommand(str, con);

            cmd.ExecuteNonQuery();
            lblmsg.Text = "The entries has been Submitted!";
            con.Close();
           
        }

        protected void txtUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MSI\MSSQLSERVER01;Initial Catalog=Zplussolution;Integrated Security=True");

            string str = "  ";

            str = "UPDATE Zplussolution SET(EmployeeName,EmployeeID,Designation,CityName,MobileNumber)"
                + "WHERE('" + txtName.Text + "','" + txtID.Text + "','" + txtDesignation.Text + "','" + txtCity.Text + "','" + txtNumber.Text + "')";

            con.Open();
            
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            lblmsg.Text = "The entries has been Updated!";
            con.Close();
        }

        protected void txtDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MSI\MSSQLSERVER01;Initial Catalog=Zplussolution;Integrated Security=True");
            string str = " ";

            str = "DELETE From Zplussolution(EmployeeName,EmployeeID,Designation,CityName,MobileNumber)"
                + "WHERE('" + txtName.Text + "','" + txtID.Text + "','" + txtDesignation.Text + "','" + txtCity.Text + "','" + txtNumber.Text + "')";

            con.Open();

            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            lblmsg.Text = "The entries has been Deleted!";
            con.Close();
        }
    }
}