<%@ Page Title="" Language="C#" MaintainScrollPositionOnPostback="true" MasterPageFile="~/View/HomePageDMA.Master" AutoEventWireup="true" CodeBehind="QuanLyDMA.aspx.cs" Inherits="BaoCao_Web.View.KTCN.QuanLyDMA" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="System.Data.SqlClient" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

<div class="Content">

   
<table width="100%" cellpadding="0" cellspacing="0" border="1" >
 <tr align="justify">
    <td valign="top" style="width:10%; height:700px;" >
      <div> <table width="100%" cellspacing="0" cellpadding="0" border="0">
                 <tbody><tr>
                   <td bgcolor="#DDEDFB" style="border-bottom:1pt #67aeef solid"><table width="100%" cellspacing="0" cellpadding="0" border="0">
                     <tbody><tr>
                       <td width="33">
                           <asp:CheckBox ID="cAll" runat="server" AutoPostBack="True" 
                               oncheckedchanged="cAll_CheckedChanged" /></td>
                       <td width="10">&nbsp;</td>
                       <td><b>MÃ DMA</b> </td>
                     </tr>
                   </tbody></table></td>
                 </tr>
               </tbody>
           </table>
       </div>
       <div style="overflow :auto; height :650px ">
       <asp:CheckBoxList ID="listDMA" runat="server" AutoPostBack="true"   ClientIDMode="Static"
               onselectedindexchanged="listDMA_SelectedIndexChanged"  >
        </asp:CheckBoxList>
       </div>
        
     </td>
    <td valign="top" style="width: 90%">

 <style type="text/css">
  .outer {
    position: relative;
   
  }

 .topright {
    position: absolute;
    top: 1em;
    right: 15em;
    width: 140px;
    padding: 4px;
    background-color: #fff;
    font-weight: bold;
    font-size: 11px;
  }

</style>

<table cellpadding="0" cellspacing="0"  style="width:100%; background-color:White; font-family:Times New Roman; font-size:15px;" class="table_list" >
         <tbody>
          <tr>
              <%
                  DataTable table = new DataTable();
                  if (Session["chamcong"] != null)
                  {
                      table = (DataTable)Session["chamcong"];
                      for (int i = 0; i < table.Rows.Count; i++)
                      {
                          string dma = table.Rows[i]["MADMA"].ToString();
                          string img = @"../Image/DMA/" + dma + @".png";
                     %><td>       
                          <div class="outer">                    
                           <img  height="300" width="400" src="<%=img%> " />                          
                            <table class="topright" border="1" style=" background-color:#90EE90;" cellpadding="0" cellspacing="0" >
                                <tr style="height:20px;"> <td rowspan="2">Áp Lực</td> 
                         <%
                          string ChannelID = "";
                          string sq = "SELECT *  FROM [t_Channel_Configurations]  where LEFT([Description],5)='" + dma.Replace("TH-","") +"' AND ChannelName='Inlet'";
                          string sqLL = "SELECT *  FROM [t_Channel_Configurations]  where LEFT([Description],5)='" + dma.Replace("TH-", "") + "' AND ChannelName='Flow'";
                          string sqTB = "SELECT *  FROM [DATALOGGER]  where MaDMA='" + dma.Replace("TH-", "").Replace("-",".") + "' ";
                          DataTable t2 = BaoCao_Web.Class.LinQConnectionGis.getDataTable(sqTB);

                          string ALMin = "";
                          string ALMax = "";
                          if (t2.Rows.Count > 0)
                          {
                              ALMin = string.Format("{0:0.##}", t2.Rows[0]["GiaTriNN"]);
                              ALMax = string.Format("{0:0.##}", t2.Rows[0]["GiaTriLN"]); 
                          }
                          
                          DataTable t1 = BaoCao_Web.Class.LinQConnectionGis.getDataTable(sq);
                                if (t1.Rows.Count > 0)
                                {
                                    ChannelID = t1.Rows[0]["ChannelId"].ToString();
                              %>
                              
                              <%
                                    if (t1.Rows[0]["LastValue"] == null || t1.Rows[0]["LastValue"].ToString() == "0") 
                                    {
                                         %><td rowspan="2"  style="background-color:Red;text-align:center">0</td><%
                                    }
                                    else
                                    {
                                        if (DateTime.Now.Date == DateTime.Parse(t1.Rows[0]["TimeStamp"].ToString()).Date)
                                        {
                                    %><td rowspan="2" style="text-align:center"><a title="Click Xem Biểu Đồ !" href="QuanLyDMA_Chart.aspx?value=<%=ChannelID%>"><%=t1.Rows[0]["LastValue"]%></a> </td><%
                                        }
                                        else
                                        { 
                                    %><td rowspan="2" style="background-color:Yellow;text-align:center"><a title="Click Xem Biểu Đồ !" href="QuanLyDMA_Chart.aspx?value=<%=ChannelID%>"><%=t1.Rows[0]["LastValue"]%></a></td><%
                                        }
                                    }

                                }
                                else { 
                                %><td rowspan="2"  style="background-color:Red;text-align:center">-</td><%
                                }
                          %>
                                     
                                     <td style="text-align:center"><%=ALMin %></td> 
                                 </tr>
                                <tr>
                                 <td style="text-align:center; border-top:2px;"><%=ALMax%></td> 
                               </tr>
                               <%
                                   
                                          DataTable t3 = BaoCao_Web.Class.LinQConnectionGis.getDataTable(sqLL);
                                          if (t3.Rows.Count > 0)
                                          {
                                              %><tr > <td>Lưu Lượng</td> <td colspan="2" style="height:20px; text-align:center;vertical-align:middle"><%=String.Format("{0:0.##}", t3.Rows[0]["LastValue"])%></td></tr><%
                                          }     
                               %>
                                 
                            </table>                            
                            </div>
                          <%
                          DataTable tb = BaoCao_Web.Class.LinQConnection.getDataTable("SELECT  * FROM TONGDHN_DMA WHERE MADMA='" + dma + "'  ");
                          if (tb.Rows.Count > 0)
                          {
                          %><%=dma%>
                          <table cellpadding="0" cellspacing="0" style="width:100%; font-family:Times New Roman; font-size:10px;" class="table_list" >
                             <tbody>
                                     <tr style="background-color:#E6E6FA" class="head11"  ><td >Tổng ĐHN</td><td>15</td><td>20</td><td>25</td><td>40</td><td>50</td><td>80</td><td>100</td><td>150</td><td>200</td></tr>
                                     <tr class="head11" ><td><%=String.Format("{0:0,0}", tb.Rows[0]["TONG"])%></td><td><%=String.Format("{0:0,0}", tb.Rows[0]["CO15"])%></td><td><%=tb.Rows[0]["CO20"]%></td><td><%=tb.Rows[0]["CO25"]%></td>
                                     <td><%=tb.Rows[0]["CO40"]%></td><td><%=tb.Rows[0]["CO50"]%></td><td><%=tb.Rows[0]["CO80"]%></td><td><%=tb.Rows[0]["CO100"]%></td><td><%=tb.Rows[0]["CO150"]%></td><td><%=tb.Rows[0]["CO200"]%></td></tr>
                             </tbody>
                             </table>             
                           </td>
                          <%
                          }
                          if((i+1)%4==0)
                          {
                              %></tr><tr>  <%
                          }
                      }
                  }
             %>
            </tr>
         </tbody>
        </table>
   
        
    </td>
 </tr>
</table>

</div>


</asp:Content>
