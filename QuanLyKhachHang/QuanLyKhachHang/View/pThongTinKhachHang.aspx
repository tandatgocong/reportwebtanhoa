<%@ Page Title="" Language="C#" MasterPageFile="~/View/HomePage.Master" AutoEventWireup="true" CodeBehind="pThongTinKhachHang.aspx.cs" Inherits="QuanLyKhachHang.View.pThongTinKhachHang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style2
        {
            width: 4%;
        }
        .style3
        {
            width: 8%;
        }
        .style6
        {
        }
        .style7
        {
            width: 70%;
        }
        .style8
        {
            width: 41%;
        }
        .style9
        {
            width: 4%;
            height: 9px;
        }
        .style10
        {
            width: 119px;
            height: 9px;
        }
        .style11
        {
            width: 41%;
            height: 9px;
        }
        .style12
        {
            width: 70%;
            height: 9px;
        }
        .style13
        {
            width: 8%;
            height: 9px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table class='table_list' style="width:100%;">           

            <tr  >
                <td class="style2">
                    &nbsp;</td>
                <td class="style3" colspan="3">
                    <div class="title_page">
                        THÔNG TIN Khách hàng</div>
                </td>
                <td class="style3">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
            </tr>

            <tr   >
                <td class="style9">
                </td>
                <td class="style9">
                    </td>
                <td class="style10" style="border-bottom: 1px #99cc99 solid"  >
                    </td>
                <td class="style11" style="border-bottom: 1px #99cc99 solid">
                    </td>
                <td class="style12" style="border-bottom: 1px #99cc99 solid">
                    </td>
                <td class="style13">
                    </td>
            </tr>

            <tr>
                <td class="style2">
                </td>
                <td class="style2">
                    &nbsp;</td>
                <td class="style6" style="border-bottom: 1px #99cc99 solid" colspan="2">
                    <asp:DetailsView ID="DetailsView1" runat="server" BackColor="White" 
                        BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" 
                        ForeColor="Black" GridLines="Vertical" Height="50px" Width="520px" 
                        Font-Names="Times New Roman" Font-Size="Large">
                        <AlternatingRowStyle BackColor="#CCCCCC" />
                        <EditRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        <FooterStyle BackColor="#CCCCCC" />
                        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" 
                            Width="80px" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    </asp:DetailsView>
                </td>
                <td class="style7" style="border-bottom: 1px #99cc99 solid">
                    &nbsp;</td>
                <td class="style3">
                    </td>
            </tr>
            <tr>
                <td class="style2">
                </td>
                <td class="style2">
                    &nbsp;</td>
                <td class="style6" style="border-bottom: 1px #99cc99 solid">
                    &nbsp;</td>
                <td class="style8" style="border-bottom: 1px #99cc99 solid">
                    &nbsp;</td>
                <td class="style7" style="border-bottom: 1px #99cc99 solid">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style3" colspan="3">
                    <div class="title_page">
                        THÔNG TIN HÓA ĐƠN 
                    </div>
                </td>
                <td class="style3">
                    &nbsp;</td>
                <td class="style3">
                   &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                </td>
                <td class="style2">
                    </td>
                <td class="style6" style="border-bottom: 1px #99cc99 solid" colspan="2">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                        BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" 
                        CellPadding="3" Font-Names="Times New Roman" Font-Size="Large" 
                        GridLines="Vertical" style="margin-right: 5px" Width="894px">
                        <AlternatingRowStyle BackColor="#DCDCDC" />
                        <Columns>
                            <asp:BoundField DataField="NAM" HeaderText="Kỳ">
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="110px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="NGAYDOC" HeaderText="Ngày Đọc">
                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="120px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="CodeMoi" HeaderText="Code">
                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundField>
                            <asp:BoundField DataField="CSCU" HeaderText="CS Củ">
                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundField>
                            <asp:BoundField DataField="CSMOI" HeaderText="CS Mới">
                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundField>
                            <asp:BoundField DataField="TIEUTHU" HeaderText="Tiêu Thụ">
                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundField>
                            <asp:BoundField DataField="ThanhTien" HeaderText="Tiền Nước">
                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            <ItemStyle HorizontalAlign="Right" VerticalAlign="Middle" />
                            </asp:BoundField>
                            <asp:BoundField DataField="ThanhToan" HeaderText="Thu Tiền">
                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundField>
                        </Columns>
                        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#0000A9" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#000065" />
                    </asp:GridView>
                </td>
                <td class="style7" style="border-bottom: 1px #99cc99 solid">
                    &nbsp;</td>
                <td class="style3">
                    </td>
            </tr>
            </table>

</asp:Content>
