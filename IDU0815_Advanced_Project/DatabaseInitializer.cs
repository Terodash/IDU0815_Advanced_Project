using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Microsoft.Ajax.Utilities;
using static InformationSystemsProgramming.App_Start.T_EVENT_TYPE;

namespace InformationSystemsProgramming.App_Start
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<BddContext>
    {
        public DatabaseInitializer()
        {
        }

        protected override void Seed(BddContext context)
        {
            GetEVENT().ForEach(e => context.T_EVENT.Add(e));
            GetCALL().ForEach(c => context.T_CALL.Add(c));
        }

        private List<T_CALL> GetCALL()
        {
            var t_call = new List<T_CALL>
        {
            new T_CALL(1, 345678, 567891),
            new T_CALL(2, 345679, 567892),
            new T_CALL(3, 345671, 567893),
            new T_CALL(4, 345672, 567894),
            new T_CALL(5, 345673, 567895),
            new T_CALL(6, 567891, 867891),
            new T_CALL(7, 567892, 867892),
            new T_CALL(8, 567893, 867893),
            new T_CALL(9, 567894, 867894),
            new T_CALL(10, 567895, 867895),
            new T_CALL(11, 891234, 367891),
            new T_CALL(12, 891235, 367892),
            new T_CALL(13, 891236, 367893),
            new T_CALL(14, 891237, 367894),
            new T_CALL(15, 891238, 367895),
            new T_CALL(16, 891239, 367896),
            new T_CALL(17, 312345, 512345),
            new T_CALL(18, 356789, 556789),
            new T_CALL(19, 512345, 812345),
            new T_CALL(20, 812345, 312345)
        };
            return t_call;
        }

        private List<T_EVENT> GetEVENT()
        {
            var t_event = new List<T_EVENT>
        {
            new T_EVENT(1, (new T_EVENT_TYPE(EVENT_ID.EVENT_PICK_UP, EVENT_NAME.PickUp)).ToString(), new DateTime(00, 00, 00), 1),
            new T_EVENT(2, (new T_EVENT_TYPE(EVENT_ID.EVENT_DIAL, EVENT_NAME.Dialling)).ToString(), new DateTime(00, 00, 00), 1),
            new T_EVENT(3, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_ESTABLISHED, EVENT_NAME.CallEstablished)).ToString(), new DateTime(00, 00, 00), 1),
            new T_EVENT(4, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_END, EVENT_NAME.CallEnd)).ToString(), new DateTime(01, 10, 10), 1),
            new T_EVENT(5, (new T_EVENT_TYPE(EVENT_ID.EVENT_HANG_UP, EVENT_NAME.HangUp)).ToString(), new DateTime(01, 10, 12), 1),

            new T_EVENT(6, (new T_EVENT_TYPE(EVENT_ID.EVENT_PICK_UP, EVENT_NAME.PickUp)).ToString(), new DateTime(00, 00, 00), 2),
            new T_EVENT(7, (new T_EVENT_TYPE(EVENT_ID.EVENT_DIAL, EVENT_NAME.Dialling)).ToString(), new DateTime(00, 00, 00), 2),
            new T_EVENT(8, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_ESTABLISHED, EVENT_NAME.CallEstablished)).ToString(), new DateTime(00, 00, 00), 2),
            new T_EVENT(9, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_END, EVENT_NAME.CallEnd)).ToString(), new DateTime(02, 10, 10), 2),
            new T_EVENT(10, (new T_EVENT_TYPE(EVENT_ID.EVENT_HANG_UP, EVENT_NAME.HangUp)).ToString(), new DateTime(02, 10, 12), 2),

            new T_EVENT(11, (new T_EVENT_TYPE(EVENT_ID.EVENT_PICK_UP, EVENT_NAME.PickUp)).ToString(), new DateTime(00, 00, 00), 3),
            new T_EVENT(12, (new T_EVENT_TYPE(EVENT_ID.EVENT_DIAL, EVENT_NAME.Dialling)).ToString(), new DateTime(00, 00, 00), 3),
            new T_EVENT(13, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_ESTABLISHED, EVENT_NAME.CallEstablished)).ToString(), new DateTime(00, 00, 00), 3),
            new T_EVENT(14, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_END, EVENT_NAME.CallEnd)).ToString(), new DateTime(03, 10, 10), 3),
            new T_EVENT(15, (new T_EVENT_TYPE(EVENT_ID.EVENT_HANG_UP, EVENT_NAME.HangUp)).ToString(), new DateTime(03, 10, 12), 3),

            new T_EVENT(16, (new T_EVENT_TYPE(EVENT_ID.EVENT_PICK_UP, EVENT_NAME.PickUp)).ToString(), new DateTime(00, 00, 00), 4),
            new T_EVENT(17, (new T_EVENT_TYPE(EVENT_ID.EVENT_DIAL, EVENT_NAME.Dialling)).ToString(), new DateTime(00, 00, 00), 4),
            new T_EVENT(18, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_ESTABLISHED, EVENT_NAME.CallEstablished)).ToString(), new DateTime(00, 00, 00), 4),
            new T_EVENT(19, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_END, EVENT_NAME.CallEnd)).ToString(), new DateTime(04, 10, 10), 4),
            new T_EVENT(20, (new T_EVENT_TYPE(EVENT_ID.EVENT_HANG_UP, EVENT_NAME.HangUp)).ToString(), new DateTime(04, 10, 12), 4),

            new T_EVENT(21, (new T_EVENT_TYPE(EVENT_ID.EVENT_PICK_UP, EVENT_NAME.PickUp)).ToString(), new DateTime(00, 00, 00), 5),
            new T_EVENT(22, (new T_EVENT_TYPE(EVENT_ID.EVENT_DIAL, EVENT_NAME.Dialling)).ToString(), new DateTime(00, 00, 00), 5),
            new T_EVENT(23, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_ESTABLISHED, EVENT_NAME.CallEstablished)).ToString(), new DateTime(00, 00, 00), 5),
            new T_EVENT(24, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_END, EVENT_NAME.CallEnd)).ToString(), new DateTime(05, 10, 10), 5),
            new T_EVENT(25, (new T_EVENT_TYPE(EVENT_ID.EVENT_HANG_UP, EVENT_NAME.HangUp)).ToString(), new DateTime(05, 10, 12), 5),

            new T_EVENT(26, (new T_EVENT_TYPE(EVENT_ID.EVENT_PICK_UP, EVENT_NAME.PickUp)).ToString(), new DateTime(00, 00, 00), 6),
            new T_EVENT(27, (new T_EVENT_TYPE(EVENT_ID.EVENT_DIAL, EVENT_NAME.Dialling)).ToString(), new DateTime(00, 00, 00), 6),
            new T_EVENT(28, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_ESTABLISHED, EVENT_NAME.CallEstablished)).ToString(), new DateTime(00, 00, 00), 6),
            new T_EVENT(29, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_END, EVENT_NAME.CallEnd)).ToString(), new DateTime(06, 10, 10), 6),
            new T_EVENT(30, (new T_EVENT_TYPE(EVENT_ID.EVENT_HANG_UP, EVENT_NAME.HangUp)).ToString(), new DateTime(06, 10, 12), 6),

            new T_EVENT(31, (new T_EVENT_TYPE(EVENT_ID.EVENT_PICK_UP, EVENT_NAME.PickUp)).ToString(), new DateTime(00, 00, 00), 7),
            new T_EVENT(32, (new T_EVENT_TYPE(EVENT_ID.EVENT_DIAL, EVENT_NAME.Dialling)).ToString(), new DateTime(00, 00, 00), 7),
            new T_EVENT(33, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_ESTABLISHED, EVENT_NAME.CallEstablished)).ToString(), new DateTime(00, 00, 00), 7),
            new T_EVENT(34, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_END, EVENT_NAME.CallEnd)).ToString(), new DateTime(07, 10, 10), 7),
            new T_EVENT(35, (new T_EVENT_TYPE(EVENT_ID.EVENT_HANG_UP, EVENT_NAME.HangUp)).ToString(), new DateTime(07, 10, 12), 7),

            new T_EVENT(36, (new T_EVENT_TYPE(EVENT_ID.EVENT_PICK_UP, EVENT_NAME.PickUp)).ToString(), new DateTime(00, 00, 00), 8),
            new T_EVENT(37, (new T_EVENT_TYPE(EVENT_ID.EVENT_DIAL, EVENT_NAME.Dialling)).ToString(), new DateTime(00, 00, 00), 8),
            new T_EVENT(38, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_ESTABLISHED, EVENT_NAME.CallEstablished)).ToString(), new DateTime(00, 00, 00), 8),
            new T_EVENT(39, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_END, EVENT_NAME.CallEnd)).ToString(), new DateTime(08, 10, 10), 8),
            new T_EVENT(40, (new T_EVENT_TYPE(EVENT_ID.EVENT_HANG_UP, EVENT_NAME.HangUp)).ToString(), new DateTime(08, 10, 12), 8),

            new T_EVENT(41, (new T_EVENT_TYPE(EVENT_ID.EVENT_PICK_UP, EVENT_NAME.PickUp)).ToString(), new DateTime(00, 00, 00), 9),
            new T_EVENT(42, (new T_EVENT_TYPE(EVENT_ID.EVENT_DIAL, EVENT_NAME.Dialling)).ToString(), new DateTime(00, 00, 00), 9),
            new T_EVENT(43, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_ESTABLISHED, EVENT_NAME.CallEstablished)).ToString(), new DateTime(00, 00, 00), 9),
            new T_EVENT(44, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_END, EVENT_NAME.CallEnd)).ToString(), new DateTime(01, 40, 10), 9),
            new T_EVENT(45, (new T_EVENT_TYPE(EVENT_ID.EVENT_HANG_UP, EVENT_NAME.HangUp)).ToString(), new DateTime(01, 40, 12), 9),

            new T_EVENT(46, (new T_EVENT_TYPE(EVENT_ID.EVENT_PICK_UP, EVENT_NAME.PickUp)).ToString(), new DateTime(00, 00, 00), 10),
            new T_EVENT(47, (new T_EVENT_TYPE(EVENT_ID.EVENT_DIAL, EVENT_NAME.Dialling)).ToString(), new DateTime(00, 00, 00), 10),
            new T_EVENT(48, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_ESTABLISHED, EVENT_NAME.CallEstablished)).ToString(), new DateTime(00, 00, 00), 10),
            new T_EVENT(49, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_END, EVENT_NAME.CallEnd)).ToString(), new DateTime(02, 40, 10), 10),
            new T_EVENT(50, (new T_EVENT_TYPE(EVENT_ID.EVENT_HANG_UP, EVENT_NAME.HangUp)).ToString(), new DateTime(02, 40, 12), 10),

            new T_EVENT(51, (new T_EVENT_TYPE(EVENT_ID.EVENT_PICK_UP, EVENT_NAME.PickUp)).ToString(), new DateTime(00, 00, 00), 11),
            new T_EVENT(52, (new T_EVENT_TYPE(EVENT_ID.EVENT_DIAL, EVENT_NAME.Dialling)).ToString(), new DateTime(00, 00, 00), 11),
            new T_EVENT(53, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_ESTABLISHED, EVENT_NAME.CallEstablished)).ToString(), new DateTime(00, 00, 00), 11),
            new T_EVENT(54, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_END, EVENT_NAME.CallEnd)).ToString(), new DateTime(03, 40, 10), 11),
            new T_EVENT(55, (new T_EVENT_TYPE(EVENT_ID.EVENT_HANG_UP, EVENT_NAME.HangUp)).ToString(), new DateTime(03, 40, 12), 11),

            new T_EVENT(56, (new T_EVENT_TYPE(EVENT_ID.EVENT_PICK_UP, EVENT_NAME.PickUp)).ToString(), new DateTime(00, 00, 00), 12),
            new T_EVENT(57, (new T_EVENT_TYPE(EVENT_ID.EVENT_DIAL, EVENT_NAME.Dialling)).ToString(), new DateTime(00, 00, 00), 12),
            new T_EVENT(58, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_ESTABLISHED, EVENT_NAME.CallEstablished)).ToString(), new DateTime(00, 00, 00), 12),
            new T_EVENT(59, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_END, EVENT_NAME.CallEnd)).ToString(), new DateTime(04, 40, 10), 12),
            new T_EVENT(60, (new T_EVENT_TYPE(EVENT_ID.EVENT_HANG_UP, EVENT_NAME.HangUp)).ToString(), new DateTime(04, 40, 12), 12),

            new T_EVENT(61, (new T_EVENT_TYPE(EVENT_ID.EVENT_PICK_UP, EVENT_NAME.PickUp)).ToString(), new DateTime(00, 00, 00), 13),
            new T_EVENT(62, (new T_EVENT_TYPE(EVENT_ID.EVENT_DIAL, EVENT_NAME.Dialling)).ToString(), new DateTime(00, 00, 00), 13),
            new T_EVENT(63, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_ESTABLISHED, EVENT_NAME.CallEstablished)).ToString(), new DateTime(00, 00, 00), 13),
            new T_EVENT(64, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_END, EVENT_NAME.CallEnd)).ToString(), new DateTime(05, 40, 10), 13),
            new T_EVENT(65, (new T_EVENT_TYPE(EVENT_ID.EVENT_HANG_UP, EVENT_NAME.HangUp)).ToString(), new DateTime(05, 40, 12), 13),

            new T_EVENT(66, (new T_EVENT_TYPE(EVENT_ID.EVENT_PICK_UP, EVENT_NAME.PickUp)).ToString(), new DateTime(00, 00, 00), 14),
            new T_EVENT(67, (new T_EVENT_TYPE(EVENT_ID.EVENT_DIAL, EVENT_NAME.Dialling)).ToString(), new DateTime(00, 00, 00), 14),
            new T_EVENT(68, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_ESTABLISHED, EVENT_NAME.CallEstablished)).ToString(), new DateTime(00, 00, 00), 14),
            new T_EVENT(69, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_END, EVENT_NAME.CallEnd)).ToString(), new DateTime(06, 40, 10), 14),
            new T_EVENT(70, (new T_EVENT_TYPE(EVENT_ID.EVENT_HANG_UP, EVENT_NAME.HangUp)).ToString(), new DateTime(06, 40, 12), 14),

            new T_EVENT(71, (new T_EVENT_TYPE(EVENT_ID.EVENT_PICK_UP, EVENT_NAME.PickUp)).ToString(), new DateTime(00, 00, 00), 15),
            new T_EVENT(72, (new T_EVENT_TYPE(EVENT_ID.EVENT_DIAL, EVENT_NAME.Dialling)).ToString(), new DateTime(00, 00, 00), 15),
            new T_EVENT(73, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_ESTABLISHED, EVENT_NAME.CallEstablished)).ToString(), new DateTime(00, 00, 00), 15),
            new T_EVENT(74, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_END, EVENT_NAME.CallEnd)).ToString(), new DateTime(07, 40, 10), 15),
            new T_EVENT(75, (new T_EVENT_TYPE(EVENT_ID.EVENT_HANG_UP, EVENT_NAME.HangUp)).ToString(), new DateTime(07, 40, 12), 15),

            new T_EVENT(76, (new T_EVENT_TYPE(EVENT_ID.EVENT_PICK_UP, EVENT_NAME.PickUp)).ToString(), new DateTime(00, 00, 00), 16),
            new T_EVENT(77, (new T_EVENT_TYPE(EVENT_ID.EVENT_DIAL, EVENT_NAME.Dialling)).ToString(), new DateTime(00, 00, 00), 16),
            new T_EVENT(78, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_ESTABLISHED, EVENT_NAME.CallEstablished)).ToString(), new DateTime(00, 00, 00), 16),
            new T_EVENT(79, (new T_EVENT_TYPE(EVENT_ID.EVENT_CALL_END, EVENT_NAME.CallEnd)).ToString(), new DateTime(08, 40, 10), 16),
            new T_EVENT(80, (new T_EVENT_TYPE(EVENT_ID.EVENT_HANG_UP, EVENT_NAME.HangUp)).ToString(), new DateTime(08, 40, 12), 16),

            new T_EVENT(81, (new T_EVENT_TYPE(EVENT_ID.EVENT_PICK_UP, EVENT_NAME.PickUp)).ToString(), new DateTime(00, 00, 00), 17),
            new T_EVENT(82, (new T_EVENT_TYPE(EVENT_ID.EVENT_DIAL, EVENT_NAME.Dialling)).ToString(), new DateTime(00, 00, 00), 17),

            new T_EVENT(83, (new T_EVENT_TYPE(EVENT_ID.EVENT_PICK_UP, EVENT_NAME.PickUp)).ToString(), new DateTime(00, 00, 00), 18),
            new T_EVENT(84, (new T_EVENT_TYPE(EVENT_ID.EVENT_DIAL, EVENT_NAME.Dialling)).ToString(), new DateTime(00, 00, 00), 18),

            new T_EVENT(85, (new T_EVENT_TYPE(EVENT_ID.EVENT_PICK_UP, EVENT_NAME.PickUp)).ToString(), new DateTime(00, 00, 00), 19),
            new T_EVENT(86, (new T_EVENT_TYPE(EVENT_ID.EVENT_DIAL, EVENT_NAME.Dialling)).ToString(), new DateTime(00, 00, 00), 19),

            new T_EVENT(87, (new T_EVENT_TYPE(EVENT_ID.EVENT_PICK_UP, EVENT_NAME.PickUp)).ToString(), new DateTime(00, 00, 00), 20)
        };
            return t_event;
        }

    }
}