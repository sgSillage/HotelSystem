using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelmanageSystem
{
    class Cost
    {
        private string kind;
        private int count;
        private int gross_cost;
        public Cost(string kn,int cnt,int grst)
        {
            this.kind = kn;
            this.count = cnt;
            this.gross_cost = grst;
        }

        public string Kind { get => kind; set => kind = value; }
        public int Count { get => count; set => count = value; }
        public int Gross_cost { get => gross_cost; set => gross_cost = value; }
    }
}
