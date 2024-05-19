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
    public partial class editdetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void updatinginputs(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["postGradSystem"].ToString();

            SqlConnection conn = new SqlConnection(connStr);
            int id =Convert.ToInt16(Session["user"].ToString());
            String Name = (TextBox2.Text);
            String fieldofwork = TextBox3.Text;

            SqlCommand editProc = new SqlCommand("editMyEXProfile", conn);
            editProc.CommandType = CommandType.StoredProcedure;

            editProc.Parameters.Add(new SqlParameter("@ExaminerID", id));
            editProc.Parameters.Add(new SqlParameter("@Name ", Name));
            editProc.Parameters.Add(new SqlParameter("@fieldofWork", fieldofwork));

            conn.Open();
            editProc.ExecuteNonQuery();
            Response.Write("DONE MONISEUR");
            conn.Close();
        }
    }
}