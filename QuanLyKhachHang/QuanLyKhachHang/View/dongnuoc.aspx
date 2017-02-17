<%@ Page Title="" Language="C#" MasterPageFile="~/View/HomePage.Master" AutoEventWireup="true" CodeBehind="dongnuoc.aspx.cs" Inherits="QuanLyKhachHang.View.dongnuoc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script language="javascript" type="text/javascript">
        window.document.getElementById("HOME").className = "top_link";
        window.document.getElementById("GANMOI").className = "top_link";
        window.document.getElementById("KHACHHANG").className = "current_link";
        window.document.getElementById("APLUC").className = "top_link"; 
    </script>

<script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyBBWgYu4Xxr6m1nac1RJfl9eCrr-rG1chY"
            type="text/javascript"></script>
    <script type="text/javascript">
        var marker;
        var infowindow;

        function initialize() {
            var latlng = new google.maps.LatLng(10.801433295748337, 106.65252816547981);
            <%
            
            if( Session["lat"] != "" &&   Session["lng"] != "")
            {
                
                %>
                    latlng = new google.maps.LatLng(<%=Session["lat"] %>, <%=Session["lng"] %>);
                <%
            }
            %>
            var options = {
                zoom: 15,
                center: latlng,
                mapTypeId: google.maps.MapTypeId.ROADMAP
            }
          
            var map = new google.maps.Map(document.getElementById("map"), options);
           

		  /* Always set the map height explicitly to define the size of the div
       * element that contains the map. */
      
      /* Optional: Makes the sample page fill the window. */
		  var marker = new google.maps.Marker({
				  position: latlng,
				  map: map,
				  title: 'Hello World!'
				});


            google.maps.event.addListener(map, "click", function (event) {
                marker = new google.maps.Marker({
                    position: event.latLng,
                    map: map
                });
                google.maps.event.addListener(marker, "click", function () {
                    infowindow.open(map, marker);
                });
            });

            var latlng1 = marker.getPosition();
             var html = "<table><tr><td> <a href='addDongNuocc.aspx?lat="+latlng1.lat() +"&lng=" + latlng1.lng()+ "'>Thêm Đóng Nước</a> <input type='button' value='Save & Close' onclick='saveData()'/> </td></tr></table>";
            infowindow = new google.maps.InfoWindow({
                content: html
            });
        }

        function saveData() {         
            var latlng = marker.getPosition();

            var url = "addDN.aspx?lat=" + latlng.lat() + "&lng=" + latlng.lng();
            window.open(url,"_self")
            
        }

        function downloadUrl(url, callback) {
            var request = window.ActiveXObject ?
          new ActiveXObject('Microsoft.XMLHTTP') :
          new XMLHttpRequest;

            request.onreadystatechange = function () {
                if (request.readyState == 4) {
                    request.onreadystatechange = doNothing;
                    callback(request.responseText, request.status);
                }
            };

            request.open('GET', url, true);
            request.send(null);
        }

        function doNothing() { }
    </script>
     <style type="text/css">
         .style1
         {
             width: 148px;
         }
         .style2
         {
             width: 89px;
         }
     </style>

  <body style="margin:0px; padding:0px;" onload="initialize()">

  <table border=1 width=100%>
  <tr>
    <td class="style2">
        <asp:Label ID="Label1" runat="server" Text="Tìm Địa Chỉ "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" ontextchanged="TextBox1_TextChanged"></asp:TextBox>
        <asp:Button ID="btTim" runat="server" Text="Tìm Kiếm" onclick="btTim_Click" />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
      </td>
  </tr>
  <tr>
    <td >
    <div id="map" style="width: 1524px; height: 800px"></div>
    <div id="message"></div>
    
    </td>
  </tr>
  </table>
  <</body>


</asp:Content>
