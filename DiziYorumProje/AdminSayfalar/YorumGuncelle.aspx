<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YorumGuncelle.aspx.cs" Inherits="DiziYorumProje.AdminSayfalar.YorumGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form runat="server" class="form-group">

        <asp:TextBox ID="TextBoxBlogBaslik" CssClass="form-control" runat="server" placeholder="Blog Başlık" Enabled="false"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBoxKullaniciAd" CssClass="form-control" runat="server" placeholder="Kullanıcı Adı"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBoxYorumIcerik" CssClass="form-control" runat="server" placeholder="Yorum İçerik"></asp:TextBox>
        <br />
        <asp:Button ID="ButtonYorumGuncelle" runat="server" Text="GÜNCELLE" CssClass="btn btn-success" OnClick="ButtonYorumGuncelle_Click" />

    </form>

</asp:Content>
