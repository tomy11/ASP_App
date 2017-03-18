using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Session
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btsend_Click(object sender, EventArgs e)
        {
            Session["firstname"] = txtfirstname.Text;
            Session["lastname"] = txtlastname.Text;
            Server.Transfer("received.aspx");
        }
    }
}