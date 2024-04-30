<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="iletisim.aspx.cs" Inherits="DiziYorumProje.iletisim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="contact-content">
        <div class="container">
            <div class="contact-info">
                <h2>İLETİŞİM</h2>
                <p>
                    Buradan bizimle iletişime geçebilirsiniz.
                </p>
            </div>
            <div class="contact-details">
                <form runat="server">
                    <asp:TextBox ID="TextBoxAdSoyad" placeholder="Ad Soyad" runat="server"></asp:TextBox>
                    <asp:TextBox ID="TextBoxMail" placeholder="Mail" runat="server"></asp:TextBox>
                    <asp:TextBox ID="TextBoxTelefon" placeholder="Telefon" runat="server"></asp:TextBox>
                    <asp:TextBox ID="TextBoxKonu" placeholder="Konu" runat="server"></asp:TextBox>
                    <asp:TextBox ID="TextBoxMesaj" placeholder="Mesaj" TextMode="MultiLine" Height="100" runat="server"></asp:TextBox>
                    <asp:Button ID="ButtonMesajGonder" runat="server" Text="Gönder" OnClick="ButtonMesajGonder_Click" />
                </form>
            </div>
            <div class="contact-details">
                <div class="col-md-6 contact-map">
                    <h4>BİZ BURADAYIZ</h4>
                    <div style="max-width: 100%; overflow: hidden; color: red; width: 500px; height: 500px;">
                        <div id="gmap-canvas" style="height: 100%; width: 100%; max-width: 100%;">
                            <iframe style="height: 100%; width: 100%; border: 0;" frameborder="0" src="https://www.google.com/maps/embed/v1/place?q=İstanbul,+Türkiye&key=AIzaSyBFw0Qbyq9zTFTd-tUY6dZWTgaQzuU17R8"></iframe>
                        </div>
                        <a class="googlecoder" href="https://www.bootstrapskins.com/themes" id="authmaps-data">premium bootstrap themes</a><style>
                                                                                                                                               #gmap-canvas img.text-marker {
                                                                                                                                                   max-width: none !important;
                                                                                                                                                   background: none !important;
                                                                                                                                               }

                                                                                                                                               img {
                                                                                                                                                   max-width: none
                                                                                                                                               }
                                                                                                                                           </style>
                    </div>
                </div>
            </div>


        </div>
    </div>
    </div>

</asp:Content>
