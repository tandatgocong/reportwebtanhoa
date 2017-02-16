<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addDongNuocc.aspx.cs" Inherits="BaoCao_Web.addDongNuocc" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cập Nhật Thông Tin Đóng Nước</title>
     <link href="../StyleSheet/Menu.css" rel="stylesheet" type="text/css" />
    <link href="../StyleSheet/StyleSheet.css" rel="stylesheet" type="text/css" />
    <script src="../JavaScript/transmenu.js" type="text/javascript"></script>

    <style type="text/css">
        .style1
        {
            height: 31px;
        }
        .style2
        {
            height: 32px;
        }
        .style4
        {
            height: 35px;
        }
        .style5
        {
            height: 40px;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
     <div class="title_page" style="hight:20px;"><asp:Label ID="title" runat="server" 
        Text="CẬP NHẬT GIẤY ĐƯỢC PHÉP VỀ SỚM"></asp:Label>
    </div>
     <table class="">
                    <tr>
                        <td class="style1">
                            &nbsp;</td>
                        <td class="style2" colspan="3"> 
                            <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
                            </asp:ToolkitScriptManager>
                        </td>
                    </tr>
                    <tr>
                        <td class="style4">
                            &nbsp;<asp:Label ID="Label1" runat="server" Text="TỪ NGÀY"></asp:Label>
                        </td>
                        <td class="style4">
                              <asp:TextBox ID="tungay" runat="server" autocomplete="off" />
                            <asp:CalendarExtender ID="CalendarExtender1" runat="server" 
                                Enabled="True" Format="dd/MM/yyyy" TargetControlID="tungay">
                            </asp:CalendarExtender>
                         
                            
                        </td>
                        <td class="style4">
                            <asp:Label ID="Label2" runat="server" Text="ĐẾN NGÀY"></asp:Label>
                        </td>
                        <td class="style4">
                            <asp:TextBox ID="denngay" runat="server" autocomplete="off" />
                            <asp:CalendarExtender ID="CalendarExtender2" runat="server" 
                                Enabled="True" Format="dd/MM/yyyy" TargetControlID="denngay">
                            </asp:CalendarExtender>
                           
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style5">
                            <asp:Label ID="Label4" runat="server" Text="TỪ GIỜ"></asp:Label>
                        </td>
                        <td class="style5">
                            <asp:TextBox ID="tugio" runat="server"></asp:TextBox>
                        </td>
                        <td class="style5">
                            <asp:Label ID="Label5" runat="server" Text="ĐẾN GIỜ"></asp:Label>
                        </td>
                        <td class="style5">
                            <asp:TextBox ID="dengio" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            NỘI DUNG</td>
                        <td class="style14" colspan="3">
                            <asp:TextBox ID="txtNoiDungCT" runat="server" Height="54px" 
                                Width="398px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            &nbsp;</td>
                        <td class="style14" colspan="3">
                            <asp:Button ID="btXemBangKe" runat="server" CssClass="button" 
                                  Text="CẬP NHẬT" Height="32px" Width="139px" 
                                onclick="btXemBangKe_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style8" colspan="4">
                            <asp:Label ID="lbThanhCong" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>
    </form>
</body>
</html>
