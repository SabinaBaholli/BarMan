
using System;
namespace CafeteriaSystem
{
    class Details
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public byte[] Picture { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
        public string Category { get; set; }
        public string Supplier { get; set; }
        public string Description;
        public string Unit { get; set; }

        public int SaleID { get; set; }
        public DateTime SaleTime;
        public int SalesmanID;
    }
}
