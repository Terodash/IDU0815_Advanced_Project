using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Data;
using IDU0815Phoning.Phoning;
using System.Text;

namespace IDU0815Phoning
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<T_EVENT_TYPE> GetEventTypes()
        {
            var _db = new IDU0815Phoning.Phoning.CallContext();
            IQueryable<T_EVENT_TYPE> query = _db.EventTypes;
            return query;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddl_PageSize.SelectedValue != "--")
            {
                GridView1.PageSize = Convert.ToInt32(ddl_PageSize.SelectedValue);
                GridView1.DataBind();
            }
        }

        protected void ClickExportCSV(object sender, EventArgs e)
        {
            {
                Response.Clear();
                Response.Buffer = true;
                Response.AddHeader("content-disposition", "attachment;filename=Phoning.csv");
                Response.Charset = "";
                Response.ContentType = "application/text";
                GridView1.AllowPaging = false;
                GridView1.DataBind();

                StringBuilder columnbind = new StringBuilder();
                for (int k = 0; k < GridView1.Columns.Count; k++)
                {

                    columnbind.Append(GridView1.Columns[k].HeaderText + ',');
                }

                columnbind.Append("\r\n");
                for (int i = 0; i < GridView1.Rows.Count; i++)
                {
                    for (int k = 0; k < GridView1.Columns.Count; k++)
                    {

                        columnbind.Append(GridView1.Rows[i].Cells[k].Text + ',');
                    }

                    columnbind.Append("\r\n");
                }
                Response.Output.Write(columnbind.ToString());
                Response.Flush();
                Response.End();

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