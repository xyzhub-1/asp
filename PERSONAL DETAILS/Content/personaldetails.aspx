<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="personaldetails.aspx.cs" Inherits="PERSONAL_DETAILS.Content.personaldetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            PERSONAL Detail<br />
            <br />
            <br />
        </div>
        <br />
        <asp:Label ID="Label1" runat="server" Text="ENTER YOUR NAME"></asp:Label>
        <asp:TextBox ID="Name" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="required0" runat="server" ControlToValidate="name" ErrorMessage="Required*" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
&nbsp;<asp:Label ID="Label2" runat="server" Text="ENTER YOUR ROLL NO"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="rollno" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="required" runat="server" ControlToValidate="rollno" ErrorMessage="Required*" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        ENTER YOUR CITY<asp:ListBox ID="location" runat="server">
            <asp:ListItem>MUMBAI</asp:ListItem>
            <asp:ListItem>PUNE</asp:ListItem>
            <asp:ListItem>THANE</asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:ListBox>
        <br />
        <br />
        SELECT&nbsp; YOUR DEPT:<asp:RadioButton ID="IT" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" Text="IT" />
        <asp:RadioButton ID="DS" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" Text="DS" />
        <asp:RadioButton ID="CS" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" Text="CS" />
        <br />
        <br />
        SELECT YOUR SUBJECT:
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem>DSA</asp:ListItem>
            <asp:ListItem>ASP</asp:ListItem>
            <asp:ListItem>BDNS</asp:ListItem>
        </asp:CheckBoxList>
        <asp:Button ID="Submit" runat="server" OnClick="Submit_Click" Text="SUBMIT" />
    </form>
</body>
</html>
