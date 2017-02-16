
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dongnuoc.aspx.cs" Inherits="BaoCao_Web.dongnuoc" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
 <head>
    <meta name="viewport" content="initial-scale=1.0, user-scalable=no" />
    <meta http-equiv="content-type" content="text/html; charset=UTF-8"/>
    <title>Google Maps JavaScript API Example: Map Simple</title>
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
            var html = "<table>" +
                 "<tr><td>Name:</td> <td><input type='text' id='name'/> </td> </tr>" +
                 "<tr><td>Address:</td> <td><input type='text' id='address'/></td> </tr>" +
                 "<tr><td>Type:</td> <td><select id='type'>" +
                 "<option value='bar' SELECTED>bar</option>" +
                 "<option value='restaurant'>restaurant</option>" +
                 "</select> </td></tr>" +
                 "<tr><td></td><td><input type='button' value='Save & Close' onclick='saveData()'/></td></tr>";
            infowindow = new google.maps.InfoWindow({
                content: html
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
        }

        function saveData() {
            var name = escape(document.getElementById("name").value);
            var address = escape(document.getElementById("address").value);
            var type = document.getElementById("type").value;
            var latlng = marker.getPosition();

            var url = "phpsqlinfo_addrow.php?name=" + name + "&address=" + address +
                "&type=" + type + "&lat=" + latlng.lat() + "&lng=" + latlng.lng();
            downloadUrl(url, function (data, responseCode) {
                if (responseCode == 200 && data.length >= 1) {
                    infowindow.close();
                    document.getElementById("message").innerHTML = "Location added.";
                }
            });
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
  </head>

  <body style="margin:0px; padding:0px;" onload="initialize()">
      <form id="form1" runat="server">
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
    
      </form>
    
  </body>

</html>