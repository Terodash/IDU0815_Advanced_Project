using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDU0815Phoning.Phoning
{
    public class T_EVENT_TYPE
    {
        EVENT_ID event_id;
        EVENT_NAME event_name;
        public const string PickUp = "Pick-up";
        public const string CallEstablished = "Call Established";
        public const string CallEnd = "Call End";
        public const string HangUp = "Hang-up";

        public T_EVENT_TYPE(EVENT_ID event_id, EVENT_NAME event_name)
        {
            event_id = this.event_id;
            event_name = this.event_name;
        }

        public enum EVENT_ID
        {
            EVENT_PICK_UP,
            EVENT_DIAL,
            EVENT_CALL_ESTABLISHED,
            EVENT_CALL_END,
            EVENT_HANG_UP
        }

        public enum EVENT_NAME
        {
            PickUp,
            Dialling,
            CallEstablished,
            CallEnd,
            HangUp
        }
    }
}