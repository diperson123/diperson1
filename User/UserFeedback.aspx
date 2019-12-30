<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMasterPage.master" AutoEventWireup="true" CodeFile="UserFeedback.aspx.cs" Inherits="User_UserFeedback" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            position: relative;
            min-height: 1px;
            top: 28px;
            left: 33px;
            width: 75%;
            float: left;
            padding-left: 15px;
            padding-right: 15px;
            background-color: #808080;
        }
        .auto-style2 {
            position: relative;
            min-height: 1px;
            top: 28px;
            left: 33px;
            width: 75%;
            float: left;
            padding-left: 15px;
            padding-right: 15px;
            background-color: #808080;
        }
        .auto-style3 {
            position: relative;
            min-height: 1px;
            top: 28px;
            left: 33px;
            width: 75%;
            float: left;
            padding-left: 15px;
            padding-right: 15px;
            background-color: #808080;
            
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
  
        <div class="container-contact" >
             
            <div class="row" >
                
                <div class="col-md-8">
                    <div class="well well-sm" style="margin-top: 0px">
                        <div class="row">
                           
                            <div class="auto-style1">
                                 <h1 style="font-size:20px;"><b>Please provide us your valuable feedbacks !</b></h1>
                                <div class="form-group">
                                    <label for="name">UserName</label>
                                     <asp:TextBox ID="txtUsername" CssClass="form-control"  runat="server" placeholder="Enter your Name..."></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label for="Email">
                                        Email </label>
                                    <div class="input-group">
                                        <span class="input-group-addon"><span class="glyphicon glyphicon-envelope"></span>
                                        </span>
                                           <asp:TextBox ID="txtEmail" CssClass="form-control"  runat="server" placeholder="Enter your Email..."></asp:TextBox>
                                 </div>
                                </div>
                                <div class="form-group">
                                    
                                                            </div>
                            </div>
                            <div class="auto-style2">
                                <div class="form-group">
                                    <label for="name"> Message</label>
                                   <asp:Textbox Rows="3"  id="txtmessage" class="form-control"  runat="server"  placeholder="Enter your Messege..."></asp:Textbox>
                                </div>
                            </div>
                            <div class="auto-style3" >
                                 <asp:Button ID="btncontactus" runat="server" Text="Send" CssClass="btn btn-primary pull-right" OnClick="btncontactus_Click" Width="110px"  />
                            </div>
                        </div>

                        <asp:Literal ID="ltrmsg" runat="server"></asp:Literal>

                    </div>
                </div>
                
            </div>
        </div>
    </div>
</asp:Content>

