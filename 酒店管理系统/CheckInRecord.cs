using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginRegisterFrame;

namespace ReceptionSection
{
    class CheckInRecord
    {
        private string identity;
        private string room_id;
        private string lodfer_time;
        private string leave_time;
        private string name;
        public CheckInRecord() { }
        public CheckInRecord(string iden,string id,string time_lo,string time_lea,string na)
        {
            this.identity = iden;
            this.room_id = id;
            this.lodfer_time = time_lo;
            this.leave_time = time_lea;
            this.name = na;
        }
        public string Identity { get { return identity; } set { identity = value; } }
        public string Room_id { get { return room_id; } set { room_id = value; } }
        public string Lodger_time { get { return lodfer_time; } set { lodfer_time = value; } }
        public string Leave_time { get { return leave_time; } set { leave_time = value; } }
        public string Name { get { return name; } set { name = value; } }
    }
}
