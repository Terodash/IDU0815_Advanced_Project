using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Data;

namespace IDU0815Phoning
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddl_PageSize.SelectedValue != "--")
            {
                GridView1.PageSize = Convert.ToInt32(ddl_PageSize.SelectedValue);
                GridView1.DataBind();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected string LookupCallReceiver(object idObj)
        {
            if (string.IsNullOrEmpty(idObj.ToString()))
                return null;

            // store the permissionID passed as an input parameter
            string CallId = idObj.ToString();

            // find the corresponding name
            IEnumerator enumos = callDB.Select(new DataSourceSelectArguments()).GetEnumerator();
            while (enumos.MoveNext())
            {
                DataRowView row = enumos.Current as DataRowView;

                if ((string)row["CALL_ID"].ToString() == CallId)
                    return string.Concat(row["RECEIVER"].ToString());
            }

            return CallId;
        }

        protected string LookupCallCaller(object idObj)
        {
            if (string.IsNullOrEmpty(idObj.ToString()))
                return null;

            // store the permissionID passed as an input parameter
            string CallId = idObj.ToString();

            // find the corresponding name
            IEnumerator enumos = callDB.Select(new DataSourceSelectArguments()).GetEnumerator();
            while (enumos.MoveNext())
            {
                DataRowView row = enumos.Current as DataRowView;

                if ((string)row["CALL_ID"].ToString() == CallId)
                    return string.Concat(row["CALLER"].ToString());
            }

            return CallId;
        }
    }
}