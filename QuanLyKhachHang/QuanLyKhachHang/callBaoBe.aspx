<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="callBaoBe.aspx.cs" Inherits="QuanLyKhachHang.callBaoBe" %>
<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="System.Data.SqlClient" %>
<%@ Import Namespace="QuanLyKhachHang.Class" %>
 

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet/Menu.css" rel="stylesheet" type="text/css" />
    <link href="StyleSheet/StyleSheet.css" rel="stylesheet" type="text/css" />
    <script src="StyleSheet/transmenu.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">

 <script language="javascript" type="text/javascript">
     window.document.getElementById("HOME").className = "top_link";
     window.document.getElementById("GANMOI").className = "top_link";
     window.document.getElementById("KHACHHANG").className = "top_link";
     window.document.getElementById("APLUC").className = "top_link";
     window.document.getElementById("BAOBE").className = "current_link";
    </script>

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
                        zoom: 17,
                        center: latlng,
                        mapTypeId: google.maps.MapTypeId.ROADMAP
                    }
                    map = new google.maps.Map(document.getElementById("map"), options);

                       infoWindow2 = new google.maps.InfoWindow();

                       // Event that closes the Info Window with a click on the map
                       google.maps.event.addListener(map, 'click', function() {
                          infoWindow2.close();
                       });

                      var marker0 = new google.maps.Marker({
				      position: latlng,
                      icon: '/Image/icon2.png',
				      map: map,
				      title: ''
				    });


                    //var html = "<table><tr><td> <input type='button' value='Thêm Mới Đóng Nước' onclick='saveData()'/> </td></tr></table>";

                     var html = "<table>" +
                         "<tr><td>Điện Thoại:</td> <td><input type='text' id='dienthoai'/> </td> </tr>" +
                         "<tr><td>Địa chỉ:</td> <td><input type='text' id='diachi'/></td> </tr>" +
                         "<tr><td>Loại:</td> <td><select id='type'>" +
                         "<option value='1' SELECTED>Bể Nổi</option>" +
                         "<option value='2'>Bể Ngầm</option>" +
                         "</select> </td></tr>" +
                         "<tr><td>Ghi Chú:</td> <td><input type='text' id='ghichu'/></td> </tr>" +
                         "<tr><td></td><td><input type='button' value='Thêm Mới' onclick='saveData()'/></td></tr>";

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
                 
                    
                var infowindow2 = new google.maps.InfoWindow();

            

                     <% 
                       DataTable table = new DataTable();
                       if(Session["dsBaoBe"]!=null)
                       {
                        table = (DataTable)Session["dsBaoBe"];
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
                                radius: 50
                              });

                              var marker<%=i%> = new google.maps.Marker({
				              position: latlng2,
				              map: map,
				              title: name<%=i%>
				              });


                            google.maps.event.addListener(marker<%=i%>, 'click', function() {
                              // Creating the content to be inserted in the infowindow
                              var iwContent="<div class='title_page'>Thông Tin  Báo Bể</div> <br/> " ;
                              iwContent+="<table  style='height:100px; colspan='2' align='center'><tr><td colspan='2' align='center'> </td></tr>";
                          iwContent+="<tr style=' height: 30px; '><td style='border-bottom:1px; border-bottom-style:dotted; hight:100px; width:400px;'>&nbsp;Địa chỉ :<b>  <%=table.Rows[i]["DiaChi"]%> </b></> &nbsp; </b> &nbsp;</td></tr>";
                          iwContent+="<tr  style=' height: 30px; '><td style='border-bottom:1px; border-bottom-style:dotted; width:400px;'>&nbsp;Báo Bể Ngày :<b>  <%=table.Rows[i]["NgayBao"]%> </b></> &nbsp;  </td></tr>";
                          
                          iwContent+="<tr  style=' height: 30px; '><td style='border-bottom:1px; border-bottom-style:dotted; width:400px;'>&nbsp; Ghi Chú : <%=table.Rows[i]["GhiChu"]%> &nbsp;</td></tr>";
                          iwContent+="<tr  style=' height: 35px; '><td style='border-bottom:1px; border-bottom-style:dotted; width:400px;'>&nbsp;<input type='button' class='button'  value='Xóa' onclick='monuoc(<%=table.Rows[i]["ID"]%>);'/> </td></tr>";
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

               function monuoc(id) {                
                var newUrl="addCallBaoBe.aspx?id="+id ;
                   // alert(latlng);
                  document.location.href = newUrl;
               }

                function saveData() {   
                    var dienthoai = escape(document.getElementById("dienthoai").value);
                    var ghichu = escape(document.getElementById("ghichu").value);
                    var diachi = escape(document.getElementById("diachi").value);
                    var type = document.getElementById("type").value;
                                        
                    var latlng = marker.getPosition();                    
                    var newUrl="addCallBaoBe.aspx?lat="+latlng.lat() + "&lng=" + latlng.lng()+ "&dienthoai=" + dienthoai + "&ghichu=" + ghichu+ "&diachi=" + diachi+ "&type=" + type;
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
         .style1
         {
             width: 148px;
         }
         .style2
         {
             width: 89px;
         }
</style>


 <body onload="initialize()">

  <table border=1 width=100%>
  <tr>
    <td>
        <asp:Label ID="Label1" runat="server" Text="Tìm Địa Chỉ "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
        <asp:Button ID="btTim" runat="server" Text="Tìm Kiếm" onclick="btTim_Click" />
        <asp:Label ID="Label2" runat="server"></asp:Label>
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
  </body>

 

    </form>
</body>
</html>
