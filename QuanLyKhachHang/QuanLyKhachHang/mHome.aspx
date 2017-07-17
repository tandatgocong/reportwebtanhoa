<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mHome.aspx.cs" Inherits="QuanLyKhachHang.mHome" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html>
   <head>
      <title>..: Thông Tin :..</title>
      <link rel="stylesheet" type="text/css" href="StyleSheet/style.css"/>
      <link rel="stylesheet" type="text/css" href="css/font-awesome.css"/>
      <link rel="stylesheet" type="text/css" href="css/animate.css"/>
      <!--<link rel="shortcut icon" href="img/fav.ico" type="image/x-icon"/> --->
      <link href="https://fonts.googleapis.com/css?family=Montserrat:700" rel="stylesheet"/>
      <meta charset="utf-8">
      <meta http-equiv="X-UA-Compatible" content="IE=edge">
      <meta name="viewport" content="width=device-width, initial-scale=1">
      <meta name="description" content="" />
      <meta name="keywords" content=" "/>
      <meta name="author" content="Shrinath Nayak">
      <meta name="robots" content="index, follow" />
      <script>


          function getLocation() {
              if (navigator.geolocation) {
                  navigator.geolocation.getCurrentPosition(showPosition);
              } else {
                  alert('Khong Tim Dia Chi');
              }
          }

          function showPosition(position) {
              document.getElementById("Lat").value = position.coords.latitude;
              document.getElementById("Long").value = position.coords.longitude;

          }


          function save() {
              var _db = document.getElementById("db").value;
              var _Lat = document.getElementById("Lat").value;
              var _Long = document.getElementById("Long").value;
              var newUrl = "addDB.aspx?lat=" + _Lat + "&lng=" + _Long + "&db=" + _db;
              document.location.href = newUrl;


          }

</script>
       <style type="text/css">
           .style1
           {
           }
           .style2
           {
               width: 133px;
           }
       </style>
   </head>
   <body style="background-image=bg.jpg" >
     <form id="Form1"  runat="server" > 
      <!--Card-->
      <div class="card animated fadeIn">
         <div class="location"> THÔNG TIN DANH BỘ </div> 
      <div class="text" style="margin-left:10px; margin-top:5px;"> 
      <table >
      <tr><td>Danh Bộ :</td><td>
          <asp:TextBox ID="txtDB" runat="server" ontextchanged="txtDB_TextChanged"></asp:TextBox>
          </td></tr>
      </table>
      <hr />

       <table >
      <tr><td class="style1" colspan="2">Khách Hàng:&nbsp;<asp:Label ID="lbTenKh" runat="server" Font-Bold="True"/>
          <asp:Label ID="lbDanhBo" runat="server" Font-Bold="True" Visible="False"/></td></tr>
      <tr><td class="style1" colspan="2">Địa Chỉ:&nbsp;<asp:Label ID="diachi" runat="server" Font-Bold="True"/></td></tr>
      <tr><td class="style2">Lộ Trình:&nbsp;<asp:Label ID="lotrinh" runat="server" Font-Bold="True"/></td> <td> Hiệu Lực :  <asp:Label ID="hieuluc" runat="server" Font-Bold="True"/></td></tr>
      <tr><td class="style2">Giá Biểu:&nbsp;<asp:Label ID="giabieu" runat="server" Font-Bold="True" /> </td> <td> Định Mức :  <asp:Label ID="dinhmuc" runat="server" Font-Bold="True"/></td></tr>
      <tr><td class="style2">Ngày Gắn:&nbsp;<asp:Label ID="ngaygan" runat="server" Font-Bold="True" /> </td> <td> Ngày KĐ:  <asp:Label ID="ngaykiemdinh" runat="server" Font-Bold="True"/></td></tr>
      <tr><td class="style1" colspan="2">Hiệu ĐHN:&nbsp;<asp:Label ID="hieudhn" runat="server" Font-Bold="True"/></td></tr>
      <tr><td class="style1" colspan="2">NV Đọc Số :&nbsp;<asp:Label ID="nvds" runat="server" Font-Bold="True"/></td></tr>
      <tr><td class="style1" colspan="2">NV Thu Tiền :&nbsp;<asp:Label ID="nvtt" runat="server" Font-Bold="True"/></td></tr>
      <tr><td class="style1" colspan="2">
      <asp:Panel ID="Panel1" runat="server" ScrollBars="Both" Width="100%" Height="150px">
          <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                        BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" 
                        CellPadding="3" Font-Names="Times New Roman" Font-Size="12px" 
                        GridLines="Vertical" style="margin-right: 5px" Width="100%">
                        <AlternatingRowStyle BackColor="#DCDCDC" />
                        <Columns>
                            <asp:BoundField DataField="NAM" HeaderText="Kỳ">
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"  />
                            </asp:BoundField>
                            <asp:BoundField DataField="NGAYDOC" HeaderText="Ngày Đọc">
                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
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
       </asp:Panel>
      </td></tr>

      <tr><td class="style1" colspan="2">
      <asp:Panel ID="Panel2" runat="server" ScrollBars="Both" Width="100%" Height="150px">
         <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                        CellPadding="4" Font-Names="Times New Roman" Font-Size="12px" 
                        GridLines="None" style="margin-right: 5px" Width="100%" 
              ForeColor="#333333">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="CREATEDATE" HeaderText="Ngày">
                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="90px"  />
                            </asp:BoundField>
                            <asp:BoundField DataField="NOIDUNG" HeaderText="Nội dung">
                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            <ItemStyle HorizontalAlign="Left" />
                            </asp:BoundField>
                        </Columns>
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                        <SortedDescendingHeaderStyle BackColor="#4870BE" />
                    </asp:GridView>
      </asp:Panel>
      </td></tr>
     <tr><td class="style2"><asp:FileUpload ID="FileUpload2" runat="server" /> <td> <asp:Button ID="btUploag" runat="server" Text="Upload" onclick="btUploag_Click"  /> <td> <asp:Label ID="upload" runat="server" ForeColor="Red" /></td></tr>
          <tr>
            <td colspan="2"> 
                <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px">
                </asp:DetailsView>
            </td>
          </tr>
      </table>
      </div>
      </div>
   </form>
      
   </body>
</html>
