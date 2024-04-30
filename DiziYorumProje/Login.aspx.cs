using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje
{
    public partial class Login : System.Web.UI.Page
    {

        BlogDiziDBEntities db = new BlogDiziDBEntities();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonGirisYap_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.TBLADMIN
                        where
                        x.KULLANICI == TextBoxKullaniciAd.Text && x.SIFRE == TextBoxSifre.Text
                        select x;
            if (sorgu.Any())
            {
                Session.Add("KULLANICI", TextBoxKullaniciAd.Text);

                Response.Redirect("/AdminSayfalar/Bloglar.aspx");
            } else
            {
                Response.Write("Hata");
            }
        }
    }
}