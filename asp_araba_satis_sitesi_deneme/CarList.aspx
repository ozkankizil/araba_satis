<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="CarList.aspx.cs" Inherits="asp_araba_satis_sitesi_deneme.CarList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <asp:DataList ID="DataList1" runat="server">
            <ItemTemplate>
                <table class="nav-justified">
                    <td>
                        <tr>
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("strCarModel") %>'></asp:Label>
                            &nbsp;&nbsp;
                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("strBrandName") %>'></asp:Label>
                        </tr>
                    </td>&nbsp;&nbsp;
                    <td>
                        <tr>&nbsp;</tr>
                    </td>&nbsp;&nbsp;
                    <td>
                        <tr>
                            <asp:Image ID="Image1" runat="server" Height="87px" ImageUrl='<%# Eval("strCarPhoto") %>'  />
                        </tr>
                    </td>&nbsp;&nbsp;
                    <td>
                        <tr>
                            <asp:Label ID="Label4" runat="server" Text='<%# Eval("intCarFuelType") %>'></asp:Label>
                        </tr>
                    </td>&nbsp;&nbsp;
                    <td>
                        <tr>
                            <asp:Label ID="TextBox1" runat="server" Height="50px" ReadOnly="True" Text='<%# Eval("strCarDescription") %>' TextMode="MultiLine" ></asp:Label>
                        </tr>
                    </td>&nbsp;&nbsp;
                    <td>
                        <tr>
                            <asp:Label ID="Label5" runat="server" Text='<%# Eval("strCarSeller") %>'></asp:Label>
                        </tr>
                    </td>&nbsp;&nbsp;
                    <td>
                        <tr>
                            <asp:Label ID="Label6" runat="server" Text='<%# Eval("intCarContact") %>'></asp:Label>
                        </tr>
                    </td>&nbsp;&nbsp;
                    <td>
                        <tr>
                            <asp:Label ID="Label7" runat="server" Text='<%# Eval("intCarPrice") %>'></asp:Label>
                        </tr>
                    </td>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </form>
</asp:Content>
