using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelmanageSystem
{
    class Employee
    {
        private string number;
        private string name;
        private string sex;
        private string status;
        private string phone;
        private int salary;
        private string time;
        private string position;
        public Employee() { }
        public Employee(string id, string na, string sx, string ss, string pn, int sa,string ti,string po)
        {
            this.number = id;
            this.name = na;
            this.sex = sx;
            this.status = ss;
            this.salary = sa;
            this.phone = pn;
            this.time = ti;
            this.position = po;
        }

        public string Number { get => number; set => number = value; }
        public string Name { get => name; set => name = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Status { get => status; set => status = value; }
        public string Phone { get => phone; set => phone = value; }
        public int Salary { get => salary; set => salary = value; }
        public string Time { get => time; set => time = value; }
        public string Position { get => position; set => position = value; }
    }
}
