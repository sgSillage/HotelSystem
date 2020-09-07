using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelmanageSystem
{
    class Income
    {
        private string kind;
        private int count;
        private int gross_income;
        private string date;
        public Income(string kn,int cnt,int grin,string d)
        {
            this.kind = kn;
            this.count = cnt;
            this.gross_income = grin;
            this.date = d;
        }

        public string Kind { get => kind; set => kind = value; }
        public int Count { get => count; set => count = value; }
        public int Gross_income { get => gross_income; set => gross_income = value; }
        public string Date { get => date; set => date = value; }
    }
}
