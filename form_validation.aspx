<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="form_validation.aspx.cs" Inherits="Quuestion15.form_validation" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="C:\Users\DELL\source\repos\form validation\form validation\Scripts\jquery-3.7.1.js"></script>
   
   
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Registration Form</h2>
            <asp:TextBox ID="txtName" runat="server" placeholder="Name"></asp:TextBox><br />
            <asp:TextBox ID="txtEmail" runat="server" placeholder="Email"></asp:TextBox><br />
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" placeholder="Password"></asp:TextBox><br />
            <asp:DropDownList ID="ddlCountry" runat="server" AutoPostBack="true">
                <asp:ListItem Text="--Select Country--" Value="" />
                <asp:ListItem Text="USA" Value="USA" />
                <asp:ListItem Text="Canada" Value="Canada" />
             
            </asp:DropDownList><br />
            <asp:CheckBox ID="chkTerms" runat="server" Text="I accept the terms and conditions." ValidationGroup="TermsValidation" /><br />
            <asp:CustomValidator ID="cvTerms" runat="server" 
                ErrorMessage="Please accept the terms and conditions." 
                OnServerValidate="CustomValidator_Terms" 
                 />
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" ValidationGroup="TermsValidation" />
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>