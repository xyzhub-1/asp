using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MovieTicket_caching
{
    public partial class MovieTickets : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Linkbtonk_Click(object sender, EventArgs e)
        {
            Session["Theatre"] = ListBox1.Text;
            Response.Redirect("Response_Movie.aspx");
        }
    }
}