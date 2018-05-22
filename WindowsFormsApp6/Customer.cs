using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    class Customer
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string EMail { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public Seller Seller { get; set; }
    }
}
