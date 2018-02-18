using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaSystem
{
    public class Bill
    {
        public int Id { get; set; }
        public int UnitId { get; set; }
        public int UserId { get; set; }
        public int TableId { get; set; }
        public int StatusId { get; set; }
        public DateTime Date { get; set; }

        public int Shpenzimet { get; set; }

        public ArrayList Items = new ArrayList();

        public double Total()
        {
            double total = 0;
            foreach (Item item in Items)
            {
                total += item.Total();
            }

            return total;
        }

        public bool ItemAlreadyExists(int ItemId)
        {
            bool exists = false;

            foreach (Item item in Items)
            {
                if (item.Id == ItemId)
                {
                    exists = true;
                }
            }

            return exists;
        }

        public void AddItem(int ItemId)
        {
            if (ItemAlreadyExists(ItemId))
            {
                foreach (Item item in Items)
                {
                    if (item.Id == ItemId)
                    {
                        item.Quantity += 1;
                    }
                }
            } else
            {
                DataAccess _DataAccess = new DataAccess();
                Items.Add(_DataAccess.GetItemsWithId(ItemId));
            }
        }

        public void RemoveItem(int ItemId)
        {
            if (ItemAlreadyExists(ItemId))
            {
                foreach (Item item in Items.ToArray())
                {
                    if (item.Id == ItemId)
                    {
                        
                        if(item.Quantity > 1)
                        {
                            item.Quantity -= 1;
                        } else
                        {
                            int IndexOfItem = Items.IndexOf(item);
                            Items.RemoveAt(IndexOfItem);
                            
                        }
                    }
                }
            }
        }

        public override string ToString()
        {
            return "";
        }
    }
}