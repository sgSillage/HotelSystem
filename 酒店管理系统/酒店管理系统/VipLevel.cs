using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class VipLevel
    {
        private int level;
        private string good;
        public VipLevel(int lv, string good, string ctime)
        {
            this.level= lv;
            this.good = good;
        }
        public int Level { get => level; set => level = value; }
        public string Good { get => good; set => good = value; }
    }
}
