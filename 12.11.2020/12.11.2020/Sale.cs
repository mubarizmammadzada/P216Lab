using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._11._2020
{
    class Sale
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public Sale(string name,DateTime date)
        {
            this.Name = name;
            this.Date = date;
        }
    }
}
