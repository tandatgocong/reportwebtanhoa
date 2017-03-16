<%@ Page Title="" Language="C#" MasterPageFile="~/View/HomePage.Master" AutoEventWireup="true" CodeBehind="addBaoBee.aspx.cs" Inherits="QuanLyKhachHang.View.addBaoBee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style3
        {
        }
        .style4
        {
            width: 43px;
            height: 26px;
        }
        .style5
        {
            width: 138px;
            height: 22px;
        }
        .style6
        {
            width: 536px;
            height: 26px;
        }
        .style7
        {
            width: 138px;
            height: 26px;
        }
        .style11
        {
            width: 102px;
        }
        .style12
        {
            width: 43px;
            height: 24px;
        }
        .style14
        {
            width: 536px;
            height: 24px;
        }
        .style17
        {
            width: 1055px;
        }
        .style25
        {
            width: 536px;
        }
        .style27
        {
            width: 1203px;
        }
        .style30
        {
            height: 31px;
        }
        .style32
        {
            width: 536px;
            height: 31px;
        }
        .style33
        {
            width: 138px;
            height: 31px;
        }
        .style37
        {
            width: 102px;
            height: 36px;
        }
        .style38
        {
            height: 36px;
        }
        .style40
        {
            width: 536px;
            height: 36px;
        }
        .style41
        {
            height: 37px;
        }
        .style43
        {
            width: 536px;
            height: 37px;
        }
        .style44
        {
            width: 102px;
            height: 37px;
        }
        .style45
        {
            height: 38px;
        }
        .style47
        {
            width: 536px;
            height: 38px;
        }
        .style48
        {
            width: 102px;
            height: 38px;
        }
        .style49
        {
            width: 138px;
            height: 24px;
        }
        .style50
        {
            height: 34px;
        }
        .style52
        {
            width: 536px;
            height: 34px;
        }
        .style53
        {
            width: 102px;
            height: 34px;
        }
        .style54
        {
            height: 40px;
        }
        .style56
        {
            width: 536px;
            height: 40px;
        }
        .style57
        {
            width: 102px;
            height: 40px;
        }
        .style58
        {
            height: 234px;
        }
        .style59
        {
            width: 603px;
            height: 234px;
        }
        .style60
        {
            width: 1203px;
            height: 234px;
        }
        .style61
        {
            width: 128px;
        }
        .style62
        {
            width: 53px;
        }
        .style63
        {
            width: 603px;
            height: 24px;
        }
        .style64
        {
            width: 603px;
        }
        .style65
        {
            width: 603px;
            height: 31px;
        }
        .style66
        {
            width: 603px;
            height: 36px;
        }
        .style67
        {
            width: 603px;
            height: 37px;
        }
        .style68
        {
            width: 603px;
            height: 38px;
        }
        .style69
        {
            width: 603px;
            height: 34px;
        }
        .style70
        {
            width: 603px;
            height: 40px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="map" style="width: 100%; height: 900px;">
<script language="javascript" type="text/javascript">
    window.document.getElementById("HOME").className = "top_link";
    window.document.getElementById("GANMOI").className = "top_link";
    window.document.getElementById("KHACHHANG").className = "top_link";
    window.document.getElementById("APLUC").className = "top_link";
    window.document.getElementById("BAOBE").className = "current_link";
    </script>
     <script type="text/javascript">
         function removeElement(divNum) {
             var d = document.getElementById('attach_file');
             var olddiv = document.getElementById(divNum);
             d.removeChild(olddiv);
         }

         var fileFieldCount = 0;
         function addFileField() {
             if (fileFieldCount >= 9) return false
             fileFieldCount++;
             var f = document.createElement("input");
             f.id = "theFile" + fileFieldCount;
             f.type = "file";
             f.size = 120;
             f.name = "theFile" + fileFieldCount;
             p = document.getElementById("attachments_fields");
             p.appendChild(document.createElement("br"));
             p.appendChild(f);
         }
      </script>


      
    <table class='table_list' style="width:100%;">           

            <tr  >
                <td class="style3">
                    &nbsp;</td>
                <td class="style3" colspan="3">
                    <div class="title_page">
                        THÔNG TIN ĐỂM BỂ
                    </div>
                </td>
                <td class="style5">
                    &nbsp;</td>
            </tr>

            <tr   >
                <td class="style12">
                </td>
                <td class="style12">
                    </td>
                <td class="style63" style="border-bottom: 1px #99cc99 solid"  >
                   <asp:Label ID="Label1" runat="server" Text=" Địa Chỉ Báo Bể :"></asp:Label>
                </td>
                <td class="style14" style="border-bottom: 1px #99cc99 solid">
                    <asp:Label ID="lbDiaChi" runat="server" Font-Bold="True" Font-Italic="False"></asp:Label>
                </td>
                <td class="style49">
                    <asp:Label ID="lbID" runat="server"></asp:Label>
                </td>
            </tr>

            <tr>
                <td class="style4">
                </td>
                <td class="style4">
                    &nbsp;</td>
                <td class="style64" style="border-bottom: 1px #99cc99 solid">
                   <asp:Label ID="Label2" runat="server" Text=" Ngày Báo Bể :"></asp:Label>
                </td>
                <td class="style6" style="border-bottom: 1px #99cc99 solid">
                    <asp:Label ID="lbNgayBaoBe" runat="server" Font-Bold="True"></asp:Label>
                </td>
                <td class="style7">
                    </td>
            </tr>
            <tr>
                <td class="style3">
                </td>
                <td class="style3">
                    &nbsp;</td>
                <td class="style64" style="border-bottom: 1px #99cc99 solid">
                    <asp:Label ID="Label3" runat="server" Text="Ghi Chú Báo Bể :"></asp:Label>
                </td>
                <td class="style25" style="border-bottom: 1px #99cc99 solid">
                    <asp:Label ID="lbGhiChuBB" runat="server" Font-Bold="True"></asp:Label>
                </td>
                <td class="style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td class="style3" colspan="3">
                    <div class="title_page">
                        THÔNG TIN HOÀN CÔNG ĐIỂM BỂ
                    </div>
                </td>
                <td class="style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style30">
                </td>
                <td class="style30">
                    </td>
                <td class="style65" style="border-bottom: 1px #99cc99 solid">
                    <asp:Label ID="Label4" runat="server" 
                        Text="Ngày Giao Sửa Bể"></asp:Label>
                </td>
                <td class="style32" style="border-bottom: 1px #99cc99 solid">
                    <asp:TextBox ID="txtDate" runat="server" TextMode="Date" />
                </td>
                <td class="style33">
                    </td>
            </tr>
            <tr>
                <td class="style38">
                    </td>
                <td class="style38">
                    </td>
                <td class="style66" style="border-bottom: 1px #99cc99 solid">
                    <asp:Label ID="Label6" runat="server" 
                        Text="Loại Sửa Bể :"></asp:Label>
                </td>
                <td class="style40" style="border-bottom: 1px #99cc99 solid">
                    <asp:DropDownList ID="cbLoaiSB" runat="server" Height="30px" Width="113px">
                        <asp:ListItem Selected="True" Value="1">Hoàn Thiện</asp:ListItem>
                        <asp:ListItem Value="2">Sửa Tạm</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="style37">
                    </td>
            </tr>
            <tr>
                <td class="style41">
                    </td>
                <td class="style41">
                    </td>
                <td class="style67" style="border-bottom: 1px #99cc99 solid">
                    <asp:Label ID="Label5" runat="server" 
                        Text="Ngày Thực Hiện :"></asp:Label>
                </td>
                <td class="style43" style="border-bottom: 1px #99cc99 solid">
                    <table cellpadding="0" border="0" cellpadding="0" style="width:100%;" >
                        <tr>
                            <td class="style61">
                    <asp:TextBox ID="dataThucHienTN" runat="server" TextMode="DateTimeLocal" />
                            </td>
                            <td class="style62">
                    <asp:Label ID="Label12" runat="server" 
                        Text="đến ngày"></asp:Label>
                            </td>
                            <td>
                    <asp:TextBox ID="dateTNden" runat="server" TextMode="DateTimeLocal" />
                            </td>
                        </tr>
                    </table>
                </td>
                <td class="style44">
                    </td>
            </tr>
            <tr>
                <td class="style45">
                    </td>
                <td class="style45">
                    </td>
                <td class="style68" style="border-bottom: 1px #99cc99 solid">
                    <asp:Label ID="Label7" runat="server" 
                        Text="Ghi Chú Thực Hiện"></asp:Label>
                </td>
                <td class="style47" style="border-bottom: 1px #99cc99 solid">
                    <asp:TextBox ID="txtGhiChuSuaBe" runat="server" Height="27px" Width="343px"></asp:TextBox>
                </td>
                <td class="style48">
                     
</td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
                <td class="style64" style="border-bottom: 1px #99cc99 solid">
                    <asp:Label ID="Label8" runat="server" 
                        Text="Nhân Viên Sửa Bể :"></asp:Label>
                </td>
                <td class="style25" style="border-bottom: 1px #99cc99 solid">                    <asp:TextBox ID="txtNVSua" runat="server" 
                        Height="27px" Width="343px"></asp:TextBox>
                
                 <asp:Panel ID="Panel2" runat="server" ScrollBars="Horizontal" Height="80px">
                    <asp:CheckBoxList ID="checkNVSua" runat="server" 
                         Font-Overline="False" Font-Strikeout="False" 
                        Height="75px" Width="283px" AutoPostBack="True" 
                         onselectedindexchanged="checkNVSua_SelectedIndexChanged">
                    </asp:CheckBoxList>
                    </asp:Panel>
                </td>
                <td class="style11">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                </td>
                <td class="style3">
                    &nbsp;</td>
                <td class="style64" style="border-bottom: 1px #99cc99 solid">
                    <asp:Label ID="Label9" runat="server" 
                        Text="Nhân Viên Giám Sát"></asp:Label>
                </td>
                <td class="style25" style="border-bottom: 1px #99cc99 solid">
                                    <asp:TextBox ID="txtNVGS" runat="server" Height="27px" Width="343px"></asp:TextBox>
                
                    <asp:Panel ID="Panel1" runat="server" ScrollBars="Horizontal" Height="77px">
                        <asp:CheckBoxList ID="checkNVGS" runat="server" 
                         Font-Overline="False" Font-Strikeout="False" 
                        Height="74px" Width="282px" 
                            onselectedindexchanged="checkNVGS_SelectedIndexChanged" 
                            AutoPostBack="True">
                        </asp:CheckBoxList>
                    </asp:Panel>
                </td>
                <td class="style11">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style50">
                    </td>
                <td class="style50">
                    </td>
                <td class="style69" style="border-bottom: 1px #99cc99 solid">
                    <asp:Label ID="Label11" runat="server" 
                        Text="File Hoàn Công :"></asp:Label>
                </td>
                <td class="style52" style="border-bottom: 1px #99cc99 solid">
                    <asp:FileUpload ID="FileUpload2" runat="server" />
                    <asp:Button ID="Button3" runat="server" 
                        Text="Upload" onclick="btUploag" ValidationGroup="adsfdsafd" />
                    <br />
                    <asp:HiddenField ID="FilePath" runat="server" />
                </td>
                <td class="style53">
                    <asp:Label ID="uploadfile" runat="server" ForeColor="Black"></asp:Label>
                    </td>
            </tr>
            <tr>
                <td class="style58">
                </td>
                <td class="style58">
                    </td>
                <td class="style59">
                    <asp:Label ID="Label10" runat="server" 
                        Text="Hình Sửa Bể :"></asp:Label>
                    </td>
                <td class="style60" colspan="2">
                    <asp:Image ID="imgFile" runat="server" Height="208px" 
                        Width="349px" Visible="False" />
                    <div class="criteria_scroll">
                        <%
                    string filelis = Session["imgfile"].ToString();
                    string[] words = Regex.Split(filelis, ",");
                    for (int i = 0; i < words.Length; i++)
                    {
                        if (!words[i].Equals("")) {
                            Response.Write("<img  src=" + words[i] + " Height='100px' Width='200px' /> ");
                        }
                         
                    }
                  %>
                    </div>
                </td>
            </tr>
            <tr>
                <td class="style3">
                </td>
                <td class="style3">
                    &nbsp;</td>
                <td class="style64">
                    Chọn Hình</td>
                <td class="style25">
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                    <asp:Button ID="Button1" runat="server" 
                        Text="Upload" onclick="Button1_Click" ValidationGroup="adsfdsafd" />
                    <asp:Button ID="Button2" runat="server" 
                        Text="Clear" onclick="Button2_Click1" ValidationGroup="adsfdsafd" />
                    <asp:HiddenField ID="imagePath" runat="server" />
                </td>
                <td class="style17">
                    <asp:Label ID="upload" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style54">
                    </td>
                <td class="style54">
                    </td>
                <td class="style70">
                    </td>
                <td class="style56">
                    <asp:Button ID="btSearch" runat="server" Height="30px"  Text="CẬP NHẬT" 
                        Width="115px" Font-Bold="True" Font-Names="Times New Roman" 
                        Font-Size="12pt" onclick="btSearch_Click" CssClass="button"  />
                    &nbsp;<asp:Button ID="btSearch0" runat="server" Height="30px"  Text="TRỞ LẠI" 
                        Width="115px" Font-Bold="True" Font-Names="Times New Roman" 
                        Font-Size="12pt" onclick="btTrolai" CssClass="button"  />
                    </td>
                <td class="style57">
                    </td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
                <td class="style64">
                    &nbsp;</td>
                <td class="style27" colspan="2">
                    <asp:Label ID="lbThanhCong" runat="server" ForeColor="Blue" Font-Bold="True" 
                        Font-Size="13pt"></asp:Label>
                    </td>
            </tr>
        </table>
</div>
</asp:Content>
