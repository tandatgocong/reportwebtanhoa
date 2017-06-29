<%@ Page Title="" Language="C#" MasterPageFile="~/View/HomePage.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="QuanLyKhachHang.View.Home" %>
 
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<script type="text/javascript">
//    var isMobile = (navigator.userAgent.toLowerCase().indexOf('android') > -1) ||
//      (navigator.userAgent.match(/(iPod|iPhone|iPad|BlackBerry|Windows Phone|iemobile)/));
//    if (isMobile) {
//        var viewport = document.querySelector("meta[name=viewport]");
//        viewport.setAttribute('content', 'initial-scale=1.0, user-scalable=no');
//        document.location.href = "moblie.aspx";
//    }

//    function reFresh() {
//        window.open(location.reload(true))
//    }
//    window.setInterval("reFresh()", 300000);
</script>

<script language="javascript" type="text/javascript">
    window.document.getElementById("HOME").className = "current_link";
    window.document.getElementById("GANMOI").className = "top_link";
    window.document.getElementById("KHACHHANG").className = "top_link";
    window.document.getElementById("APLUC").className = "top_link";
    window.document.getElementById("BAOBE").className = "top_link";
</script>
 

</asp:Content>