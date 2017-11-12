using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;
using IDU0815Phoning.Phoning;

namespace IDU0815Phoning
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<T_EVENT> GetEvents()
        {
            var _db = new IDU0815Phoning.Phoning.CallContext();
            IQueryable<T_EVENT> query = _db.Events;
            return query;
        }

        public IQueryable<T_CALL> GetCalls()
        {
            var _db = new IDU0815Phoning.Phoning.CallContext();
            IQueryable<T_CALL> query = _db.Calls;
            return query;
        }

        public IQueryable<T_EVENT_TYPE> GetEventTypes()
        {
            var _db = new IDU0815Phoning.Phoning.CallContext();
            IQueryable<T_EVENT_TYPE> query = _db.EventTypes;
            return query;
        }

    }
}