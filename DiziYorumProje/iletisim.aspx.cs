using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje
{
    public partial class iletisim : System.Web.UI.Page
    {

        BlogDiziDBEntities db = new BlogDiziDBEntities();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonMesajGonder_Click(object sender, EventArgs e)
        {
            TBLILETISIM t = new TBLILETISIM();
            t.ADSOYAD = TextBoxAdSoyad.Text;
            t.MAIL = TextBoxMail.Text;
            t.TELEFON = TextBoxTelefon.Text;
            t.KONU = TextBoxKonu.Text;
            t.MESAJ = TextBoxMesaj.Text;
            db.TBLILETISIM.Add(t);
            db.SaveChanges();
            Response.Redirect("iletisim.aspx");
        }
    }
}