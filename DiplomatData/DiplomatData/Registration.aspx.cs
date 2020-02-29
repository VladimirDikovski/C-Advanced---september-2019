using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DiplomatData
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Clear();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["UserReg"].ConnectionString;
            if(txtUserName.Text==" "||txtPassword.Text==" ")
            {
                lblError.Text = "Pls enter username or password";
            }
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                lblError.Text = "Your Password is not the same";
            }
            else
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "InputUsers";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserId", Convert.ToInt32(hfUserID.Value == "" ? "0" : hfUserID.Value));
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@Gender", DropDownList1.SelectedValue);
                    cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    cmd.ExecuteNonQuery();
                    lblSucsec.Text = "Sumbited";
                    Clear();

                }
            }
        }

        void Clear()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPassword.Text = "";
            txtUserName.Text = " ";
            txtConfirmPassword.Text = " ";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}