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
    public partial class searchthesis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void searchThesis(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["postGradSystem"].ToString();

            SqlConnection conn = new SqlConnection(connStr);
            string keyword = TextBox1.Text;

            SqlCommand searchProc = new SqlCommand("searchThesis", conn);
            searchProc.CommandType = CommandType.StoredProcedure;

            searchProc.Parameters.Add(new SqlParameter("@keyword", keyword));

            SqlParameter Sucess = searchProc.Parameters.Add(new SqlParameter("@success", SqlDbType.Int));
            Sucess.Direction = ParameterDirection.Output;

            conn.Open();
            SqlDataReader rdr = searchProc.ExecuteReader(CommandBehavior.CloseConnection);

            while (rdr.Read())

            {
                TableRow r = new TableRow();
                String titlen = rdr.GetString(rdr.GetOrdinal("title"));
                Label name = new Label();
                name.Text = titlen + "  ";
                TableCell c1 = new TableCell();
                c1.Controls.Add(name);
                r.Cells.Add(c1);
                Table1.Rows.Add(r);
            }
            conn.Close();
            conn.Open();


            searchProc.ExecuteNonQuery();
            conn.Close();
            if (Sucess.Value.ToString() == "0")
            {
                Response.Write("sorry sir but you have not attended any defenses");

            }


        }
    }
}