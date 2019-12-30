<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="ManageUsers.aspx.cs" Inherits="Admin_ManageUsers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
        <asp:View ID="View1" runat="server">
            <asp:Button ID="Button1" CssClass="btn btn-default" style="margin-bottom:10px; background-color: gray;" OnClick="showForm_click" runat="server" Text="Add New User" />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="677px" DataKeyNames="Id" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None">

                <AlternatingRowStyle BackColor="White" />

                <Columns>
                    <asp:BoundField DataField="Username" HeaderText="UserName" />
                    <asp:BoundField DataField="Phone" HeaderText="Phone" />
                    <asp:BoundField DataField="Email" HeaderText="Email" />
                    <asp:BoundField DataField="UserType" HeaderText="UserType" />
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
        </asp:View>
        <asp:View ID="View2" runat="server">
            <div class="container">
        <div class="col-md-offset-2 col-md-8">
            <div class="panel panel-primary" style="margin-top: 100px;">
                <div class="panel-heading" style="color: #171616; background-color: #ffff00; border-color: #337ab7; text-align: center;">
                    <h2>Registration</h2>
                    <h3 class="panel-title">Valid information is required to register. <span class="req"><small>required *</small></span></h3>
                </div>

                <div class="panel-body">
                    <asp:Label ID="lblMsg" runat="server"></asp:Label>
                    <div class="col-md-offset-1 col-md-9">
                        <div class="form-group">
                            <label for="username"><span class="req">* </span>User name:  <small>This will be your login user name</small> </label>
                            <asp:TextBox ID="txtUsername" CssClass="form-control" placeholder="Enter Username" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter username" ForeColor="Red" ControlToValidate="txtUsername" ValidationGroup="a"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            <label for="txtPhone"><span class="req">* </span>Phone Number: </label>
                            <asp:TextBox ID="txtPhone" CssClass="form-control" name="phonenumber" placeholder="Enter phone number" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorPhone" runat="server" ErrorMessage="Please enter phone number" ForeColor="Red" ControlToValidate="txtPhone" ValidationGroup="a"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            <label for="txtEmail"><span class="req">* </span>Email Address: </label>
                            <asp:TextBox ID="txtEmail" CssClass="form-control" name="email" placeholder="Enter email" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server" ErrorMessage="Please enter valid email address" ForeColor="Red" ControlToValidate="txtEmail" ValidationGroup="a"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server" ErrorMessage="Invalid Email" ForeColor="Red" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="a"></asp:RegularExpressionValidator>
                        </div>
                        <div class="form-group">
                            <label for="password"><span class="req">* </span>Password: </label>
                            <asp:TextBox ID="txtPassword" type="password" CssClass="form-control" name="password" placeholder="Enter password" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" runat="server" ErrorMessage="Please enter password" ForeColor="Red" ControlToValidate="txtPassword" ValidationGroup="a"></asp:RequiredFieldValidator>
                        </div>
                        <div>
                            <label for="txtConfirmPassword"><span class="req">* </span>Password Confirm: </label>
                            <asp:TextBox ID="txtConfirmPassword" type="password" CssClass="form-control" name="confirmpassword" placeholder="Confirm your password" runat="server"></asp:TextBox>
                            <asp:CompareValidator ID="CompareValidatorPassword" runat="server" ErrorMessage="Password Mismatch" ForeColor="Red" ControlToValidate="txtConfirmPassword" ControlToCompare="txtPassword" ValidationGroup="a"></asp:CompareValidator>
                        </div>
                        <div style="margin-bottom:10px;">
                             <label for="lblUserType"><span class="req">* </span>Choose User: </label>
                            <asp:TextBox ID="txtUserType" CssClass="form-control" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorusertype" ControlToValidate="txtUserType" ValidationGroup="a" ForeColor="Red" runat="server" ErrorMessage="User type Required"></asp:RequiredFieldValidator>
                        </div>
                    </div>                                      
                    <div class="col-md-12 form-group">
                        <asp:Button ID="btnRegister" class="btn btn-success" style="background-color: #ffff00; border-color:none; color:black;" type="submit" runat="server" Text="New Users" ValidationGroup="a" OnClick="AddNewUsers" />
                        <asp:Button ID="btnDelete" class="btn btn-success" style="background-color: #ffff00; border-color:none; color:black;" runat="server" Text="Delete" OnClick="deleteUsers" />
                        <asp:Button ID="btnCancel" class="btn btn-success" style="background-color: #ffff00; border-color:none; color:black;" runat="server" Text="Cancel" OnClick="cancelForm" />
                    </div>
                    <asp:HiddenField ID="HiddenField1" runat="server" />
                    <div class="col-md-12">
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </div>

                </div>
            </div>
        </div>
    </div>
        </asp:View>
    </asp:MultiView>
  
    </asp:Content>

