<%@ Page Title="" Language="C#" MasterPageFile="~/View/HomePage.Master" AutoEventWireup="true" CodeBehind="addDongNuocc.aspx.cs" Inherits="QuanLyKhachHang.View.addDongNuocc" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <script language="javascript" type="text/javascript">
     window.document.getElementById("HOME").className = "top_link";
     window.document.getElementById("GANMOI").className = "top_link";
     window.document.getElementById("KHACHHANG").className = "current_link";
     window.document.getElementById("APLUC").className = "top_link";
     window.document.getElementById("BAOBE").className = "top_link";
    </script>
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

     <div class="title_page" style="hight:20px;">
         <asp:Label ID="title" runat="server" 
        Text="CẬP NHẬT THÔNG TIN ĐÓNG NƯỚC"></asp:Label>
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
                        <td class="style1">
                            ĐỊA CHỈ&nbsp;</td>
                        <td class="style2" colspan="3"> 
                              <asp:TextBox ID="txtDiachi" runat="server"  Height="20px" 
                                Width="360px" />
                            
                         
                            
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
                            <asp:Button ID="btTrolai" runat="server" CssClass="button" 
                                  Text="TRỞ LẠI" Height="32px" Width="139px" onclick="btTrolai_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style8" colspan="4">
                            <asp:Label ID="lbThanhCong" runat="server" Font-Bold="True" Font-Size="Large"></asp:Label>
                        </td>
                    </tr>
                </table>

</asp:Content>
