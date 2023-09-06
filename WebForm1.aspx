<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Zplussolution.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                
                <tr>
                    <td>Employee Name
                    </td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Employee ID
                    </td>
                    <td>
                        <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Designation
                    </td>
                    <td>
                        <asp:TextBox ID="txtDesignation" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Address(City Name)
                    </td>
                    <td>
                        <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Mobile Number
                    </td>
                    <td>
                        <asp:TextBox ID="txtNumber" runat="server"></asp:TextBox>
                    </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="txtSubmit" runat="server" Text="Submit" OnClick="txtSubmit_Click" />
                            
                       </td>
                    </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                

            </table>
        </div>
    </form>
</body>
</html>
