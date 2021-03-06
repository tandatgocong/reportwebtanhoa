﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mMangLuoi.aspx.cs" Inherits="QuanLyKhachHang.mMangLuoi" %>

<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="System.Data.SqlClient" %>
<%@ Import Namespace="QuanLyKhachHang.Class" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html>
    
   <head>
      <LINK REL="SHORTCUT ICON"  HREF="Image/th.png">
      <title>.:.QLML.:.</title>
      <link rel="stylesheet" type="text/css" href="StyleSheet/style.css"/>
      <link rel="stylesheet" type="text/css" href="css/font-awesome.css"/>
      <link rel="stylesheet" type="text/css" href="css/animate.css"/>
      <!-- <link rel="shortcut icon" href="img/fav.ico" type="image/x-icon"/> --->
      <link href="https://fonts.googleapis.com/css?family=Montserrat:700" rel="stylesheet"/>
      <meta charset="utf-8">
      <meta http-equiv="X-UA-Compatible" content="IE=edge">
      <meta name="viewport" content="width=device-width, initial-scale=1">
      <meta name="description" content="" />
      <meta name="keywords" content=" "/>
      <meta name="author" content="Shrinath Nayak">
      <meta name="robots" content="index, follow" />

       <style type="text/css">
          .title_mobile
          {
        border-bottom: 2px solid #663300;
        color: #006600;
        font-family: Tahoma,Arial,Helvetica,sans-serif;
        font-size: 13px;
        font-weight: bold;
        margin: 0 10px;
        padding: 5px 0;
        text-transform: uppercase;
    }
            
           .style3
           {
               height: 32px;
           }
           .style4
           {
               height: 52px;
           }
            
           </style>
   </head>
   <body style="background-image="bg.jpg" >
     <form id="Form1"  runat="server" > 
      <!--Card-->
      <div class="card animated fadeIn">
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
        padding: 0 11px 0 13px;
        text-overflow: ellipsis;
        width: 250px;
        height:25px;
        margin-top:20px;
        margin-left: 0px;
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
                zoom: 18,
                mapTypeId: 'roadmap'
            });


            var layer5 = new google.maps.FusionTablesLayer({
                    query: {
                        select: 'col2',
                        from: '1vBx-orvk3EmpzawLGKNGgyOKQUTMiq7qEeflsz88'
                    },
                    options: {
                        styleId: 2,
                        templateId: 2
                    }
                });
                layer5.setMap(map); 


             var layer = new google.maps.FusionTablesLayer({
              query: {
                select: 'col1',
                from: '1hISjNL0pcj13jK3hiCJ-RSBsQC1mB2wFgGT6HoWT'
			    },
			      options: {
				    styleId: 2,
				    templateId: 2
				},
                styles: [{
                  markerOptions: {
                    iconName: 'large_blue'
                  }
                }]
               });
            layer.setMap(map);
            

           var  infoWindow2 = new google.maps.InfoWindow();
          
                     <% 
                       DataTable table = new DataTable();
                       if(Session["dsVan"]!=null)
                       {
                        table = (DataTable)Session["dsVan"];
                        for(int i=0;i<table.Rows.Count;i++)
                        {
                        %>
                           var x = parseFloat(<%=table.Rows[i]["Lat"]%>);
                           var y = parseFloat(<%=table.Rows[i]["Lng"]%>);
                          // var latlng2 = new google.maps.LatLng(x, y);

                             var latlng2 = new google.maps.LatLng(x, y);
                             var name<%=i%> =<%=table.Rows[i]["ID"]%>;
                                                            
                              var marker<%=i%> = new google.maps.Marker({
				              position: latlng2,
                              icon: '/Image/reddot.png',
				              map: map,
				              title: name<%=i%>
				              });


                            google.maps.event.addListener(marker<%=i%>, 'click', function() {
                              // Creating the content to be inserted in the infowindow
                              var iwContent="<div class='title_page'>Thông Tin  Báo Bể</div> <br/> " ;
      
                              // including content to the Info Window.
                              infoWindow2.setContent(iwContent);

                              // opening the Info Window in the current map and at the current marker location.
                              infoWindow2.open(map, marker<%=i%>);
                           });


                        <%
                        }
                       }
                    %>







                var infoWindow = new google.maps.InfoWindow({map: map});

            // Try HTML5 geolocation.
                if (navigator.geolocation) {
                  navigator.geolocation.getCurrentPosition(function(position) {
                    var pos = {
                      lat: position.coords.latitude,
                      lng: position.coords.longitude
                    };

                    infoWindow.setPosition(pos);
                    infoWindow.setContent('Location');
                    map.setCenter(pos);
                  }, function() {
                    handleLocationError(true, infoWindow, map.getCenter());
                  });
                } else {
                  // Browser doesn't support Geolocation
                  handleLocationError(false, infoWindow, map.getCenter());
                }

                

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
         function monuoc(id) {                
                 var newUrl="mMangLuoi.aspx?id="+id ;
                   // alert(latlng);
                  document.location.href = newUrl;
               }

    </script>
    <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyBnK4XMpV0do1pWTYFGUydQvA_EyMkJ9xU&libraries=places&callback=initAutocomplete"         async defer></script>
  </div>
    
   </form>
      
   </body>
</html>
