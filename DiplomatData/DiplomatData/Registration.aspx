<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="DiplomatData.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>UserRegistration</title>
    <link href="Style.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            height: 38px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">      
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:UserReg %>" SelectCommand="SELECT * FROM [Users]"></asp:SqlDataSource>
     
        <h1>Users Registration</h1>
        <table class="registration" >
             <asp:HiddenField ID="hfUserID" runat="server" />
            <tr>
                <td>
                    <asp:Label ID="lblFirstName" runat="server" Text="FirstName"></asp:Label>
                </td>
                 <td>
                     <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="lblLastName" runat="server" Text="LastName"></asp:Label>
                </td>
                 <td class="auto-style1">
                     <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                 <td>
                    <asp:Label ID="lblGender" runat="server" Text="Gender"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem Value="1">Male</asp:ListItem>
                        <asp:ListItem Value="2">Female</asp:ListItem>
                    </asp:DropDownList>
                </td>          
            </tr>
             <tr>
                <td>
                    <asp:Label ID="lblUserName" runat="server" Text="UserName"></asp:Label>
                </td>
                 <td>
                     <asp:TextBox ID="txtUserName" runat="server" ToolTip="Pls Enter your UserName"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                </td>
                 <td>
                     <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" ToolTip="Pls Enter your Password"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="lblConfirmPassword" runat="server" Text="Confirm Password"></asp:Label>
                </td>
                 <td>
                     <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" ToolTip="Confirm your Passsword"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Set" OnClick="Button1_Click" />
                    
                </td>   
                 <td >
                    <asp:Button ID="Button2" runat="server" Text="Clear" OnClick="Button2_Click" />
                 </td>
                
            </tr>
             
            <tr>
                <td>
            
               <asp:Label ID="lblSucsec" runat="server" Text="" ForeColor="Green" ></asp:Label>
                </td>          
            </tr>
            <tr>
                <td>
            
               <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red" ></asp:Label>
                </td>          
            </tr>
            
        </table>
    </form>
 
</body>
</html>
