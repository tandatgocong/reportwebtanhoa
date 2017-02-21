<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="callcenter.aspx.cs" Inherits="QuanLyKhachHang.callcenter" %>
<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="System.Data.SqlClient" %>
<%@ Import Namespace="QuanLyKhachHang.Class" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <link href="../StyleSheet/Menu.css" rel="stylesheet" type="text/css" />
    <link href="../StyleSheet/StyleSheet.css" rel="stylesheet" type="text/css" />
    <script src="../JavaScript/transmenu.js" type="text/javascript"></script>
    <title>...: Call Center :...</title>
</head>
<script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyBBWgYu4Xxr6m1nac1RJfl9eCrr-rG1chY"
            type="text/javascript"></script>

            <script type="text/javascript">
                var map;
                var marker;
                var infowindow;
                var infoWindow2;
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
                    map = new google.maps.Map(document.getElementById("map"), options);

               
                 var marker = new google.maps.Marker({
				      position: latlng,
                      icon: 'Image/icon2.png',
				      map: map,
				      title: ''
				    });
                 
                var infowindow2 = new google.maps.InfoWindow();

                     <% 
                       DataTable table = new DataTable();
                       if(Session["dsDongnuoc"]!=null)
                       {
                        table = (DataTable)Session["dsDongnuoc"];
                        for(int i=0;i<table.Rows.Count;i++)
                        {
                        %>
                           var x = parseFloat(<%=table.Rows[i]["lat"]%>);
                           var y = parseFloat(<%=table.Rows[i]["lng"]%>);
                          // var latlng2 = new google.maps.LatLng(x, y);

                             var latlng2 = new google.maps.LatLng(x, y);
                             var name<%=i%> =<%=table.Rows[i]["ID"]%>;
                                                            
                          
                             var cityCircle = new google.maps.Circle({
                                strokeColor: '#FF0000',
                                strokeOpacity: 0.8,
                                strokeWeight: 2,
                                fillColor: '#FF0000',
                                fillOpacity: 0.35,
                                map: map,
                                center: latlng2,
                                radius: 200
                              });

                              var marker<%=i%> = new google.maps.Marker({
				              position: latlng2,
				              map: map,
				              title: name<%=i%>
				              });


                            google.maps.event.addListener(marker<%=i%>, 'click', function() {
                              // Creating the content to be inserted in the infowindow
                              var iwContent="<div class='title_page'>Thông Tin Đóng Nước </div> <br/> " ;
                              iwContent+="<table  style='height:100px; colspan='2' align='center'><tr><td colspan='2' align='center'> </td></tr>";
                          iwContent+="<tr style=' height: 30px; '><td style='border-bottom:1px; border-bottom-style:dotted; hight:100px; width:400px;'>&nbsp;Địa chỉ :<b>  <%=table.Rows[i]["DiaChi"]%> </b></> &nbsp; </b> &nbsp;</td></tr>";
                          iwContent+="<tr  style=' height: 30px; '><td style='border-bottom:1px; border-bottom-style:dotted; width:400px;'>&nbsp;Đóng nước Từ Ngày :<b>  <%=table.Rows[i]["TuNgay"]%> </b></> &nbsp;   Đến Ngày : <b><%=table.Rows[i]["DenNgay"]%></b> &nbsp;</td></tr>";
                          iwContent+="<tr  style=' height: 30px; '><td style='border-bottom:1px; border-bottom-style:dotted; width:400px;'>&nbsp;Từ Giờ : <b><%=table.Rows[i]["TuGio"]%></b> &nbsp;  Đến Giờ : <b><%=table.Rows[i]["DenGio"]%></b>    &nbsp;</td></tr>";
                          iwContent+="<tr  style=' height: 30px; '><td style='border-bottom:1px; border-bottom-style:dotted; width:400px;'>&nbsp; Nội Dung : <%=table.Rows[i]["NoiDung"]%> &nbsp;</td></tr>";
                          iwContent+="</table>";
      
                              // including content to the Info Window.
                              infoWindow2.setContent(iwContent);

                              // opening the Info Window in the current map and at the current marker location.
                              infoWindow2.open(map, marker<%=i%>);
                           });


                        <%
                        }
                       }
                    %>

                   
                }

               

                function saveData() {                   
                    var latlng = marker.getPosition();                    
                    var newUrl="addDongNuocc.aspx?lat="+latlng.lat() + "&lng=" + latlng.lng()
                   // alert(latlng);
                  document.location.href = newUrl;

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
                /*------------------------*/
            </script>
    
<style type="text/css">
         .style3
    {
        height: 32px;
    }
</style>


 <body style="margin:0px; padding:0px;" onload="initialize()">
  <form id="form1" runat="server">
  <table border=1 width=100%>
  <tr>
    <td class="style3"><b>
        <asp:Label ID="Label1" runat="server" Text="Tìm Địa Chỉ "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"  ontextchanged="TextBox1_TextChanged"></asp:TextBox>
        <asp:Button ID="btTim" runat="server" CssClass="button" Text="Tìm Kiếm" 
            onclick="btTim_Click" Height="30px" />
        </b>
      </td>
      
<div id="out"></div></td>      
  </tr>
  <tr>
    <td  >
    <div id="map" style="width: 100%; height: 800px"></div>
    <div id="message"></div>    
    </td>
  </tr>
  </table>
  </form>
 </body>

</html>
