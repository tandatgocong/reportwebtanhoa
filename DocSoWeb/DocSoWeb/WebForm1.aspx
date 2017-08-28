<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebMobile.WebForm1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <style type="text/css">
        .style1
        {
            height: 25px;
        }
        
    </style>
    
</head>
<body>
    <form id="form2" runat="server">
    <div>
<asp:ScriptManager ID="ScriptManager1" runat="server" 
EnablePageMethods = "true">
</asp:ScriptManager>

<asp:TextBox ID="txtContactsSearch" runat="server"></asp:TextBox>
<cc1:AutoCompleteExtender ServiceMethod="SearchCustomers" 
    MinimumPrefixLength="2"
    CompletionInterval="100" EnableCaching="false" CompletionSetCount="10" 
    TargetControlID="txtContactsSearch"
    ID="AutoCompleteExtender1" runat="server" FirstRowSelected = "false">
</cc1:AutoCompleteExtender>
    </div>
    
 
    <div>
    
        <table style="width:100%;" >
            <tr>
                <td class="style1">
                    Loại Bể</td>
                <td >
                    <asp:DropDownList ID="cbLoaiBe" runat="server">
                        <asp:ListItem>Bể Ngầm</asp:ListItem>
                        <asp:ListItem>Bể Nổi</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Số nhà</td>
                <td  >
                    <asp:TextBox ID="txtSoNha" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Tên Đường</td>
                <td >
                    <asp:TextBox ID="txtTenDuong" runat="server"></asp:TextBox>

                   
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Phường</td>
                <td  >
                    <asp:DropDownList ID="cbPhuong" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Quận</td>
                <td>
                    <asp:DropDownList ID="cbQuan" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Mã DMA</td>
                <td>
                    <asp:DropDownList ID="cbMaDMA" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Ghi Chú</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
