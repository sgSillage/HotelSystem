using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelmanageSystem
{
    class Complaint
    {
        private string com_id;
        private string order_id;
        private string com_time;
        public Complaint(string cid,string oid,string ctime)
        {
            this.com_id = cid;
            this.order_id = oid;
            this.com_time = ctime;
        }

        public string Com_id { get => com_id; set => com_id = value; }
        public string Order_id { get => order_id; set => order_id = value; }
        public string Com_time { get => com_time; set => com_time = value; }
    }
}
