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
    public partial class ListThesis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["postGradSystem"].ToString();

            SqlConnection conn = new SqlConnection(connStr);
            int ID = Convert.ToInt16(Session["user"].ToString());

            SqlCommand listProc = new SqlCommand("listthesis", conn);
            listProc.CommandType = CommandType.StoredProcedure;

            listProc.Parameters.Add(new SqlParameter("@Examiner_id", ID));

            SqlParameter Sucess = listProc.Parameters.Add(new SqlParameter("@success", SqlDbType.Int));
            Sucess.Direction = ParameterDirection.Output;

            conn.Open();
            
            SqlDataReader rdr = listProc.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                TableRow r = new TableRow();


                String title = rdr.GetString(rdr.GetOrdinal("title"));
                Label titleT = new Label();
                titleT.Text = title;
                TableCell c1 = new TableCell();
                c1.Controls.Add(titleT);
                r.Cells.Add(c1);


                String supname = rdr.GetString(rdr.GetOrdinal("name"));
                Label name = new Label();
                name.Text = supname;
                TableCell c2 = new TableCell();
                c2.Controls.Add(name);
                r.Cells.Add(c2);

                String studentname = rdr.GetString(rdr.GetOrdinal("firstName"));
                Label nameS = new Label();
                nameS.Text = studentname;
                TableCell c3 = new TableCell();
                c3.Controls.Add(nameS);
                r.Cells.Add(c3);

                Table1.Rows.Add(r);

            }

            conn.Close();
            conn.Open();


            listProc.ExecuteNonQuery();
            conn.Close();
            if (Sucess.Value.ToString() == "0")
            {
                Response.Write("sorry sir but you have not attended any defenses");

            }


        }
    }
}