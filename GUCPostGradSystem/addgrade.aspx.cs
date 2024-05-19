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
    public partial class addgrade : System.Web.UI.Page
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
            decimal grade = decimal.Parse(TextBox3.Text);
            int id = Convert.ToInt16(Session["user"].ToString());

            SqlCommand gradeProc = new SqlCommand("AddDefenseGrade", conn);
            gradeProc.CommandType = CommandType.StoredProcedure;

            gradeProc.Parameters.Add(new SqlParameter("@ThesisSerialNo", thesisserial));
            gradeProc.Parameters.Add(new SqlParameter("@DefenseDate ", defensedate));
            gradeProc.Parameters.Add(new SqlParameter("@grade ", grade));
            gradeProc.Parameters.Add(new SqlParameter("@examiner_id ", id));

            SqlParameter Sucess = gradeProc.Parameters.Add("@success", SqlDbType.Int);
            Sucess.Direction = ParameterDirection.Output;

            conn.Open();
            gradeProc.ExecuteNonQuery();
            
            conn.Close();
            if (Sucess.Value.ToString() == "0")
            {
                Response.Write("sorry Sir but you have already added a grade for the defense you are trying to add grades or it  isnot under your evaluation ");

            }
            else
            {
                Response.Write("Done monsieur");
            }

        }
    }
}