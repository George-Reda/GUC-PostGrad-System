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
    public partial class addcomments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void insertinginputs(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["postGradSystem"].ToString();

            SqlConnection conn = new SqlConnection(connStr);
            int thesisserial = Int32.Parse(TextBox1.Text);
            DateTime defensedate = DateTime.Parse(TextBox2.Text);
            String comments = TextBox3.Text;
            int id = Convert.ToInt16(Session["user"].ToString());

            SqlCommand commentProc = new SqlCommand("AddCommentsGrade", conn);
            commentProc.CommandType = CommandType.StoredProcedure;

            commentProc.Parameters.Add(new SqlParameter("@ThesisSerialNo", thesisserial));
            commentProc.Parameters.Add(new SqlParameter("@DefenseDate ", defensedate));
            commentProc.Parameters.Add(new SqlParameter("@comments ", comments));
            commentProc.Parameters.Add(new SqlParameter("@examiner_id ", id));

            SqlParameter Sucess = commentProc.Parameters.Add("@success", SqlDbType.Int);
            Sucess.Direction = ParameterDirection.Output;
            conn.Open();
            commentProc.ExecuteNonQuery();
            
            conn.Close();
            if (Sucess.Value.ToString() == "0")
            {
                Response.Write("sorry Sir but you have already added a comment for the defense you are trying to add comments or it isnot under your evaluation ");

            }
            else
            {
                Response.Write("Done monsieur");
            }

        }
    }
}