<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="MenuCategory.aspx.cs" Inherits="Admin_MenuCategory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
        <div class="container">
            <h2>
                <asp:Label ID="lblHeading" runat="server" Text="Product Categories"></asp:Label>
            </h2>
            <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
                <asp:View ID="View1" runat="server">
                    <div>
                        <asp:Button ID="txtNew" CssClass="btn btn-default" Style="margin-bottom: 20px;" runat="server" Text="Add New Category" OnClick="txtNew_Click" />
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Id" ForeColor="#333333" GridLines="None" Width="659px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:BoundField DataField="MenuCategory" HeaderText="Category Name" />
                                <asp:CommandField SelectImageUrl="~/InventoryImages/images.jpg" ShowSelectButton="True" ButtonType="Image" />
                            </Columns>
                            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="gray" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                            <SortedAscendingCellStyle BackColor="#FDF5AC" />
                            <SortedAscendingHeaderStyle BackColor="#4D0000" />
                            <SortedDescendingCellStyle BackColor="#FCF6C0" />
                            <SortedDescendingHeaderStyle BackColor="#820000" />
                        </asp:GridView>
                    </div>
                </asp:View>
                <asp:View ID="View2" runat="server">
                    <div class="col-md-12">
                        <div class="col-md-2">
                            <asp:Label ID="lblCategoryName" runat="server" Text="Category Name" />
                        </div>
                        <div class="col-md-7">
                            <asp:TextBox ID="txtCategoryName" runat="server" class="form-control" placeholder="enter category name"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorCategoryName" ControlToValidate="txtCategoryName" ForeColor="Red" ValidationGroup="a" runat="server" ErrorMessage="Category Name required"></asp:RequiredFieldValidator>
                        </div>
                        <div>
                            <asp:HiddenField ID="HiddenField1" runat="server" />
                        </div>
                    </div>
                    <div class="col-md-12">
                        <div class="col-md-1">
                            <asp:Button ID="btnSubmit" runat="server" CssClass="btn btn-success" OnClick="btnSubmit_Click" Text="Save" ValidationGroup="a" />
                        </div>
                        <div class="col-md-1">
                            <asp:Button ID="btnCancel" runat="server" CssClass="btn btn-success" OnClick="btnCancel_Click" Text="Cancel" />
                        </div>
                        <div class="col-md-1">
                            <asp:Button ID="btnDelete" runat="server" CssClass="btn btn-danger" Text="Delete" OnClick="btnDelete_Click" />
                        </div>
                    </div>
                    <div class="col-md-12">
                        <asp:Literal ID="ltlMsg" runat="server"></asp:Literal>
                    </div>
                </asp:View>
            </asp:MultiView>
        </div>
</asp:Content>

