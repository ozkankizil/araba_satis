<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="asp_araba_satis_sitesi_deneme.Iletisim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        İsim ve soyisim
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        Mail
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        Mesaj
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Gönder" OnClick="Button1_Click" />

        </form>

</asp:Content>

