<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMasterPage.master" AutoEventWireup="true" CodeFile="ForgotPassword.aspx.cs" Inherits="User_ForgotPassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container">
   
             <div style="margin-bottom: 10px;">
            <h2>Forgot Password
            </h2>
        </div>
        <div>
            <div class="col-md-4">
                <asp:TextBox ID="txtForgotPassword" CssClass="form-control" runat="server" placeholder="Enter Email.."></asp:TextBox>
            </div>
            <div class="col-md-3">
                <asp:Button ID="btnForgotPassword" CssClass="btn btn-primary" runat="server" Text="Submit" ValidationGroup="a" OnClick="btnForgotPassword_Click" />
            </div>
        </div>
        <div>
            <asp:Label ID="lblMsg" runat="server" Text="Label"></asp:Label>

            <div class="col-md-4">
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorForgotPassword" runat="server" ErrorMessage="Please Enter the Email" ControlToValidate="txtForgotPassword" ValidationGroup="a"></asp:RequiredFieldValidator>
            </div>
        </div>
      
       
    </div>
</asp:Content>

