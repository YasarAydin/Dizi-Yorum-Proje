using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje
{
    public partial class Default : System.Web.UI.Page
    {

        BlogDiziDBEntities db = new BlogDiziDBEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            var bloglar = db.TBLBLOG.ToList();
            Repeater1.DataSource = bloglar;
            Repeater1.DataBind();

            var son5blog = db.TBLBLOG.OrderByDescending(x=>x.ID).Take(5).ToList();
            Repeater2.DataSource = son5blog;
            Repeater2.DataBind();

            var son5yorum = db.TBLYORUM.OrderByDescending(x => x.YORUMID).Take(5).ToList();
            Repeater4.DataSource = son5yorum;
            Repeater4.DataBind();
        }
    }
}