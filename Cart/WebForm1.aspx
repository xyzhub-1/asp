<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Cart.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
</body>
</html>
<asp:GridView runat="server" Width="478px" ID="ProductGridView" AutoGenerateColumns="False" DataKeyNames="ProductID">
    <Columns>
        <asp:BoundField DataField="ProductID" HeaderText="Product ID" />
        <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
        <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
        <asp:TemplateField HeaderText="AddToCart">
            <ItemTemplate>
               <asp:Button ID="AddToCartButton" runat="server" Text="Add to Cart" OnClick="AddToCartButton_Click" />

            </ItemTemplate>
        </asp:TemplateField>
          </Columns>
    </asp:GridView>
    SHOPPING CART<br />
    <asp:ListView ID="CartListView" runat="server">
          <ItemTemplate>
                    <p><%# Eval("ProductName") %>, Price: $<%# Eval("Price") %><asp:Button ID="RemoveFromCartButton" runat="server" Text="Remove" CommandName="RemoveFromCart" CommandArgument='<%# Eval("ProductID") %>' OnClick="RemoveFromCartButton_Click" />
                    </p>
                </ItemTemplate>

    </asp:ListView>
                 <asp:Label ID="LabelMessage" runat="server" Text=""></asp:Label>

    </form>

