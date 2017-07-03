<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addDB.aspx.cs" Inherits="QuanLyKhachHang.addDB" %>

 <!DOCTYPE html>
<html lang="en-us">
<head>
<style>
.city {
   float: left;
   margin: 10px;
   padding: 10px;
   max-width: 300px;
   height: 300px;
   border: 1px solid black;
}   
</style>
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
</head>
<body>

<h1>Demo Vị Trí ĐHN</h1>

<div class="city">
  <button onclick="getLocation()">Tim</button>
  <p><form id="Form1"  runat=server >  <p id="demo">
    <table style="width:100%;">
        <tr>
            <td class="style1">
                Danh Bộ :</td>
            <td>
                <input id="db" name="db" type="text" /></td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                Latitude</td>
            <td>
                <input id="Lat" name="Lat" type="text" /></td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                Longitude</td>
            <td>
                <input id="Long" name="Long"  type="text" /></td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td>
                <asp:Button ID="Button2" runat="server" onclick="Button1_Click1" 
                    Text="Thêm" />
               </td>  
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
               </td>  
            <td>
                &nbsp;</td>
        </tr>
    </table>
    </p>
 
    </form></p>
 
</div>


</body>
</html>