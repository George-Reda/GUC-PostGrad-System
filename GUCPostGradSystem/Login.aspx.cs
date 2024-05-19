using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCPostGradSystem
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["postGradSystem"].ToString();

            SqlConnection conn = new SqlConnection(connStr);
            int ID = Int16.Parse(UserName.Text);

            String Pass = Password.Text;

            SqlCommand loginProc = new SqlCommand("userLogin", conn);
            loginProc.CommandType = CommandType.StoredProcedure;

            loginProc.Parameters.Add(new SqlParameter("@ID", ID));
            loginProc.Parameters.Add(new SqlParameter("@Pass", Pass));


            SqlParameter Sucess = loginProc.Parameters.Add("@Success", SqlDbType.Int);
            Sucess.Direction = ParameterDirection.Output;

            conn.Open();
            loginProc.ExecuteNonQuery();
            conn.Close();
            if (Sucess.Value.ToString() == "1")
            {
                Response.Write("Welcome User");
                Session["user"] = ID;
                Response.Redirect("Examiners.aspx");

            }
            else
            {
                Response.Write("Please enter a valid userName or Password");
            }
        }

        protected void studentRegister(object sender, EventArgs e)
        {
            Response.Redirect("StudentRegister.aspx");
        }

        protected void supervisorRegister(object sender, EventArgs e)
        {
            
            Response.Redirect("SupervisorRegister.aspx");
        }

        protected void examinerRegister(object sender, EventArgs e)
        {
            Response.Redirect("ExaminerRegister.aspx");
        }
    }
}