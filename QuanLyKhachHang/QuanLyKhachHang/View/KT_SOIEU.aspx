<%@ Page Title="" Language="C#" MasterPageFile="~/View/HomePage.Master" AutoEventWireup="true" CodeBehind="KT_SOIEU.aspx.cs" Inherits="QuanLyKhachHang.View.KT_SOIEU" %>
<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="System.Data.SqlClient" %>
<%@ Import Namespace="QuanLyKhachHang.Class" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script language="javascript" type="text/javascript">
    window.document.getElementById("HOME").className = "top_link";
    window.document.getElementById("GANMOI").className = "top_link";
    window.document.getElementById("KHACHHANG").className = "top_link";
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
        width: 95px;
        height: 49px;
    }
    .style5
    {
        height: 30px;
    }
    .style6
    {
        height: 27px;
    }
    .style7
    {
        width: 140px;
    }
    </style>
<body>
 <asp:Panel ID="Panel1" runat="server"    >  
 
 <table cellpadding="0" cellspacing="0" style="font-family:Times New Roman;  margin-left:20px;margin-top:10px;" class="table_list" >
        <tbody>
           <tr class="head2">
               <td class="style11" style="border-right:0px #99cc99 solid; border-bottom: 1px solid;">
                                            &nbsp;&nbsp;&nbsp;&nbsp;DMA : </td>
               <td class="style11" style="border-right:2px #99cc99 solid; border-bottom: 1px solid;">
                                            &nbsp;
                                            <asp:DropDownList ID="MaDMA" runat="server" AutoPostBack="True" 
                                                onselectedindexchanged="MaDMA_SelectedIndexChanged">
                                            </asp:DropDownList>
               </td>
                <td class="style10" style="border-right:0px #99cc99 solid; border-bottom: 1px solid;">
                                            ĐỢT&nbsp;&nbsp; </td>
                <td>
                    <asp:DropDownList ID="cbDot" runat="server" AutoPostBack="True" 
                        onselectedindexchanged="cbDot_SelectedIndexChanged">
                    </asp:DropDownList>
               </td>
               <td>
                   MÁY</td>
                <td class="style10" style=" font-size:10px; font-weight:normal;   border-bottom: 1px solid;">
                                       
                    <asp:DropDownList ID="cbMay" runat="server" AutoPostBack="True" 
                        onselectedindexchanged="btXemBangKe_Click">
                    </asp:DropDownList>
               </td>
               <td class="style10" 
                   style="border-right:2px #99cc99 solid; font-size:10px; font-weight:normal;   border-bottom: 1px solid;">
                   &nbsp;</td>
               <td class="style10" 
                   style="border-right:2px #99cc99 solid; font-size:10px; font-weight:normal;   border-bottom: 1px solid;">
                   <asp:Button ID="btXemBangKe" runat="server" CssClass="button1" Height="27px" 
                       onclick="btXemBangKe_Click" Text="XEM THÔNG TIN" />
               </td>
               <td class="style7" 
                   style="border-right:2px #99cc99 solid; font-size:10px; font-weight:normal;   border-bottom: 1px solid;">
                   <asp:CheckBox ID="chekHien" runat="server" AutoPostBack="True" Font-Bold="True" 
                       Font-Size="Small" oncheckedchanged="chekHien_CheckedChanged" 
                       Text="Chuyển Sửa Bể" />
               </td>
             </tr>
             
          </tbody>
    </table>

<asp:Panel ID="Panel2" runat="server"  Width="1000px" Height="200px" ScrollBars="Both">    
  
    <table cellpadding="0" cellspacing="0" class="table_list_1"  style="font-family:Times New Roman; margin-left:50px; font-size:15px; width: 500px;">
                     <tr class="head1">
                          <td class="style5" 
                              style="border-right:1px #FF0000 solid; background-color:#CCFFFF; font-size:large; border-bottom: 2px #FF0000 solid">
                              <center>
                                        DANH SÁCH THÔNG TIN KHÁCH HÀNG</center>
                           </td>
                      </tr>
                     <tr >
                          <td  style="border-right:1px #FF0000 solid; font-size:large; border-bottom: 2px #FF0000 solid" 
                              class="style6">
                              &nbsp;</td>
                      </tr>
                     <tr >
                          <td class="style1" align=center >
                              <asp:GridView ID="gChuyen" runat="server" 
                                  BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" 
                                  CellPadding="4" Width="902px">
                                  <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                                  <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                                  <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                                  <RowStyle BackColor="White" ForeColor="#330099" />
                                  <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                                  <SortedAscendingCellStyle BackColor="#FEFCEB" />
                                  <SortedAscendingHeaderStyle BackColor="#AF0101" />
                                  <SortedDescendingCellStyle BackColor="#F6F0C0" />
                                  <SortedDescendingHeaderStyle BackColor="#7E0000" />
                              </asp:GridView>
                          </td>
                      </tr>
                 </table>


</asp:Panel>
</asp:Panel>

 
    <input id="pac-input" class="controls" type="text" placeholder="Search Box">
     <div id="map" style="width: 100%; height: 500px"></div>

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
                            var x= parseFloat(<%=table.Rows[i]["lat"]%>);
                            lagx= parseFloat(<%=table.Rows[i]["lat"]%>);
                            var y = parseFloat(<%=table.Rows[i]["lng"]%>);
                            lagy= parseFloat(<%=table.Rows[i]["lng"]%>);
                          // var latlng2 = new google.maps.LatLng(x, y);

                             var latlng2 = new google.maps.LatLng(x, y);
                              var marker<%=i%> = new google.maps.Marker({
				              position: latlng2,
                               icon: '/Image/dot.png',
				               map: map
				              });

                        <%
                        }
                        
                       // triangleCoords  = triangleCoords.Remove(triangleCoords.Length - 1, 1) + " ]; ";

                       }
                    %>
            ////////////////////
   
                     /* Define the LatLng coordinates for the polygon's path.*/
                   // var  triangleCoord= [ {lat: 10.7938672756, lng: 106.668200943},{lat: 10.7938491622, lng: 106.66816852},{lat: 10.793892361, lng: 106.668249593},{lat: 10.7939285139, lng: 106.668248473},{lat: 10.793946613, lng: 106.668291308},{lat: 10.793986128, lng: 106.668302205},{lat: 10.7940986676, lng: 106.668374192},{lat: 10.7941247297, lng: 106.668331361},{lat: 10.794133426, lng: 106.668320589},{lat: 10.794163699, lng: 106.668275313},{lat: 10.7941750712, lng: 106.668261173},{lat: 10.7942113585, lng: 106.668213244},{lat: 10.7942220565, lng: 106.6682018},{lat: 10.7942583382, lng: 106.668157923},{lat: 10.7942590665, lng: 106.668136999},{lat: 10.794271069, lng: 106.668135011},{lat: 10.7942953121, lng: 106.668094898},{lat: 10.7942945847, lng: 106.668019843},{lat: 10.7940018976, lng: 106.667972873},{lat: 10.7939178609, lng: 106.668097013},{lat: 10.794373017, lng: 106.667957044},{lat: 10.794277579, lng: 106.667882404},{lat: 10.7942443047, lng: 106.66785818},{lat: 10.7942340121, lng: 106.6678485},{lat: 10.7942091853, lng: 106.667830581},{lat: 10.7941863068, lng: 106.667810484},{lat: 10.7941617434, lng: 106.667794329},{lat: 10.7939394077, lng: 106.668051322},{lat: 10.7942057231, lng: 106.667994723},{lat: 10.7940636554, lng: 106.667898323},{lat: 10.7941242331, lng: 106.667872664},{lat: 10.7940365406, lng: 106.667922752},{lat: 10.7940099054, lng: 106.667963184},{lat: 10.7940059138, lng: 106.667967091},{lat: 10.7941346785, lng: 106.667795517},{lat: 10.7941201445, lng: 106.668391192},{lat: 10.7939329529, lng: 106.668062267},{lat: 10.7938381588, lng: 106.668189551},{lat: 10.7940104481, lng: 106.667847007},{lat: 10.7937960748, lng: 106.668145781},{lat: 10.793805792, lng: 106.668131559},{lat: 10.7938375884, lng: 106.668085342},{lat: 10.7938490613, lng: 106.668072015},{lat: 10.7938702583, lng: 106.668041796},{lat: 10.7938940915, lng: 106.668011586},{lat: 10.7939252321, lng: 106.667967047},{lat: 10.7939349404, lng: 106.667955496},{lat: 10.7939693756, lng: 106.667909287},{lat: 10.7939808485, lng: 106.66789596},{lat: 10.7940029088, lng: 106.667858157},{lat: 10.7940216263, lng: 106.667833633},{lat: 10.7940534157, lng: 106.667790086},{lat: 10.7940976849, lng: 106.667742956},{lat: 10.7939858879, lng: 106.667656632},{lat: 10.7938022994, lng: 106.667574034},{lat: 10.793791008, lng: 106.667587137},{lat: 10.7937651439, lng: 106.667619954},{lat: 10.7937449248, lng: 106.66764663},{lat: 10.7937092918, lng: 106.667691247},{lat: 10.7936988518, lng: 106.667702629},{lat: 10.7936663251, lng: 106.667745763},{lat: 10.7936567478, lng: 106.667759757},{lat: 10.7936193694, lng: 106.667805253},{lat: 10.7936106671, lng: 106.667818365},{lat: 10.7935883807, lng: 106.667852563},{lat: 10.7935671904, lng: 106.667880521},{lat: 10.7935350172, lng: 106.667925147},{lat: 10.7935254459, lng: 106.667937418},{lat: 10.7934620435, lng: 106.667898976},{lat: 10.7933762904, lng: 106.667881918},{lat: 10.7934480117, lng: 106.667920085},{lat: 10.7934711771, lng: 106.667887636},{lat: 10.7934960278, lng: 106.667857244},{lat: 10.7935051638, lng: 106.667844833},{lat: 10.7935282713, lng: 106.667814528},{lat: 10.7935435197, lng: 106.667789509},{lat: 10.7935537308, lng: 106.667777614},{lat: 10.793570919, lng: 106.667755443},{lat: 10.7935941614, lng: 106.66772295},{lat: 10.7936027547, lng: 106.66771212},{lat: 10.7936297021, lng: 106.667683458},{lat: 10.7936630915, lng: 106.667643307},{lat: 10.7936767521, lng: 106.667617771},{lat: 10.7936923084, lng: 106.667609945},{lat: 10.7937040296, lng: 106.66758147},{lat: 10.7937266475, lng: 106.667551955},{lat: 10.7937373745, lng: 106.667539222},{lat: 10.793754013, lng: 106.667517388},{lat: 10.7936394239, lng: 106.66738753},{lat: 10.7936100903, lng: 106.667364825},{lat: 10.7935885669, lng: 106.667339067},{lat: 10.7935152407, lng: 106.667368223},{lat: 10.7934975098, lng: 106.667392022},{lat: 10.7934819874, lng: 106.667414337},{lat: 10.7934731066, lng: 106.667426982},{lat: 10.7934502146, lng: 106.66745446},{lat: 10.793437523, lng: 106.667472391},{lat: 10.7934168286, lng: 106.667501398},{lat: 10.7934057394, lng: 106.667515527},{lat: 10.7933821166, lng: 106.667546763},{lat: 10.7933776337, lng: 106.667563148},{lat: 10.7933521161, lng: 106.667593772},{lat: 10.7933218121, lng: 106.66763915},{lat: 10.7933077856, lng: 106.667658488},{lat: 10.7932871089, lng: 106.667681533},{lat: 10.7932730562, lng: 106.667700871},{lat: 10.7932616091, lng: 106.667719839},{lat: 10.7932264897, lng: 106.667767816},{lat: 10.7931194357, lng: 106.667790709},{lat: 10.7931866247, lng: 106.667692456},{lat: 10.7932036334, lng: 106.667670145},{lat: 10.7932191306, lng: 106.66764783},{lat: 10.7932280082, lng: 106.667635931},{lat: 10.793252375, lng: 106.667604698},{lat: 10.7932701246, lng: 106.667583134},{lat: 10.793279721, lng: 106.667571237},{lat: 10.793300422, lng: 106.667539993},{lat: 10.7933177086, lng: 106.667519034},{lat: 10.7933295113, lng: 106.667506398},{lat: 10.7933516754, lng: 106.667474413},{lat: 10.7933605584, lng: 106.667461023},{lat: 10.7933849199, lng: 106.66743128},{lat: 10.7933954973, lng: 106.667421733},{lat: 10.7934184971, lng: 106.667389339},{lat: 10.7934299896, lng: 106.667375461},{lat: 10.7934491484, lng: 106.667348474},{lat: 10.7934686831, lng: 106.667322442},{lat: 10.7934966868, lng: 106.66728175},{lat: 10.7933306508, lng: 106.667156188},{lat: 10.7932374716, lng: 106.667162155},{lat: 10.7932284582, lng: 106.667173492},{lat: 10.7932079906, lng: 106.667209252},{lat: 10.7931978604, lng: 106.667218881},{lat: 10.7931768705, lng: 106.667253039},{lat: 10.7931698891, lng: 106.667263255},{lat: 10.7931476744, lng: 106.667296455},{lat: 10.793136894, lng: 106.667309218},{lat: 10.7931127835, lng: 106.667342413},{lat: 10.7931051702, lng: 106.667352625},{lat: 10.7930777097, lng: 106.667384183},{lat: 10.7930688307, lng: 106.667395032},{lat: 10.7930542235, lng: 106.667419939},{lat: 10.7930333115, lng: 106.667439708},{lat: 10.7930153831, lng: 106.667474629},{lat: 10.7930066495, lng: 106.667484615},{lat: 10.7929812319, lng: 106.667517783},{lat: 10.7929731219, lng: 106.667529942} ];
                                     // Tạo polyline
                        var  triangleCoord=<%= Session["poy"] %>
                       
                        var bermudaTriangle = new google.maps.Polyline({
                            path: triangleCoord,
                            geodesic: true,
                            strokeColor: '#FF0000',
                            strokeOpacity: 0.5,
                            strokeWeight: 2
                        });
                 
                        // Dùng hàm setMap để gắn vào bản đồ
                           bermudaTriangle.setMap(map);
                       

               
                 

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
