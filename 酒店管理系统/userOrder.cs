using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class userOrder
    {
        private string type;
        private string order_time;
        private string all_price;
        public userOrder(string type, string order_time, string all_price)
        {
            this.type = type;
            this.order_time = order_time;
            this.all_price = all_price;
        }
        public string Type { get => type; set => type = value; }
        public string Order_time { get => order_time; set => order_time = value; }
        public string All_price { get => all_price; set => all_price = value; }
    }
}
