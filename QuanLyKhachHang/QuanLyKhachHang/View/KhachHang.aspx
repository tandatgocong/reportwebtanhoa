<%@ Page Title="" Language="C#" MasterPageFile="~/View/HomePage.Master" AutoEventWireup="true" CodeBehind="KhachHang.aspx.cs" Inherits="QuanLyKhachHang.View.KhachHang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script language="javascript" type="text/javascript">
    window.document.getElementById("HOME").className = "top_link";
    window.document.getElementById("GANMOI").className = "top_link";
    window.document.getElementById("KHACHHANG").className = "current_link";
    window.document.getElementById("APLUC").className = "top_link"; 
    </script>
    
    <style type="text/css">
        
      input[type=text], textarea
        {
             background-color: White;
        }
        
        input[type=text]:focus, textarea:focus
        {
            background-color: Yellow;
        }

        .normalrow
        {
            background-color: White;
        }
        .onmouseoverrow
        {
            background-color: Yellow;
        }
        
        .cach
        {
            border-left:1px #FF0000 solid;    
        }
        .style1
        {
            height: 25px;
        }
    </style>

<div class="title_page"><asp:Label ID="title" runat="server" Text="NHẬP THÔNG TIN KHÁCH HÀNG "></asp:Label>
</div>
<table style="width:95%; margin-left:20px; " border="0">
        <tr>
    <td class="style28" rowspan="2"  valign=top>
       <table cellpadding="0" cellspacing="0" style="font-family:Times New Roman; font-size:15px; margin-left:20px;" class="table_list" >
        <tbody>
           <tr class="head1">
               <td class="style11" style="border-right:0px #99cc99 solid; border-bottom: 1px solid;">
                                            &nbsp;DANH BỘ:</td>
               <td class="style5" 
                   style="border-right:2px #99cc99 solid; font-size:10px; font-weight:normal;   border-bottom: 1px solid;">
                                            <asp:TextBox ID="txtDanhBo" runat="server" autocomplete="off" 
                                                ontextchanged="txtDanhBo_TextChanged" AutoPostBack="True" />
               </td>               
                <td class="style10" style="border-right:0px #99cc99 solid; border-bottom: 1px solid;">
                                            &nbsp;&nbsp;&nbsp; ĐỊA CHỈ: </td>
                <td class="style5" 
                   style="border-right:2px #99cc99 solid; font-size:10px; font-weight:normal;   border-bottom: 1px solid;">
                                            <asp:TextBox ID="txtDiaChi"  runat="server" autocomplete="off" Width="242px" 
                                                ontextchanged="txtDiaChi_TextChanged" AutoPostBack="True" />
               </td>
               <td class="style10" style="border-right:0px #99cc99 solid; border-bottom: 1px solid;">
                                            &nbsp;&nbsp;&nbsp; ĐIỆN THOẠI: </td>
                <td class="style5" 
                   style="border-right:2px #99cc99 solid; font-size:10px; font-weight:normal;   border-bottom: 1px solid;">
                                            <asp:TextBox ID="txtDienthoai"  runat="server" autocomplete="off" Width="138px" 
                                                ontextchanged="txtDienthoai_TextChanged" AutoPostBack="True" />
               </td>               
             </tr>
          </tbody>
    </table>
                
    </td>
    </tr>
</table>
<asp:Panel ID="pSearch" runat="server">
<table cellpadding="0" cellspacing="0"     
    style="margin-left:20px;font-family:Times New Roman; font-size:15px; width: 1062px; " >
                            <tr class="head1">
                                <td class="style1" 
                                    style="border-right:1px #FF0000 solid; background-color:#CCFFFF; font-size:large; border-bottom: 2px #FF0000 solid">
                                <b><table width="100% "  style="font-size:large;  border-right:1px #FF0000 solid;font-size:large; font-family:Times New Roman; border-bottom: 2px #FF0000 solid ">
                                <tr align="center"><td style="width:100px;">  Danh Bộ  </td><td style="width:200px;">     Họ Tên</td> <td style="width:400px;">      Địa Chỉ</td> <td style="width:200px;">   Điện Thoại</td></tr>
                                </table></b>
                                </td>
                            </tr>
                            <tr class="head1">
                                <td class="style21" 
                                    style="border-right:1px #FF0000 solid;font-size:large; font-family:Times New Roman; border-bottom: 2px #FF0000 solid ">

<asp:Panel ID="Panel1" runat="server" ScrollBars="Both" Height="400px"  >  
 <asp:Panel ID="Panel2" runat="server" ScrollBars="None" Width="1062px" > 
                                    <asp:GridView ID="GridView1" runat="server" Width="100%" 
                                        AutoGenerateColumns="False" style="margin-top: 3px" 
                                        onrowcommand="GridView1_RowCommand" onrowcreated="GridView1_RowCreated" 
                                        ShowHeader="False">
                                        <Columns>
                                            <asp:TemplateField HeaderText="Danh Bộ" ShowHeader="False">
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("DANHBO") %>'></asp:TextBox>
                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="LinkButton1" runat="server" 
                                                        CommandArgument='<%# Bind("DANHBO") %>' CommandName="View" 
                                                        Text='<%# Bind("DANHBO") %>'></asp:LinkButton>
                                                </ItemTemplate>
                                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
                                            </asp:TemplateField>
                                            <asp:BoundField DataField="HOTEN" HeaderText="Họ Tên">
                                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="200px" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="DIACHI" HeaderText="Địa Chỉ">
                                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="400px" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="DIENTHOAI" HeaderText="Điện Thoại">
                                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="200px" />
                                            </asp:BoundField>
                                        </Columns>
                                    </asp:GridView>
                                    </asp:Panel>
                                    </asp:Panel>


                                </td>
                            </tr>
                            </table>
</asp:Panel>
<asp:Panel ID="pResult" runat="server">

 
 <table border="1">
 <tr>
 <td>
    <div class="title_page"><asp:Label ID="Label2" runat="server" Text="..: THÔNG TIN KHÁCH HÀNG :.."></asp:Label>
    </div>
   
    <table cellpadding="0" cellspacing="0" class="table_list_1" style="font-family:Times New Roman; font-size:15px; width: 100%;">                            
     <tr class="head1">
        <td>Danh Bộ : </td>
         <td  >
                 <asp:Label ID="lbDanhBo" runat="server" Text="Label"></asp:Label>
         </td>
         <td class="cach">Hợp Đồng : </td>
         <td  >
                 <asp:Label ID="lbHopDong" runat="server" Text="Label"></asp:Label>
         </td>
         <td class="cach">Hiệu Lực : </td>
         <td  >
                 <asp:Label ID="lbHieuLuc" runat="server" Text="Label"></asp:Label>
         </td>
      </tr>

      <tr class="head1">
        <td>Lộ Trình : </td>
         <td  >
                 <asp:Label ID="lbLotrinh" runat="server" Text="Label"></asp:Label>
         </td>
         <td class="cach">Đợt : </td>
         <td  >
                 <asp:Label ID="lbDot" runat="server" Text="Label"></asp:Label>
         </td>
         <td class="cach">Quận Phường : </td>
         <td  >
                 <asp:Label ID="lbQuanPhuong" runat="server" Text="Label"></asp:Label>
         </td>
      </tr>

        <tr class="head1">
            <td class="style1">
                Họ Tên :</td>
            <td colspan="5" class="style1"><asp:Label ID="lbHoTen" runat="server" Text="Label"></asp:Label>
                &nbsp;</td>
        </tr>
        <tr class="head1">
            <td>
                Địa Chỉ :</td>
            <td colspan="5"><asp:Label ID="lbDiaChi" runat="server" Text="Label"></asp:Label>
                &nbsp;</td>
        </tr>
        <tr class="head1">
        <td>Giá Biểu: </td>
         <td  >
                 <asp:Label ID="lbGiaBieu" runat="server" Text="Label"></asp:Label>
         </td>
         <td class="cach">Định Mức : </td>
         <td  >
                 <asp:Label ID="lbDinhMuc" runat="server" Text="Label"></asp:Label>
         </td>
         <td class="cach" colspan="2">&nbsp;</td>
      </tr>
      <tr class="head1">
        <td>Ngày Gắn: </td>
         <td  >
                 <asp:Label ID="lbNgayGan" runat="server" Text="Label"></asp:Label>
         </td>
         <td class="cach">Kiểm Định : </td>
         <td  >
                 <asp:Label ID="lbKiemDinh" runat="server" Text="Label"></asp:Label>
         </td>
         <td class="cach" colspan="2">&nbsp;</td>
      </tr>
        <tr class="head1">
            <td colspan="6">
     <table border=0 cellpadding=0 cellspacing=0>                            
             <tr   >
             <td style="border-bottom:0">Hiệu :</td><td style="border-bottom:0"><asp:Label ID="lbHieu" runat="server" Text="Label"></asp:Label></td>
             <td class="cach" style="border-bottom:0";>Cở :</td><td style="border-bottom:0"><asp:Label ID="lbCo" runat="server" Text="Label"></asp:Label></td>
             <td class="cach" style="border-bottom:0">Cấp :</td><td style="border-bottom:0"><asp:Label ID="lbCap" runat="server" Text="Label"></asp:Label></td>
             <td class="cach" style="border-bottom:0">Số Thân :</td><td style="border-bottom:0"><asp:Label ID="lbSoThan" runat="server" Text="Label"></asp:Label></td>
             <td class="cach" style="border-bottom:0">Vị Trí :</td><td style="border-bottom:0"><asp:Label ID="lbViTri" runat="server" Text="Label"></asp:Label></td>
             </tr>
     </table>     
            </td>
        </tr>
        <tr class="head1">
            <td colspan="6">
                 <div class="title_page_tt"><i><asp:Label ID="Label1" runat="server" Text="..: Lịch sử điều chỉnh :.."></asp:Label></i>
        </div>
               </td>
        </tr>

</table>

 </td>
 </tr>
 </table>


</asp:Panel>
</asp:Content>
