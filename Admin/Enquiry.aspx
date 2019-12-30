<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Enquiry.aspx.cs" Inherits="Admin_Enquiry" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <div style="width:100%; height: 207px;" >
           <h2>Customer Feedbacks :</h2><hr />
                      <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Id" ForeColor="Black" Width="884px" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellSpacing="2" Height="66px" OnRowDeleting="GridView1_RowDeleting">
                   <Columns>
                                        <asp:BoundField DataField="Username" HeaderText="Username" />
                                            <asp:BoundField DataField="Email" HeaderText="Email" />
                     
                                            
                       <%-- <asp:BoundField DataField="EnquiryDate" HeaderText="Enquiry Date" DataFormatString="{0:dd-M-yyyy}" />
                      --%> 
                          
                                                 <asp:BoundField DataField="Message" HeaderText="Message" />
                        <asp:CommandField HeaderText="Delete Feedback" ShowDeleteButton="True" />
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="gray" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                    <RowStyle BackColor="White" />
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#808080" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#383838" />
                </asp:GridView>
          
</div>
    <br /
</asp:Content>

