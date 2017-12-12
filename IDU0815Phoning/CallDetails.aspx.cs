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
    public partial class CallDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtSearch.Text = Request.QueryString["id"];
            }
            Page.Title = "Call " + Request.QueryString["id"] + " details";
        }

        protected string queryCallId()
        {
            return Request.QueryString["id"];
        }

        protected string GetTimestamp()
        {
            string Timestamp = "";
            DateTime EstablishedTime = DateTime.Now ;
            DateTime EndTime = DateTime.Now;

            if (CheckStateOfCall().Equals("Regular"))
            {
                foreach (GridViewRow row in GridView1.Rows)
                {
                    string eventType = row.Cells[2].Text;

                    if (eventType.Equals("Call Established"))
                    {
                        EstablishedTime = DateTime.Parse(row.Cells[3].Text);
                    }

                    else if (eventType.Equals("Call End"))
                    {
                        EndTime = DateTime.Parse(row.Cells[3].Text);
                        break;
                    }
                }
                Timestamp = "Call duration : " + (EndTime - EstablishedTime).ToString();
            }

            return Timestamp;
        }

        protected string CheckStateOfCall()
        {
            string state_call = "Cancelled";

            foreach (GridViewRow row in GridView1.Rows)
            {
                string eventType = row.Cells[2].Text;
                
                if (eventType.Equals("Dialling"))
                {
                    state_call = "Non-dialled";
                }

                else if (eventType.Equals("Call Established"))
                {
                    state_call = "Regular";
                }
            }
            return state_call;
        }

        //public IQueryable<T_CALL> GetCalls([QueryString("id")] int? callId)
        //{
        //    var _db = new IDU0815Phoning.Phoning.CallContext();
        //    IQueryable<T_CALL> query = _db.Calls;
        //    if (callId.HasValue && callId > 0)
        //    {
        //        query = query.Where(e => e.CALL_ID == callId);
        //    }
        //    return query;
        //}

        protected void callDetails_PageIndexChanging(object sender, FormViewPageEventArgs e)
        {

        }
    }
}