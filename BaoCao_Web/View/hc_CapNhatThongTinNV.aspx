﻿<%@ Page Title="" Language="C#" MasterPageFile="~/View/HomePage.Master" AutoEventWireup="true" CodeBehind="hc_CapNhatThongTinNV.aspx.cs" Inherits="BaoCao_Web.View.hc_CapNhatThongTinNV" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style4
        {            color: #CC0000;
            font-size: x-large;
        }
        .style7
        {
            width: 252px;
        }
        .style8
        {
        }
        .style12
        {
        }
        .style13
        {
            width: 169px;
        }
        .style14
        {
            width: 157px;
        }
        .style15
        {
        }
        .style16
        {
            width: 169px;
            height: 28px;
        }
        .style17
        {
            height: 28px;
        }
        .style20
        {
            width: 140px;
            height: 28px;
        }
        .style21
        {
            width: 252px;
            height: 28px;
        }
        .style22
        {
            width: 32px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <div class="title_page" style="hight:20px;">
        <asp:Label ID="title" runat="server" 
        Text="CẬP NHẬT THÔNG TIN NHÂN VIÊN"></asp:Label>
    </div>
<div class="block_content">
    <AjaxControl:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </AjaxControl:ToolkitScriptManager>
    <table class="table_list_in">
                    <tr>
                        <td class="style12">
                            PHÒNG BAN ĐỘI :</td>
                        <td class="style8">
                            <asp:DropDownList ID="cbPhongBanDoi" runat="server" Height="19px" Width="195px" 
                                AutoPostBack="True" onselectedindexchanged="cbPhongBanDoi_SelectedIndexChanged">
                                <asp:ListItem Value="1">Tất Cả</asp:ListItem>
                                <asp:ListItem Value="2">To</asp:ListItem>
                                <asp:ListItem Value="3">232</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td class="style22">
                            &nbsp;</td>
                        <td class="style4" rowspan="3">
                            <strong>CHUYỂN ĐẾN</strong></td>
                        <td>
                            PHÒNG BAN ĐỘI :</td>
                        <td>
                            <asp:DropDownList ID="cbPhongBanDoi0" runat="server" Height="19px" Width="195px" 
                                AutoPostBack="True">
                                <asp:ListItem Value="1">Tất Cả</asp:ListItem>
                                <asp:ListItem Value="2">To</asp:ListItem>
                                <asp:ListItem Value="3">232</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="style12">
                            NHÂN VIÊN :</td>
                        <td class="style8">
                            <asp:DropDownList ID="cpNhanVien" runat="server" Height="19px" Width="195px">
                                <asp:ListItem Value="1">Tất Cả</asp:ListItem>
                                <asp:ListItem Value="2">To</asp:ListItem>
                                <asp:ListItem Value="3">232</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td class="style22">
                            &nbsp;</td>
                        <td class="style15" colspan="2">
                            <asp:CheckBox ID="ckNV0" runat="server" 
                                Text="Nhân Viên Văn Phòng" />
                            <asp:CheckBox ID="ckCN0" runat="server" Text="Công Nhân Đi Ngoài" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style12" colspan="2">
                            &nbsp;</td>
                        <td class="style22">
                            &nbsp;</td>
                        <td class="style15">
                            &nbsp;</td>
                        <td class="style7">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style13" align="right">
                            &nbsp;</td>
                        <td class="style8">
                            &nbsp;</td>
                        <td class="style22">
                            &nbsp;</td>
                        <td class="style14">
                            &nbsp;</td>
                        <td class="style15">
                            &nbsp;</td>
                        <td class="style7">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style16">
                            </td>
                        <td class="style17">
                        </td>
                        <td class="style17" colspan="2">
                            <asp:Button ID="btXemBangKe" runat="server" CssClass="button" 
                                onclick="btXemBangKe_Click" Text="CẬP NHẬT" Height="32px" Width="139px" />
                            </td>
                        <td class="style20">
                            </td>
                        <td class="style21">
                            </td>
                    </tr>
                    <tr>
                        <td class="style12">
                            &nbsp;</td>
                        <td class="style8" colspan="5">
                            <asp:Label ID="lbThanhCong" runat="server" 
                                style="font-weight: 700; font-size: large; color: #0000FF"></asp:Label>
                        </td>
                    </tr>
                </table>
                <fieldset>
                                
                            </fieldset>
</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>