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
            GetEventTypes().ForEach(eT => context.EventTypes.Add(eT));
            GetCalls().ForEach(c => context.Calls.Add(c));
            GetEvents().ForEach(e => context.Events.Add(e));
        }

        private static List<T_EVENT_TYPE> GetEventTypes()
        {
            var eventTypes = new List<T_EVENT_TYPE>
            {
                new T_EVENT_TYPE
                {
                    //EVENT_KEY = 1,
                    EVENT_ID = "EVENT_PICK_UP",
                    EVENT_NAME = "Pick-up"
                },

                new T_EVENT_TYPE
                {
                    //EVENT_KEY = 2,
                    EVENT_ID = "EVENT_DIAL",
                    EVENT_NAME = "Dialling"
                },

                new T_EVENT_TYPE
                {
                    //EVENT_KEY = 3,
                    EVENT_ID = "EVENT_CALL_ESTABLISHED",
                    EVENT_NAME = "Call Established"
                },

                new T_EVENT_TYPE
                {
                    //EVENT_KEY = 4,
                    EVENT_ID = "EVENT_CALL_END",
                    EVENT_NAME = "Call End"
                },

                new T_EVENT_TYPE
                {
                    //EVENT_KEY = 5,
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
                new T_EVENT
                {
                    RECORD_ID = 1,
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2011, 12, 01),
                    CALL_ID = 3456781927
                },
                new T_EVENT
                {
                    RECORD_ID = 2,
                    RECORD_EVENT_ID = "EVENT_DIAL",
                    RECORD_DATE = new DateTime(2012, 11, 02),
                    CALL_ID = 0002
                },

                new T_EVENT
                {
                    RECORD_ID = 3,
                    RECORD_EVENT_ID = "EVENT_CALL_ESTABLISHED",
                    RECORD_DATE = new DateTime(2017, 11, 03),
                    CALL_ID = 0003
                },

                new T_EVENT
                {
                    RECORD_ID = 4,
                    RECORD_EVENT_ID = "EVENT_CALL_END",
                    RECORD_DATE = new DateTime(2015, 11, 05),
                    CALL_ID = 0004
                },

                new T_EVENT
                {
                    RECORD_ID = 5,
                    RECORD_EVENT_ID = "EVENT_CALL_END",
                    RECORD_DATE = new DateTime(2014, 11, 04),
                    CALL_ID = 0001
                },

                new T_EVENT
                {
                    RECORD_ID = 6,
                    RECORD_EVENT_ID = "EVENT_HANG_UP",
                    RECORD_DATE = new DateTime(2011, 11, 10),
                    CALL_ID = 0002
                },

                new T_EVENT
                {
                    RECORD_ID = 7,
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2012, 11, 12),
                    CALL_ID = 0005
                },

                new T_EVENT
                {
                    RECORD_ID = 8,
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2012, 11, 02),
                    CALL_ID = 0010
                },

                new T_EVENT
                {
                    RECORD_ID = 9,
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2012, 11, 02),
                    CALL_ID = 0012
                },

                new T_EVENT
                {
                    RECORD_ID = 10,
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2012, 11, 02),
                    CALL_ID = 0113
                },

                new T_EVENT
                {
                    RECORD_ID = 11,
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2012, 11, 02),
                    CALL_ID = 0008
                },

                new T_EVENT
                {
                    RECORD_ID = 12,
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2012, 11, 02),
                    CALL_ID = 0009
                },

                new T_EVENT
                {
                    RECORD_ID = 13,
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2012, 11, 02),
                    CALL_ID = 0010
                },

                new T_EVENT
                {
                    RECORD_ID = 14,
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2012, 11, 02),
                    CALL_ID = 0013
                },

                new T_EVENT
                {
                    RECORD_ID = 15,
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2012, 11, 02),
                    CALL_ID = 0002
                },

                new T_EVENT
                {
                    RECORD_ID = 16,
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2012, 11, 02),
                    CALL_ID = 0003
                },

                new T_EVENT
                {
                    RECORD_ID = 17,
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2012, 11, 02),
                    CALL_ID = 0005
                },

                new T_EVENT
                {
                    RECORD_ID = 18,
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2012, 11, 02),
                    CALL_ID = 0006
                },

                new T_EVENT
                {
                    RECORD_ID = 19,
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2012, 11, 02),
                    CALL_ID = 0007
                },

                new T_EVENT
                {
                    RECORD_ID = 20,
                    RECORD_EVENT_ID = "EVENT_PICK_UP",
                    RECORD_DATE = new DateTime(2012, 11, 02),
                    CALL_ID = 0008
                }
            
                //new T_EVENT(1, "My first test event", new DateTime(2017, 11, 21), 0001),
            /*new T_EVENT(2, (new T_EVENT_TYPE(EVENT_ID.EVENT_DIAL, EVENT_NAME.Dialling)).ToString(), new DateTime(2017, 11, 21), 1),
            new T_EVENT(3, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_ESTABLISHED, EVENT_NAME.CallEstablished)).ToString(), new DateTime(2017, 11, 21), 1),
            new T_EVENT(4, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_END, EVENT_NAME.CallEnd)).ToString(), new DateTime(01, 10, 10), 1),
            new T_EVENT(5, (new T_EVENT_TYPE(EVENT_ID.EVENT_HANG_UP, EVENT_NAME.HangUp)).ToString(), new DateTime(01, 10, 12), 1),

            new T_EVENT(6, (new T_EVENT_TYPE(EVENT_ID.EVENT_PICK_UP, EVENT_NAME.PickUp)).ToString(), new DateTime(2017, 11, 21), 2),
            new T_EVENT(7, (new T_EVENT_TYPE(EVENT_ID.EVENT_DIAL, EVENT_NAME.Dialling)).ToString(), new DateTime(2017, 11, 21), 2),
            new T_EVENT(8, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_ESTABLISHED, EVENT_NAME.CallEstablished)).ToString(), new DateTime(2017, 11, 21), 2),
            new T_EVENT(9, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_END, EVENT_NAME.CallEnd)).ToString(), new DateTime(02, 10, 10), 2),
            new T_EVENT(10, (new T_EVENT_TYPE(EVENT_ID.EVENT_HANG_UP, EVENT_NAME.HangUp)).ToString(), new DateTime(02, 10, 12), 2),

            new T_EVENT(11, (new T_EVENT_TYPE(EVENT_ID.EVENT_PICK_UP, EVENT_NAME.PickUp)).ToString(), new DateTime(2017, 11, 21), 3),
            new T_EVENT(12, (new T_EVENT_TYPE(EVENT_ID.EVENT_DIAL, EVENT_NAME.Dialling)).ToString(), new DateTime(2017, 11, 21), 3),
            new T_EVENT(13, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_ESTABLISHED, EVENT_NAME.CallEstablished)).ToString(), new DateTime(2017, 11, 21), 3),
            new T_EVENT(14, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_END, EVENT_NAME.CallEnd)).ToString(), new DateTime(03, 10, 10), 3),
            new T_EVENT(15, (new T_EVENT_TYPE(EVENT_ID.EVENT_HANG_UP, EVENT_NAME.HangUp)).ToString(), new DateTime(03, 10, 12), 3),

            new T_EVENT(16, (new T_EVENT_TYPE(EVENT_ID.EVENT_PICK_UP, EVENT_NAME.PickUp)).ToString(), new DateTime(2017, 11, 21), 4),
            new T_EVENT(17, (new T_EVENT_TYPE(EVENT_ID.EVENT_DIAL, EVENT_NAME.Dialling)).ToString(), new DateTime(2017, 11, 21), 4),
            new T_EVENT(18, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_ESTABLISHED, EVENT_NAME.CallEstablished)).ToString(), new DateTime(2017, 11, 21), 4),
            new T_EVENT(19, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_END, EVENT_NAME.CallEnd)).ToString(), new DateTime(04, 10, 10), 4),
            new T_EVENT(20, (new T_EVENT_TYPE(EVENT_ID.EVENT_HANG_UP, EVENT_NAME.HangUp)).ToString(), new DateTime(04, 10, 12), 4),

            new T_EVENT(21, (new T_EVENT_TYPE(EVENT_ID.EVENT_PICK_UP, EVENT_NAME.PickUp)).ToString(), new DateTime(2017, 11, 21), 5),
            new T_EVENT(22, (new T_EVENT_TYPE(EVENT_ID.EVENT_DIAL, EVENT_NAME.Dialling)).ToString(), new DateTime(2017, 11, 21), 5),
            new T_EVENT(23, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_ESTABLISHED, EVENT_NAME.CallEstablished)).ToString(), new DateTime(2017, 11, 21), 5),
            new T_EVENT(24, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_END, EVENT_NAME.CallEnd)).ToString(), new DateTime(05, 10, 10), 5),
            new T_EVENT(25, (new T_EVENT_TYPE(EVENT_ID.EVENT_HANG_UP, EVENT_NAME.HangUp)).ToString(), new DateTime(05, 10, 12), 5),

            new T_EVENT(26, (new T_EVENT_TYPE(EVENT_ID.EVENT_PICK_UP, EVENT_NAME.PickUp)).ToString(), new DateTime(2017, 11, 21), 6),
            new T_EVENT(27, (new T_EVENT_TYPE(EVENT_ID.EVENT_DIAL, EVENT_NAME.Dialling)).ToString(), new DateTime(2017, 11, 21), 6),
            new T_EVENT(28, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_ESTABLISHED, EVENT_NAME.CallEstablished)).ToString(), new DateTime(2017, 11, 21), 6),
            new T_EVENT(29, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_END, EVENT_NAME.CallEnd)).ToString(), new DateTime(06, 10, 10), 6),
            new T_EVENT(30, (new T_EVENT_TYPE(EVENT_ID.EVENT_HANG_UP, EVENT_NAME.HangUp)).ToString(), new DateTime(06, 10, 12), 6),

            new T_EVENT(31, (new T_EVENT_TYPE(EVENT_ID.EVENT_PICK_UP, EVENT_NAME.PickUp)).ToString(), new DateTime(2017, 11, 21), 7),
            new T_EVENT(32, (new T_EVENT_TYPE(EVENT_ID.EVENT_DIAL, EVENT_NAME.Dialling)).ToString(), new DateTime(2017, 11, 21), 7),
            new T_EVENT(33, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_ESTABLISHED, EVENT_NAME.CallEstablished)).ToString(), new DateTime(2017, 11, 21), 7),
            new T_EVENT(34, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_END, EVENT_NAME.CallEnd)).ToString(), new DateTime(07, 10, 10), 7),
            new T_EVENT(35, (new T_EVENT_TYPE(EVENT_ID.EVENT_HANG_UP, EVENT_NAME.HangUp)).ToString(), new DateTime(07, 10, 12), 7),

            new T_EVENT(36, (new T_EVENT_TYPE(EVENT_ID.EVENT_PICK_UP, EVENT_NAME.PickUp)).ToString(), new DateTime(2017, 11, 21), 8),
            new T_EVENT(37, (new T_EVENT_TYPE(EVENT_ID.EVENT_DIAL, EVENT_NAME.Dialling)).ToString(), new DateTime(2017, 11, 21), 8),
            new T_EVENT(38, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_ESTABLISHED, EVENT_NAME.CallEstablished)).ToString(), new DateTime(2017, 11, 21), 8),
            new T_EVENT(39, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_END, EVENT_NAME.CallEnd)).ToString(), new DateTime(08, 10, 10), 8),
            new T_EVENT(40, (new T_EVENT_TYPE(EVENT_ID.EVENT_HANG_UP, EVENT_NAME.HangUp)).ToString(), new DateTime(08, 10, 12), 8),

            new T_EVENT(41, (new T_EVENT_TYPE(EVENT_ID.EVENT_PICK_UP, EVENT_NAME.PickUp)).ToString(), new DateTime(2017, 11, 21), 9),
            new T_EVENT(42, (new T_EVENT_TYPE(EVENT_ID.EVENT_DIAL, EVENT_NAME.Dialling)).ToString(), new DateTime(2017, 11, 21), 9),
            new T_EVENT(43, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_ESTABLISHED, EVENT_NAME.CallEstablished)).ToString(), new DateTime(2017, 11, 21), 9),
            new T_EVENT(44, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_END, EVENT_NAME.CallEnd)).ToString(), new DateTime(01, 09, 10), 9),
            new T_EVENT(45, (new T_EVENT_TYPE(EVENT_ID.EVENT_HANG_UP, EVENT_NAME.HangUp)).ToString(), new DateTime(01, 09, 12), 9),

            new T_EVENT(46, (new T_EVENT_TYPE(EVENT_ID.EVENT_PICK_UP, EVENT_NAME.PickUp)).ToString(), new DateTime(2017, 11, 21), 10),
            new T_EVENT(47, (new T_EVENT_TYPE(EVENT_ID.EVENT_DIAL, EVENT_NAME.Dialling)).ToString(), new DateTime(2017, 11, 21), 10),
            new T_EVENT(48, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_ESTABLISHED, EVENT_NAME.CallEstablished)).ToString(), new DateTime(2017, 11, 21), 10),
            new T_EVENT(49, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_END, EVENT_NAME.CallEnd)).ToString(), new DateTime(02, 09, 10), 10),
            new T_EVENT(50, (new T_EVENT_TYPE(EVENT_ID.EVENT_HANG_UP, EVENT_NAME.HangUp)).ToString(), new DateTime(02, 09, 12), 10),

            new T_EVENT(51, (new T_EVENT_TYPE(EVENT_ID.EVENT_PICK_UP, EVENT_NAME.PickUp)).ToString(), new DateTime(2017, 11, 21), 11),
            new T_EVENT(52, (new T_EVENT_TYPE(EVENT_ID.EVENT_DIAL, EVENT_NAME.Dialling)).ToString(), new DateTime(2017, 11, 21), 11),
            new T_EVENT(53, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_ESTABLISHED, EVENT_NAME.CallEstablished)).ToString(), new DateTime(2017, 11, 21), 11),
            new T_EVENT(54, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_END, EVENT_NAME.CallEnd)).ToString(), new DateTime(03, 09, 10), 11),
            new T_EVENT(55, (new T_EVENT_TYPE(EVENT_ID.EVENT_HANG_UP, EVENT_NAME.HangUp)).ToString(), new DateTime(03, 09, 12), 11),

            new T_EVENT(56, (new T_EVENT_TYPE(EVENT_ID.EVENT_PICK_UP, EVENT_NAME.PickUp)).ToString(), new DateTime(2017, 11, 21), 12),
            new T_EVENT(57, (new T_EVENT_TYPE(EVENT_ID.EVENT_DIAL, EVENT_NAME.Dialling)).ToString(), new DateTime(2017, 11, 21), 12),
            new T_EVENT(58, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_ESTABLISHED, EVENT_NAME.CallEstablished)).ToString(), new DateTime(2017, 11, 21), 12),
            new T_EVENT(59, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_END, EVENT_NAME.CallEnd)).ToString(), new DateTime(04, 09, 10), 12),
            new T_EVENT(60, (new T_EVENT_TYPE(EVENT_ID.EVENT_HANG_UP, EVENT_NAME.HangUp)).ToString(), new DateTime(04, 09, 12), 12),

            new T_EVENT(61, (new T_EVENT_TYPE(EVENT_ID.EVENT_PICK_UP, EVENT_NAME.PickUp)).ToString(), new DateTime(2017, 11, 21), 13),
            new T_EVENT(62, (new T_EVENT_TYPE(EVENT_ID.EVENT_DIAL, EVENT_NAME.Dialling)).ToString(), new DateTime(2017, 11, 21), 13),
            new T_EVENT(63, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_ESTABLISHED, EVENT_NAME.CallEstablished)).ToString(), new DateTime(2017, 11, 21), 13),
            new T_EVENT(64, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_END, EVENT_NAME.CallEnd)).ToString(), new DateTime(05, 09, 10), 13),
            new T_EVENT(65, (new T_EVENT_TYPE(EVENT_ID.EVENT_HANG_UP, EVENT_NAME.HangUp)).ToString(), new DateTime(05, 09, 12), 13),

            new T_EVENT(66, (new T_EVENT_TYPE(EVENT_ID.EVENT_PICK_UP, EVENT_NAME.PickUp)).ToString(), new DateTime(2017, 11, 21), 14),
            new T_EVENT(67, (new T_EVENT_TYPE(EVENT_ID.EVENT_DIAL, EVENT_NAME.Dialling)).ToString(), new DateTime(2017, 11, 21), 14),
            new T_EVENT(68, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_ESTABLISHED, EVENT_NAME.CallEstablished)).ToString(), new DateTime(2017, 11, 21), 14),
            new T_EVENT(69, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_END, EVENT_NAME.CallEnd)).ToString(), new DateTime(06, 09, 10), 14),
            new T_EVENT(70, (new T_EVENT_TYPE(EVENT_ID.EVENT_HANG_UP, EVENT_NAME.HangUp)).ToString(), new DateTime(06, 09, 12), 14),

            new T_EVENT(71, (new T_EVENT_TYPE(EVENT_ID.EVENT_PICK_UP, EVENT_NAME.PickUp)).ToString(), new DateTime(2017, 11, 21), 15),
            new T_EVENT(72, (new T_EVENT_TYPE(EVENT_ID.EVENT_DIAL, EVENT_NAME.Dialling)).ToString(), new DateTime(2017, 11, 21), 15),
            new T_EVENT(73, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_ESTABLISHED, EVENT_NAME.CallEstablished)).ToString(), new DateTime(2017, 11, 21), 15),
            new T_EVENT(74, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_END, EVENT_NAME.CallEnd)).ToString(), new DateTime(07, 09, 10), 15),
            new T_EVENT(75, (new T_EVENT_TYPE(EVENT_ID.EVENT_HANG_UP, EVENT_NAME.HangUp)).ToString(), new DateTime(07, 09, 12), 15),

            new T_EVENT(76, (new T_EVENT_TYPE(EVENT_ID.EVENT_PICK_UP, EVENT_NAME.PickUp)).ToString(), new DateTime(2017, 11, 21), 16),
            new T_EVENT(77, (new T_EVENT_TYPE(EVENT_ID.EVENT_DIAL, EVENT_NAME.Dialling)).ToString(), new DateTime(2017, 11, 21), 16),
            new T_EVENT(78, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_ESTABLISHED, EVENT_NAME.CallEstablished)).ToString(), new DateTime(2017, 11, 21), 16),
            new T_EVENT(79, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_END, EVENT_NAME.CallEnd)).ToString(), new DateTime(08, 09, 10), 16),
            new T_EVENT(80, (new T_EVENT_TYPE(EVENT_ID.EVENT_HANG_UP, EVENT_NAME.HangUp)).ToString(), new DateTime(08, 09, 12), 16),

            new T_EVENT(81, (new T_EVENT_TYPE(EVENT_ID.EVENT_PICK_UP, EVENT_NAME.PickUp)).ToString(), new DateTime(2017, 11, 21), 17),
            new T_EVENT(82, (new T_EVENT_TYPE(EVENT_ID.EVENT_DIAL, EVENT_NAME.Dialling)).ToString(), new DateTime(2017, 11, 21), 17),

            new T_EVENT(83, (new T_EVENT_TYPE(EVENT_ID.EVENT_PICK_UP, EVENT_NAME.PickUp)).ToString(), new DateTime(2017, 11, 21), 18),
            new T_EVENT(84, (new T_EVENT_TYPE(EVENT_ID.EVENT_DIAL, EVENT_NAME.Dialling)).ToString(), new DateTime(2017, 11, 21), 18),

            new T_EVENT(85, (new T_EVENT_TYPE(EVENT_ID.EVENT_PICK_UP, EVENT_NAME.PickUp)).ToString(), new DateTime(2017, 11, 21), 19),
            new T_EVENT(86, (new T_EVENT_TYPE(EVENT_ID.EVENT_DIAL, EVENT_NAME.Dialling)).ToString(), new DateTime(2017, 11, 21), 19),

            new T_EVENT(87, (new T_EVENT_TYPE(EVENT_ID.EVENT_PICK_UP, EVENT_NAME.PickUp)).ToString(), new DateTime(2017, 11, 21), 20)*/
        };
            return events;
        }

        private static List<T_CALL> GetCalls()
        {
            var calls = new List<T_CALL>
            {
                new T_CALL
                {
                    RECORD_ID = 1,
                    CALLER = 345678,
                    RECEIVER = 567891
                },

                new T_CALL
                {
                    RECORD_ID = 2,
                    CALLER = 345679,
                    RECEIVER = 567892
                },

                new T_CALL
                {
                    RECORD_ID = 3,
                    CALLER = 345671,
                    RECEIVER = 567893
                },

                new T_CALL
                {
                    RECORD_ID = 4,
                    CALLER = 345672,
                    RECEIVER = 567894
                },

                new T_CALL
                {
                    RECORD_ID = 5,
                    CALLER = 345673,
                    RECEIVER = 567895
                },

                new T_CALL
                {
                    RECORD_ID = 6,
                    CALLER = 345674,
                    RECEIVER = 567896
                },

                new T_CALL
                {
                    RECORD_ID = 7,
                    CALLER = 345675,
                    RECEIVER = 5678917
                },

                new T_CALL
                {
                    RECORD_ID = 8,
                    CALLER = 345676,
                    RECEIVER = 567891
                },

                new T_CALL
                {
                    RECORD_ID = 9,
                    CALLER = 345677,
                    RECEIVER = 567882
                },

                new T_CALL
                {
                    RECORD_ID = 10,
                    CALLER = 345681,
                    RECEIVER = 567891
                },

                new T_CALL
                {
                    RECORD_ID = 11,
                    CALLER = 345682,
                    RECEIVER = 567898
                },

                new T_CALL
                {
                    RECORD_ID = 12,
                    CALLER = 345684,
                    RECEIVER = 567893
                }
            };
            return calls;
        }
    }
}