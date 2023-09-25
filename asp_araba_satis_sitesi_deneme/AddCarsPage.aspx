<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="AddCarsPage.aspx.cs" Inherits="asp_araba_satis_sitesi_deneme.AddCarsPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <table class="nav-justified">
            <tr>
                <td style="height: 20px; width: 160px">Araba markasını seçiniz</td>
                <td class="modal-sm" style="height: 20px; width: 140px">Araba modelini yazınız</td>
                <td style="width: 168px; height: 20px">Araba fotoğraf linki giriniz</td>
                <td style="height: 20px; width: 159px">Aracın yakıt tipini seçiniz</td>
                <td style="height: 20px; width: 111px">Açıklama giriniz</td>
                <td style="height: 20px; width: 94px">Araç satıcısı</td>
                <td style="height: 20px; width: 116px">İletişim numarası</td>
                <td style="height: 20px; width: 70px">Fiyat</td>
                <td style="height: 20px">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 160px">
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="20px" Width="166px">
                    </asp:DropDownList>
                </td>
                <td class="modal-sm" style="width: 140px">
                    <asp:TextBox ID="TextBox1" runat="server" Height="16px" Width="147px"></asp:TextBox>
                </td>
                <td style="width: 168px">
                    <asp:TextBox ID="TextBox2" runat="server" Height="16px" Width="147px"></asp:TextBox>
                </td>
                <td style="width: 159px">
                    <asp:DropDownList ID="DropDownList2" runat="server" Height="20px" Width="166px">
                    </asp:DropDownList>
                </td>
                <td class="modal-sm" style="width: 111px">
                    <asp:TextBox ID="TextBox3" runat="server" Height="50px" TextMode="MultiLine" Width="119px"></asp:TextBox>
                </td>
                <td style="width: 94px">
                    <asp:TextBox ID="TextBox4" runat="server" Height="16px" Width="95px"></asp:TextBox>
                </td>
                <td style="width: 116px">
                    <asp:TextBox ID="TextBox5" runat="server" Height="16px" Width="106px"></asp:TextBox>
                </td>
                <td style="width: 70px">
                    <asp:TextBox ID="TextBox6" runat="server" Height="16px" Width="52px"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" Height="39px" OnClick="Button1_Click" Text="Gönder" Width="93px" />
                </td>
            </tr>
        </table>
    </form>
</asp:Content>
