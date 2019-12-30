    <%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMasterPage.master" AutoEventWireup="true" CodeFile="ResetPassword.aspx.cs" Inherits="User_ResetPassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="container">
        <h2 style="text-align:center;">Reset Password</h2>
        <div class="col-md-12" style="margin-top:20px;">
            <div class="col-md-offset-1 col-md-2">
                Password:
            </div>
            <div class="col-md-6">
                <asp:TextBox ID="txtPassword" CssClass="form-control" placeholder="Enter new password" type="password" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" ForeColor="Red" runat="server" ErrorMessage="Password Required" ControlToValidate="txtPassword" ValidationGroup="a"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="col-md-12">
            <div class="col-md-offset-1 col-md-2">
                Confirm Password:
            </div>
            <div class="col-md-6">
                <asp:TextBox ID="txtConfirmPassword" CssClass="form-control" placeholder="Retype password" type="password" runat="server"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidatorConfirmPassword" ForeColor="Red" runat="server" ErrorMessage="Password MisMatch" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword" ValidationGroup="a"></asp:CompareValidator>
            </div>
        </div>
        <div>
            <div class="col-md-offset-3">
            <asp:Button ID="btnSubmit"  CssClass="btn btn-success" runat="server" Text="Submit" ValidationGroup="a" OnClick="btnSubmit_Click" />
            </div>
            <div class="col-md-offset-3">
                <asp:Label ID="lblMsg" runat="server"></asp:Label>
            </div>
        </div>

    </div>
</asp:Content>

