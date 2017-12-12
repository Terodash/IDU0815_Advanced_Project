using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using static IDU0815Phoning.Phoning.T_CALL;
using static IDU0815Phoning.Phoning.PhoningDatabaseInitializer;

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

        static int nextId;
        [Key]
        [ScaffoldColumn(false)]
        public int RECORD_ID { get; private set; }
        
        [Required, StringLength(100), Display(Name = "Event ID")]
        public string RECORD_EVENT_ID { get; set; }
        public virtual ICollection<T_EVENT_TYPE> T_EVENT_TYPE { set; get; }

        public DateTime RECORD_DATE { get; set; }
        

        public int CALL_ID { get; set; }
        public virtual ICollection<T_CALL> T_CALL { set; get; }

        //public T_CALL AssociatedCall { get; private set; }

        //public int? EVENT_KEY { get; set; }
        //public virtual T_EVENT_TYPE T_EVENT_TYPE { get; set; }

        public T_EVENT()
        {
            RECORD_ID = nextId++; //auto-incremented ID
            //AssociatedCall = PhoningDatabaseInitializer.FindCall(2);
        }
    }
}