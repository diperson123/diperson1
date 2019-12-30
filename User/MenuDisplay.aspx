<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMasterPage.master" AutoEventWireup="true" CodeFile="MenuDisplay.aspx.cs" Inherits="User_MenuDisplay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container">
        <h1>Menu Details</h1>
        <asp:FormView ID="FormViewMenu" runat="server">
            <ItemTemplate>
                <div style="padding: 10px">
                    <div class="col-md-5">
                        <div class="thumbnail" style="border:none">
                            
                            <div class="item">
                                <img id="Img1" src='<%# "~/MenuImages/" + Eval("image") %>' alt='<%#Eval("image") %>' style="width: 430px; height: 350px;" runat="server" />
                            </div>
                        </div>
                    </div>
                    </div>
                    <div class="col-md-8">
                        <div style="margin-bottom: 5px; font-size:18px;">

                            <h1 class="proNameView"><%#Eval("Foodname") %></h1>
                            <div>
                                <span>Price</span> <span class="proOgPriceView"><%#Eval("Price") %></span>
                            </div>
                            <div class="col-lg-offset-10">
                            <asp:Button ID="Button1" class="btn btn-default" OnClick="addToCart_Click" runat="server" Style="color:#ff0000; padding-left: 8px; font-size: 18px; background-color: #000000;" Text="ADD TO CART" />

                        </div>

                        </div>

                    </div>
                </div>
                </div>

            </ItemTemplate>
        </asp:FormView>
        <div  style="width:100px;text-align:right" class="col-lg-4">
           Quantity: <span>
                <asp:TextBox ID="menuQuantity" CssClass="form-control" TextMode="Number" name="menuQuantity" runat="server">1</asp:TextBox></span>
        </div>
        <div>
            <asp:Label ID="lblMsg" runat="server"></asp:Label>
        </div>

    </div>
    
</asp:Content>
