<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="tab_BieuDoSanLuong.ascx.cs" Inherits="BaoCao_Web.View.tabBieuDo.tab_BieuDoSanLuong" %>
<html>
  <head>
    <script type="text/javascript" src="https://www.google.com/jsapi"></script>
    <script type="text/javascript">
        google.load("visualization", "1", { packages: ["corechart"] });
        google.setOnLoadCallback(drawChart);
        function drawChart() {
        
            var data = google.visualization.arrayToDataTable([
         <%=Session["sanluong"] %>
        ]);

            var options = {
                title: 'Company Performance',
                 width: 800, 
                height: 480, 
            };

            var chart = new google.visualization.LineChart(document.getElementById('chart_div'));
            chart.draw(data, options);
        }
    </script>
  </head>
  <body>
    <div id="chart_div" style="width: 900px; height: 500px;"></div>
  </body>
</html>