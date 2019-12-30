<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMasterPage.master" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="User_SignUp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
     <div class="container">
        <div class="col-md-offset-2 col-md-8">
            <div class="panel panel-primary" style="margin-top: 100px;">
                <div class="panel-heading" style="color: #171616; background-color: #808080; border-color: #337ab7; text-align: center;">
                    <h2>Registration Page</h2>
                    
                </div>

                <div class="panel-body" style="background-color: #808080;">
                    <asp:Label ID="lblMsg" runat="server"></asp:Label>
                    <div class="col-md-offset-1 col-md-9">
                        <div class="form-group">
                            <label for="username"><span class="req">* </span>Desired UserName:  </label>
                            <asp:TextBox ID="txtUsername" CssClass="form-control" placeholder="Enter Username..." runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter username !" ForeColor="Red" ControlToValidate="txtUsername" ValidationGroup="a"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            <label for="txtPhone"><span class="req">* </span>Phone Number: </label>
                            <asp:TextBox ID="txtPhone" CssClass="form-control" name="phonenumber" placeholder="Enter phone number..." runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorPhone" runat="server" ErrorMessage="Please enter phone number!" ForeColor="Red" ControlToValidate="txtPhone" ValidationGroup="a"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            <label for="txtEmail"><span class="req">* </span>Email Address: </label>
                            <asp:TextBox ID="txtEmail" CssClass="form-control" name="email" placeholder="Enter email" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server" ErrorMessage="Please enter valid email address..." ForeColor="Red" ControlToValidate="txtEmail" ValidationGroup="a"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server" ErrorMessage="Invalid Email !" ForeColor="Red" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="a"></asp:RegularExpressionValidator>
                        </div>
                        <div class="form-group">
                            <label for="password"><span class="req">* </span> Desired Password: </label>
                            <asp:TextBox ID="txtPassword" type="password" CssClass="form-control" name="password" placeholder="Enter password" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" runat="server" ErrorMessage="Please enter password !" ForeColor="Red" ControlToValidate="txtPassword" ValidationGroup="a"></asp:RequiredFieldValidator>
                        </div>
                        <div>
                            <label for="txtConfirmPassword"><span class="req">* </span>Re-Enter Password: </label>
                            <asp:TextBox ID="txtConfirmPassword" type="password" CssClass="form-control" name="confirmpassword" placeholder="Re-enter your password..." runat="server"></asp:TextBox>
                            <asp:CompareValidator ID="CompareValidatorPassword" runat="server" ErrorMessage="password didnot match !" ForeColor="Red" ControlToValidate="txtConfirmPassword" ControlToCompare="txtPassword" ValidationGroup="a"></asp:CompareValidator>
                        </div>
                    </div>
                    <div class="col-md-12 form-group">
                        <label for="terms"><input type="checkbox" name="terms" />I agree with the <a data-toggle="modal" data-target="#myModal">terms and conditions</a> for Registration.</label><span class="req">* </span>
                    </div>                    
                    <div class="col-md-12 form-group">
                        <asp:Button ID="btnRegister" class="btn btn-success" style="background-color: silver; border-color: #000000; color:black;" type="submit" runat="server" Text="Register" ValidationGroup="a" OnClick="btnRegister_Click" />
                    </div>
                    <div class="col-md-12">
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </div>

                </div>
            </div>
        </div>
    </div>
    <!-- Trigger the modal with a button -->

<!-- Modal -->
<div id="myModal" class="modal fade" role="dialog">
  <div class="modal-dialog">

    <!-- Modal content-->
    <div class="modal-content">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal">&times;</button>
        <h4 class="modal-title">Terms and Condition</h4>
      </div>
      <div class="modal-body">
        <p>
            It is vital for you to have terms and conditions set in place to display limitations on what can and cannot be done with your website, mobile application or product. It also specifies expectation boundaries on your users' side and can protect you from being sued if there's a disagreement between you and a user.
        </p>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
      </div>
    </div>

  </div>
</div>
</asp:Content>

