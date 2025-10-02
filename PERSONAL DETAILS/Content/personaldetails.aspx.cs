using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PERSONAL_DETAILS.Content
{
    public partial class personaldetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            Response.Write("NAME:" + Name.Text + "</br>");
            Response.Write("rollno:" + rollno.Text + "</br>");
            Response.Write("location" + location.SelectedItem.Text + "</br>");

            if (IT.Checked == true)
            {
                Response.Write("DEPT : " + IT.Text + "<br/>");

            }
            if (DS.Checked == true)
            {
                Response.Write("DEPT : " + DS.Text + "<br/>");

            }
            if (CS.Checked == true)
            {
                Response.Write("DEPT : " + CS.Text + "<br/>");

            }


            foreach (ListItem item in CheckBoxList1.Items)
            {
                if (item.Selected)
                {
                    Response.Write(item.Text);
                }
            }
        }
    }
}