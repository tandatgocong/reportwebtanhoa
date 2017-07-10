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
      <table>
      <tr><td><b></d>Danh Bộ :</td><td>
          <asp:TextBox ID="txtDB" runat="server" ontextchanged="txtDB_TextChanged"></asp:TextBox>
          </td></tr>
      </table>
      <hr />

       <table>
      <tr><td class="style1" colspan="2">Khách Hàng:&nbsp;<asp:Label ID="lbTenKh" runat="server" Font-Bold="True"/></td></tr>
      <tr><td class="style1" colspan="2">Địa Chỉ:&nbsp;<asp:Label ID="diachi" runat="server" Font-Bold="True"/></td></tr>
      <tr><td class="style2">Lộ Trình:&nbsp;<asp:Label ID="lotrinh" runat="server" Font-Bold="True"/></td> <td> Hiệu Lực :  <asp:Label ID="hieuluc" runat="server" Font-Bold="True"/></td></tr>
      <tr><td class="style2">Giá Biểu:&nbsp;<asp:Label ID="giabieu" runat="server" Font-Bold="True" /> </td> <td> Định Mức :  <asp:Label ID="dinhmuc" runat="server" Font-Bold="True"/></td></tr>
      <tr><td class="style2">Ngày Gắn:&nbsp;<asp:Label ID="ngaygan" runat="server" Font-Bold="True" /> </td> <td> Ngày KĐ:  <asp:Label ID="ngaykiemdinh" runat="server" Font-Bold="True"/></td></tr>
      <tr><td class="style1" colspan="2">Hiệu ĐHN:&nbsp;<asp:Label ID="hieudhn" runat="server" Font-Bold="True"/></td></tr>
      <tr><td class="style1" colspan="2">NV Đọc Số :&nbsp;<asp:Label ID="nvds" runat="server" Font-Bold="True"/></td></tr>
       <tr><td class="style1" colspan="2">NV Thu Tiền :&nbsp;<asp:Label ID="nvtt" runat="server" Font-Bold="True"/></td></tr>
      </table>


      </div>
      </div>
   </form>
      
   </body>
</html>
