<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Menu.aspx.cs" Inherits="Admin_Menu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <%--<form runat="server">--%>
        <div class="container">
           
            <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
                <asp:View ID="View1" runat="server">
                    <div class="container">
                        <div style="margin-bottom: 10px;">
                            <asp:Button ID="btnNew" CssClass="btn btn-default" runat="server" Text="Add New product" OnClick="btnNew_Click" />
                        </div>
                        <div style="margin-left: 3%;">
                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="729px" DataKeyNames="Id" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:BoundField DataField="MenuCategory" HeaderText="Product Category" />
                                    <asp:BoundField DataField="FoodName" HeaderText="Product Name" />
                                    <asp:BoundField DataField="Price" HeaderText="Price" />
                                    <asp:BoundField DataField="Image" HeaderText="Image" />
                                    <asp:CommandField ButtonType="Image" SelectImageUrl="~/InventoryImages/images.jpg" ShowSelectButton="True" />
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

                    </div>

                </asp:View>
                <asp:View ID="View2" runat="server">
                    <div class="col-md-12">

                        <asp:Label ID="lblHeading" runat="server" Text="Add Menu"></asp:Label>
                        <div class="col-md-12">
                            <div class="col-md-2">
                                <asp:Label ID="lblFoodName" runat="server" Text="Product Name"></asp:Label>
                            </div>
                            <div class="col-md-7">
                                <asp:TextBox ID="txtFoodname" placeholder="Enter Product Name" CssClass="form-control" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorFoodname" ControlToValidate="txtFoodname" ForeColor="Red" ValidationGroup="a" runat="server" ErrorMessage="Foodname Required"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="col-md-12">
                            <div class="col-md-2">
                                <asp:Label ID="lblMenuCategory" runat="server" Text="Choose Category"></asp:Label>
                            </div>
                            <div class="col-md-7">
                                <asp:DropDownList ID="ddlMenuCategory" CssClass="form-control" runat="server"></asp:DropDownList>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorMenuCategory" ControlToValidate="ddlMenuCategory" ValidationGroup="a" ForeColor="Red" runat="server" ErrorMessage="Menu Category Required"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="col-md-12">
                            <div class="col-md-2">
                                <asp:Label ID="description" runat="server" Text="Description"></asp:Label>
                            </div>
                            <div class="col-md-7">
                                <asp:TextBox ID="txtDescription" CssClass="form-control" placeholder="Enter description" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorDescription" ControlToValidate="txtDescription" ValidationGroup="a" ForeColor="Red" runat="server" ErrorMessage="Enter Description"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="col-md-12">
                            <div class="col-md-2">
                                <asp:Label ID="lblPrice" runat="server" Text="Price"></asp:Label>
                            </div>
                            <div class="col-md-7">
                                <asp:TextBox ID="txtPrice" CssClass="form-control" placeholder="Enter price" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorPrice" ControlToValidate="txtPrice" ValidationGroup="a" ForeColor="Red" runat="server" ErrorMessage="Price Required"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="col-md-12">
                            <div class="col-md-2">
                                <asp:Label ID="lblImage" runat="server" Text="Image"></asp:Label>
                            </div>
                            <div class="col-md-7">
                                <asp:FileUpload ID="FileUploadImage" CssClass="form-control" runat="server" />
                                <asp:Label ID="lblImageName" runat="server" Text=""></asp:Label>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1Image" ControlToValidate="FileUploadImage" ValidationGroup="a" ForeColor="Red" runat="server" ErrorMessage="Image Required"></asp:RequiredFieldValidator>                               
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="fileuploadImage" ValidationGroup="a" ForeColor="Red" ErrorMessage="Only .jpg,.png,.jpeg,.gif Files are allowed" Font-Bold="True" Font-Size="Medium" ValidationExpression="(.*?)\.(jpg|jpeg|png|gif|JPG|JPEG|PNG|GIF)$"></asp:RegularExpressionValidator>
                            </div>
                        </div>
                        <div class="col-md-12">
                            <asp:Literal ID="ltlMsg" runat="server"></asp:Literal>
                        </div>
                        <div class="col-md-12">
                            <asp:HiddenField ID="HiddenField1" runat="server" />
                        </div>

                        <div class="col-md-12">
                            <div class="col-md-1">
                                <asp:Button ID="btnSubmit" CssClass="btn btn-success" ValidationGroup="a" runat="server" Text="Save" OnClick="btnSubmit_Click" />
                            </div>
                            <div class="col-md-1">
                                <asp:Button ID="btnDelete" CssClass="btn btn-danger" runat="server" Text="Delete" OnClick="btnDelete_Click" />
                            </div>
                            <div class="col-md-1">
                                <asp:Button ID="btnCancel" CssClass="btn btn-success" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
                            </div>
                        </div>

                    </div>

                </asp:View>
            </asp:MultiView>



        </div>

    <%--</form>--%>

</asp:Content>

