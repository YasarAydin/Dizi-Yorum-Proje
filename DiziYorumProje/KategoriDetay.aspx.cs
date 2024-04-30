using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje
{
    public partial class KategoriDetay : System.Web.UI.Page
    {

        BlogDiziDBEntities db = new BlogDiziDBEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            int kategori_id = Convert.ToInt32(Request.QueryString["KATEGORIID"]);
            var bloglar = db.TBLBLOG.Where(x=>x.BLOGKATEGORI == kategori_id).ToList();
            Repeater1.DataSource = bloglar;
            Repeater1.DataBind();
        }
    }
}