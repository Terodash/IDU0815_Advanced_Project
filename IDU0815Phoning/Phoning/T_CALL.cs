using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace IDU0815Phoning.Phoning
{
    public class T_CALL
    {
        /*public T_CALL(int RECORD_ID, long CALLER, long RECEIVER)
        {
            RECORD_ID = this.RECORD_ID;
            CALLER = this.CALLER;
            RECEIVER = this.RECEIVER;
        }*/

        static int nextId;
        [Key]
        [ScaffoldColumn(false)]
        public int CALL_ID { get; private set; }

        public T_CALL()
        {
            CALL_ID = nextId++; //auto-incremented ID
        }

        public long CALLER { get; set; }
        public long RECEIVER { get; set; }
    }
}