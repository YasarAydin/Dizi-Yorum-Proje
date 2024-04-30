using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje.AdminSayfalar
{
    public partial class Istatistik : System.Web.UI.Page
    {

        BlogDiziDBEntities db = new BlogDiziDBEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            LabelToplamBlog.Text = db.TBLBLOG.Count().ToString();
            LabelToplamYorum.Text = db.TBLYORUM.Count().ToString();
            LabelToplamFilm.Text = db.TBLBLOG.Where(x => x.BLOGTUR == 1)
                .Count().ToString();
            LabelToplamDizi.Text = db.TBLBLOG.Where(x => x.BLOGTUR == 2)
                .Count().ToString();
            LabelToplamAnimasyon.Text = db.TBLBLOG.Where(x => x.BLOGTUR == 3)
                .Count().ToString();

            LabelEnFazlaYorumluBlog.Text = db.TBLBLOG.Where(y => y.ID == 
            (db.TBLYORUM.GroupBy(x => x.YORUMBLOG)
            .OrderByDescending(X => X.Count()).Select(X => X.Key)
            .FirstOrDefault())).Select(x => x.BLOGBASLIK)
            .FirstOrDefault();
        }
    }
}