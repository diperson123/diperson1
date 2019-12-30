<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="User_Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
  <div class="container">
        <div class="row" style="margin-top:90px;">
            <div class="col-sm-6 col-md-4 col-md-offset-4" style="margin-bottom: 21px; border-color: #ff0000; border: 2px solid; background-color: #4dd0e1;">
                <h1 class="text-center login-title">Login !</h1>
                <div class="account-wall" style="margin-bottom:10px;">
                     <form class="form-login" style="width:75%;padding:10px; ">
                        <asp:TextBox ID="txtUsername" class="form-control" name="username" placeholder="Enter your Username..." runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorUserame" runat="server" ErrorMessage="Please enter your Username !" ForeColor="Red" ControlToValidate="txtUsername" ValidationGroup="a"></asp:RequiredFieldValidator>

                        <asp:TextBox ID="txtPassword" type="password" class="form-control" name="password" placeholder="Enter your Password..." runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" runat="server" ErrorMessage="Please enter your password !" ForeColor="Red" ControlToValidate="txtPassword" ValidationGroup="a"></asp:RequiredFieldValidator>
                        
                        <label style="float:left">

                            <asp:CheckBox ID="ChkRememberMe" runat="server" />
                            
                            Remember Me!			
                        </label>
                        <asp:Button ID="btnLogin" class="btn  btn-primary btn-block" Style="background-color: #808080; color:black;" type="submit" runat="server" Text="Login" ValidationGroup="a" OnClick="btnLogin_Click" />
                        <asp:Label ID="lblError" runat="server"></asp:Label><br />
                                <b><a href="registration.aspx">Don't have account? Create one! </a></b>
              
                          <div>
                 </div>
                       
                    </form>
                </div>
                
               </div>
        </div>
    </div>
</asp:Content>

