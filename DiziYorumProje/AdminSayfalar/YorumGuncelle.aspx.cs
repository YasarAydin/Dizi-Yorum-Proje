using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje.AdminSayfalar
{
    public partial class YorumGuncelle : System.Web.UI.Page
    {

        BlogDiziDBEntities db = new BlogDiziDBEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            int yorum_id = Convert.ToInt32(Request.QueryString["YORUMID"]);
            if (Page.IsPostBack == false)
            {
                var yorum = db.TBLYORUM.Find(yorum_id);
                TextBoxBlogBaslik.Text = yorum.TBLBLOG.BLOGBASLIK;
                TextBoxKullaniciAd.Text = yorum.KULLANICIAD;
                TextBoxYorumIcerik.Text = yorum.YORUMICERIK;
            }
        }

        protected void ButtonYorumGuncelle_Click(object sender, EventArgs e)
        {
            int yorum_id = Convert.ToInt32(Request.QueryString["YORUMID"]);
            var yorum = db.TBLYORUM.Find(yorum_id);
            yorum.KULLANICIAD = TextBoxKullaniciAd.Text;
            yorum.YORUMICERIK = TextBoxYorumIcerik.Text;
            db.SaveChanges();
            Response.Redirect("Yorumlar.aspx");
        }
    }
}