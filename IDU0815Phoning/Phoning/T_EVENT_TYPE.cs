using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace IDU0815Phoning.Phoning
{
    public class T_EVENT_TYPE
    {
        //[Key]
        //[ScaffoldColumn(false)]
        //public int EVENT_KEY { get; set; }

        [Key]
        [ScaffoldColumn(false)]
        public String EVENT_ID { get; set; }
        public String EVENT_NAME { get; set; }

        public virtual ICollection<T_EVENT> Events { get; set; }

        //public T_EVENT_TYPE(String EVENT_ID, String EVENT_NAME)
        //{
        //    EVENT_ID = this.EVENT_ID;
        //    EVENT_NAME = this.EVENT_NAME;
        //}
    }

}