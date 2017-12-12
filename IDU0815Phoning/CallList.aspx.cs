using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IDU0815Phoning.Phoning;
using System.Web.ModelBinding;


namespace IDU0815Phoning
{
    public partial class CallList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                textCaller.Text = Request.QueryString["caller"];
            }
            Page.Title = "Caller " + Request.QueryString["caller"] + " list";
            
        }
        
    }
}