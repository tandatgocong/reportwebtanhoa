<%@ Page Title="" Language="C#" MasterPageFile="~/View/HomePage.Master" AutoEventWireup="true" CodeBehind="KT_ToaDo.aspx.cs" Inherits="QuanLyKhachHang.View.KT_ToaDo" %>
<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="System.Data.SqlClient" %>
<%@ Import Namespace="QuanLyKhachHang.Class" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<body>
    <input id="pac-input" class="controls" type="text" placeholder="Search Box">
    <div id="map" style="width: 100%; height: 100vh"></div>
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
                zoom: 19,
                mapTypeId: 'roadmap'
            });
 
                   
                var  infoWindow2 = new google.maps.InfoWindow();  

                     <% 
                        int f=1;
                       DataTable table = new DataTable();                      
                       if(Session["dsBaoBe"]!=null)
                       {
                        table = (DataTable)Session["dsBaoBe"];
                        int tong=table.Rows.Count;
                        for(int i=0;i<tong;i++)
                        {
                         f++;
                        %>
                            var x= parseFloat(<%=table.Rows[i]["lat"]%>);
                            lagx= parseFloat(<%=table.Rows[i]["lat"]%>);
                            var y = parseFloat(<%=table.Rows[i]["lng"]%>);
                            lagy= parseFloat(<%=table.Rows[i]["lng"]%>);
                          // var latlng2 = new google.maps.LatLng(x, y);                           
                           var icon_='/Image/dot.png';
                             var latlng2 = new google.maps.LatLng(x, y);
                              var marker<%=f%> = new google.maps.Marker({
				              position: latlng2,
                               icon: icon_,
				               map: map
				              });

                                google.maps.event.addListener(marker<%=f%>, 'click', function() {
                              // Creating the content to be inserted in the infowindow
                              var iwContent="<table ><tr><td colspan='2' align='center'> </td></tr>";
                              iwContent+="<tr style=' height: 30px; '><td style='border-bottom:1px; border-bottom-style:dotted; hight:100px; width:400px;'>&nbsp;Danh Bộ :<b> <%=table.Rows[i]["DANHBO"]%> &nbsp; </td></tr>";                      
                              iwContent+="</table>";
      
                              // including content to the Info Window.
                              infoWindow2.setContent(iwContent);

                              // opening the Info Window in the current map and at the current marker location.
                              infoWindow2.open(map, marker<%=f%>);
                           });

                              

                        <%
                        }

                       }
                    %>
                ////////////////////

                
                     <% 
                         
                        table = new DataTable();                      
                       if(Session["dsMOi"]!=null)
                       {
                        table = (DataTable)Session["dsMOi"];
                        int tong=table.Rows.Count;
                        for(int i=0;i<tong;i++)
                        {
                         f++;
                        %>
                            var x= parseFloat(<%=table.Rows[i]["lat"]%>);
                            lagx= parseFloat(<%=table.Rows[i]["lat"]%>);
                            var y = parseFloat(<%=table.Rows[i]["lng"]%>);
                            lagy= parseFloat(<%=table.Rows[i]["lng"]%>);
                          // var latlng2 = new google.maps.LatLng(x, y);                           
                           var icon_='/Image/ydot.png';
                             var latlng2 = new google.maps.LatLng(x, y);
                              var marker<%=f%> = new google.maps.Marker({
				              position: latlng2,
                               icon: icon_,
				               map: map
				              });

                                google.maps.event.addListener(marker<%=f%>, 'click', function() {
                              // Creating the content to be inserted in the infowindow
                              var iwContent="<table ><tr><td colspan='2' align='center'> </td></tr>";
                              iwContent+="<tr style=' height: 30px; '><td style='border-bottom:1px; border-bottom-style:dotted; hight:100px; width:400px;'>&nbsp;Danh Bộ :<b> <%=table.Rows[i]["DANHBO"]%> &nbsp; </td></tr>";                      
                              iwContent+="</table>";
      
                              // including content to the Info Window.
                              infoWindow2.setContent(iwContent);

                              // opening the Info Window in the current map and at the current marker location.
                              infoWindow2.open(map, marker<%=f%>);
                           });

                              

                        <%
                        }

                       }
                    
    %>

            ///
            var infoWindow = new google.maps.InfoWindow({map: map});
                 var pos = {
                      lat: lagx,
                      lng: lagy
                    };
                    
                    map.setCenter(pos);


                   




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
                        url: '/Image/icon2.png',
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
                   var dma = document.getElementById("dma").value;  
                                                
                   var newUrl="addBaoBe.aspx?lat="+lagx+ "&lng=" + lagy+ "&dienthoai=" + dienthoai + "&ghichu=" + ghichu+ "&diachi=" + diachi+ "&type=" + type+ "&phuong=" + phuong+ "&quan=" + quan+ "&tenkh=" + tenkh+ "&sonha=" + sonha + "&dma=" + dma;
                   // alert(latlng);
                   document.location.href = newUrl;
                                    
                   // var newUrl="addBaoBee.aspx?lat="+lagx+ "&lng=" + lagy ;
                   // alert(latlng);
                   //document.location.href = newUrl;
                      
              }

    </script>
    
    <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyBnK4XMpV0do1pWTYFGUydQvA_EyMkJ9xU&libraries=places&callback=initAutocomplete"   async defer></script>
 
  </body>
</asp:Content>
