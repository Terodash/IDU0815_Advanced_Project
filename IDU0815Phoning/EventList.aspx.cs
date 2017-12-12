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
    public partial class EventList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<T_EVENT> GetEvents([QueryString("id")] int?eventId)
        //public IQueryable<T_EVENT> GetEvents([QueryString("id")] String eventTypeId)
        {
            var _db = new IDU0815Phoning.Phoning.CallContext();
            IQueryable<T_EVENT> query = _db.Events;
            if (eventId.HasValue && eventId > 0)
            //if (eventTypeId.Length > 0)
            {
                query = query.Where(e => e.RECORD_ID == eventId);
                //query = query.Where(e => e.RECORD_EVENT_ID == eventTypeId);
            }
            return query;
        }

        public IQueryable<T_EVENT> GetEventTypes([QueryString("id")] String eventTypeId)
        {
            var _db = new IDU0815Phoning.Phoning.CallContext();
            IQueryable<T_EVENT> query = _db.Events;
            if (eventTypeId != null)
            {
                query = query.Where(e => e.RECORD_EVENT_ID == eventTypeId);
            }
            return query;
        }

        protected void eventList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void EventGrid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}