<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label runat="server" Text="XML Verification"></asp:Label>
        <div>
            <asp:Label ID="lbVer1" runat="server" Text="XML URL:"></asp:Label>
            <asp:TextBox ID="xmlURL1" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lbVer2" runat="server" Text="XMLS/XSD URL:"></asp:Label>
            <asp:TextBox ID="xmlsURL" runat="server"></asp:TextBox>

        </div>
        <div>
            <asp:Button ID="btnValidate" runat="server" Text="Validate" OnClick="btnValidate_Click" />
        </div>
        <div>
            <asp:Label ID="validationLabel" runat="server" Text="XML URL:"></asp:Label>
        </div>
        <br />
        <asp:Label runat="server" Text="XPath Search"></asp:Label>
        <div>
            <asp:Label ID="Label1" runat="server" Text="XML URL:"></asp:Label>
            <asp:TextBox ID="xmlURL2" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="XPath Expression:"></asp:Label>
            <asp:TextBox ID="xpath" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btnxPathSearch" runat="server" Text="xPathSearch" OnClick ="btnxPathSearch_Click"/>
        </div>
        <div>
            <asp:Label ID="pathLabel" runat="server" Text="XML URL:"></asp:Label>
        </div>

    </form>

</body>
</html>
