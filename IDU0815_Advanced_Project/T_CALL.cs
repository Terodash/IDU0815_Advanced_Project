using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InformationSystemsProgramming.App_Start
{
    public class T_CALL
    {
        public T_CALL(int RECORD_ID, long CALLER, long RECEIVER)
        {
            RECORD_ID = this.RECORD_ID;
            CALLER = this.CALLER;
            RECEIVER = this.RECEIVER;
        }

        public int RECORD_ID { get; set; }
        public long CALLER{ get; set; }
        public long RECEIVER { get; set; }
    }
}