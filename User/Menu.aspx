<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMasterPage.master" AutoEventWireup="true" CodeFile="Menu.aspx.cs" Inherits="User_Menu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    
        <div class="container">
  <h2>Choose Your Product Category below !</h2>
  <div class="panel panel-default">
    <div class="panel-heading" style="padding-left:2px;font-size:25px;background-color: #4dd0e1;text-align:center;text-decoration:solid;">Choose Your Product Category below !</div>
   
  </div>


        
        <hr />
        <div class="container">
            <asp:Repeater ID="rptrCategory" runat="server">
                <HeaderTemplate>
                    <ul id="filter" class="hide-for-small">
                </HeaderTemplate>
                <ItemTemplate>
                    <lu>
                        <asp:Button ID="menuCategoryId" CommandArgument='<%#Bind("Id") %>' runat="server" UseSubmitBehavior="false" OnClick="menuCategoryId_Click" Text='<%# Eval("MenuCategory") %>' />
                    </lu>
                </ItemTemplate>
                <FooterTemplate>
                    </ul>
                </FooterTemplate>
            </asp:Repeater>
            <div class="ci-menus-container ci-menu-cols-3">
                        <asp:Repeater ID="RptrMenu" runat="server">
                    <HeaderTemplate>
                       
                    </HeaderTemplate>
                    <ItemTemplate>
                            <div class="col-md-6" style="padding: 20px;">
                            <a class="ci-meal-thumb-link ci-fancybox" title="<%# Eval("Foodname") %> – $<%# Eval("Price") %>">
                                <img id="Img1" src='<%# "~/MenuImages/" + Eval("image") %>' alt='<%#Eval("image") %>' style="width: 430px; height: 350px;" runat="server" />
                            </a>
                            <a title="Salad Ruccula – $14.95">
                                <h6><%# Eval("Foodname") %> – RS.<%# Eval("price") %></h6>
                            </a>    
                            <p><%# Eval("description") %></p>
                            <p>
                                <a href='<%# "MenuDisplay.aspx?id="+Eval("Id") %>' style="color: #03f9a9; padding-right: 8px; font-size: 19px;">Order Now</a>

                            </p>
                        </div>
                        

                    </ItemTemplate>
                    <FooterTemplate>
                       
                    </FooterTemplate>
                </asp:Repeater>   
                <!-- .ci-cat-group END -->
            </div>

        </div>
    </div>
</asp:Content>
