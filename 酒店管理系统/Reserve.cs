using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Reserve
    {
        private string room_id;
        private string start_time;
        private string end_time;
        public Reserve(string room_id,string start_time,string end_time)
        {
            this.room_id = room_id;
            this.start_time = start_time;
            this.end_time = end_time;
        }
        public string Room_id { get => room_id; set => room_id = value; }
        public string Start_time { get => start_time; set => start_time = value; }
        public string End_time { get => end_time; set => end_time = value; }
    }
}
