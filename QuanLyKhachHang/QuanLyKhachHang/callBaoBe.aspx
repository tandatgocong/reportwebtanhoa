<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="callBaoBe.aspx.cs" Inherits="QuanLyKhachHang.callBaoBe" %>
<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="System.Data.SqlClient" %>
<%@ Import Namespace="QuanLyKhachHang.Class" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
 <link href="../StyleSheet/Menu.css" rel="stylesheet" type="text/css" />
    <link href="../StyleSheet/StyleSheet.css" rel="stylesheet" type="text/css" />
    <script src="../JavaScript/transmenu.js" type="text/javascript"></script>
    <title>...: Call Center :...</title>
</head>
<style>
      /* Always set the map height explicitly to define the size of the div
       * element that contains the map. */
      #map {
        height: 100%;
      }
      /* Optional: Makes the sample page fill the window. */
      
      #description {
        font-family: Roboto;
        font-size: 15px;
        font-weight: 300;
      }

      #infowindow-content .title {
        font-weight: bold;
      }

      #infowindow-content {
        display: none;
      }

      #map #infowindow-content {
        display: inline;
      }

      .pac-card {
        margin: 10px 10px 0 0;
        border-radius: 2px 0 0 2px;
        box-sizing: border-box;
        -moz-box-sizing: border-box;
        outline: none;
        box-shadow: 0 2px 6px rgba(0, 0, 0, 0.3);
        background-color: #fff;
        font-family: Roboto;
      }

      #pac-container {
        padding-bottom: 12px;
        margin-right: 12px;
      }

      .pac-controls {
        display: inline-block;
        padding: 5px 11px;
      }

      .pac-controls label {
        font-family: Roboto;
        font-size: 13px;
        font-weight: 300;
      }

      #pac-input {
        background-color: #fff;
        font-family: Roboto;
        font-size: 15px;
        font-weight: 300;
        margin-left: 12px;
        padding: 0 11px 0 13px;
        text-overflow: ellipsis;
        width: 400px;
        height:25px;
        margin-top:11px;
      }

      #pac-input:focus {
        border-color: #4d90fe;
      }

      #title {
        color: #fff;
        background-color: #4d90fe;
        font-size: 25px;
        font-weight: 500;
        padding: 6px 12px;
      }
      #target {
        width: 345px;
      }
    </style>
  
  <body>
    <input id="pac-input" class="controls" type="text" placeholder="Search Box">
     <div id="map" style="width: 100%; height: 800px"></div>

    <script>
        var lagx;
        var lagy;
        // This example adds a search box to a map, using the Google Place Autocomplete
        // feature. People can enter geographical searches. The search box will return a
        // pick list containing a mix of places and predicted search terms.

        // This example requires the Places library. Include the libraries=places
        // parameter when you first load the API. For example:
        // <script src="https://maps.googleapis.com/maps/api/js?key=YOUR_API_KEY&libraries=places">

        function initAutocomplete() {
            var latlng = new google.maps.LatLng(10.801433295748337, 106.65252816547981);
            var marker;
            var infowindow;
            var map = new google.maps.Map(document.getElementById('map'), {
                center: latlng,
                zoom: 13,
                mapTypeId: 'roadmap'
            });
 
                infowindow = new google.maps.InfoWindow();
                   var html = " <meta http-equiv='Content-Type' content='text/html; charset=utf-8' /><div class='title_page'>Nhập Thông Tin  Báo Bể</div> <br/> <table  >" +
                         "<tr style=' height: 30px; '><td style='border-bottom:1px; border-bottom-style:dotted; hight:100px; width:80px;'>NV Báo Bể:</td> <td style='hight:100px; width:200px;'><input type='text' value='<%=Session["login"]%>' id='dienthoai'/> </td> </tr>" +
                         "<tr style=' height: 30px; '><td style='border-bottom:1px; border-bottom-style:dotted; hight:100px; width:80px;'>Khách Hàng :</td> <td><input type='text' id='tenkh'/></td> </tr>" +
                         "<tr style=' height: 30px; '><td style='border-bottom:1px; border-bottom-style:dotted; hight:100px; width:80px;'>Số Nhà :</td> <td><input type='text' id='sonha'/></td> </tr>" +
                         "<tr style=' height: 30px; '><td style='border-bottom:1px; border-bottom-style:dotted; hight:100px; width:80px;'>Đường:</td> <td><input type='text' id='diachi'/></td> </tr>" +                         
                         "<tr style=' height: 30px; '><td style='border-bottom:1px; border-bottom-style:dotted; hight:100px; width:80px;' >Phường:</td> <td><select id='phuong'>" +
                         "<option value='01' SELECTED> 01 </option>" +
                         "<option value='02' > 02 </option>" +
                         "<option value='03' > 03 </option>" +
                         "<option value='04' > 04 </option>" +
                         "<option value='05' > 05 </option>" +
                         "<option value='06' > 06 </option>" +
                         "<option value='07' > 07 </option>" +
                         "<option value='08' > 08 </option>" +
                         "<option value='09' > 09 </option>" +
                         "<option value='10' > 10 </option>" +
                         "<option value='11' > 11 </option>" +
                         "<option value='12' > 12 </option>" +
                         "<option value='13' > 13 </option>" +
                         "<option value='14' > 14 </option>" +
                         "<option value='15' > 15 </option>" +
                         "<option value='01' > Tân Sơn Nhì </option>" +
                         "<option value='02' > Tân Quý </option>" +
                         "<option value='03' > Sơn Kỳ </option>" +
                         "<option value='04' > Tân Thành </option>" +
                         "<option value='05' > Phú Thọ Hòa </option>" +
                         "<option value='06' > Phú Thạnh </option>" +
                         "<option value='07' > Phú Trung </option>" +
                         "<option value='08' > Hòa Thạnh </option>" +
                         "<option value='09' > Tân Thới Hòa </option>" +
                         "<option value='10' > Hiệp Tân </option>" +
                         "<option value='11' > Tây Thạnh </option>" +
                          "</select> </td></tr>" +

                         "<tr style=' height: 30px; '><td style='border-bottom:1px; border-bottom-style:dotted; hight:100px; width:80px;'>Quận:</td> <td><select id='quan'>" +
                         "<option value='22' SELECTED>Phú Nhuận</option>" +
                         "<option value='23'>Tân Bình</option>" +
                         "<option value='33'>Tân Phú</option>" +
                         "</select> </td></tr>" +

                         "<tr style=' height: 30px; '><td style='border-bottom:1px; border-bottom-style:dotted; hight:100px; width:80px;'>Loại:</td> <td><select id='type'>" +
                         "<option value='Bể Nổi' SELECTED>Bể Nổi</option>" +
                         "<option value='Bể Ngầm'>Bể Ngầm</option>" +
                         "</select> </td></tr>" +
                         "<tr style=' height: 30px; '><td style='border-bottom:1px; border-bottom-style:dotted; hight:100px; width:80px;'>Ghi Chú:</td> <td><input type='text' id='ghichu'/></td> </tr>" +
                         "<tr style=' height: 30px; '><td style='hight:100px; width:80px;'></td><td><input type='button' class='button' value='Thêm Mới' onclick='save()'/></td></tr></table>";

                    infowindow = new google.maps.InfoWindow({
                        content: html 
                    });

                    google.maps.event.addListener(map, "click", function (event) {
                        marker = new google.maps.Marker({
                            position: event.latLng,
                            map: map
                        });
                        google.maps.event.addListener(marker, "click", function () {
                            infowindow.open(map, marker),
                            lagx=marker.getPosition().lat(),
                            lagy=marker.getPosition().lng()
                        });
                    });
                 
                   
                var  infoWindow2 = new google.maps.InfoWindow();

                       // Event that closes the Info Window with a click on the map
                       google.maps.event.addListener(map, 'click', function() {
                          infoWindow2.close();
                       });

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
                          iwContent+="<tr style=' height: 30px; '><td style='border-bottom:1px; border-bottom-style:dotted; hight:100px; width:400px;'>&nbsp;Địa chỉ :<b> <%=table.Rows[i]["SoNha"]%> &nbsp;  <%=table.Rows[i]["TenDuong"]%> </b></> &nbsp; </b> &nbsp;</td></tr>";
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







            ////////////////////

            // Create the search box and link it to the UI element.
            var input = document.getElementById('pac-input');
            var searchBox = new google.maps.places.SearchBox(input);
            map.controls[google.maps.ControlPosition.TOP_LEFT].push(input);

            // Bias the SearchBox results towards current map's viewport.
            map.addListener('bounds_changed', function () {
                searchBox.setBounds(map.getBounds());
            });


            var markers = [];
            // Listen for the event fired when the user selects a prediction and retrieve
            // more details for that place.
            searchBox.addListener('places_changed', function () {
                var places = searchBox.getPlaces();

                if (places.length == 0) {
                    return;
                }

                /* Clear out the old markers.
                markers.forEach(function (marker) {
                    marker.setMap(null);
                }); */
                markers = [];

                // For each place, get the icon, name and location.
                var bounds = new google.maps.LatLngBounds();
                places.forEach(function (place) {
                    if (!place.geometry) {
                        console.log("Returned place contains no geometry");
                        return;
                    }
                    var icon = {
                        url: 'Image/icon2.png',
                        size: new google.maps.Size(71, 71),
                        origin: new google.maps.Point(0, 0),
                        anchor: new google.maps.Point(17, 34),
                        scaledSize: new google.maps.Size(67, 67)
                    };

                    // Create a marker for each place.
                    markers.push(new google.maps.Marker({
                        map: map,
                        icon: icon,
                        title: place.name,
                        position: place.geometry.location
                    }));

                    
                    if (place.geometry.viewport) {
                        // Only geocodes have viewport.
                        bounds.union(place.geometry.viewport);
                    } else {
                        bounds.extend(place.geometry.location);
                    }
                });
                map.fitBounds(bounds);
            });
            
 }
            function monuoc(id) {                
                var newUrl="callBaoBeAdd.aspx?id="+id ;
                   // alert(latlng);
                  document.location.href = newUrl;
               }

                function save() {  
                   var dienthoai = document.getElementById("dienthoai").value;
                   var ghichu = document.getElementById("ghichu").value;
                   var diachi = document.getElementById("diachi").value;
                   var type = document.getElementById("type").value;
                   var phuong = document.getElementById("phuong").value;
                   var quan = document.getElementById("quan").value;         
                   var tenkh = document.getElementById("tenkh").value;  
                   var sonha = document.getElementById("sonha").value;  
                   
                                                
                   var newUrl="callBaoBeAdd.aspx?lat="+lagx+ "&lng=" + lagy+ "&dienthoai=" + dienthoai + "&ghichu=" + ghichu+ "&diachi=" + diachi+ "&type=" + type+ "&phuong=" + phuong+ "&quan=" + quan+ "&tenkh=" + tenkh+ "&sonha=" + sonha;
                   // alert(latlng);
                   document.location.href = newUrl;
                                    
                   // var newUrl="addBaoBee.aspx?lat="+lagx+ "&lng=" + lagy ;
                   // alert(latlng);
                   //document.location.href = newUrl;
                      
              }

    </script>
    
    <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyBnK4XMpV0do1pWTYFGUydQvA_EyMkJ9xU&libraries=places&callback=initAutocomplete"         async defer></script>
  </body>
  </html>
