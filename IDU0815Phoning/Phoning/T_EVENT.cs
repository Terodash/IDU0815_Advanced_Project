using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace IDU0815Phoning.Phoning
{
    public class T_EVENT
    {
        /*public T_EVENT(int RECORD_ID, string RECORD_EVENT, DateTime RECORD_DATE, long CALL_ID)
        {
            RECORD_ID = this.RECORD_ID;
            RECORD_EVENT = this.RECORD_EVENT_ID;
            RECORD_DATE = this.RECORD_DATE;
            CALL_ID = this.CALL_ID;
        }*/

        //[ScaffoldColumn(false)]
        [Key]
        public int RECORD_ID { get; set; }

        [Required, StringLength(100), Display(Name = "Event ID")]
        public string RECORD_EVENT_ID { get; set; }

        public DateTime RECORD_DATE { get; set; }
        public long CALL_ID { get; set; }

    }
}