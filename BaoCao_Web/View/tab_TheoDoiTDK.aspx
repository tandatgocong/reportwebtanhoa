<%@ Page Title="" Language="C#" MasterPageFile="~/View/HomePage.Master" AutoEventWireup="true" CodeBehind="tab_TheoDoiTDK.aspx.cs" Inherits="BaoCao_Web.View.tab_TheoDoiTDK" %>
 <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 145px;
        }
        .style2
        {
            width: 144px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <script language="javascript" type="text/javascript">
           window.document.getElementById("HOME").className = "top_link";
           window.document.getElementById("DHN").className = "current_link";
           window.document.getElementById("HSKH").className = "top_link";
           window.document.getElementById("BDBC").className = "top_link";
    </script>
   <div class="Pages_content">

<div class="title_page"><asp:Label ID="title" runat="server" Text="QUẢN LÝ ĐỒNG HỒ NƯỚC "></asp:Label></div>
 <asp:Panel ID="Panel1" runat="server" Height="94%" ScrollBars="Both" >  
       <ajaxToolkit:ToolkitScriptManager runat="Server" EnableScriptGlobalization="true"
            EnableScriptLocalization="true" ID="ScriptManager1"  />     
 <div class="block block_left events" style="width: 97%; margin-left:10px; margin-bottom:10px;">
 	<h3>Theo Dõi Tình Hình Báo Thay </h3>
	<div class="block_content">
        <table style="font-size:13px;">
            <tr>
                <td class="style3"> <asp:Label ID="Label1" runat="server" Text="Từ Ngày : " CssClass="label"></asp:Label></td>
                <td class="style1"><asp:TextBox runat="server" ID="tungay" autocomplete="off" /></td>
                <td class="style3"> <asp:Label ID="Label2" runat="server" Text="Đến Ngày : " CssClass="label"></asp:Label></td>
                <td class="style2"><asp:TextBox runat="server" ID="denngay" autocomplete="off" /></td>
                <td class="style4">&nbsp;<asp:Button ID="Button1" runat="server" Text="XEM THÔNG TIN" 
                        CssClass="button" /></td>
                
            </tr>
            <tr>
                <td colspan="5" class="style5"></td>
            </tr>
             <tr>
                 <td colspan="5">
                     <asp:GridView ID="GridView1" runat="server" BackColor="White" 
                         BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" 
                         AutoGenerateColumns="False" ShowFooter="True" Width="626px">
                         <Columns>
                             <asp:BoundField DataField="TONGBK" HeaderText="TỔNG SỐ BẢNG KÊ" />
                             <asp:BoundField DataField="SLDHN" HeaderText="SỐ LƯỢNG ĐHN" />
                             <asp:BoundField DataField="CHUATHAY" HeaderText="CHƯA THAY " />
                             <asp:BoundField DataField="DATHAY" HeaderText="ĐÃ THAY" />
                             <asp:BoundField DataField="TRONGAI" HeaderText="TRỞ NGẠI" />
                         </Columns>
                         <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                         <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                         <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                         <RowStyle BackColor="White" ForeColor="#330099" />
                         <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                         <SortedAscendingCellStyle BackColor="#FEFCEB" />
                         <SortedAscendingHeaderStyle BackColor="#AF0101" />
                         <SortedDescendingCellStyle BackColor="#F6F0C0" />
                         <SortedDescendingHeaderStyle BackColor="#7E0000" />
                     </asp:GridView>
                 </td>
            </tr>
             <tr>
                <td colspan="5">&nbsp;</td>
            </tr>
        </table>
       <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="tungay" Format="dd/MM/yyyy" >
    </ajaxToolkit:CalendarExtender>
         <ajaxToolkit:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="denngay" Format="dd/MM/yyyy" >
    </ajaxToolkit:CalendarExtender>

    </div>
 
 
 
       </asp:Panel>
   
 </div>     

</asp:Content>
