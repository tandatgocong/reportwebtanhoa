﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mobile.aspx.cs" Inherits="QuanLyKhachHang.View.mobile" %>
<html>
<body>
<p>Kích vào button để lấy toạ độ của bạn</p>

<button onclick="getLocation()">Lấy vị trí</button>

<p id="demo"></p>

<script>
    var x = document.getElementById("demo");

    function getLocation() {
        if (navigator.geolocation) {
            navigator.geolocation.getCurrentPosition(showPosition);
        } else {
            x.innerHTML = "Geolocation không được hỗ trợ bởi trình duyệt này.";
        }
    }

    function showPosition(position) {
        x.innerHTML = "Vĩ độ: " + position.coords.latitude +
"<br>Kinh độ: " + position.coords.longitude;
    }
</script>

</body>
</html>
