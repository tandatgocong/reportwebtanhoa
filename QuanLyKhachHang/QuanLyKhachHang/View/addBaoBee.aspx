<%@ Page Title="" Language="C#" MasterPageFile="~/View/HomePage.Master" AutoEventWireup="true" CodeBehind="addBaoBee.aspx.cs" Inherits="QuanLyKhachHang.View.addBaoBee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 357px;
        }
        .style2
        {
            width: 138px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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



    <table style="width:100%;" border=1>            

            <tr>
                <td class="style3">
                </td>
                <td class="style2">
                    Mã Chi Nhánh :</td>
                <td class="style1">
                    <asp:TextBox ID="txtMaChiNhanh" runat="server" Height="27px" Width="343px"></asp:TextBox>
                </td>
                <td class="style5">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtMaChiNhanh" ErrorMessage="Mã Chi Nhánh Không Được Trống" 
                        ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style3">
                </td>
                <td class="style2">
                    Tên Cửa Hàng :</td>
                <td class="style1">
                    <asp:TextBox ID="txtTenChiNhanh" runat="server" Height="27px" Width="343px"></asp:TextBox>
                </td>
                <td class="style5">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtTenChiNhanh" 
                        ErrorMessage="Tên Cửa Hàng Không Được Trống" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style3">
                </td>
                <td class="style2">
                    Địa Chỉ :</td>
                <td class="style1">
                    <asp:TextBox ID="txtDiaChi" runat="server" Height="27px" Width="343px"></asp:TextBox>
                </td>
                <td class="style5">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="txtDiaChi" ErrorMessage="Địa Chỉ Chi Nhánh Không Được Trống" 
                        ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style9">
                    &nbsp;</td>
                <td class="style2">
                    Loại CH :</td>
                <td class="style1">
                    <asp:TextBox ID="txtLoaiCH" runat="server" Height="27px" Width="343px"></asp:TextBox>
                </td>
                <td class="style11">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style9">
                    &nbsp;</td>
                <td class="style2">
                    Trưng Bày</td>
                <td class="style1">
                    <asp:TextBox ID="txtTrungBay" runat="server" Height="27px" Width="343px"></asp:TextBox>
                </td>
                <td class="style11">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style9">
                    &nbsp;</td>
                <td class="style2">
                    Tần Số</td>
                <td class="style1">
                    <asp:TextBox ID="txtTanSo" runat="server" Height="27px" Width="343px"></asp:TextBox>
                </td>
                <td class="style11">
                     
</td>
            </tr>
            <tr>
                <td class="style9">
                    &nbsp;</td>
                <td class="style2">
                    Số Call</td>
                <td class="style1">
                    <asp:TextBox ID="txtSoCall" runat="server" Height="27px" Width="343px"></asp:TextBox>
                </td>
                <td class="style11">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style9">
                </td>
                <td class="style2">
                    Chủ Cửa Hàng:</td>
                <td class="style1">
                    <asp:TextBox ID="txtChuCuaHang" runat="server" Height="27px" Width="343px"></asp:TextBox>
                </td>
                <td class="style11">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style12">
                </td>
                <td class="style2">
                    </td>
                <td class="style18" colspan="2">
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
                <td class="style15">
                </td>
                <td class="style2">
                    Chọn Hình</td>
                <td class="style1">
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                    <br />
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
                <td class="style9">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td class="style1">
                    <asp:Button ID="btSearch" runat="server" Height="30px"  Text="Thêm Mới" 
                        Width="115px" Font-Bold="True" Font-Names="Times New Roman" 
                        Font-Size="12pt" ForeColor="#663300" onclick="btSearch_Click"  />
                    <input id="Reset1" type="reset" value="Làm Lại" />
                    </td>
                <td class="style11">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style9">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td class="style21" colspan="2">
                    <asp:Label ID="lbThanhCong" runat="server" ForeColor="Blue" Font-Bold="True" 
                        Font-Size="13pt"></asp:Label>
                    </td>
            </tr>
        </table>

</asp:Content>
