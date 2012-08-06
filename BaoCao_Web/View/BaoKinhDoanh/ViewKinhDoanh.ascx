<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ViewKinhDoanh.ascx.cs" Inherits="BaoCao_Web.View.BaoKinhDoanh.ViewKinhDoanh" %>
<link href="../../StyleSheet/StyleSheet.css" rel="stylesheet" type="text/css" />
<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="System.Data.SqlClient" %>

<style type="text/css">
    .style2
    {
        width: 132px;
    }
    .style3
    {
        width: 42px;
    }
    .style4
    {
        width: 76px;
        height: 2px;
        border-left:1px #99cc99 solid;
        text-align: center;
        border-bottom-style: solid;
        border-bottom-width: 2px;
    }
    .style5
    {
        width: 64px;
        height: 2px;
        border-bottom-style: solid;
        border-right:1px #99cc99 solid;
        border-bottom-width: 2px;
        text-align: center;
    }
    .style6
    {
        width: 97px;
    }
    .style10
    {
        width: 117px;
    }
    .style11
    {
        width: 53px;
        height: 42px;
         border-right:1px #99cc99 solid;
    }
    .style12
    {
        width: 74px;
        height: 2px;
        border-right:1px #99cc99 solid;
        border-bottom-style: solid;     
        border-bottom-width: 2px;
        text-align: center;
    }
    .style14
    {
        width: 79px;
    }
    .style24
    {
        width: 107px;
        border-left:1px #99cc99 solid;
        border-right:1px #99cc99 solid;
        border-bottom: 2px solid;
    }
    .style25
    {
        width: 89px;
        height: 42px;
        border-right:1px #99cc99 solid;
        border-left:1px #99cc99 solid;
        text-align: center;
    }
    .style30
    {
        width: 69px;        
        border-left:1px #99cc99 solid;
        border-bottom-style: solid;     
        border-bottom-width: 2px;
        text-align: right;
    }
    .style32
    {
        width: 56px;
    }
    .style35
    {
        width: 92px;
    }
    .style400
    {
        text-align: right;
         border-bottom-style: solid;     
        border-bottom-width: 2px;
       
    }
    .style401
    {
        text-align: right;
        border-bottom-style: solid;     
        border-bottom-width: 2px;
        border-left:1px #99cc99 solid;
        border-right:1px #99cc99 solid;
       
    }
    .style40
    {
        text-align: right;
         border-bottom-style: solid;     
        border-bottom-width: 2px;
       
    }
    .style41
    {
        width: 48px;
       
    }
    .style45
    {
        width: 52px;
        height: 2px;
        border-left:1px #99cc99 solid;
        border-bottom-style: solid;     
        border-bottom-width: 2px;
        text-align: center;
    }
    .style46
    {
        width: 89px;
        height: 2px;
        border-right:1px #99cc99 solid;
        border-left:1px #99cc99 solid;
        border-bottom-style: solid;     
        border-bottom-width: 2px;
        text-align: center;
    }
    .style54
    {
        width: 44px;
        border-bottom-style: solid;     
        border-bottom-width: 2px;
        text-align: center;
    }
    .style55
    {
        width: 52px;
        text-align: center;
        border-left:1px #99cc99 solid;
        border-right:1px #99cc99 solid;
        border-bottom-style: solid;     
        border-bottom-width: 2px;
    }
    .style58
    {
        height: 42px;
          border-left:1px #99cc99 solid;
        border-right:1px #99cc99 solid;
        text-align: center;
    }
    .style59
    {
        width: 114px;
    }
    .style61
    {
        width: 52px;
        height: 42px;
        border-right: 2px #99cc99 solid;
    }
    .style62
    {
        width: 52px;
        height: 2px;
        border-bottom-style: solid;
        border-bottom-width: 2px;
        border-right: 2px #99cc99 solid;
    }
    .style63
    {
        width: 53px;
        height: 2px;
        border-right: 1px #99cc99 solid;
        border-bottom-style: solid;
        border-bottom-width: 2px;
    }
    .style402
    {
        text-align: right;
    }
</style>
<div class="title_page"><asp:Label ID="title" runat="server" Text="SỐ LIỆU KINH DOANH NĂM"></asp:Label>&nbsp;<asp:DropDownList 
        ID="year" runat="server" Font-Bold="True" Font-Size="13pt" 
        ForeColor="#006600" AutoPostBack="True" 
        onselectedindexchanged="year_SelectedIndexChanged">

    </asp:DropDownList>
    </div>
<div class="block_content">
   <asp:Panel ID="Panel2" runat="server" ScrollBars="Auto" Height="95%"  
        BorderWidth="0px" Width="1221px" >      
            <table cellpadding="0" cellspacing="0" 
                style="font-family:Times New Roman; font-size:15px; width: 1192px;" 
                class="table_list" >
              <tbody>
                  <tr class="head" >
                    <td rowspan="2" class="style3"  >KỲ</td>
                    <td rowspan="2" class="style2"  >
                        DOANH THU<br />
                        TỈ LỆ DOANH THU</td>
                     
                    <td  rowspan="2" class="style6" >
                        SẢN LƯỢNG</td>
                     <td rowspan="2" class="style10"  >
                         ĐỒNG HỒ NƯỚC </td>
                 
                     <td  rowspan="2" class="style14" >
                         GIÁ BQ</td>
                 
                     <td  rowspan="2" class="style59"  >
                         HÓA ĐƠN
                         <br />
                         TB</td>
                 
                     <td  colspan="2" >
                         HÓA ĐƠN =0</td>
                 
                     <td  rowspan="2" >
                         TỒN THU</td>
                 
                </tr>
                  <tr class="head" >
                 
                     <td class="style35"   >
                         0m<sup>3</sup></td>
                 
                     <td class="style6"  >
                         4m<sup>3</sup></td>
                 
                </tr>
              </tbody>
            </table>
             
        <asp:Panel ID="Panel1" runat="server" ScrollBars="Auto"  
                BorderWidth="0px" Width="1217px" Height="480px" >
             
            <table border="0" cellpadding="0" cellspacing="0" 
                style="width: 1192px;" >
                             <% 
                       DataTable table = new DataTable();
                       if (Session["BAOKD"] != null)
                       {
                           table = (DataTable)Session["BAOKD"];
                           for (int i = 0; i < table.Rows.Count; i++)
                           {
                           %>
                <tr>
                    <td class="style55" rowspan="2" >
                        <b ><%=table.Rows[i]["KY"]%></b></td>
                    <td  colspan="2" class="style58" >
                       <span title="Tiền Nước Chuẩn Thu "><%=table.Rows[i]["DOANHTHU"]%></span> </td>
                    <td style="text-align: center" class="style24" rowspan="2" >
                       <span title="Lượng Nước Chuẩn Thu ">2 369 602 </span></td>
                    <td  colspan="2" class="style58">
                       <span title="Số Đồng Hồ Nước">115 493</span></td>
                    <td class="style25" >
                       <span title="Giá Bán Bình Quân">7 343</span></td>
                    <td rowspan="2" class="style30">
                        <div class="style402">
                            <span title="HĐ Trung Bình Q.Phú Nhuận">0</span>&nbsp;<br /> <span title="HĐ Trung Bình Q.Tân Bình">128</span>&nbsp;<br /><span title="HĐ Trung Bình Q.Tân Phú">107</span>&nbsp;</div>
                        <hr style="height: 0px; margin-bottom:0px; margin-top:0px; width: 63px;" />
                        <div class="style402">
                            <span title="Tổng HĐ Trung Bình">235</span>&nbsp;</div>
                    </td>
                    <td class="style61">
                        </td>
                    <td  rowspan="2" class="style41">
                        <div class="style40" >
                           <span title="HĐ=0 Q.Phú Nhuận">0</span>&nbsp;<br /> <span title="HĐ=0 Q.Tân Bình">128</span>&nbsp;<br /><span title="HĐ=0 Q.Tân Phú">107</span>&nbsp;
                        <hr style="height: 0px; margin-bottom:0px; margin-top:0px; width: 44px;" />
                        <span title="Tổng HĐ=0">235&nbsp;</span></div>
                    </td>
                    <td class="style11" >
                    </td>
                    <td  rowspan="2" class="style32">
                        <div class="style40">
                            <span title="HĐ<4 Q.Phú Nhuận">0</span>&nbsp;<br /> <span title="HĐ<4  Q.Tân Bình">128</span>&nbsp;<br /><span title="HĐ<4  Q.Tân Phú">107</span>&nbsp;
                        <hr style="height: 0px; margin-bottom:0px; margin-top:0px; width: 47px;" />
                        <span title="Tổng HĐ<4">235&nbsp;</span></div>
                    </td>
                    <td class="style61" >
                    </td>
                    <td rowspan="2" class="style54">
                       <span title="Số Lượng Hóa Đơn Tồn Các Kỳ Trước">235&nbsp;</span></td>
                    <td rowspan="2" >
                        <div class="style400" >
                            &nbsp;&nbsp;<br /> <span title="Hóa Đơn Tồn Tư Gia ">128</span>&nbsp;&nbsp;<br /><span title="Hóa Đơn Tồn Cơ Quan ">107</span>&nbsp;&nbsp;
                            <hr style="height: 0px; margin-bottom:0px; margin-top:0px; width: 108px;" />                       
                            <span title="Tổng Hóa Đơn Tồn ">235</span>&nbsp;&nbsp;</div>
                    </td>
                    <td rowspan="2" style="border:1px;">
                        <div class="style401" >
                            &nbsp;&nbsp;&nbsp;<br /><span title="Doanh Thu Tồn Tư Gia "> 128</span>&nbsp;&nbsp;&nbsp;<br /><span title="Doanh Thu Tồn Cơ Quan">107</span>&nbsp;&nbsp;&nbsp;
                            <hr style="height: 0px; margin-bottom:0px; margin-top:0px; width: 161px;" />
                            <span title="Tổng Doanh Thu Tồn">235</span>&nbsp;&nbsp;</div>
                    </td>

                </tr>
                <tr>
                    <td class="style4" >
                       <span title="Tỉ Lệ Thực Thu 4 Kỳ">9949</span></td>
                    <td class="style5" >
                       <span title="Tỉ Lệ Thực Thu Kỳ ">6866</span></td>
                    <td class="style45" >
                         <span title="ĐHN Tăng">656</span></td>
                    <td class="style12" >
                        <span title="Số Lượng Hóa Đơn <=4m3">656</span>&nbsp;
                    </td>
                    <td class="style46" >
                        <span title="Tổng Hóa Đơn Định Mức">2 044 960</span>&nbsp;&nbsp;</td>
                    <td class="style62" >
                        789</td>
                    <td class="style63" >
                        789</td>
                    <td class="style62" >
                        678</td>
                </tr>
          
                        <%}
                       } %>      
            </table>
        </asp:Panel>
    </asp:Panel>
</div>



 
    