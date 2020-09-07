using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelmanageSystem
{
    class Room
    {
        private string number;
        private string kind;
        private string isNormal;
        private int price;
        public Room() { }
        public Room(string num,string knd,string isNor,int pri)
        {
            this.number = num;
            this.kind = knd;
            this.isNormal = isNor;
            this.price = pri;
        }
        public string Number
        {
            get { return number; }
            set { number = value; }

        }
        public string Kind
        {
            get { return kind; }
            set { kind = value; }
        }
        public string IsNormal
        {
            get { return isNormal; }
            set { isNormal = value; }
        }
        public int Price
        {
            get{ return price; }
            set { price = value; }
        }
    }
}
