﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UpdateKinhDoanh.ascx.cs" Inherits="BaoCao_Web.View.BaoKinhDoanh.UpdateKinhDoanh" %>
<link href="../../StyleSheet/StyleSheet.css" rel="stylesheet" type="text/css" />
<style type="text/css">
    .style8
    {
        width: 3px;
        height: 51px;
    }
    .style13
    {
        height: 51px;
    }
    .style15
    {
        width: 3px;
        height: 56px;
    }
    .style23
    {
        width: 157px;
        height: 51px;
    }
    .style28
    {
        height: 56px;
    }
    .style29
    {
        height: 51px;
        width: 32px;
    }
    .style31
    {
        width: 150px;
    }
    .style33
    {
        width: 150px;
        height: 56px;
    }
    .style34
    {
        width: 3px;
        height: 40px;
    }
    .style36
    {
        width: 157px;
        height: 40px;
    }
    .style37
    {
        height: 40px;
    }
    .style41
    {
        width: 177px;
        height: 51px;
    }
    .style45
    {
        width: 1px;
        height: 51px;
    }
    .style47
    {
        width: 1px;
        height: 40px;
    }
    .style54
    {
        width: 72px;
        height: 56px;
    }
    .style58
    {
        width: 177px;
        height: 56px;
    }
    .style59
    {
        width: 3px;
    }
    .style60
    {
        width: 72px;
    }
    .style61
    {
        width: 32px;
    }
    .style62
    {
        width: 32px;
        height: 56px;
    }
    .style66
    {
        height: 40px;
        width: 177px;
    }
    .style85
    {
        width: 3px;
        height: 39px;
    }
    .style87
    {
        height: 39px;
    }
    .style89
    {
        height: 39px;
    }
    .style93
    {
        width: 3px;
        height: 33px;
    }
    .style95
    {
        height: 33px;
    }
    .style96
    {
        height: 39px;
        width: 177px;
    }
    .style97
    {
        width: 177px;
    }
    .style101
    {
        width: 1px;
    }
    .style102
    {
        width: 1px;
        height: 56px;
    }
    .style103
    {
        height: 48px;
        text-align: center;
    }
    .style106
    {
        width: 157px;
    }
    .style107
    {
        width: 157px;
        height: 56px;
    }
    .style109
    {
        width: 12px;
        height: 40px;
    }
    .style110
    {
        width: 12px;
    }
    .style111
    {
        height: 51px;
        width: 12px;
    }
    .style112
    {
        width: 12px;
        height: 56px;
    }
    .style114
    {
        width: 3px;
        height: 42px;
    }
    .style115
    {
        height: 42px;
    }
    .style116
    {
        width: 3px;
        height: 48px;
    }
    .style117
    {
        height: 48px;
        width: 177px;
    }
    .style118
    {
        height: 48px;
    }
    </style>
<div class="title_page"><asp:Label ID="title" runat="server" Text="CẬP NHẬT SỐ LIỆU KINH DOANH NĂM"></asp:Label>&nbsp;<asp:DropDownList 
        ID="year" runat="server" Font-Bold="True" Font-Size="13pt" 
        ForeColor="#006600" >

    </asp:DropDownList>
    &nbsp;KỲ
    <asp:DropDownList 
        ID="ky" runat="server" Font-Bold="True" Font-Size="13pt" 
        ForeColor="#006600" AutoPostBack="True" >
        <asp:ListItem>1</asp:ListItem>
        <asp:ListItem>2</asp:ListItem>
        <asp:ListItem>3</asp:ListItem>
        <asp:ListItem>4</asp:ListItem>
        <asp:ListItem>5</asp:ListItem>
        <asp:ListItem>6</asp:ListItem>
        <asp:ListItem>7</asp:ListItem>
        <asp:ListItem>8</asp:ListItem>
        <asp:ListItem>9</asp:ListItem>
        <asp:ListItem>10</asp:ListItem>
        <asp:ListItem>11</asp:ListItem>
        <asp:ListItem>12</asp:ListItem>

    </asp:DropDownList>
    </div>
<div class="block_content">
   <asp:Panel ID="Panel2" runat="server" ScrollBars="Auto" Height="95%"  
        BorderWidth="0px" Width="100%" >
       <table >
           <tr>
               <td class="style59">
                   &nbsp;</td>
               <td class="style97">
                   &nbsp;</td>
               <td class="style101">
                   &nbsp;</td>
               <td class="style106">
                   &nbsp;</td>
               <td class="style110">
                   &nbsp;</td>
               <td class="style60">
                   &nbsp;</td>
               <td class="style61">
                   &nbsp;</td>
               <td class="style31">
                   &nbsp;</td>
               <td>
                   &nbsp;</td>
           </tr>
           <tr>
               <td class="style8">
               </td>
               <td class="style41">
                   Doanh Thu:<asp:TextBox ID="txtDoanhThu" runat="server" Width="147px"></asp:TextBox>
               </td>
               <td class="style45">
                   &nbsp;</td>
               <td class="style23">
                   Tỉ Lệ Doanh Thu Kỳ :<asp:TextBox ID="txtTiLeDTKy" runat="server" Width="131px"></asp:TextBox>
               </td>
               <td class="style111">
                   &nbsp;</td>
               <td class="style13" >
                   Tỉ Lệ Doanh Thu 4 Kỳ :<br /> <asp:TextBox ID="txtTiLeDTKy0" runat="server" 
                       Width="131px"></asp:TextBox>
               </td>
               <td class="style29">
               </td>
           </tr>
           <tr>
               <td class="style15">
               </td>
               <td class="style58">
                   Sản Lượng:<asp:TextBox ID="txtDoanhThu0" runat="server" Width="146px"></asp:TextBox>
               </td>
               <td class="style102">
                   &nbsp;</td>
               <td class="style107">
                   Đồng Hồ Nước :<asp:TextBox ID="txtTiLeDTKy1" runat="server" Width="131px"></asp:TextBox>
               </td>
               <td class="style112">
                   &nbsp;</td>
               <td class="style54">
                   Tăng ĐHN :<br />
                   <asp:TextBox ID="txtTiLeDTKy2" runat="server" Width="131px"></asp:TextBox>
               </td>
               <td class="style62">
                   &nbsp;</td>
               <td class="style33">
                   Hóa Đơn &lt; 4m<sup>3</sup><asp:TextBox ID="txtTiLeDTKy3" runat="server" 
                       Width="131px"></asp:TextBox></td>
               <td class="style28">
               </td>
           </tr>
           <tr>
               <td class="style34">
                   </td>
               <td class="style66">
                   Giá Bình Quân:<asp:TextBox ID="txtDoanhThu1" runat="server" Width="143px"></asp:TextBox>
               </td>
               <td class="style47">
                   &nbsp;</td>
               <td class="style36">
                   Hóa Đơn Định Mực<asp:TextBox ID="txtTiLeDTKy4" runat="server" Width="131px"></asp:TextBox>
               </td>
               <td class="style109">
                   &nbsp;</td>
               <td class="style37" colspan="4">
                   &nbsp;</td>
           </tr>
           <tr>
               <td class="style114">
                   </td>
               <td class="style115" colspan="8">
                   <strong>Hóa Đơn T.Bình</strong>&nbsp; Q.Phú Nhuận :
                   <asp:TextBox ID="txtTiLeDTKy5" runat="server" Width="88px"></asp:TextBox>
                   &nbsp; Tân Bình:<asp:TextBox ID="txtTiLeDTKy6" runat="server" Width="88px"></asp:TextBox>
                   &nbsp; Tân Phú:
                   <asp:TextBox ID="txtTiLeDTKy7" runat="server" Width="88px"></asp:TextBox>
                   Tổng Cộng :<asp:TextBox ID="txtTiLeDTKy8" runat="server" Width="116px"></asp:TextBox>
                   &nbsp;Tăng/Giảm:<asp:TextBox ID="txtTiLeDTKy9" runat="server" Width="88px"></asp:TextBox>
               </td>
           </tr>
           <tr>
               <td class="style34">
                   </td>
               <td class="style37" colspan="8">
                   <strong>Hóa Đơn 0m</strong><sup>3</sup> &nbsp; Q.Phú Nhuận :
                   <asp:TextBox ID="txtTiLeDTKy10" runat="server" Width="88px"></asp:TextBox>
                   &nbsp; Tân Bình:<asp:TextBox ID="txtTiLeDTKy11" runat="server" Width="88px"></asp:TextBox>
                   &nbsp; Tân Phú:
                   <asp:TextBox ID="txtTiLeDTKy12" runat="server" Width="88px"></asp:TextBox>
                   Tổng Cộng :<asp:TextBox ID="txtTiLeDTKy13" runat="server" Width="116px"></asp:TextBox>
                   &nbsp;Tăng/Giảm:<asp:TextBox ID="txtTiLeDTKy14" runat="server" Width="101px"></asp:TextBox>
               </td>
           </tr>
           <tr>
               <td class="style85">
                   </td>
               <td class="style87" colspan="8">
                   <strong>Hóa Đơn 4m</strong><sup>3</sup>&nbsp;&nbsp; Q.Phú Nhuận :
                   <asp:TextBox ID="txtTiLeDTKy15" runat="server" Width="88px"></asp:TextBox>
                   &nbsp; Tân Bình:<asp:TextBox ID="txtTiLeDTKy16" runat="server" Width="88px"></asp:TextBox>
                   &nbsp; Tân Phú:
                   <asp:TextBox ID="txtTiLeDTKy17" runat="server" Width="88px"></asp:TextBox>
                   Tổng Cộng :<asp:TextBox ID="txtTiLeDTKy18" runat="server" Width="116px"></asp:TextBox>
                   &nbsp;Tăng/Giảm:<asp:TextBox ID="txtTiLeDTKy19" runat="server" Width="102px"></asp:TextBox>
               </td>
           </tr>
           <tr>
               <td class="style93">
                   </td>
               <td class="style97" rowspan="2">
                   <strong>Số HĐ Tồn Các Kỳ Trước</strong><br />
                   <asp:TextBox ID="txtDoanhThu2" runat="server" Width="156px"></asp:TextBox>
               </td>
               <td class="style95" colspan="7">
                   <strong>Hóa Đơn Tồn Thu </strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Tư Gia:
                   <asp:TextBox ID="txtDoanhThu3" runat="server" Width="143px"></asp:TextBox>
                   &nbsp; &nbsp; Cơ Quan:
                   <asp:TextBox ID="txtDoanhThu5" runat="server" Width="143px"></asp:TextBox>
                   &nbsp; Tổng:&nbsp;<asp:TextBox ID="txtDoanhThu7" runat="server" Width="175px"></asp:TextBox>
                   </td>
           </tr>
           <tr>
               <td class="style85">
                   </td>
               <td class="style87" colspan="7">
                   <strong>Doanh Thu Tồn Thu</strong>&nbsp;&nbsp; Tư Gia: &nbsp;<asp:TextBox ID="txtDoanhThu4" 
                       runat="server" Width="143px"></asp:TextBox>
                   &nbsp;&nbsp; Cơ Quan:
                   <asp:TextBox ID="txtDoanhThu6" runat="server" Width="143px"></asp:TextBox>
                   &nbsp;&nbsp; Tổng:
                   <asp:TextBox ID="txtDoanhThu8" runat="server" Width="172px"></asp:TextBox>
               </td>
           </tr>
           <tr>
               <td class="style116">
                   </td>
               <td class="style117">
                   </td>
               <td class="style103" colspan="5">
                   <asp:Button ID="Button1" runat="server" CssClass="button" Text="CẬP NHẬT" 
                       Width="156px" />
               </td>
               <td class="style118">
                   </td>
           </tr>
       </table>
          
             
    </asp:Panel>
  
</div>



 
    