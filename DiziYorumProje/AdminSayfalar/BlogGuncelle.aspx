<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="BlogGuncelle.aspx.cs" Inherits="DiziYorumProje.AdminSayfalar.BlogGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form runat="server" class="form-group">

        <asp:TextBox ID="TextBoxBlogBaslik" CssClass="form-control" runat="server" placeholder="Blog Başlık"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBoxTarih" CssClass="form-control" runat="server" placeholder="Blog Tarih"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBoxGorsel" CssClass="form-control" runat="server" placeholder="Blog Görsel"></asp:TextBox>
        <br />
        <asp:DropDownList ID="DropDownListTur" CssClass="form-control" runat="server" DataTextField="TURAD" DataValueField="TURID"></asp:DropDownList>
        <br />
        <asp:DropDownList ID="DropDownListKategori" CssClass="form-control" runat="server" DataTextField="KATEGORIAD" DataValueField="KATEGORIID"></asp:DropDownList>
        <br />
        <asp:TextBox ID="TextBoxIcerik" CssClass="form-control" runat="server" placeholder="Blog İçerik" TextMode="MultiLine" Height="150"></asp:TextBox>
        <br />
        <asp:Button ID="ButtonYeniBlogGuncelle" runat="server" Text="GÜNCELLE" CssClass="btn btn-success" OnClick="ButtonYeniBlogGuncelle_Click" />
    
    </form>

</asp:Content>
