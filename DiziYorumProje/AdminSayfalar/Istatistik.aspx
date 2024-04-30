<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Istatistik.aspx.cs" Inherits="DiziYorumProje.AdminSayfalar.Istatistik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="table table-bordered">
        <tr>
            <td>Toplam Blog Sayısı :<asp:Label ID="LabelToplamBlog" runat="server" Text="Label"></asp:Label>
            </td>
            <td>Toplam Yorum Sayısı :<asp:Label ID="LabelToplamYorum" runat="server" Text="Label"></asp:Label>

            </td>
            <td>Toplam Film Sayısı :<asp:Label ID="LabelToplamFilm" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Toplam Dizi Sayısı :<asp:Label ID="LabelToplamDizi" runat="server" Text="Label"></asp:Label>
            </td>
            <td>Toplam Animasyon Sayısı :<asp:Label ID="LabelToplamAnimasyon" runat="server" Text="Label"></asp:Label>

            </td>
            <td>En Fazla Yorumlu Blog :<asp:Label ID="LabelEnFazlaYorumluBlog" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
    </table>

</asp:Content>
