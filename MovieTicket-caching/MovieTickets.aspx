<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MovieTickets.aspx.cs" Inherits="MovieTicket_caching.MovieTickets" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        MOVIE TICKET BOOKING<div>
        </div>
        <asp:ListBox ID="ListBox1" runat="server">
            <asp:ListItem>PVR</asp:ListItem>
            <asp:ListItem>IMAX</asp:ListItem>
            <asp:ListItem>CINIMAX</asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:ListBox>
        <p>
            <asp:LinkButton ID="Linkbtonk" runat="server" OnClick="Linkbtonk_Click" OnClientClick="Linkbton_Click">OK!!!</asp:LinkButton>
        </p>
    </form>
</body>
</html>
