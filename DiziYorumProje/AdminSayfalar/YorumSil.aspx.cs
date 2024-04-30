﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje.AdminSayfalar
{
    public partial class YorumSil : System.Web.UI.Page
    {

        BlogDiziDBEntities db = new BlogDiziDBEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            int yorum_id = Convert.ToInt32(Request.QueryString["YORUMID"]);
            var yorum = db.TBLYORUM.Find(yorum_id);
            db.TBLYORUM.Remove(yorum);
            db.SaveChanges();
            Response.Redirect("Yorumlar.aspx");
        }
    }
}