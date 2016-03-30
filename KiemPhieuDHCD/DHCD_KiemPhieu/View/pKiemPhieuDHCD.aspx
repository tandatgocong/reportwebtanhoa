<%@ Page Title="" Language="C#" MasterPageFile="~/View/HomePage.Master" AutoEventWireup="true" CodeBehind="pKiemPhieuDHCD.aspx.cs" Inherits="DHCD_KiemPhieu.View.pKiemPhieuDHCD" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     
     <script type="text/javascript">
         function Focus(object) {
             object.value = "";
         }

        </script>

    <style type="text/css">
        .style1
        {
            width: 165px;
        }
        .style2
        {
            width: 148px;
        }
        .style4
        {
            width: 40%;
            height: 129px;
        }
    </style>
     

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script language="javascript" type="text/javascript">
        window.document.getElementById("HOME").className = "top_link";
     window.document.getElementById("CODONG").className = "top_link";
     window.document.getElementById("KIEMPHIEU").className = "current_link";
     window.document.getElementById("BIEUQUYET").className = "top_link";
     window.document.getElementById("BAUCU").className = "top_link"; 
    </script>

     <div class="title_page" style=" margin-top:10px; height: 26px; text-align:center;">
         <asp:Label ID="title" runat="server" 
        Text="..: KIỂM PHIẾU BIỀU QUYẾT CỔ ĐÔNG CÔNG TY CỔ PHẦN CẤP NƯỚC TÂN HÒA :.."></asp:Label>
    </div>
<ajaxToolkit:ToolkitScriptManager runat="Server" EnableScriptGlobalization="true"
            EnableScriptLocalization="true" ID="ScriptManager1"  />
    <br />
     <table cellpadding="0" cellspacing="0" style="font-family:Times New Roman; font-size:15px; margin-left:20px;" class="table_list" >
        <tbody>
           <tr class="head1">
               <td class="style11" style="border-right:0px #99cc99 solid; border-bottom: 1px solid;">
                                            &nbsp;&nbsp;&nbsp;&nbsp;
                                            BIỂU QUYẾT LẦN : </td>
               <td class="style11" style="border-right:2px #99cc99 solid; border-bottom: 1px solid;">
                                            <asp:DropDownList ID="DropDownList1" runat="server" Height="24px" Width="58px" 
                                                AutoPostBack="True" onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                                                <asp:ListItem>0</asp:ListItem>
                                                <asp:ListItem>1</asp:ListItem>
                                                <asp:ListItem>2</asp:ListItem>
                                                <asp:ListItem Value="3">3</asp:ListItem>
                                                <asp:ListItem>4</asp:ListItem>
                                                <asp:ListItem>5</asp:ListItem>
                                                <asp:ListItem>6</asp:ListItem>
                                                <asp:ListItem>7</asp:ListItem>
                                                <asp:ListItem>8</asp:ListItem>
                                                <asp:ListItem>9</asp:ListItem>
                                            </asp:DropDownList>
                                            &nbsp;
               </td>
                <td class="style10" style="border-right:0px #99cc99 solid; border-bottom: 1px solid;">
                                            &nbsp;&nbsp;&nbsp; NGÀY&nbsp;: </td>
                <td class="style10" style="border-right:2px #99cc99 solid; font-size:10px; font-weight:normal;   border-bottom: 1px solid;">
                                            <asp:TextBox ID="tungay"  runat="server" autocomplete="off" />
                              <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="tungay" Format="dd/MM/yyyy" >
    </ajaxToolkit:CalendarExtender>              
               </td>
             </tr>
           <tr class="head1">
               <td class="style11" 
                   style="border-right:2px #99cc99 solid; border-bottom: 1px solid;" colspan="4">
                                            &nbsp;</td>
             </tr>
             
           <tr class="head1">
               <td class="style11" 
                   style="border-right:2px #99cc99 solid;background-color:Lavender; border-bottom: 1px solid;" colspan="3">
                                            NHẬP SỐ THỨ TỰ CỔ ĐÔNG KHÔNG ĐỒNG Ý</td>
                <td class="style10" style="border-right:2px #99cc99 solid; background-color:Lavender; border-bottom: 1px solid;">
                                            <asp:TextBox ID="txtCoDong" onfocus="Focus(this)" runat="server" AutoPostBack="True" 
                                                ontextchanged="txtCoDong_TextChanged"></asp:TextBox>
               </td>
             </tr>
          </tbody>
    </table>
    
    <br />
    <table style="width:95%; margin-left:20px; " border="0">
        <tr>
            <td class="style4" >
            <table cellpadding="0" cellspacing="0" class="table_list_1" 
                    style="font-family:Times New Roman; font-size:15px; margin-left:100px;">
                    <tr ;="" class="head1" style="height:17px;">
                        <td class="style2" colspan="2" 
                            style="border-right:1px #FF0000 solid; color:Red;  background-color:#FFFF99; font-size:large; border-bottom: 2px #FF0000	 solid; ">
                            CỔ ĐÔNG KHÔNG ĐỒNG Ý</td>
                    </tr>
                    <tr class="head1">
                        <td class="style2" 
                            style="border-right:2px #FF0000 solid; border-bottom: 1px solid; ">
                            SỐ LƯỢNG CỔ ĐÔNG :</td>
                        <td class="style1" 
                            style="border-right:1px #FF0000 solid; border-bottom: 1px solid;background-color:#FFFF99">
                            <asp:Label ID="kdy_sl" runat="server" Font-Size="X-Large" ForeColor="Red">0</asp:Label>
                        </td>
                    </tr>
                    <tr class="head1">
                        <td class="style2" 
                            style="border-right:2px #FF0000 solid; border-bottom: 1px solid;">
                            TỔNG SỐ CỔ 
                            PHIẾU :</td>
                        <td class="style1" 
                            style="border-right:1px #FF0000 solid; border-bottom: 1px solid;background-color:#FFFF99">
                            <asp:Label ID="kdy_cp" runat="server" Font-Size="X-Large" ForeColor="Red">0</asp:Label>
                        </td>
                    </tr>
                    <tr class="head1">
                        <td class="style2" 
                            style="border-right:2px #FF0000 solid; border-bottom: 1px solid;">
                            TỈ LỆ :</td>
                        <td class="style1" 
                            style="border-right:1px #FF0000 solid; border-bottom: 1px solid;background-color:#FFFF99">
                            <asp:Label ID="kdy_tl" runat="server" Font-Size="X-Large" ForeColor="Red">0</asp:Label>
                        </td>
                    </tr>
                </table>

            </td>
            <td class="style4"  >

            <table cellpadding="0" cellspacing="0" style="font-family:Times New Roman; font-size:15px; margin-left:100px;" class="table_list_1" >
        <tbody>
           <tr class="head1" style="height:17px;";>
               <td class="style2" 
                   
                   style="border-right:1px #FF0000 solid;  background-color:#CCFFFF; font-size:large; border-bottom: 2px #FF0000	 solid; " 
                   colspan="2">                                           
                                            CỔ ĐÔNG ĐỒNG Ý</td>
             </tr>
           
           
           
           <tr class="head1">
               <td class="style2" 
                   style="border-right:2px #FF0000 solid; border-bottom: 1px solid; ">                                           
                                            SỐ LƯỢNG CỔ ĐÔNG :</td>
               <td class="style1" 
                   style="border-right:1px #FF0000 solid; border-bottom: 1px solid;background-color:#CCFFFF;">                                           
                                            <asp:Label ID="dy_sl" runat="server" Font-Bold="True" Font-Size="X-Large" 
                                                ForeColor="Red" Text="0"></asp:Label>
                                            </td>
             </tr>
           
           
           
           <tr class="head1">
               <td class="style2" 
                   style="border-right:2px #FF0000 solid; border-bottom: 1px solid;">                                        
                                            TỔNG SỐ CỔ 
                                            PHIẾU :</td>
               <td class="style1" 
                   style="border-right:1px #FF0000 solid; border-bottom: 1px solid;background-color:#CCFFFF;">                                           
                                           <asp:Label ID="dy_cp" runat="server" Font-Size="X-Large" ForeColor="Red" 
                                               Text="0"></asp:Label>
               </td>
             </tr>
           
              <tr class="head1">
               <td class="style2" 
                   style="border-right:2px #FF0000 solid; border-bottom: 1px solid;">                                        
                                            TỈ LỆ :</td>
               <td class="style1" 
                   style="border-right:1px #FF0000 solid; border-bottom: 1px solid;background-color:#CCFFFF;">                                           
                                           <asp:Label ID="dy_tl" runat="server" Font-Size="X-Large" ForeColor="Red" 
                                               Text="0"></asp:Label>
                  </td>
             </tr>

          </tbody>
    </table>

                
            </td>
        </tr>
        <tr>
            <td style="width:40%;border-right:2px #000044 solid;"" valign="top" >
    <asp:GridView ID="G_KDY" runat="server" 
        AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" 
        BorderStyle="None" BorderWidth="1px" CellPadding="4" PageSize="1000" style="margin-right: 0px" 
        Width="100%" onrowcommand="G_KDY_RowCommand">
        <Columns>
            <asp:TemplateField HeaderText="STT">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox12" runat="server" Text='<%# Bind("STT") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label12" runat="server" Text='<%# Bind("STT") %>'></asp:Label>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="8px" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="STTCD" Visible="False">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox13" runat="server" Text='<%# Bind("STTCD") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label13" runat="server" Text='<%# Bind("STTCD") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="MÃ CỔ ĐÔNG">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox14" runat="server" Text='<%# Bind("MACD") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label14" runat="server" Text='<%# Bind("MACD") %>'></asp:Label>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="80px" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="TÊN CỔ ĐÔNG">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox15" runat="server" Text='<%# Bind("TENCD") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label15" runat="server" Text='<%# Bind("TENCD") %>'></asp:Label>
                </ItemTemplate>
                <ItemStyle VerticalAlign="Middle" Width="150px" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="TỔNG CỘNG">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox16" runat="server" Text='<%# Bind("TONGCD") %>'></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:Label ID="lbCPTC0" runat="server" Text='<%# Bind("TONGCD","{0:0,0}") %>'></asp:Label>
                </FooterTemplate>
                <HeaderTemplate>
                    <table style="width:100%;">
                        <tr>
                            <td style="text-align: center">
                                TỔNG CỘNG</td>
                        </tr>
                        <tr>
                            <td style="text-align: center">
                                <asp:Label ID="TongCong0" runat="server"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label16" runat="server" Text='<%# Bind("TONGCD","{0:0,0}")%>'></asp:Label>
                </ItemTemplate>
                <FooterStyle HorizontalAlign="Right" VerticalAlign="Middle" />
                <ItemStyle HorizontalAlign="Right" VerticalAlign="Middle" Width="100px" />
            </asp:TemplateField>
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:LinkButton ID="TRONGAI" runat="server" CommandArgument='<%# Bind("ID") %>' 
                        CommandName="TRONGAI" ForeColor="Blue" 
                        onclientclick="if(confirm('Bạn có muốn xóa ?') == false)return false;">Xóa</asp:LinkButton>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="20px" />
            </asp:TemplateField>
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
            <td style="width:40%" valign="top">
    <asp:GridView ID="G_DY" runat="server" 
        AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" 
        BorderStyle="None" BorderWidth="1px" CellPadding="3" PageSize="1000" 
                    style="margin-right: 0px"  Width="100%">
        <Columns>
            <asp:TemplateField HeaderText="STT">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("STT") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("STT") %>'></asp:Label>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="8px" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="STTCD" Visible="False">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("STTCD") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("STTCD") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="MÃ CỔ ĐÔNG">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("MACD") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("MACD") %>'></asp:Label>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="80px" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="TÊN CỔ ĐÔNG">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("TENCD") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("TENCD") %>'></asp:Label>
                </ItemTemplate>
                <ItemStyle VerticalAlign="Middle" Width="150px" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="TỔNG CỘNG">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox11" runat="server" Text='<%# Bind("TONGCD") %>'></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:Label ID="lbCPTC" runat="server" Text='<%# Bind("TONGCD","{0:0,0}") %>'></asp:Label>
                </FooterTemplate>
                <HeaderTemplate>
                    <table style="width:100%;">
                        <tr>
                            <td style="text-align: center">
                                TỔNG CỘNG</td>
                        </tr>
                        <tr>
                            <td style="text-align: center">
                                <asp:Label ID="TongCong" runat="server"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label11" runat="server" Text='<%# Bind("TONGCD","{0:0,0}")%>'></asp:Label>
                </ItemTemplate>
                <FooterStyle HorizontalAlign="Right" VerticalAlign="Middle" />
                <ItemStyle HorizontalAlign="Right" VerticalAlign="Middle" Width="100px" />
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="White" ForeColor="#000066" />
        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
        <RowStyle ForeColor="#000066" />
        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#007DBB" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#00547E" />
    </asp:GridView>
            </td>
        </tr>
    </table>
    <br />
    
    </asp:Content>
