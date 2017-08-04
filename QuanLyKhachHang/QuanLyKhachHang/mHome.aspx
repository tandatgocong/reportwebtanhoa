<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mHome.aspx.cs" Inherits="QuanLyKhachHang.mHome" %>

<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="System.Data.SqlClient" %>
<%@ Import Namespace="QuanLyKhachHang.Class" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html>
   <head>
      <title>..: Thông Tin :..</title>
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
         <div class="location"> THÔNG TIN DANH BỘ </div> 
      <div class="text"> 
      <table   >
      <tr><td style="width:80px;"><asp:DropDownList ID="dot" runat="server" Height="19px" Width="85px">
          <asp:ListItem Value="0">Danh Bộ</asp:ListItem>
          <asp:ListItem Value="1">Địa Chỉ</asp:ListItem>
          </asp:DropDownList></td><td>
          <asp:TextBox ID="txtDB" runat="server" ontextchanged="txtDB_TextChanged" 
                  style="margin-left: 0px"></asp:TextBox>
          </td></tr>
      <tr><td colspan="2" >
       <asp:Panel ID="Panel3" Visible="false" runat="server" ScrollBars="Both" 
              Width="320px" Height="100px">
         <asp:Panel ID="Panel4"   runat="server"  Width="800px" Height="100%">
          <asp:GridView ID="GridView3" runat="server" Width="100%" AutoGenerateColumns="False" 
              CellPadding="4" ForeColor="#333333" GridLines="None" 
               onrowcommand="GridView3_RowCommand">
              <AlternatingRowStyle BackColor="White" />
              <Columns>
                  <asp:TemplateField HeaderText="DANH BO" ShowHeader="False">
                      <ItemTemplate>
                          <asp:LinkButton ID="DB" runat="server" CausesValidation="False" 
                              CommandArgument='<%# Bind("DANHBO") %>' CommandName="Select" 
                              Text='<%# Bind("DANHBO") %>'></asp:LinkButton>
                      </ItemTemplate>
                      <ItemStyle Width="80px" />
                  </asp:TemplateField>
                  <asp:BoundField DataField="DCHI" HeaderText="DCHI" >
                  <ItemStyle Width="200px" />
                  </asp:BoundField>
                  <asp:BoundField DataField="HOTEN" HeaderText="HOTEN">
                  </asp:BoundField>
                  <asp:BoundField DataField="HIEUDH" HeaderText="HIEUDH" />
                  <asp:BoundField DataField="SOTHANDH" HeaderText="SOTHANDH" />
                  <asp:BoundField DataField="NAMGAN" HeaderText="NAMGAN" />
                  <asp:BoundField DataField="CHISOKYTRUOC" HeaderText="CSCU" />
                  <asp:BoundField DataField="LOTRINH" HeaderText="LOTRINH" >
                  <ItemStyle Width="70px" />
                  </asp:BoundField>
              </Columns>
              <EditRowStyle BackColor="#7C6F57" />
              <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
              <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
              <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
              <RowStyle BackColor="#E3EAEB" />
              <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
              <SortedAscendingCellStyle BackColor="#F8FAFA" />
              <SortedAscendingHeaderStyle BackColor="#246B61" />
              <SortedDescendingCellStyle BackColor="#D4DFE1" />
              <SortedDescendingHeaderStyle BackColor="#15524A" />
          </asp:GridView>
          </asp:Panel>
          </asp:Panel>
          </td></tr>
      </table>   
      <hr /> 
       <table> 
      <tr><td class="style1" colspan="2">Khách Hàng:&nbsp;<asp:Label ID="lbTenKh" runat="server" Font-Bold="True"/>
          <asp:Label ID="lbDanhBo" runat="server" Font-Bold="True" Visible="False"/></td></tr>
      <tr><td class="style1" colspan="2">Địa Chỉ:&nbsp;<asp:Label ID="diachi" runat="server" Font-Bold="True"/></td></tr>
      <tr><td class="style2" colspan="2">Lộ Trình:&nbsp;<asp:Label ID="lotrinh" runat="server" Font-Bold="True"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Hiệu Lực :  <asp:Label ID="hieuluc" runat="server" Font-Bold="True"/></td> </tr>
      <tr><td class="style2" colspan="2">Giá Biểu:&nbsp;<asp:Label ID="giabieu" runat="server" Font-Bold="True" /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Định Mức :  <asp:Label ID="dinhmuc" runat="server" Font-Bold="True"/> </td> </tr>
      <tr><td class="style2" colspan="2">Ngày Gắn:&nbsp;<asp:Label ID="ngaygan" runat="server" Font-Bold="True" /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Ngày KĐ:  <asp:Label ID="ngaykiemdinh" runat="server" Font-Bold="True"/> </td> </tr>
      <tr><td class="style1" colspan="2">Hiệu ĐHN:&nbsp;<asp:Label ID="hieudhn" runat="server" Font-Bold="True"/></td></tr>
      <tr><td class="style1" colspan="2">NV Đọc Số :&nbsp;<asp:Label ID="nvds" runat="server" Font-Bold="True"/></td></tr>
      <tr><td class="style1" colspan="2">NV Thu Tiền :&nbsp;<asp:Label ID="nvtt" runat="server" Font-Bold="True"/></td></tr>
      <tr><td class="title_mobile"  style="border-bottom: 1px  #FF0000 solid; background-color: #FFFF99; text-align: center;" colspan="2"> Phiếu Tiêu Thụ </td></tr>
      <tr><td class="style1" colspan="2">
      <asp:Panel ID="Panel1" runat="server" ScrollBars="Both" Width="100%" Height="150px">
          <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                        BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" 
                        CellPadding="3" Font-Names="Times New Roman" Font-Size="12px" 
                        GridLines="Vertical" Width="100%">
                        <AlternatingRowStyle BackColor="#DCDCDC" />
                        <Columns>
                            <asp:BoundField DataField="NAM" HeaderText="Kỳ">
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"  />
                            </asp:BoundField>
                            <asp:BoundField DataField="NGAYDOC" HeaderText="Ngày Đọc">
                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundField>
                            <asp:BoundField DataField="CodeMoi" HeaderText="Code">
                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundField>
                            <asp:BoundField DataField="CSCU" HeaderText="CS Củ">
                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundField>
                            <asp:BoundField DataField="CSMOI" HeaderText="CS Mới">
                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundField>
                            <asp:BoundField DataField="TIEUTHU" HeaderText="Tiêu Thụ">
                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundField>
                            <asp:BoundField DataField="ThanhTien" HeaderText="Tiền Nước">
                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            <ItemStyle HorizontalAlign="Right" VerticalAlign="Middle" />
                            </asp:BoundField>
                            <asp:BoundField DataField="ThanhToan" HeaderText="Thu Tiền">
                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundField>
                        </Columns>
                        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#0000A9" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#000065" />
                    </asp:GridView>
       </asp:Panel>
      </td></tr>
      <tr><td class="title_mobile"  style="border-bottom: 1px  #FF0000 solid; background-color: #FFFF99; text-align: center;" colspan="2"> Lịch sử điều chỉnh</td></tr>
      <tr><td class="style1" colspan="2">
      <asp:Panel ID="Panel2" runat="server" ScrollBars="Both" Width="100%" Height="150px">
         <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                        CellPadding="4" Font-Names="Times New Roman" Font-Size="12px" 
                        GridLines="None" Width="100%" 
              ForeColor="#333333">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="CREATEDATE" HeaderText="Ngày">
                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="90px"  />
                            </asp:BoundField>
                            <asp:BoundField DataField="NOIDUNG" HeaderText="Nội dung">
                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            <ItemStyle HorizontalAlign="Left" />
                            </asp:BoundField>
                        </Columns>
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                        <SortedDescendingHeaderStyle BackColor="#4870BE" />
                    </asp:GridView>
      </asp:Panel>
      </td></tr>
      <tr><td class="title_mobile"  style="border-bottom: 1px  #FF0000 solid; background-color: #FFFF99; text-align: center;" colspan="2">tọa độ vị trí</td></tr>
      <tr>
      
      <td colspan="2">
    <div id="map" style="width: 100%; height: 300px;"></div>
    <script> 
        function initAutocomplete() {
         <% 
                    
                       DataTable table = new DataTable();                      
                       if(Session["db"]!=null)
                       {
                        table = (DataTable)Session["db"];
                        int tong=table.Rows.Count;
                        for(int i=0;i<tong;i++)
                        {
                        %>
                        var x= parseFloat(<%=table.Rows[i]["Lat"]%>);                           
                        var y = parseFloat(<%=table.Rows[i]["Long"]%>); 
                        var latlng = new google.maps.LatLng(x, y);
                        var marker;
                        var infowindow;
                        var map = new google.maps.Map(document.getElementById('map'), {
                            center: latlng,
                            zoom: 18,
                            mapTypeId: 'roadmap'
                        });
            
                           
                            var icon_='Image/db.png';
                            var latlng2 = new google.maps.LatLng(x, y);
                            var marker= new google.maps.Marker({
				              position: latlng2,
                               icon: icon_,
				               map: map
				              });

                            var pos = {
                              lat: x,
                              lng: y
                            };
                    
                           map.setCenter(pos);

                        <%
                        }

                       }
                    %>


        }
          

    </script>
    
    <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyBnK4XMpV0do1pWTYFGUydQvA_EyMkJ9xU&libraries=places&callback=initAutocomplete"   async defer></script>
 
      </td>
      </tr>

      <tr><td class="title_mobile"  style="border-bottom: 1px  #FF0000 solid; background-color: #FFFF99; text-align: center;" colspan="2"> Hình ảnh lưu trữ</td></tr>
     <tr><td class="style4"><asp:FileUpload ID="FileUpload2" runat="server" /> 
         <td class="style4">  <asp:Button ID="btUploag" runat="server" Text="Upload" onclick="btUploag_Click"  /> 
         <td class="style4"> <asp:Label ID="upload" runat="server" ForeColor="Red" /></td></tr>
     <tr><td class="style3" colspan="2">
        <marquee behavior='scroll' SCROLLAMOUNT='20' direction='left' onmouseover='this.stop();' onmouseout='this.start();'>  <asp:Panel ID="PanelImg" runat="server"></asp:Panel></marquee>
        </td>
        </tr>
      </table>
      </div>
      </div>
    
   </form>
      
   </body>
</html>
