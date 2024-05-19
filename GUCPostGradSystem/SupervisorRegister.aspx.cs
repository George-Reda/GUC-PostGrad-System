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
    public partial class SupervisorRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        
        protected void SupervisorRegister1(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["postGradSystem"].ToString();

            SqlConnection conn = new SqlConnection(connStr);
            String firstName = (TextBox1.Text);
            String lastName = (TextBox2.Text);
            String password = (TextBox3.Text);
            String faculty = (TextBox4.Text);
            String email = (TextBox5.Text);
            

            SqlCommand registerProc = new SqlCommand("SupervisorRegister", conn);
            registerProc.CommandType = CommandType.StoredProcedure;

            registerProc.Parameters.Add(new SqlParameter("@first_name", firstName));
            registerProc.Parameters.Add(new SqlParameter("@last_name ", lastName));
            registerProc.Parameters.Add(new SqlParameter("@password ", password));
            registerProc.Parameters.Add(new SqlParameter("@faculty", faculty));
            registerProc.Parameters.Add(new SqlParameter("@email", email));
           
            conn.Open();
            registerProc.ExecuteNonQuery();
            Response.Write("Welcome our New Supervisor");
            Response.Redirect("Login.aspx");
            conn.Close();

        }
    }
}