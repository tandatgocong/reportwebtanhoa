<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="tabThongKeDHN.ascx.cs" Inherits="BaoCao_Web.View.tabDHN.tabThongKeDHN" %>
<div class="block block_left events" style="width: 160px;">
 	<h3>THỐNG KÊ CỞ ĐHN </h3>
	<div class="block_content">
        <asp:GridView ID="DONGHONUOC" runat="server" AutoGenerateColumns="False" 
            BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" 
            CellPadding="4" ShowFooter="True" style="text-align: right" 
            onrowdatabound="DONGHONUOC_RowDataBound">
            <Columns>
                <asp:BoundField DataField="CODH" HeaderText="CỞ ĐHN">
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:TemplateField HeaderText="SỐ LƯỢNG">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("SODH") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:Label ID="lbSum" runat="server" Text="Label"></asp:Label>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("SODH","{0:0,0}")  %>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Right" VerticalAlign="Middle" />
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
 	</div>
    <h3> NĂM GẮN ĐHN </h3>
    <div class="block_content">
        <asp:GridView ID="NAMGAN" runat="server" AutoGenerateColumns="False" 
            BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" 
            CellPadding="4" ShowFooter="True" style="text-align: right" 
            onrowdatabound="NAMGAN_RowDataBound">
            <Columns>
                <asp:BoundField DataField="NGAYTHAY" HeaderText="NĂM GẮN">
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:TemplateField HeaderText="SỐ LƯỢNG">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("SODH") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:Label ID="lbSum" runat="server" Text="Label"></asp:Label>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("SODH","{0:0,0}")  %>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Right" VerticalAlign="Middle" />
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
 	</div>
</div>
<P />
<div class="block block_left events" style="width: 150px; float:left;">
 	
	
</div>

