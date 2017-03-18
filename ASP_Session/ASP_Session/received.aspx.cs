using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Session
{
    public partial class received : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["firstname"] != null) && (Session["lastname"] != null))
            {
                lbfirstname.Text = Session["firstname"].ToString();
                lblastname.Text = Session["lastname"].ToString();
                Session.Remove("firstname");
                Session.Remove("lastname");
            }
        }
    }
}