<%@ Page Title="" Language="C#" MasterPageFile="~/View/HomePage.Master" AutoEventWireup="true" CodeBehind="QuanLyHoSoKhachHang.aspx.cs" Inherits="BaoCao_Web.View.QuanLyHoSoKhachHang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .button1
        {}
        .style1
        {
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <script language="javascript" type="text/javascript">
           window.document.getElementById("HOME").className = "top_link";
           window.document.getElementById("KINHDOANH").className = "current_link";
           window.document.getElementById("CHAMCONG").className = "top_link";
    </script>
<div class="Pages_content" >
<div class="title_page"><asp:Label ID="title" runat="server" Text="QUẢN LÝ HỒ SƠ KHÁCH HÀNG "></asp:Label>
</div>
<table style="width:95%; margin-left:20px; " border="0">
        <tr>
    <td class="style28" rowspan="2"  valign=top>
       <table cellpadding="0" cellspacing="0" style="font-family:Times New Roman; font-size:15px; margin-left:20px;" class="table_list" >
        <tbody>
           <tr class="head1">
               <td class="style11" style="border-right:0px #99cc99 solid; border-bottom: 1px solid;">
                                            &nbsp;SỐ ĐƠN:</td>
               <td class="style5" 
                   style="border-right:2px #99cc99 solid; font-size:10px; font-weight:normal;   border-bottom: 1px solid;">
                                            <asp:TextBox ID="txtSoDon"  runat="server" autocomplete="off" />
               </td>               
                <td class="style10" style="border-right:0px #99cc99 solid; border-bottom: 1px solid;">
                                            &nbsp;&nbsp;&nbsp; ĐỊA CHỈ: </td>
                <td class="style5" 
                   style="border-right:2px #99cc99 solid; font-size:10px; font-weight:normal;   border-bottom: 1px solid;">
                                            <asp:TextBox ID="txtDiaChi"  runat="server" autocomplete="off" Width="242px" />
               </td>
               <td class="style10" style="border-right:0px #99cc99 solid; border-bottom: 1px solid;">
                                            &nbsp;&nbsp;&nbsp; ĐỢT THI CÔNG: </td>
                <td class="style5" 
                   style="border-right:2px #99cc99 solid; font-size:10px; font-weight:normal;   border-bottom: 1px solid;">
                                            <asp:TextBox ID="txtDotTC"  runat="server" autocomplete="off" Width="138px" />
               </td>
                <td class="style5" 
                   style="border-right:2px #99cc99 solid; font-size:10px; font-weight:normal;   border-bottom: 1px solid;">
                                            <asp:Button ID="btSubmit" runat="server" CssClass="button" Height="27px" 
                                                onclick="btSubmit_Click" Text="Tìm Kiếm" Width="103px" />
               </td>
             </tr>
          </tbody>
    </table>
                
    </td>
    </tr>
</table>

<table cellpadding="0" cellspacing="0" 
    class="table_list_1" 
    style="font-family:Times New Roman; font-size:15px; width: 100%;">
                            <tr class="head1">
                                <td class="style1" 
                                    style="border-right:1px #FF0000 solid; background-color:#CCFFFF; font-size:large; border-bottom: 2px #FF0000 solid">
                                    <center>
                                    </center>
                                </td>
                            </tr>
                            <tr class="head1">
                                <td class="style21" 
                                    style="border-right:1px #FF0000 solid;font-size:large; border-bottom: 2px #FF0000 solid ">

                                         <asp:Panel ID="Panel1" runat="server" ScrollBars="Both" Height="400px"  >  
 <asp:Panel ID="Panel2" runat="server" ScrollBars="None"> 
                                    <asp:GridView ID="GridView1" runat="server" 
                                        BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" 
                                        CellPadding="4" ForeColor="Black" GridLines="Vertical" Width="150%" 
                                        AutoGenerateColumns="False">
                                        <AlternatingRowStyle BackColor="White" />
                                        <Columns>
                                            <asp:BoundField DataField="SHS" HeaderText="Số Đơn">
                                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="90px" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="HOTEN" HeaderText="Họ Tên">
                                            <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Width="200px" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="DIACHI" HeaderText="Địa Chỉ">
                                            <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Width="300px" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="DIENTHOAI" HeaderText="Điện Thoại">
                                            <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Width="110px" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="MADOTTC" HeaderText="Đợt Thi Công">
                                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="150px" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="TENCONGTY" HeaderText="Đơn Vị Thi Công">
                                            <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Width="200px" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="TCNGAY" HeaderText="Ngày Thi Công">
                                            <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Width="200px" />
                                            </asp:BoundField>
                                        </Columns>
                                        <FooterStyle BackColor="#CCCC99" />
                                        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                                        <RowStyle BackColor="#F7F7DE" />
                                        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                                        <SortedAscendingCellStyle BackColor="#FBFBF2" />
                                        <SortedAscendingHeaderStyle BackColor="#848384" />
                                        <SortedDescendingCellStyle BackColor="#EAEAD3" />
                                        <SortedDescendingHeaderStyle BackColor="#575357" />
                                    </asp:GridView>
                                    </asp:Panel>
                                    </asp:Panel>


                                </td>
                            </tr>
                            </table>


</div>
</asp:Content>
