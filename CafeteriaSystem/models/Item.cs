using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaSystem
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UnitId { get; set; }
        public int CategoryId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
        public string ID { get; set; }

        public double Total()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}