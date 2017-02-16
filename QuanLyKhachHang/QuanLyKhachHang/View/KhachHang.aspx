<%@ Page Title="" Language="C#" MasterPageFile="~/View/HomePage.Master" AutoEventWireup="true" CodeBehind="KhachHang.aspx.cs" Inherits="QuanLyKhachHang.View.KhachHang" %>
<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="System.Data.SqlClient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script language="javascript" type="text/javascript">
    window.document.getElementById("HOME").className = "top_link";
    window.document.getElementById("GANMOI").className = "top_link";
    window.document.getElementById("KHACHHANG").className = "current_link";
    window.document.getElementById("APLUC").className = "top_link"; 
    </script>
    
    <style type="text/css">
        
      input[type=text], textarea
        {
             background-color: White;
        }
        
        input[type=text]:focus, textarea:focus
        {
            background-color: Yellow;
        }

        .normalrow
        {
            background-color: White;
        }
        .onmouseoverrow
        {
            background-color: Yellow;
        }
        
        .cach
        {
            border-left:1px #FF0000 solid;    
        }
        .style1
        {
            height: 25px;
        }
        .style2
        {
            width: 6%;
        }
    </style>

<div class="title_page"><asp:Label ID="title" runat="server" Text="NHẬP THÔNG TIN KHÁCH HÀNG "></asp:Label>
</div>
<table style="width:95%; margin-left:20px; " border="0">
        <tr>
    <td class="style28" rowspan="2"  valign=top>
       <table cellpadding="0" cellspacing="0" style="font-family:Times New Roman; font-size:15px; margin-left:20px;" class="table_list" >
        <tbody>
           <tr class="head1">
               <td class="style11" style="border-right:0px #99cc99 solid; border-bottom: 1px solid;">
                                            &nbsp;DANH BỘ:</td>
               <td class="style5" 
                   style="border-right:2px #99cc99 solid; font-size:10px; font-weight:normal;   border-bottom: 1px solid;">
                                            <asp:TextBox ID="txtDanhBo" runat="server" autocomplete="off" 
                                                ontextchanged="txtDanhBo_TextChanged" AutoPostBack="True" />
               </td>               
                <td class="style10" style="border-right:0px #99cc99 solid; border-bottom: 1px solid;">
                                            &nbsp;&nbsp;&nbsp; ĐỊA CHỈ: </td>
                <td class="style5" 
                   style="border-right:2px #99cc99 solid; font-size:10px; font-weight:normal;   border-bottom: 1px solid;">
                                            <asp:TextBox ID="txtDiaChi"  runat="server" autocomplete="off" Width="242px" 
                                                ontextchanged="txtDiaChi_TextChanged" AutoPostBack="True" />
               </td>
               <td class="style10" style="border-right:0px #99cc99 solid; border-bottom: 1px solid;">
                                            &nbsp;&nbsp;&nbsp; ĐIỆN THOẠI: </td>
                <td class="style5" 
                   style="border-right:2px #99cc99 solid; font-size:10px; font-weight:normal;   border-bottom: 1px solid;">
                                            <asp:TextBox ID="txtDienthoai"  runat="server" autocomplete="off" Width="138px" 
                                                ontextchanged="txtDienthoai_TextChanged" AutoPostBack="True" />
               </td>               
             </tr>
          </tbody>
    </table>
                
    </td>
    </tr>
</table>
<asp:Panel ID="pSearch" runat="server">
<table cellpadding="0" cellspacing="0"     
    style="margin-left:20px;font-family:Times New Roman; font-size:15px; width: 1062px; " >
                            <tr class="head1">
                                <td class="style1" 
                                    style="border-right:1px #FF0000 solid; background-color:#CCFFFF; font-size:large; border-bottom: 2px #FF0000 solid">
                                <b><table width="100% "  style="font-size:large;  border-right:1px #FF0000 solid;font-size:large; font-family:Times New Roman; border-bottom: 2px #FF0000 solid ">
                                <tr align="center"><td style="width:100px;">  Danh Bộ  </td><td style="width:200px;">     Họ Tên</td> <td style="width:400px;">      Địa Chỉ</td> <td style="width:200px;">   Điện Thoại</td></tr>
                                </table></b>
                                </td>
                            </tr>
                            <tr class="head1">
                                <td class="style21" 
                                    style="border-right:1px #FF0000 solid;font-size:large; font-family:Times New Roman; border-bottom: 2px #FF0000 solid ">

<asp:Panel ID="Panel1" runat="server" ScrollBars="Both" Height="400px"  >  
 <asp:Panel ID="Panel2" runat="server" ScrollBars="None" Width="1062px" > 
                                    <asp:GridView ID="GridView1" runat="server" Width="100%" 
                                        AutoGenerateColumns="False" style="margin-top: 3px" 
                                        onrowcommand="GridView1_RowCommand" onrowcreated="GridView1_RowCreated" 
                                        ShowHeader="False">
                                        <Columns>
                                            <asp:TemplateField HeaderText="Danh Bộ" ShowHeader="False">
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("DANHBO") %>'></asp:TextBox>
                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="LinkButton1" runat="server" 
                                                        CommandArgument='<%# Bind("DANHBO") %>' CommandName="View" 
                                                        Text='<%# Bind("DANHBO") %>'></asp:LinkButton>
                                                </ItemTemplate>
                                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
                                            </asp:TemplateField>
                                            <asp:BoundField DataField="HOTEN" HeaderText="Họ Tên">
                                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="200px" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="DIACHI" HeaderText="Địa Chỉ">
                                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="400px" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="DIENTHOAI" HeaderText="Điện Thoại">
                                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="200px" />
                                            </asp:BoundField>
                                        </Columns>
                                    </asp:GridView>
                                    </asp:Panel>
                                    </asp:Panel>


                                </td>
                            </tr>
                            </table>
</asp:Panel>
<asp:Panel ID="pResult" runat="server">

 
 <table border="1">
 <tr>
 <td>
    <div class="title_page"><asp:Label ID="Label2" runat="server" Text="..: THÔNG TIN KHÁCH HÀNG :.."></asp:Label>
    </div>
   
    <table cellpadding="0" cellspacing="0" class="table_list_1" style="font-family:Times New Roman; font-size:15px; width: 100%;">                            
     <tr class="head1">
        <td>Danh Bộ : </td>
         <td  >
                 <asp:Label ID="lbDanhBo" runat="server" Text="Label"></asp:Label>
         </td>
         <td class="cach">Hợp Đồng : </td>
         <td  >
                 <asp:Label ID="lbHopDong" runat="server" Text="Label"></asp:Label>
         </td>
         <td class="cach">Hiệu Lực : </td>
         <td  >
                 <asp:Label ID="lbHieuLuc" runat="server" Text="Label"></asp:Label>
         </td>
      </tr>

      <tr class="head1">
        <td>Lộ Trình : </td>
         <td  >
                 <asp:Label ID="lbLotrinh" runat="server" Text="Label"></asp:Label>
         </td>
         <td class="cach">Đợt : </td>
         <td  >
                 <asp:Label ID="lbDot" runat="server" Text="Label"></asp:Label>
         </td>
         <td class="cach">Quận Phường : </td>
         <td  >
                 <asp:Label ID="lbQuanPhuong" runat="server" Text="Label"></asp:Label>
         </td>
      </tr>

        <tr class="head1">
            <td class="style1">
                Họ Tên :</td>
            <td colspan="5" class="style1"><asp:Label ID="lbHoTen" runat="server" Text="Label"></asp:Label>
                &nbsp;</td>
        </tr>
        <tr class="head1">
            <td>
                Địa Chỉ :</td>
            <td colspan="5"><asp:Label ID="lbDiaChi" runat="server" Text="Label"></asp:Label>
                &nbsp;</td>
        </tr>
        <tr class="head1">
        <td>Giá Biểu: </td>
         <td  >
                 <asp:Label ID="lbGiaBieu" runat="server" Text="Label"></asp:Label>
         </td>
         <td class="cach">Định Mức : </td>
         <td  >
                 <asp:Label ID="lbDinhMuc" runat="server" Text="Label"></asp:Label>
         </td>
         <td class="cach" colspan="2" >Điện Thoại:&nbsp;<asp:Label ID="lbDienthoai" 
                 runat="server" Text="Label"></asp:Label>
            </td> 
      </tr>
      <tr class="head1">
        <td>Ngày Gắn: </td>
         <td  >
                 <asp:Label ID="lbNgayGan" runat="server" Text="Label"></asp:Label>
         </td>
         <td class="cach">Kiểm Định : </td>
         <td  >
                 <asp:Label ID="lbKiemDinh" runat="server" Text="Label"></asp:Label>
         </td>
         <td class="cach" colspan="2">&nbsp;</td>
      </tr>
        <tr class="head1">
            <td colspan="6">
     <table border=0 cellpadding=0 cellspacing=0>                            
             <tr   >
             <td style="border-bottom:0">Hiệu :</td><td style="border-bottom:0"><asp:Label ID="lbHieu" runat="server" Text="Label"></asp:Label></td>
             <td class="cach" style="border-bottom:0";>Cở :</td><td style="border-bottom:0"><asp:Label ID="lbCo" runat="server" Text="Label"></asp:Label></td>
             <td class="cach" style="border-bottom:0">Cấp :</td><td style="border-bottom:0"><asp:Label ID="lbCap" runat="server" Text="Label"></asp:Label></td>
             <td class="cach" style="border-bottom:0">Số Thân :</td><td style="border-bottom:0"><asp:Label ID="lbSoThan" runat="server" Text="Label"></asp:Label></td>
             <td class="cach" style="border-bottom:0">Vị Trí :</td><td style="border-bottom:0"><asp:Label ID="lbViTri" runat="server" Text="Label"></asp:Label></td>
             </tr>
     </table>     
            </td>
        </tr>
        <tr class="head1">
            <td colspan="6">
                 <div class="title_page" style="margin-bottom:5px;"><asp:Label ID="Label1" runat="server" Text="..: LỊCH SỬ QUẢN LÝ KHÁCH HÀNG :.."></asp:Label>
                 </div>
                 <asp:Panel ID="Panel3" runat="server" ScrollBars="Both" Height="180px" 
                     Width="560px"  >  
                 <asp:Panel ID="Panel4" runat="server" ScrollBars="None" Width="540px" > 

                                 <asp:GridView ID="gGhiChu" runat="server" AutoGenerateColumns="False" 
                                     BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" 
                                     CellPadding="3" GridLines="Vertical" Width="526px">
                                     <AlternatingRowStyle BackColor="#DCDCDC" />
                                     <Columns>
                                         <asp:BoundField DataField="CREATEDATE"  DataFormatString="{0:dd/MM/yyyy}"  HeaderText="Ngày Cập Nhật">
                                         <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="90px" />
                                         </asp:BoundField>
                                         <asp:BoundField DataField="NOIDUNG" HeaderText="Nội Dung" >
                                         <ItemStyle Width="320px" />
                                         </asp:BoundField>
                                         <asp:BoundField DataField="DONVI" HeaderText="Đơn vị">
                                         <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="80px" />
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
                 </asp:Panel>
                 <br />


               </td>
        </tr>

</table>

 </td>
 <td valign=top>
  <div class="title_page"><asp:Label ID="Label3" runat="server" Text="..: THÔNG TIN ĐỌC SỐ VÀ THU TIỀN :.."></asp:Label>
   </div>
   <asp:Panel ID="Panel5" runat="server" ScrollBars="Both" Height="220px" 
                     Width="880px" style="margin-bottom: 0px"  >  
    <asp:Panel ID="Panel6" runat="server" ScrollBars="None" Width="850px" > 
         <table cellpadding="0" border=0 cellspacing="0" style="font-family:Times New Roman; font-size:15px; margin-left:20px;" class="table_list" >
        <tbody>
           <tr class="head1"  align="center">
            <td style="width:60px" >Kỳ Đọc Số</td>
            <td style="width:50px" >Ngày đọc</td>
            <td style="width:75px" >Chỉ số cũ</td>
            <td style="width:85px" >Chỉ số mới</td>
            <td style="width:60px" >Tiêu thụ</td>
            <td style="width:80px" >Phí BVMT</td>
            <td style="width:80px" >Thuế GTGT</td>
            <td style="width:80px" >Tiền Nước</td>
            <td style="width:80px" >Thành Tiền</td>
            <td style="width:60px">Thanh Toán</td>
            </tr>
		<%
             DataTable table = new DataTable();
             if (Session["HoaDon"] != null)
             {
                 table = (DataTable)Session["HoaDon"];
                 foreach (DataRow row in table.Rows)
                 {
                              %>
                              <tr style="height:25px;">
                                <td align="center" style="border-right:1px #99cc99 solid; border-bottom:1px #99cc99 solid;"><%=int.Parse(row["KyHD"].ToString()) <= 9 ? ("0" + row["KyHD"].ToString()) : row["KyHD"].ToString()%>/<%=row["NamHD"].ToString()%></td>
                                <td align="right" style="border-right:1px #99cc99 solid; border-bottom:1px #99cc99 solid;"><%=row["NGAYDOC"].ToString()%></td>
                                <td align="right" style="border-right:1px #99cc99 solid; border-bottom:1px #99cc99 solid;"><%=row["CSCU"].ToString()%></td>
                                <td align="right" style="border-right:1px #99cc99 solid; border-bottom:1px #99cc99 solid;"><%=row["CSMOI"].ToString()%></td>
                                <td align="right" style="border-right:1px #99cc99 solid; border-bottom:1px #99cc99 solid;"><%=row["TIEUTHU"].ToString()%></td>
                                <td align="right" style="border-right:1px #99cc99 solid; border-bottom:1px #99cc99 solid;"><%=String.Format("{0:0,0}",row["PBVMT"])%></td>
                                <td align="right" style="border-right:1px #99cc99 solid; border-bottom:1px #99cc99 solid;"><%=String.Format("{0:0,0}",row["TGTGT"])%></td>
                                <td align="right" style="border-right:1px #99cc99 solid; border-bottom:1px #99cc99 solid;"><%=String.Format("{0:0,0}",row["TNuoc"])%></td>
                                <td align="right" style="border-right:1px #99cc99 solid; border-bottom:1px #99cc99 solid;"><%=String.Format("{0:0,0}",row["ThanhTien"])%></td>
                                <td align="center" style="border-right:1px #99cc99 solid; border-bottom:1px #99cc99 solid;"><%=row["ThanhToan"].ToString()%></td>
                         </tr>
                              <%
                               
                 }
             }
        %>
        
            </tbody></table>
 </asp:Panel>
 </asp:Panel>
 <div class="title_page"><asp:Label ID="Label4" runat="server" Text="..: ĐÓNG MỞ NƯỚC :.. "></asp:Label>
   </div>
    <asp:Panel ID="Panel7" runat="server" ScrollBars="Both" Height="220px" 
                     Width="600px" style="margin-bottom: 0px"  >  
    <asp:Panel ID="Panel8" runat="server" ScrollBars="None" Width="600px" > 

     <asp:GridView ID="GridView2" runat="server" CellPadding="3" 
         GridLines="Vertical" AutoGenerateColumns="False" BackColor="White" 
         BorderColor="#999999" BorderStyle="None" BorderWidth="1px">
         <AlternatingRowStyle BackColor="#DCDCDC" />
         <Columns>
             <asp:BoundField DataField="STT" HeaderText="STT">
             <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="70px" />
             </asp:BoundField>
             <asp:BoundField DataField="NGAYDN" HeaderText="Ngày Đóng Nước">
             <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="120px" />
             </asp:BoundField>
             <asp:BoundField DataField="LyDo" HeaderText="Lý Do">
             <ItemStyle Width="300px" />
             </asp:BoundField>
             <asp:BoundField DataField="NGAYMN" HeaderText="Ngày Mở Nước">
             <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="120px" />
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
</asp:Panel></asp:Panel>
 </td>
 </tr>

 <tr>
  <td>
    <div class="title_page"><asp:Label ID="Label5" runat="server" Text="..: THÔNG TIN ÁP LỰC NƯỚC :.."></asp:Label>
    </div>
     <table cellpadding="0" cellspacing="0" border=2  style="width:100%; background-color:White; font-family:Times New Roman; font-size:15px;" class="table_list" >
         <tbody>
          <tr>
              <%
                  DataTable table = new DataTable();
                  if (Session["MADMA"] != null)
                  {

                      string dma = Session["MADMA"].ToString();
                      string img = @"../Image/DMA/" + dma + @".png";
                     %><td>       
                          <div class="outer">                    
                           <img  height="300" width="500" src="<%=img%> " />                          
                            <table width="300;" class="topright" border="1" style="background-color:#CCFFCC; text-align:center; margin-top:30px; margin-left:20px; font-size:20px;" cellpadding="0" cellspacing="0" >
                                <tr style="height:20px;"> <td rowspan="2">Áp Lực</td> 
                         <%
                      string ChannelID = "";
                      string sq = "SELECT *  FROM [t_Channel_Configurations]  where LEFT([Description],5)='" + dma.Replace("TH-", "") + "' AND ChannelName='Pressure'";
                      string sqLL = "SELECT *  FROM [t_Channel_Configurations]  where LEFT([Description],5)='" + dma.Replace("TH-", "") + "' AND ChannelName='Flow'";
                      string sqTB = "SELECT *  FROM [DATALOGGER]  where MaDMA='" + dma.Replace("TH-", "").Replace("-", ".") + "' ";
                      DataTable t2 = QuanLyKhachHang.Class.LinQConnectionGis.getDataTable(sqTB);

                      string ALMin = "";
                      string ALMax = "";
                      if (t2.Rows.Count > 0)
                      {
                          ALMin = string.Format("{0:0.##}", t2.Rows[0]["GiaTriNN"]);
                          ALMax = string.Format("{0:0.##}", t2.Rows[0]["GiaTriLN"]);
                      }

                      DataTable t1 = QuanLyKhachHang.Class.LinQConnectionGis.getDataTable(sq);
                      if (t1.Rows.Count > 0)
                      {
                          ChannelID = t1.Rows[0]["ChannelId"].ToString();
                              %>
                              
                              <%
                          if (t1.Rows[0]["LastValue"] == null)
                          {
                                         %><td rowspan="2"   style=" background-color:White;width:50px; text-align:center"><a title="Click Xem Biểu Đồ !" href="QuanLyDMA_Chart.aspx?value=<%=ChannelID%>"><img alt="" class="style1" src="../Image/error.gif" /></a></td><%
                          }
                          else if (t1.Rows[0]["LastValue"].ToString() == "0")
                          { 
                              %>
                                <td rowspan="2"   style=" background-color:Red;width:50px; text-align:center"><a title="Click Xem Biểu Đồ !" href="QuanLyDMA_Chart.aspx?value=<%=ChannelID%>">0</a></td><%
                          }
                          else
                          {
                              if (DateTime.Now.Date == DateTime.Parse(t1.Rows[0]["TimeStamp"].ToString()).Date)
                              {
                                    %><td rowspan="2" style="text-align:center;width:100px; color:Red;"><a title="Click Xem Biểu Đồ !" href="QuanLyDMA_Chart.aspx?value=<%=ChannelID%>"><%=t1.Rows[0]["LastValue"]%></a> </td><%
                              }
                              else
                              { 
                                    %><td rowspan="2" style="background-color:Yellow;width:50px;text-align:center"><a title="Click Xem Biểu Đồ !" href="QuanLyDMA_Chart.aspx?value=<%=ChannelID%>"><%=t1.Rows[0]["LastValue"]%></a></td><%
                              }
                          }

                      }
                      else
                      { 
                                %><td rowspan="2"  style="background-color:White;width:50px;text-align:center"><img alt="" class="style1" src="../Image/error.gif" /></td><%
                      }
                          %>
                                     
                                     <td style="text-align:center;width:50px;"><%=ALMin%></td> 
                                 </tr>
                                <tr>
                                 <td style="text-align:center; border-top:2px;width:50px;"><%=ALMax%></td> 
                               </tr>
                               <%
                                   
                      DataTable t3 = QuanLyKhachHang.Class.LinQConnectionGis.getDataTable(sqLL);
                      if (t3.Rows.Count > 0)
                      {
                          try
                          {
                              ChannelID = t3.Rows[0]["ChannelId"].ToString();
                          }
                          catch (Exception)
                          {

                          }
                               %><tr > <td>Lưu Lượng</td>
                                <td colspan="2" style="height:20px; text-align:center;vertical-align:middle"><a title="Click Xem Biểu Đồ !" href="QuanLyDMA_ChartLL.aspx?value=<%=ChannelID%>"><%=String.Format("{0:0.##}", t3.Rows[0]["LastValue"])%></a></td></tr><%
                      }     
                               %>
                                 
                            </table>                            
                            </div>
                          
                          <%
                     
                  }
             %>
            </tr>
         </tbody>
        </table>
    </td>
</tr>
 </table>


</asp:Panel>
</asp:Content>
