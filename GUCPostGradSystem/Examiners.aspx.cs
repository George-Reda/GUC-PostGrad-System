using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCPostGradSystem
{
    public partial class Examiners : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void editdetails(object sender, EventArgs e)
        {
            Response.Redirect("editdetails.aspx");
        }
        protected void Listdetails(object sender, EventArgs e)
        {
            Response.Redirect("listThesis.aspx");
        }
        protected void addcomments(object sender, EventArgs e)
        {
            Response.Redirect("addcomments.aspx");
        }
        protected void addgrade(object sender, EventArgs e)
        {
            Response.Redirect("addgrade.aspx");
        }
        protected void searchthesis(object sender, EventArgs e)
        {
            Response.Redirect("searchthesis.aspx");
        }
    }
}