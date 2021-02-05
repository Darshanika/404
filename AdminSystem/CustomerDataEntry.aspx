<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblCustomerName" runat="server" Text="Name" width="79px"></asp:Label>
            <asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblCustomerEmail" runat="server" Text="Email" width="79px"></asp:Label>
        <asp:TextBox ID="txtCustomerEmail" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblPassword" runat="server" Text="Password" width="79px"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblCustomerAddress" runat="server" Text="Address" width="79px"></asp:Label>
        <asp:TextBox ID="txtCustomerAddress" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblDateOfBirth" runat="server" Text="Date of Birth" width="79px"></asp:Label>
            <asp:TextBox ID="txtDateOfBirth" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="chkLivesInUK" runat="server" Text="Live in the UK" />
        </p>
        <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
        <p>
            <asp:Button ID="btnConfirm" runat="server" OnClick="btnConfirm_Click" Text="Confirm" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
