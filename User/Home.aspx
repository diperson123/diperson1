<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="User_Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
           <div class="container" style="margin-top: 20px; text-align: center;">
        <div class="row special-offers">
            <h2>Special Offers</h2>
            <asp:Repeater ID="SepcialOffers" runat="server">
                <ItemTemplate>
                    <div class="col-md-3 col-sm-6 col-xs-6 menu-section">
                        <div class="card" style="border: 1px solid;">
                            <div class="well well-sm" style="background-color: #00bcd4;">
                                Promotion
                         <span style="font-size: 15px; font-weight: 500; color: rosybrown; display: inline-block;" class="discount pull-right"><%#Eval("Discount")+"% Dis." %></span>
                            </div>
                            <div class="image-section">
                                <asp:Image ID="Image1" ImageUrl='<%# "~/MenuImages/"+Eval("Image") %>' Width="260px" Height="180px" runat="server" />
                            </div>
                            <div class="menu-content" style="background-color: #8c6616; min-height: 17vh;">
                                <div>
                                    <h4 style="padding-left: 4px; padding-top: 4px; color: white; text-align: left; padding-top: 4px;">
                                        <asp:Label ID="lblTitle" Text="Title" runat="server" />: &nbsp;<%# Eval("FoodName") %></h4>
                                    <p style="color: white; text-align: left; padding-left: 4px;">
                                        <asp:Label ID="lblPrice" Text="Price" runat="server" />: <%# Eval("Price") %>
                                    </p>
                                    <p style="color: white; text-align: left; padding-left: 4px;">
                                        <asp:Label ID="lblDescription" Text="Description" runat="server" />: <%# Eval("Description")+"....." %>
                                    </p>
                                </div>

                            </div>
                            <div style="background-color: #c1890b; margin-top: -10px; text-align: right;">
                                <a href='<%# "MenuDetail.aspx?id="+Eval("Id") %>' style="color: #8c6616; padding-right: 8px; font-size: 19px;">Order Now</a>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
        <div class="row our-menu">
            
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <div class="col-md-3 col-sm-6 col-xs-6 menu-section">
                        <div class="card" style="border: 1px solid;">
                            <div class="well well-sm" style="background-color: #f0ac1a;">
                                Promotion
                         <span style="font-size: 15px; font-weight: 500; color: rosybrown; display: inline-block;" class="discount pull-right"><%# Eval("Discount").ToString()!=string.Empty? Eval("Discount")+"% Dis.":string.Empty%></span>
                            </div>
                            <div class="image-section">
                                <asp:Image ID="Image1" ImageUrl='<%# "~/MenuImages/"+Eval("Image") %>' Width="260px" Height="180px" runat="server" />
                            </div>
                            <div class="menu-content" style="background-color: #8c6616; min-height: 17vh;">
                                <div>
                                    <h4 style="padding-left: 4px; padding-top: 4px; color: white; text-align: left; padding-top: 4px;">
                                        <asp:Label ID="lblTitle" Text="Title" runat="server" />: &nbsp;<%# Eval("FoodName") %></h4>
                                    <p style="color: white; text-align: left; padding-left: 4px;">
                                        <asp:Label ID="lblPrice" Text="Price" runat="server" />: <%# Eval("Price") %>
                                    </p>
                                    <p style="color: white; text-align: left; padding-left: 4px;">
                                        <asp:Label ID="lblDescription" Text="Description" runat="server" />: <%# Eval("Description")+"....." %>
                                    </p>
                                </div>

                            </div>
                            <div style="background-color: #c1890b; margin-top: -10px; text-align: right;">
                                <a href='<%# "MenuDetail.aspx?id="+Eval("Id") %>' style="color: #03f9a9; padding-right: 8px; font-size: 19px;">Order Now</a>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>

    <div class="container text-center">
        <h3>Happy New Year Hot Sales</h3>
        <br/>
        <div class="ci-menus-container ci-menu-cols-3">
               
                        <asp:Repeater ID="RptrMenu" runat="server">                    
                    <ItemTemplate>
                            <div class="col-md-6" style="padding: 20px;">
                            <a class="ci-meal-thumb-link ci-fancybox" title="<%# Eval("Foodname") %> – $<%# Eval("Price") %>">
                                <img id="Img1" src='<%# "~/MenuImages/" + Eval("image") %>' alt='<%#Eval("image") %>' style="width: 430px; height: 350px;" runat="server" />
                            </a>
                              <p>
                                <a href='<%# "MenuDisplay.aspx?id="+Eval("Id") %>' style="color: #03f9a9; padding-right: 8px; font-size: 19px;">Order Now</a>

                            </p>
                        </div>
                        

                    </ItemTemplate>                   
                   
                </asp:Repeater>
                   
                
                <!-- .ci-cat-group END -->
            </div>
    </div>
    <br>
</asp:Content>

