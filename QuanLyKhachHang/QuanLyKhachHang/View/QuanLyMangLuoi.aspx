<%@ Page Title="" Language="C#" MasterPageFile="~/View/HomePage.Master" AutoEventWireup="true" CodeBehind="QuanLyMangLuoi.aspx.cs" Inherits="QuanLyKhachHang.View.QuanLyMangLuoi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 

<script language="javascript" type="text/javascript">
    window.document.getElementById("HOME").className = "top_link";
    window.document.getElementById("MANGLUOI").className = "current_link";
    window.document.getElementById("KHACHHANG").className = "top_link";
    window.document.getElementById("APLUC").className = "top_link";
    window.document.getElementById("BAOBE").className = "top_link";

    
    </script> 
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
        .style1
        {
            width: 114px;
        }
        .style2
        {
            width: 105px;
        }
        .style3
        {
            width: 117px;
        }
    </style>

  <body>
  <table class='table_list' style="width:100%;" border=1>   
  <tr><td class="style1">
          <asp:CheckBox ID="ckThuaDat" runat="server" Text="Thửa Đất" 
          oncheckedchanged="ckThuaDat_CheckedChanged" AutoPostBack="True" />
      </td><td class="style3">
      <asp:CheckBox ID="ckTuyenDuong" runat="server" Text="Tuyến Đường" 
              AutoPostBack="True" oncheckedchanged="ckTuyenDuong_CheckedChanged" />
      </td><td class="style3">
          <asp:CheckBox ID="ckTuyenOng" runat="server" Text="Tuyến Ống" 
              AutoPostBack="True" oncheckedchanged="ckTuyenOng_CheckedChanged" />
      </td><td class="style2">
          <asp:CheckBox ID="ckDongHo" runat="server" Text="Đồng Hồ" 
              oncheckedchanged="ckDongHo_CheckedChanged" AutoPostBack="True" />
      </td><td>
          <asp:DropDownList ID="MaDMA" runat="server" 
              onselectedindexchanged="MaDMA_SelectedIndexChanged" AutoPostBack="True">
          </asp:DropDownList>
      </td><td>fdsads</td><td>fdsads</td></tr>
  </table>
    <input id="pac-input" class="controls" type="text" placeholder="Search Box">   
     <div id="map" style="width: 100%; height: 100vh">
    </div>
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

            
            var latlng = new google.maps.LatLng(<%=Session["lat"]%>, <%=Session["lng"]%>); 
            var marker;
            var infowindow;
            var map = new google.maps.Map(document.getElementById('map'), {
                center: latlng,
                zoom: 16,
                mapTypeId: 'roadmap'
            });

            /*
            google.maps.visualRefresh = true;
            var isMobile = (navigator.userAgent.toLowerCase().indexOf('android') > -1) ||
              (navigator.userAgent.match(/(iPod|iPhone|iPad|BlackBerry|Windows Phone|iemobile)/));
            if (isMobile) {
              var viewport = document.querySelector("meta[name=viewport]");
              viewport.setAttribute('content', 'initial-scale=1.0, user-scalable=no');
            }
            var mapDiv = document.getElementById('map');
            mapDiv.style.width = isMobile ? '100%' : '100%';
            mapDiv.style.height = isMobile ? '100%' : '100vh';
            */

            /* Try HTML5 geolocation.
            var infoWindow = new google.maps.InfoWindow({ map: map });
            if (navigator.geolocation) {
                navigator.geolocation.getCurrentPosition(function (position) {
                    var pos = {
                        lat: position.coords.latitude,
                        lng: position.coords.longitude
                    };

                    infoWindow.setPosition(pos);
                    infoWindow.setContent('Location');
                    map.setCenter(pos);
                }, function () {
                    handleLocationError(true, infoWindow, map.getCenter());
                });
            } else {
                // Browser doesn't support Geolocation
                handleLocationError(false, infoWindow, map.getCenter());
            }

            */

            /// DMA
             <% if(Session["dma"]=="0") { %>
                /*var layer1 = new google.maps.FusionTablesLayer({
                    query: {
                        select: 'col2',
                        from: '1gosPIEZPWjr_sBAEGwWzTB7ZU5BQuR7q91oLbRy5'
                    },
                    options: {
                        styleId: 3,
                        templateId: 4
                    },
                    styles: [{
                        polygonOptions: { 
                            fillOpacity: 9
                        }
                    }]
                });
                layer1.setMap(map);  */
             <% }else{ %>

                 var layer1 = new google.maps.FusionTablesLayer({
                        query: {
                            select: 'col2',
                            from: '1gosPIEZPWjr_sBAEGwWzTB7ZU5BQuR7q91oLbRy5',
                            where: 'name=\'<%=Session["dma"] %>\''
                        },
                        options: {
                            styleId: 3,
                            templateId: 4
                        }
                    });
                    layer1.setMap(map);
                     
                     // dhn
                      var layer4 = new google.maps.FusionTablesLayer({
                    query: {
                        select: 'col3',
                        from: '1OhVqP2doaHq7b1uG0T_nMtkHu3Yu2hzuzekFnyd4',
                        where: 'dma = <%=Session["iddma"] %>'
                    },
                    options: {
                        styleId: 2,
                        templateId: 2
                    }
                });
                layer4.setMap(map);


              <% } %>

            /// THUA DAT
            <% if(Session["thuadat"]=="1") { %>
                var layer2 = new google.maps.FusionTablesLayer({
                    query: {
                        select: 'col7',
                        from: '1ShMQTJf2bG3A09NsMyO3i7RWECWr0RFD7L_YsZya'
                    },
                    options: {
                        styleId: 2,
                        templateId: 2
                    }
                });
                layer2.setMap(map);
                <% } %>
          
            ///////// TUYEN DUONG ////
             <% if(Session["tuyenduong"]=="1") { %>
                var layer3 = new google.maps.FusionTablesLayer({
                    query: {
                        select: 'col2',
                        from: '1mR0wrH3Apk_UbdCB6umqwJmTR7gwSZHUvn3T83s7'
                    },
                    styles: [{
                        polygonOptions: {
                            fillColor: '#FFFF00',
                            fillOpacity: 0.0
                        }
                    }]
                });
                layer3.setMap(map);
             <% } %>

            ///// DONG HO KHACH HANG //////
            <% if(Session["dongho"]=="1") { %>
                var layer4 = new google.maps.FusionTablesLayer({
                    query: {
                        select: 'col3',
                        from: '1OhVqP2doaHq7b1uG0T_nMtkHu3Yu2hzuzekFnyd4'
                    },
                    options: {
                        styleId: 2,
                        templateId: 2
                    }
                });
                layer4.setMap(map);

           <% } %>
            
            <% if(Session["tuyenong"]=="1") { %>
                            
                ////// ONG CAI/ ///////
                   var layer5 = new google.maps.FusionTablesLayer({
                    query: {
                        select: 'col7',
                        from: '1IaexZr3GNIRkUkyEyvAnPhYMHOFy1CGNPZ_tqNzv'
                    },
                    options: {
                        styleId: 2,
                        templateId: 2
                    }
                });
                layer5.setMap(map); 
              
                //
                /*
                /// ong nghanh ///
             var layer6 = new google.maps.FusionTablesLayer({
                    query: {
                        select: 'col2',
                        from: '1r04MVRg1lS2lu6TZXEoaqA5M0WmrvFxdUngaFXYN'
                    },
                    options: {
                        styleId: 2,
                        templateId: 2
                    }
                });
                layer6.setMap(map);
                
                *
                 /// TAN PHU 03
                 var layer6 = new google.maps.FusionTablesLayer({
                    query: {
                        select: 'col2',
                        from: '1SDAI0y50XMdQX7oVyT-rN84uC7SMWz1PSOvUIe2J'
                    }
                });
                layer6.setMap(map);

                /// TAN BINH 01
                 var layer6 = new google.maps.FusionTablesLayer({
                    query: {
                        select: 'col2',
                        from: '1SWckvNe0HGLV2I2_GKCS3mZb8Grp6coUB9EnQhsd'
                    }
                });
                layer6.setMap(map);


                 /// TAN BINH 02
                 var layer7 = new google.maps.FusionTablesLayer({
                    query: {
                        select: 'col2',
                        from: '1AZPx3Qmus-KGHMoDGgjHkG_xPuHd8E1Sk-NiOXGI'
                    }
                });
                layer7.setMap(map); 

                /// TAN PHU 01
                 var layer8 = new google.maps.FusionTablesLayer({
                    query: {
                        select: 'col2',
                        from: '1ypQgJNX5V4-pDQEEOVTlMK9XRPbyOnEwwJsLWscm'
                    },
                    options: {
                        styleId: 2,
                        templateId: 2
                    }
                });
                layer8.setMap(map);

                 /// TAN PHU 02
                 var layer9 = new google.maps.FusionTablesLayer({
                    query: {
                        select: 'col2',
                        from: '1dLDjbhR-Pik_V4V0teOk1OBJw52xhxPowZDGMRpF'
                    },
                    options: {
                        styleId: 2,
                        templateId: 2
                    }
                });
                layer9.setMap(map);*/


              <% } %>
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
                        scaledSize: new google.maps.Size(67, 65)
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
         
    </script>
    <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyBnK4XMpV0do1pWTYFGUydQvA_EyMkJ9xU&libraries=places&callback=initAutocomplete"         async defer></script>
  </body>

              
</asp:Content>