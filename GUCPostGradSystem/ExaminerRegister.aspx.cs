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
    public partial class ExaminerRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ExaminerRegister1(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["postGradSystem"].ToString();

            SqlConnection conn = new SqlConnection(connStr);
            String firstName = (TextBox1.Text);
            String lastName = (TextBox2.Text);
            String password = (TextBox3.Text);
            String faculty = (TextBox4.Text);
            String email = (TextBox5.Text);
            String fieldOFwork = (TextBox6.Text);
            bool bit = bool.Parse(TextBox7.Text);


            SqlCommand registerProc = new SqlCommand("ExaminerRegister", conn);
            registerProc.CommandType = CommandType.StoredProcedure;

            registerProc.Parameters.Add(new SqlParameter("@first_name", firstName));
            registerProc.Parameters.Add(new SqlParameter("@last_name ", lastName));
            registerProc.Parameters.Add(new SqlParameter("@password ", password));
            registerProc.Parameters.Add(new SqlParameter("@faculty", faculty));
            registerProc.Parameters.Add(new SqlParameter("@email", email));
            registerProc.Parameters.Add(new SqlParameter("@fieldOfWork", fieldOFwork));
            registerProc.Parameters.Add(new SqlParameter("@isNational", bit));

            conn.Open();
            registerProc.ExecuteNonQuery();
            Response.Write("Welcome our New Examiner");
            Response.Redirect("Login.aspx");
            conn.Close();


        }
    }
}