using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MovieTicket_caching
{
    public partial class Response_Movie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string th;
            TableCell c1 = new TableCell();
            TableCell c2 = new TableCell();
            TableCell c3 = new TableCell();
            TableCell c4 = new TableCell();
            TableCell c5 = new TableCell();
            TableCell c6 = new TableCell();
            TableCell c7 = new TableCell();
            TableCell c8 = new TableCell();

            TableRow r1 = new TableRow();
            TableRow r2 = new TableRow();
            c1.Text = "Show Timings";
            c2.Text = "9:00";
            c3.Text = "10:00";
            c4.Text = "11:00";

            Table1.Controls.Add(r1);
            r1.Controls.Add(c1);
            r1.Controls.Add(c2);
            r1.Controls.Add(c3);
            r1.Controls.Add(c4);

            c5.Text = "MOVIES";
            c6.Text = "XYZ";
            c7.Text = "PQR";
            c8.Text = "ABC";

            Table1.Controls.Add(r2);
            r2.Controls.Add(c5);
            r2.Controls.Add(c6);
            r2.Controls.Add(c7);
            r2.Controls.Add(c8);


            th = Convert.ToString(Session["Theatre"]);

            if (th == "IMAX")
            {
                
                if (Cache["IMAX"] == null)
                {
                    Cache.Insert("IMAX", Table1, null, DateTime.Now.AddSeconds(30), TimeSpan.Zero);
                }
                else
                {
                    Response.Write("reading from cache");
                }
            }
      
            if (th == "PVR")
            {
                
                if (Cache["PVR"] == null)
                {
                    Cache.Insert("PVR", Table1, null, DateTime.Now.AddSeconds(30), TimeSpan.Zero);
                }
                else
                {
                    Response.Write("reading from cache");
                }
            } 
            if (th == "CINIMAX")
            {
                
                if (Cache["CINIMAX"] == null)
                {
                    Cache.Insert("CINIMAX", Table1, null, DateTime.Now.AddSeconds(30), TimeSpan.Zero);
                }
                else
                {
                    Response.Write("reading from cache");
                }
            }



        }
    }
}