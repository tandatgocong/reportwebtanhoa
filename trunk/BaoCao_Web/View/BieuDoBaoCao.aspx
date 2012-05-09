<%@ Page Title="" Language="C#" MasterPageFile="~/View/HomePage.Master" AutoEventWireup="true" CodeBehind="BieuDoBaoCao.aspx.cs" Inherits="BaoCao_Web.View.BieuDoBaoCao" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <script language="javascript" type="text/javascript">
           window.document.getElementById("HOME").className = "top_link";
           window.document.getElementById("DHN").className = "top_link";
           window.document.getElementById("HSKH").className = "top_link";
           window.document.getElementById("BDBC").className = "current_link";
    </script>
<div class="Pages_content">
<div class="title_page"><asp:Label ID="title" runat="server" Text="BIỂU ĐỒ BÁO CÁO "></asp:Label>
</div>

</asp:Content>
