<%@ Page Title="" Language="C#" MasterPageFile="~/View/HomePage.Master" AutoEventWireup="true" CodeBehind="bbNhapThongTinBe.aspx.cs" Inherits="QuanLyKhachHang.View.bbNhapThongTinBe" %>
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
    window.document.getElementById("BAOBE").className = "current_link";
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
       <ajaxToolkit:ToolkitScriptManager runat="Server" EnableScriptGlobalization="true"
            EnableScriptLocalization="true" ID="ScriptManager1"  />     
 
 <table cellpadding="0" cellspacing="0" style="font-family:Times New Roman;  margin-left:20px;margin-top:10px;" class="table_list" >
        <tbody>
           <tr class="head2">
               <td class="style11" style="border-right:0px #99cc99 solid; border-bottom: 1px solid;">
                                            &nbsp;&nbsp;&nbsp;&nbsp; TỪ NGÀY : </td>
               <td class="style11" style="border-right:2px #99cc99 solid; border-bottom: 1px solid;">
                                            &nbsp;
                                            <asp:TextBox ID="tungay" runat="server" autocomplete="off" Height="20px" 
                                                Width="87px" />
               </td>
                <td class="style10" style="border-right:0px #99cc99 solid; border-bottom: 1px solid;">
                                            &nbsp;&nbsp;&nbsp;&nbsp; ĐẾN NGÀY&nbsp;: </td>
                <td class="style10" style=" font-size:10px; font-weight:normal;   border-bottom: 1px solid;">
                                       
                    &nbsp;</td>
               <td class="style10" 
                   style="border-right:2px #99cc99 solid; font-size:10px; font-weight:normal;   border-bottom: 1px solid;">
                   <asp:TextBox ID="denngay" runat="server" autocomplete="off" Height="21px" 
                       Width="86px" />
               </td>
               <td class="style10" 
                   style="border-right:2px #99cc99 solid; font-size:10px; font-weight:normal;   border-bottom: 1px solid;">
                   <asp:Button ID="btXemBangKe" runat="server" CssClass="button1" Height="27px" 
                       onclick="btXemBangKe_Click" Text="XEM THÔNG TIN" Visible="False" />
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

       <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="tungay" Format="dd/MM/yyyy" >
    </ajaxToolkit:CalendarExtender>
         <ajaxToolkit:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="denngay" Format="dd/MM/yyyy" >
    </ajaxToolkit:CalendarExtender>
<asp:Panel ID="Panel2" runat="server"  Width="1248px">    
  
    <table cellpadding="0" cellspacing="0" class="table_list_1"  style="font-family:Times New Roman; margin-left:50px; font-size:15px; width: 500px;">
                     <tr class="head1">
                          <td class="style5" 
                              style="border-right:1px #FF0000 solid; background-color:#CCFFFF; font-size:large; border-bottom: 2px #FF0000 solid">
                              <center>
                                        DANH SÁCH THÔNG TIN ĐIỂM BỂ
                                        
                              </center>
                           </td>
                      </tr>
                     <tr >
                          <td  style="border-right:1px #FF0000 solid; font-size:large; border-bottom: 2px #FF0000 solid" 
                              class="style6">
                              <table cellpadding="0" cellspacing="0" class="table_list" 
                                  style="font-family:Times New Roman; font-size:15px; margin-left:20px;">
                                  <tr class="head1">
                                      <td class="style26" 
                                          style="border-right:2px #FF0000 solid; border-bottom: 1px solid;">
                                          SỐ CÔNG VĂN :</td>
                                      <td class="style26" 
                                          style="border-right:2px #FF0000 solid; border-bottom: 1px solid;">
                                          <asp:TextBox ID="TextBox1" runat="server" Width="139px"></asp:TextBox>
                                      </td>
                                      <td class="style26" 
                                          style="border-right:2px #FF0000 solid; border-bottom: 1px solid;">
                                          <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                                      </td>
                                  </tr>
                                  <tr class="head1">
                                      <td class="style26" 
                                          
                                          style="border-right:2px #FF0000 solid; text-align: center; border-bottom-style: solid; border-bottom-color: inherit; border-bottom-width: 1px;">
                                          ĐƠN VỊ NHẬN
                                          <br />
                                          SỬA BỂ</td>
                                      <td class="style26" 
                                          style="border-right:2px #FF0000 solid; border-bottom: 1px solid;">
                                          <asp:DropDownList ID="cbDonViSuaBe" runat="server" Height="23px" Width="188px">
                                          </asp:DropDownList>
                                      </td>
                                      <td class="style26" 
                                          style="border-right:2px #FF0000 solid; border-bottom: 1px solid;">
                                          <asp:Button ID="btChuyen" runat="server" CssClass="button1" Height="27px" 
                                              onclick="btChuyen_Click" Text="CHUYỂN" />
                                      </td>
                                  </tr>
                              </table>
                           
                          </td>
                      </tr>
                     <tr >
                          <td class="style1" align=center >
                              <asp:GridView ID="gChuyen" runat="server" AutoGenerateColumns="False" 
                                  BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" 
                                  CellPadding="4" Width="902px">
                                  <Columns>
                                      <asp:TemplateField>
                                          <ItemTemplate>
                                              <asp:CheckBox ID="chkRow" runat="server" />
                                          </ItemTemplate>
                                      </asp:TemplateField>
                                      <asp:TemplateField HeaderText="ID" Visible="False">
                                          <EditItemTemplate>
                                              <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("ID") %>'></asp:TextBox>
                                          </EditItemTemplate>
                                          <ItemTemplate>
                                              <asp:Label ID="lbID" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
                                          </ItemTemplate>
                                      </asp:TemplateField>
                                      <asp:BoundField DataField="STT" HeaderText="STT" >
                                      <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="50px" />
                                      </asp:BoundField>
                                      <asp:BoundField DataField="LoaiBao" HeaderText="Loại Bể">
                                      <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="150px" />
                                      </asp:BoundField>
                                      <asp:BoundField DataField="MaDMA" HeaderText="Mã DMA" >
                                      <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="120px" />
                                      </asp:BoundField>
                                      <asp:BoundField DataField="SoNha" HeaderText="Số Nhà" >
                                      <ItemStyle VerticalAlign="Middle" Width="150px" />
                                      </asp:BoundField>
                                      <asp:BoundField DataField="TenDuong" HeaderText="Tên Đường" >
                                      <ItemStyle VerticalAlign="Middle" Width="250px" />
                                      </asp:BoundField>
                                      <asp:BoundField DataField="TenPhuong" HeaderText="Phường" >
                                      <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="200px" />
                                      </asp:BoundField>
                                      <asp:BoundField DataField="TenQuan" HeaderText="Quận" >
                                      <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
                                      </asp:BoundField>
                                      <asp:BoundField DataField="TenDonVi" HeaderText="Đơn Vị Sửa Bể" >
                                      <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="250px" />
                                      </asp:BoundField>
                                      <asp:BoundField />
                                  </Columns>
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
                zoom: 14,
                mapTypeId: 'roadmap'
            });
 
          var layer = new google.maps.FusionTablesLayer({
                      query: {
                        select: 'col2',
                        from: '1eXgHvhPw8I3YbH3oGi0Z58qcjHnIOJZ5X0KOt358'
			            },
			              options: {
				            styleId: 2,
				            templateId: 2
			            }
                    });
                    layer.setMap(map);


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
                         "<option value='31'>Tân Phú</option>" +
                         "</select> </td></tr>" +

                         "<tr style=' height: 30px; '><td style='border-bottom:1px; border-bottom-style:dotted; hight:100px; width:80px;'>Loại:</td> <td><select id='type'>" +
                         "<option value='Bể Nổi' >Bể Nổi</option>" +
                         "<option value='Bể Ngầm' SELECTED>Bể Ngầm</option>" +
                         "</select> </td></tr>" +
                           "<tr style=' height: 30px; '><td style='border-bottom:1px; border-bottom-style:dotted; hight:100px; width:80px;'>Mã DMA:</td> <td><input type='text' id='dma'/></td> </tr>" +
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
                            var x= parseFloat(<%=table.Rows[i]["lat"]%>);
                            lagx= parseFloat(<%=table.Rows[i]["lat"]%>);
                            var y = parseFloat(<%=table.Rows[i]["lng"]%>);
                            lagy= parseFloat(<%=table.Rows[i]["lng"]%>);
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
