using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.Data.Entity;
using static IDU0815Phoning.Phoning.T_EVENT_TYPE;

namespace IDU0815Phoning.Phoning
{
    public class PhoningDatabaseInitializer : DropCreateDatabaseAlways<CallContext>
    {
        protected override void Seed (CallContext context)
        {
            GetCalls().ForEach(c => context.Calls.Add(c));
            GetEventTypes().ForEach(eT => context.EventTypes.Add(eT));
            GetEvents().ForEach(e => context.Events.Add(e));
        }

        public static T_CALL FindCall(int CALL_ID)
        {
            //T_CALL myCall = GetCalls().Find(x => x.CALL_ID == CALL_ID);

            return GetCalls().Find(x => x.CALL_ID == CALL_ID); ;
        }

        private static List<T_EVENT_TYPE> GetEventTypes()
        {
            var eventTypes = new List<T_EVENT_TYPE>
            {
                new T_EVENT_TYPE
                {
                    EVENT_ID = "EVENT_PICK_UP",
                    EVENT_NAME = "Pick-up"
                },

                new T_EVENT_TYPE
                {
                    EVENT_ID = "EVENT_DIAL",
                    EVENT_NAME = "Dialling"
                },

                new T_EVENT_TYPE
                {
                    EVENT_ID = "EVENT_CALL_ESTABLISHED",
                    EVENT_NAME = "Call Established"
                },

                new T_EVENT_TYPE
                {
                    EVENT_ID = "EVENT_CALL_END",
                    EVENT_NAME = "Call End"
                },

                new T_EVENT_TYPE
                {
                    EVENT_ID = "EVENT_HANG_UP",
                    EVENT_NAME = "Hang-up"
                },
        };
            return eventTypes;
        }

        private static List<T_EVENT> GetEvents()
        {
            var events = new List<T_EVENT>
            {
                //1
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2017, 07, 23, 08, 12, 00),
                    CALL_ID = 1
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_DIAL",
                    RECORD_DATE = new DateTime(2017, 07, 23, 08, 12, 05),
                    CALL_ID = 1
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_ESTABLISHED",
                    RECORD_DATE = new DateTime(2017, 07, 23, 08, 12, 15),
                    CALL_ID = 1
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_END",
                    RECORD_DATE = new DateTime(2017, 07, 23, 09, 06, 34),
                    CALL_ID = 1
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_HANG_UP",
                    RECORD_DATE = new DateTime(2017, 07, 23, 09, 06, 40),
                    CALL_ID = 1
                },


                //2
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2017, 12, 09, 17, 02, 54),
                    CALL_ID = 2
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_DIAL",
                    RECORD_DATE = new DateTime(2017, 11, 09, 17, 03, 01),
                    CALL_ID = 2
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_ESTABLISHED",
                    RECORD_DATE = new DateTime(2017, 11, 09, 17, 03, 07),
                    CALL_ID = 2
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_END",
                    RECORD_DATE = new DateTime(2017, 11, 09, 17, 54, 00),
                    CALL_ID = 2
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_HANG_UP",
                    RECORD_DATE = new DateTime(2017, 11, 09, 17, 54, 05),
                    CALL_ID = 2
                },

                //3+
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 00),
                    CALL_ID = 20
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_DIAL",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 05),
                    CALL_ID = 20
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_ESTABLISHED",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 18),
                    CALL_ID = 20
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_END",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 30),
                    CALL_ID = 20
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_HANG_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 34),
                    CALL_ID = 20
                },


                //3
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 00),
                    CALL_ID = 5
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_DIAL",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 05),
                    CALL_ID = 5
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_ESTABLISHED",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 18),
                    CALL_ID = 5
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_END",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 30),
                    CALL_ID = 5
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_HANG_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 34),
                    CALL_ID = 5
                },

                //4
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 00),
                    CALL_ID = 6
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_DIAL",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 05),
                    CALL_ID = 6
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_ESTABLISHED",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 18),
                    CALL_ID = 6
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_END",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 30),
                    CALL_ID = 6
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_HANG_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 34),
                    CALL_ID = 6
                },


                //5
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 00),
                    CALL_ID = 7
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_DIAL",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 05),
                    CALL_ID = 7
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_ESTABLISHED",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 18),
                    CALL_ID = 7
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_END",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 30),
                    CALL_ID = 7
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_HANG_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 34),
                    CALL_ID = 7
                },

                //6
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 00),
                    CALL_ID = 9
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_DIAL",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 05),
                    CALL_ID = 9
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_ESTABLISHED",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 18),
                    CALL_ID = 9
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_END",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 30),
                    CALL_ID = 9
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_HANG_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 34),
                    CALL_ID = 9
                },


                //7
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 00),
                    CALL_ID = 11
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_DIAL",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 05),
                    CALL_ID = 11
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_ESTABLISHED",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 18),
                    CALL_ID = 11
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_END",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 30),
                    CALL_ID = 11
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_HANG_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 34),
                    CALL_ID = 11
                },

                //8
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 00),
                    CALL_ID = 12
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_DIAL",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 05),
                    CALL_ID = 12
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_ESTABLISHED",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 18),
                    CALL_ID = 12
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_END",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 30),
                    CALL_ID = 12
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_HANG_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 34),
                    CALL_ID = 12
                },


                //9
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 00),
                    CALL_ID = 14
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_DIAL",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 05),
                    CALL_ID = 14
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_ESTABLISHED",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 18),
                    CALL_ID = 14
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_END",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 30),
                    CALL_ID = 14
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_HANG_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 34),
                    CALL_ID = 14
                },

                //1
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 00),
                    CALL_ID = 15
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_DIAL",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 05),
                    CALL_ID = 15
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_ESTABLISHED",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 18),
                    CALL_ID = 15
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_END",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 30),
                    CALL_ID = 15
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_HANG_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 34),
                    CALL_ID = 15
                },


                //10
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 00),
                    CALL_ID = 16
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_DIAL",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 05),
                    CALL_ID = 16
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_ESTABLISHED",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 18),
                    CALL_ID = 16
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_END",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 30),
                    CALL_ID = 16
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_HANG_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 34),
                    CALL_ID = 16
                },

                //1
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 00),
                    CALL_ID = 18
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_DIAL",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 05),
                    CALL_ID = 18
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_ESTABLISHED",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 18),
                    CALL_ID = 18
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_END",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 30),
                    CALL_ID = 18
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_HANG_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 34),
                    CALL_ID = 18
                },


                //11
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 00),
                    CALL_ID = 19
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_DIAL",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 05),
                    CALL_ID = 19
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_ESTABLISHED",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 18),
                    CALL_ID = 19
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_END",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 30),
                    CALL_ID = 19
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_HANG_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 34),
                    CALL_ID = 19
                },

                //1
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 00),
                    CALL_ID = 21
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_DIAL",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 05),
                    CALL_ID = 21
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_ESTABLISHED",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 18),
                    CALL_ID = 21
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_END",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 30),
                    CALL_ID = 21
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_HANG_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 34),
                    CALL_ID = 21
                },


                //12
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 00),
                    CALL_ID = 22
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_DIAL",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 05),
                    CALL_ID = 22
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_ESTABLISHED",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 18),
                    CALL_ID = 22
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_END",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 30),
                    CALL_ID = 22
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_HANG_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 34),
                    CALL_ID = 23
                },

                //13
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 00),
                    CALL_ID = 24
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_DIAL",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 05),
                    CALL_ID = 24
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_ESTABLISHED",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 18),
                    CALL_ID = 24
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_END",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 30),
                    CALL_ID = 24
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_HANG_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 34),
                    CALL_ID = 24
                },

                //14
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 00),
                    CALL_ID = 26
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_DIAL",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 05),
                    CALL_ID = 26
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_ESTABLISHED",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 18),
                    CALL_ID = 26
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_END",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 30),
                    CALL_ID = 26
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_HANG_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 34),
                    CALL_ID = 26
                },

                //15
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 00),
                    CALL_ID = 27
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_DIAL",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 05),
                    CALL_ID = 27
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_ESTABLISHED",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 18),
                    CALL_ID = 27
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_END",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 30),
                    CALL_ID = 27
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_HANG_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 34),
                    CALL_ID = 27
                },

                //16
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 00),
                    CALL_ID = 29
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_DIAL",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 05),
                    CALL_ID = 29
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_ESTABLISHED",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 18),
                    CALL_ID = 29
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_END",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 30),
                    CALL_ID = 29
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_HANG_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 34),
                    CALL_ID = 29
                },

                //17
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 00),
                    CALL_ID = 30
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_DIAL",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 05),
                    CALL_ID = 30
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_ESTABLISHED",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 18),
                    CALL_ID = 30
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_END",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 30),
                    CALL_ID = 30
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_HANG_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 34),
                    CALL_ID = 30
                },

                //18
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 00),
                    CALL_ID = 31
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_DIAL",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 05),
                    CALL_ID = 31
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_ESTABLISHED",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 18),
                    CALL_ID = 31
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_END",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 30),
                    CALL_ID = 31
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_HANG_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 34),
                    CALL_ID = 31
                },

                //19
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 00),
                    CALL_ID = 32
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_DIAL",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 05),
                    CALL_ID = 32
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_ESTABLISHED",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 18),
                    CALL_ID = 32
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_END",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 30),
                    CALL_ID = 32
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_HANG_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 34),
                    CALL_ID = 32
                },

                //20
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 00),
                    CALL_ID = 33
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_DIAL",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 05),
                    CALL_ID = 33
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_ESTABLISHED",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 18),
                    CALL_ID = 33
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_END",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 30),
                    CALL_ID = 33
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_HANG_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 34),
                    CALL_ID = 33
                },

                //21
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 00),
                    CALL_ID = 34
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_DIAL",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 05),
                    CALL_ID = 34
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_ESTABLISHED",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 18),
                    CALL_ID = 34
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_END",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 30),
                    CALL_ID = 34
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_HANG_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 34),
                    CALL_ID = 34
                },

                //22
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 00),
                    CALL_ID = 35
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_DIAL",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 05),
                    CALL_ID = 35
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_ESTABLISHED",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 18),
                    CALL_ID = 35
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_END",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 30),
                    CALL_ID = 35
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_HANG_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 34),
                    CALL_ID = 35
                },

                //23
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 00),
                    CALL_ID = 36
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_DIAL",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 05),
                    CALL_ID = 36
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_ESTABLISHED",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 18),
                    CALL_ID = 36
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_END",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 30),
                    CALL_ID = 36
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_HANG_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 34),
                    CALL_ID = 36
                },

                //24
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 00),
                    CALL_ID = 37
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_DIAL",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 05),
                    CALL_ID = 37
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_ESTABLISHED",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 18),
                    CALL_ID = 37
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_END",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 30),
                    CALL_ID = 37
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_HANG_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 34),
                    CALL_ID = 37
                },

                //25
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 00),
                    CALL_ID = 38
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_DIAL",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 05),
                    CALL_ID = 38
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_ESTABLISHED",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 18),
                    CALL_ID = 38
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_END",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 30),
                    CALL_ID = 38
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_HANG_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 34),
                    CALL_ID = 38
                },

                //26
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 00),
                    CALL_ID = 39
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_DIAL",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 05),
                    CALL_ID = 39
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_ESTABLISHED",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 18),
                    CALL_ID = 39
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_END",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 30),
                    CALL_ID = 39
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_HANG_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 34),
                    CALL_ID = 39
                },

                //27
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 00),
                    CALL_ID = 40
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_DIAL",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 05),
                    CALL_ID = 40
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_ESTABLISHED",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 18),
                    CALL_ID = 40
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_END",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 30),
                    CALL_ID = 40
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_HANG_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 34),
                    CALL_ID = 40
                },

                //28
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 00),
                    CALL_ID = 41
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_DIAL",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 05),
                    CALL_ID = 42
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_ESTABLISHED",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 18),
                    CALL_ID = 42
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_END",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 30),
                    CALL_ID = 42
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_HANG_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 34),
                    CALL_ID = 42
                },

                //29
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 00),
                    CALL_ID = 43
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_DIAL",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 05),
                    CALL_ID = 43
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_ESTABLISHED",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 18),
                    CALL_ID = 43
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_END",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 30),
                    CALL_ID = 43
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_HANG_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 34),
                    CALL_ID = 43
                },

                //30
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 00),
                    CALL_ID = 44
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_DIAL",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 05),
                    CALL_ID = 44
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_ESTABLISHED",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 18),
                    CALL_ID = 44
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_CALL_END",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 30),
                    CALL_ID = 44
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_HANG_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 04, 34),
                    CALL_ID = 44
                },

                //31
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 00),
                    CALL_ID = 3
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_DIAL",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 05),
                    CALL_ID = 3
                },

                //32
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 00),
                    CALL_ID = 8
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_DIAL",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 05),
                    CALL_ID = 8
                },

                //33
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 00),
                    CALL_ID = 10
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_DIAL",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 05),
                    CALL_ID = 10
                },

                //34
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 00),
                    CALL_ID = 13
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_DIAL",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 05),
                    CALL_ID = 13
                },

                //35
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 00),
                    CALL_ID = 17
                },
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_DIAL",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 05),
                    CALL_ID = 17
                },

                //36
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 00),
                    CALL_ID = 4
                },

                //37
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 05),
                    CALL_ID = 25
                },

                //38
                new T_EVENT
                {
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2017, 11, 01, 12, 00, 05),
                    CALL_ID = 28
                }
            };
            return events;
        }

        private static List<T_CALL> GetCalls()
        {
            var calls = new List<T_CALL>
            {
                new T_CALL //1
                {
                    CALLER = 345678,
                    RECEIVER = 872345
                },

                new T_CALL //2
                {
                    CALLER = 375193,
                    RECEIVER = 356987
                },

                new T_CALL //3
                {
                    CALLER = 345678,
                    RECEIVER = 872345
                },

                new T_CALL //4
                {
                    CALLER = 345154,
                    RECEIVER = 314258
                },

                new T_CALL //5
                {
                    CALLER = 514235,
                    RECEIVER = 356987
                },

                new T_CALL //6
                {
                    CALLER = 802457,
                    RECEIVER = 812341
                },

                new T_CALL //7
                {
                    CALLER = 362178,
                    RECEIVER = 512642
                },

                new T_CALL //8
                {
                    CALLER = 348952,
                    RECEIVER = 567891
                },

                new T_CALL //9
                {
                    CALLER = 345678,
                    RECEIVER = 567892
                },

                new T_CALL //10
                {
                    CALLER = 814526,
                    RECEIVER = 567892
                },

                new T_CALL //11
                {
                    CALLER = 174952,
                    RECEIVER = 567892
                },

                new T_CALL //12
                {
                    CALLER = 315248,
                    RECEIVER = 567893
                },

                new T_CALL //13
                {
                    CALLER = 5321478,
                    RECEIVER = 567893
                },

                new T_CALL //14
                {
                    CALLER = 345678,
                    RECEIVER = 831456
                },

                new T_CALL //15
                {
                    CALLER = 847562,
                    RECEIVER = 567854
                },

                new T_CALL //16
                {
                    CALLER = 847562,
                    RECEIVER = 567854
                },

                new T_CALL //17
                {
                    CALLER = 367128,
                    RECEIVER = 842365
                },

                new T_CALL //18
                {
                    CALLER = 516952,
                    RECEIVER = 842365
                },

                new T_CALL //19
                {
                    CALLER = 345213,
                    RECEIVER = 842365
                },

                new T_CALL //20
                {
                    CALLER = 846235,
                    RECEIVER = 872345
                },

                new T_CALL //21
                {
                    CALLER = 845666,
                    RECEIVER = 842365
                },

                new T_CALL //22
                {
                    CALLER = 345126,
                    RECEIVER = 814536
                },

                new T_CALL //23
                {
                    CALLER = 846235,
                    RECEIVER = 814536
                },

                new T_CALL //24
                {
                    CALLER = 342168,
                    RECEIVER = 814536
                },

                new T_CALL //25
                {
                    CALLER = 395342,
                    RECEIVER = 814536
                },

                new T_CALL //26
                {
                    CALLER = 846235,
                    RECEIVER = 814412
                },

                new T_CALL //27
                {
                    CALLER = 532418,
                    RECEIVER = 814412
                },

                new T_CALL //28
                {
                    CALLER = 894235,
                    RECEIVER = 356852
                },

                new T_CALL //29
                {
                    CALLER = 871652,
                    RECEIVER = 356852
                },

                new T_CALL //30
                {
                    CALLER = 354126,
                    RECEIVER = 541689
                },

                new T_CALL //31
                {
                    CALLER = 565632,
                    RECEIVER = 541689
                },

                new T_CALL //32
                {
                    CALLER = 565632,
                    RECEIVER = 541689
                },

                new T_CALL //33
                {
                    CALLER = 348932,
                    RECEIVER = 541689
                },

                new T_CALL //34
                {
                    CALLER = 345678,
                    RECEIVER = 591364
                },

                new T_CALL //35
                {
                    CALLER = 512364,
                    RECEIVER = 591364
                },

                new T_CALL //36
                {
                    CALLER = 3425698,
                    RECEIVER = 591364
                },

                new T_CALL //37
                {
                    CALLER = 345678,
                    RECEIVER = 591348
                },

                new T_CALL //38
                {
                    CALLER = 342168,
                    RECEIVER = 356987
                },

            };
            return calls;
        }
    }
}