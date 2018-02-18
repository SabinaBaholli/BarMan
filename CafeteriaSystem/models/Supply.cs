using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CafeteriaSystem
{
    public class Supply
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public int Quantity { get; set; }
        public string Supplier { get; set; }
        public DateTime Date { get; set; }

    }
}
