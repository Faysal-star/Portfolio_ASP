<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="p1.aspx.cs" Inherits="web_app1.p1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Num 1 :
            <asp:TextBox ID="n1" runat="server"></asp:TextBox> <br/>
            Num 2 :
            <asp:TextBox ID="n2" runat="server"></asp:TextBox> <br/>
            <asp:Button ID="plus" runat="server" Text="+" OnClick="display_Click" />
            <asp:Button ID="minus" runat="server" Text="-" OnClick="clr_Click" /> 
            <asp:Button ID="mul" runat="server" Text="*" OnClick="mul_Click" />
            <asp:Button ID="div" runat="server" Text="/" OnClick="div_Click" />
            <br />
            <asp:Label ID="ans" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
