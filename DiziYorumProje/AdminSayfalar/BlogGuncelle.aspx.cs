using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje.AdminSayfalar
{
    public partial class BlogGuncelle : System.Web.UI.Page
    {

        BlogDiziDBEntities db = new BlogDiziDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int blog_id = Convert.ToInt32(Request.QueryString["BLOGID"]);
            if (Page.IsPostBack == false)
            {
                var turler = (from x in db.TBLTUR
                              select new
                              {
                                  x.TURID,
                                  x.TURAD
                              }).ToList();
                DropDownListTur.DataSource = turler;
                DropDownListTur.DataBind();



                var kategoriler = (from x in db.TBLKATEGORI
                                   select new
                                   {
                                       x.KATEGORIID,
                                       x.KATEGORIAD
                                   }).ToList();
                DropDownListKategori.DataSource = kategoriler;
                DropDownListKategori.DataBind();

                var deger = db.TBLBLOG.Find(blog_id);
                TextBoxBlogBaslik.Text = deger.BLOGBASLIK;
                TextBoxTarih.Text = deger.BLOGTARIH.ToString();
                TextBoxGorsel.Text = deger.BLOGGORSEL;
                DropDownListTur.SelectedValue = deger.BLOGTUR.ToString();
                DropDownListKategori.SelectedValue = deger.BLOGKATEGORI.ToString();
                TextBoxIcerik.Text = deger.BLOGICERIK;
            }
        }

        protected void ButtonYeniBlogGuncelle_Click(object sender, EventArgs e)
        {
            int blog_id = Convert.ToInt32(Request.QueryString["BLOGID"]);
            var blog = db.TBLBLOG.Find(blog_id);
            blog.BLOGBASLIK = TextBoxBlogBaslik.Text;
            blog.BLOGTARIH = DateTime.Parse(TextBoxTarih.Text);
            blog.BLOGGORSEL = TextBoxGorsel.Text;
            blog.BLOGICERIK = TextBoxIcerik.Text;
            blog.BLOGTUR = byte.Parse(DropDownListTur.SelectedValue);
            blog.BLOGKATEGORI = byte.Parse(DropDownListKategori.SelectedValue);
            db.SaveChanges();
            Response.Redirect("Bloglar.aspx");
        }
    }
}