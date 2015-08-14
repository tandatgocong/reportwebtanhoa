<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QuanLyDMA_Chart.aspx.cs" Inherits="BaoCao_Web.View.QuanLyDMA_Chart1" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>BIỂU ĐỒ ÁP LỰC NƯỚC </title>
        <script type="text/javascript" src="https://www.google.com/jsapi"></script><!-- linechart "corechart",-->
    <script type="text/javascript">
        google.load("visualization", "1", { packages: ["linechart" ] });
        google.setOnLoadCallback(drawChart);
        function drawChart() {
        
            var data = google.visualization.arrayToDataTable([
         <%=Session["sanluong"] %>
        ]);

            var options = {
                title: 'BIỂU ĐỒ ÁP LỰC NƯỚC',                 
                 height: 680
            };

            var chart = new google.visualization.LineChart(document.getElementById('chart_div'));
            chart.draw(data, options);
        }
    </script>

</head>
<body style="width:100%;">
    <form id="form1" runat="server">
    <p>
        Chọn Ngày&nbsp;
    
     
                    <asp:TextBox ID="txtngay" runat="server" ReadOnly="True"></asp:TextBox>
        <asp:Button ID="chuyengnay0" runat="server" Text="Chọn Ngày" 
            OnClick="Button7_Click" />
        <asp:Button ID="chuyengnay" runat="server" Text="Chuyển Ngày" Visible="False" 
            OnClick="chuyenngay_Click" />
                    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#3366CC"
                        BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana"
                        Font-Size="8pt" ForeColor="#003399" Height="200px" Visible="False" Width="220px" OnSelectionChanged="Calendar1_SelectionChanged">
                        <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                        <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                        <WeekendDayStyle BackColor="#CCCCFF" />
                        <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                        <OtherMonthDayStyle ForeColor="#999999" />
                        <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                        <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                        <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True"
                            Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                    </asp:Calendar>
    </p>
    <div id="chart_div" ></div>
    </form>


</body>
</html>
