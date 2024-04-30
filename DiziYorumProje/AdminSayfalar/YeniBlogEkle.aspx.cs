using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje.AdminSayfalar
{
    public partial class YeniBlogEkle : System.Web.UI.Page
    {

        BlogDiziDBEntities db = new BlogDiziDBEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
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
            }
        }

        protected void ButtonYeniBlogKaydet_Click(object sender, EventArgs e)
        {
            TBLBLOG t = new TBLBLOG();
            t.BLOGBASLIK = TextBoxBlogBaslik.Text;
            t.BLOGICERIK = TextBoxIcerik.Text;
            t.BLOGTARIH = DateTime.Parse(TextBoxTarih.Text);
            t.BLOGTUR = byte.Parse(DropDownListTur.SelectedValue);
            t.BLOGKATEGORI = byte.Parse(DropDownListKategori.SelectedValue);
            db.TBLBLOG.Add(t);
            db.SaveChanges();
            Response.Redirect("Bloglar.aspx");
        }
    }
}