using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace Cart
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private List<Product> CartItems
        {
            get
            {
                if (Session["Cart"] == null) Session["Cart"] = new List<Product>();
                return (List<Product>)Session["Cart"];
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ProductGridView.DataSource = ProductRepository.GetAllProducts();
                ProductGridView.DataBind();
            }
            BindCart();
        }

        protected void AddToCartButton_Click(object sender, EventArgs e)
        {
            var row = (GridViewRow)((Button)sender).NamingContainer;
            int id = Convert.ToInt32(ProductGridView.DataKeys[row.RowIndex].Value);

            if (CartItems.Exists(p => p.ProductID == id))
                LabelMessage.Text = "Already in cart!";
            else
                CartItems.Add(ProductRepository.GetAllProducts().Find(p => p.ProductID == id));

            BindCart();
        }

        protected void RemoveFromCartButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(((Button)sender).CommandArgument);
            CartItems.RemoveAll(p => p.ProductID == id);
            BindCart();
        }

        private void BindCart()
        {
            CartListView.DataSource = CartItems;
            CartListView.DataBind();
        }
    }
}
