using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cart
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ProductGridView.DataSource = ProductRepository.GetAllProducts();
                ProductGridView.DataBind();
            }
        }

        private ShoppingCart Cart
        {
            get
            {
                if (Session["Cart"] == null)
                {
                    Session["Cart"] = new ShoppingCart();
                }
                return (ShoppingCart)Session["Cart"];
            }
        }

        protected void AddToCartButton_Click(object sender, EventArgs e)
        {
            // Implement code to add items to the cart when the "Add to Cart" button is clicked.
            Button button = (Button)sender;
            GridViewRow row = (GridViewRow)button.NamingContainer;

            // Get the product ID from the GridView row
            int productId = Convert.ToInt32(ProductGridView.DataKeys[row.RowIndex]["ProductID"]);

            // Check if the product is already in the cart (you can modify this logic based on your needs)
            bool isProductInCart = Cart.ProductsInCart.Any(p => p.ProductID == productId);

            if (isProductInCart)
            {
                // Handle the case where the product is already in the cart (e.g., display a message)
                // You can also update the quantity or implement different behavior as needed.
                // For simplicity, I'll just show a message here.
                LabelMessage.Text = "This product is already in the cart.";
            }
            else
            {
                // Fetch the product details from the data source (ProductRepository)
                Product product = ProductRepository.GetAllProducts().Find(p => p.ProductID == productId);

                // Add the selected product to the shopping cart
                Cart.ProductsInCart.Add(product);

                // Update the CartListView with the updated cart data
                CartListView.DataSource = Cart.ProductsInCart;
                CartListView.DataBind();
            }
        }

        protected void RemoveFromCartButton_Click(object sender, EventArgs e)
        {
            // Implement code to remove items from the cart when the "Remove" button is clicked.
            Button button = (Button)sender;
            ListViewItem item = (ListViewItem)button.NamingContainer;

            int productId = Convert.ToInt32(CartListView.DataKeys[item.DataItemIndex].Value);

            ShoppingCart cart = Cart;
            Product productToRemove = cart.ProductsInCart.Find(p => p.ProductID == productId);

            if (productToRemove != null)
            {
                cart.ProductsInCart.Remove(productToRemove);
            }

            CartListView.DataSource = cart.ProductsInCart;
            CartListView.DataBind();
        }

        protected void Unnamed1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
