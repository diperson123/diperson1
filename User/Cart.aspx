<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMasterPage.master" AutoEventWireup="true" CodeFile="Cart.aspx.cs" Inherits="User_Cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div style="margin-top: 180px; margin-left: 106px;">
        <h1>Cart</h1>
        <asp:GridView ID="GridView1" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" Width="795px" AutoGenerateColumns="False">
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
            <Columns>
                <asp:BoundField DataField="MenuId" HeaderText="MenuId" Visible="True" />
                <asp:TemplateField HeaderText="Image">
                    <ItemTemplate>
                        <asp:Image ID="Image1" ImageUrl='<%#"~/MenuImages/" + Eval("image")%>' Height="75PX" Width="75PX" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="foodname" HeaderText="Product Name" />
                <asp:BoundField DataField="price" HeaderText="Price" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                <asp:BoundField DataField="Total" HeaderText="Total" />
                <asp:TemplateField HeaderText="Action">
                    <ItemTemplate>
                        <%--<asp:Button ID="btnEdit" ToolTip="Edit" CommandArgument='<%# Eval("Id") %>' runat="server" OnClick="EditQuantity"  Text="remove" />--%>                   
                        <asp:Button ID="btnRemove" ToolTip="remove" CommandArgument='<%# Eval("Id") %>' runat="server" OnClick="removeItem"  Text="remove" />                   
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="Tan" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />    
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <SortedAscendingCellStyle BackColor="#FAFAE7" />
            <SortedAscendingHeaderStyle BackColor="#DAC09E" />
            <SortedDescendingCellStyle BackColor="#E1DB9C" />
            <SortedDescendingHeaderStyle BackColor="#C2A47B" />
        </asp:GridView>
        <asp:Button ID="btnPurchase" CssClass="btn btn-success"  runat="server" OnClick="PurchaseAllItem_Click" Text="Purchase" />
        <asp:Label ID="lblMsg" Font-Size="Large" Text="" runat="server" />
    </div>
</asp:Content>

