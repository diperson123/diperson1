<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Promotion.aspx.cs" Inherits="Admin_Promotion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="container">
        <div class="col-md-12">
            <h2>
                Promotion and Offer
            </h2>
                  <asp:MultiView ID="MultiView1" runat="server">
                <asp:View ID="View1" runat="server">

                </asp:View>
                <asp:View ID="View2" runat="server">
                    <div class="col-md-12">
                        <h4>
                            <asp:Label ID="lblHeading" runat="server" Text="Add Promotion"></asp:Label>
                        </h4>
                        <div class="col-md-12">
                            <div class="c0l-md-2">

                            </div>
                            <div class="c0l-md-7">

                            </div>
                        </div>
                    </div>
                </asp:View>
            </asp:MultiView>
        </div>
    </div>
</asp:Content>

