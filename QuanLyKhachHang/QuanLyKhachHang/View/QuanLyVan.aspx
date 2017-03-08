<%@ Page Title="" Language="C#" MasterPageFile="~/View/HomePage.Master" AutoEventWireup="true" CodeBehind="QuanLyVan.aspx.cs" Inherits="QuanLyKhachHang.View.QuanLyVan" %>
<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="System.Data.SqlClient" %>
<%@ Import Namespace="QuanLyKhachHang.Class" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 <script language="javascript" type="text/javascript">
     window.document.getElementById("HOME").className = "top_link";
     window.document.getElementById("GANMOI").className = "current_link";
     window.document.getElementById("KHACHHANG").className = "top_link";
     window.document.getElementById("APLUC").className = "top_link";
     window.document.getElementById("BAOBE").className = "top_link";
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
                        zoom: 15,
                        center: latlng,
                        mapTypeId: google.maps.MapTypeId.ROADMAP
                    }
                    map = new google.maps.Map(document.getElementById("map"), options);

                       infoWindow2 = new google.maps.InfoWindow();

                       // Event that closes the Info Window with a click on the map
                       google.maps.event.addListener(map, 'click', function() {
                          infoWindow2.close();
                       });

                    /*  var marker0 = new google.maps.Marker({
				      position: latlng,
                      icon: '/Image/icon2.png',
				      map: map,
				      title: ''
				    });*/


                    //var html = "<table><tr><td> <input type='button' value='Thêm Mới Đóng Nước' onclick='saveData()'/> </td></tr></table>";

                     var html = " <meta http-equiv='Content-Type' content='text/html; charset=utf-8' /><div class='title_page'>Nhập Thông Tin  Van</div> <br/> <table class='table_list'  >" +
                         "<tr  class='head11' ><td style='width:120px;' >Đường Chính :  </td> <td><input style='width:250px;' type='text' id='duongchinh'/> </td> </tr>" +
                         "<tr  class='head11' ><td style='width:120px;' >Địa Chỉ Đặt Van :  </td> <td><input style='width:250px;' type='text' id='diachi'/> </td> </tr>" +                        
                         "<tr  class='head11' ><td style='width:120px;' > Phường:</td> <td><select id='phuong' style='width:250px;'>" +
                         "<option value='01' SELECTED> 01 </option>" +
                         "<option value='02' SELECTED> 02 </option>" +
                         "<option value='03' SELECTED> 03 </option>" +
                         "<option value='04' SELECTED> 04 </option>" +
                         "<option value='05' SELECTED> 05 </option>" +
                         "<option value='06' SELECTED> 06 </option>" +
                         "<option value='07' SELECTED> 07 </option>" +
                         "<option value='08' SELECTED> 08 </option>" +
                         "<option value='09' SELECTED> 09 </option>" +
                         "<option value='10' SELECTED> 10 </option>" +
                         "<option value='11' SELECTED> 11 </option>" +
                         "<option value='12' SELECTED> 12 </option>" +
                         "<option value='13' SELECTED> 13 </option>" +
                         "<option value='14' SELECTED> 14 </option>" +
                         "<option value='15' SELECTED> 15 </option>" +
                         "<option value='01' SELECTED> Tân Sơn Nhì </option>" +
                         "<option value='02' SELECTED> Tân Quý </option>" +
                         "<option value='03' SELECTED> Sơn Kỳ </option>" +
                         "<option value='04' SELECTED> Tân Thành </option>" +
                         "<option value='05' SELECTED> Phú Thọ Hòa </option>" +
                         "<option value='06' SELECTED> Phú Thạnh </option>" +
                         "<option value='07' SELECTED> Phú Trung </option>" +
                         "<option value='08' SELECTED> Hòa Thạnh </option>" +
                         "<option value='09' SELECTED> Tân Thới Hòa </option>" +
                         "<option value='10' SELECTED> Hiệp Tân </option>" +
                         "<option value='11' SELECTED> Tây Thạnh </option>" +
                          "</select> </td></tr>" +
                          "<tr  class='head11' ><td style='width:120px;' >Quận:</td> <td><select style='width:250px;' id='quan'>" +
                         "<option value='22' SELECTED>Phú Nhuận</option>" +
                         "<option value='23'>Tân Bình</option>" +
                         "<option value='33'>Tân Phú</option>" +
                         "</select> </td></tr>" +
                        
                         "<tr  class='head11' ><td style='width:120px;' >Tuyến Ống :  </td> <td><select id='tuyenong' style='width:250px;'>" +
                         "<option value='100' SELECTED> 100 </option>" +
                         "<option value='150' SELECTED> 150 </option>" +
                         "<option value='180' SELECTED> 180 </option>" +
                         "<option value='200' SELECTED> 200 </option>" +
                         "<option value='250' SELECTED> 250 </option>" +
                         "<option value='300' SELECTED> 300 </option>" +
                         "<option value='375' SELECTED> 375 </option>" +
                         "<option value='400' SELECTED> 400 </option>" +
                         "<option value='500' SELECTED> 500 </option>" +
                         "<option value='1500' SELECTED> 1500 </option>" +
                          "</select> </td></tr>" +  
                         "<tr  class='head11' ><td style='width:120px;' > Cở Van :  </td> <td><select id='covan' style='width:250px;'>" +
                         "<option value='100' SELECTED> 100 </option>" +
                         "<option value='150' SELECTED> 150 </option>" +                          
                         "<option value='200' SELECTED> 200 </option>" +
                         "<option value='250' SELECTED> 250 </option>" +
                         "<option value='300' SELECTED> 300 </option>" +
                         "<option value='375' SELECTED> 375 </option>" +
                         "<option value='400' SELECTED> 400 </option>" +
                         "<option value='500' SELECTED> 500 </option>" +
                         "<option value='1500' SELECTED> 1500 </option>" +
                          "</select> </td></tr>" + 

                          "<tr  class='head11' ><td style='width:120px;' >Mã Số Van :  </td> <td><input style='width:250px;' type='text' id='masovan'/> </td> </tr>" +   
                          "<tr  class='head11' ><td style='width:120px;text-align:left;' >Loại Van :  </td> <td style=' text-align:left;'> <input type='checkbox'   id='chantuyen'> Chặn Tuyến &nbsp;&nbsp; <br><input type='checkbox' id='xacan'> Xã Cặn &nbsp;&nbsp;  <br> " +  
                                "<input type='checkbox' id='TCH'> TCH &nbsp;&nbsp; <br><input type='checkbox' id='vanbien'> Van Biên&nbsp;&nbsp;  <br> </td></tr>" +

                        "<tr  class='head11' ><td style='width:120px;' >Thông Tin Mạng:</td> <td><input type='text' style='width:250px;' id='thongtin'/></td> </tr>" +
                        "<tr  class='head11' ><td style='width:120px;' >Ghi Chú:</td> <td><input type='text' style='width:250px;' id='ghichu'/></td> </tr>" +
                         "<tr style=' height: 30px; '><td style='hight:100px; width:80px;'></td><td><input type='button' class='button' value='Thêm Mới' onclick='saveData()'/></td></tr>";

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
                          /*    var iwContent="<div class='title_page'>Thông Tin  Báo Bể</div> <br/> " ;
                              iwContent+="<table    style='height:100px; colspan='2' align='center'><tr><td colspan='2' align='center'> </td></tr>";
                          iwContent+="<tr style=' height: 30px; '><td style='border-bottom:1px; border-bottom-style:dotted; hight:100px; width:400px;'>&nbsp;Địa chỉ :<b>  <%=table.Rows[i]["DiaChi"]%> </b></> &nbsp; </b> &nbsp;</td></tr>";
                          iwContent+="<tr  style=' height: 30px; '><td style='border-bottom:1px; border-bottom-style:dotted; width:400px;'>&nbsp;Báo Bể Ngày :<b>  <%=table.Rows[i]["NgayBao"]%> </b></> &nbsp;  </td></tr>";
                          
                          iwContent+="<tr  style=' height: 30px; '><td style='border-bottom:1px; border-bottom-style:dotted; width:400px;'>&nbsp; Ghi Chú : <%=table.Rows[i]["GhiChu"]%> &nbsp;</td></tr>";
                          iwContent+="<tr  style=' height: 35px; '><td style='border-bottom:1px; border-bottom-style:dotted; width:400px;'>&nbsp;<input type='button' class='button'  value='Xóa' onclick='monuoc(<%=table.Rows[i]["ID"]%>);'/> </td></tr>";
                          iwContent+="</table>"; */
      
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
                
                    var duongchinh = document.getElementById("duongchinh").value;
                    var diachi = document.getElementById("diachi").value;                
                    var phuong = document.getElementById("phuong").value;
                    var quan = document.getElementById("quan").value;
                    var tuyenong = document.getElementById("tuyenong").value;
                    var covan = document.getElementById("covan").value;
                    
                    var chantuyen = document.getElementById("chantuyen").checked;
                    var xacan = document.getElementById("xacan").checked;
                    var TCH = document.getElementById("TCH").checked;
                    var vanbien = document.getElementById("vanbien").checked;
                     /* var isChecked = input.checked;
                        isChecked = (isChecked)? "checked" : "not checked";
                        alert ("The checkBox is " + isChecked);*/

                       
                    var masovan = document.getElementById("masovan").value;
                    var thongtin = document.getElementById("thongtin").value;
                    var ghichu = document.getElementById("ghichu").value;                    
                                        
                    var latlng = marker.getPosition();                    
                    var newUrl="addVan.aspx?lat="+latlng.lat() + "&lng=" + latlng.lng()+ "&duongchinh=" + duongchinh + "&diachi=" + diachi+ "&phuong=" + phuong+ "&quan=" + quan+ "&tuyenong=" + tuyenong+ "&covan=" + covan +"&chantuyen="+ chantuyen + "&xacan="+ xacan + "&TCH="+ TCH +"&vanbien="+ vanbien +"&masovan="+masovan +"&thongtin="+ thongtin +"&ghichu="+ ghichu;

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
                /*----------------- <body onload="initialize()">-------*/
            </script>

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


</asp:Content>
 