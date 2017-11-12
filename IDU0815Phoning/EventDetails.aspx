﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IDU0815Phoning;
using System.Web.ModelBinding;

namespace IDU0815Phoning
{
  public partial class EventDetails : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public IQueryable<t_event> GetEvent(
                        [QueryString("RECORD_ID")] int? recordId,
                        [RouteData] string typeEvent)
    {
      var _db = new IDU0815Phoning.Phoning.CallContext();
      IQueryable<T_EVENT>
      query = _db.Events;
      if (recordId.HasValue && recordId > 0)
      {
        query = query.Where(p => p.RECORD_ID == recordId);
      }
      else if (!String.IsNullOrEmpty(typeEvent))
      {
        query = query.Where(p =>
                  String.Compare(p.RECORD_EVENT_ID, typeEvent) == 0);
      }
      else
      {
        query = null;
      }
      return query;
    }
  }
}