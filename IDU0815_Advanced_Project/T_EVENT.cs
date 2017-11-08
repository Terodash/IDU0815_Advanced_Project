using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InformationSystemsProgramming.App_Start
{
    public class T_EVENT
    {
        public T_EVENT(long RECORD_ID, String RECORD_EVENT, DateTime RECORD_DATE, long CALL_ID)
        {
            RECORD_ID = this.RECORD_ID;
            RECORD_EVENT = this.RECORD_EVENT_ID;
            RECORD_DATE = this.RECORD_DATE;
            CALL_ID = this.CALL_ID;
        }

        public long RECORD_ID { get; set; }
        public string RECORD_EVENT_ID { get; set; }
        public DateTime RECORD_DATE{ get; set; }
        public long CALL_ID { get; set; }
    }
}