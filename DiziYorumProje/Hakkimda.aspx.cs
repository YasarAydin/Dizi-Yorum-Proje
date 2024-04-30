using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje
{
    public partial class Hakkimda : System.Web.UI.Page
    {

        BlogDiziDBEntities db = new BlogDiziDBEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            var hakkimda = db.TBLHAKKIMIZDA.ToList();
            Repeater1.DataSource = hakkimda;
            Repeater1.DataBind();
        }
    }
}