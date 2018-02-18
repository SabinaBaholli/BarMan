using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaSystem
{
    public class Table
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public Bill Bill;

        public int Owner { get; set; }
        public bool IsSelected { get; set; }

        public bool HasActiveBills()
        {
            return BillIsEmpty();
        }

        private bool BillIsEmpty()
        { 
         
            if (Bill.Items.Count == 0)
            {
                return true;
            }
            else
            {
                return false;  
            }
        }

        public Color GetColor()
        {
            if (IsSelected)
            {
                return Color.CadetBlue;
            }
            else
            {
                if (BillIsEmpty())
                {
                    return Color.LightSlateGray;
                }
                else
                {
                    return Color.IndianRed;
                }

            }

        }

        public int GetTotal()
        {
            double total = 0;
            if(Bill != null)
            {
                foreach (Item item in Bill.Items)
                {
                    total += item.Quantity * item.Price;
                }
            }

            return (int)total;
        }

        public void AddItem(int ItemId)
        {
            if (BillIsEmpty())
            {
                Bill = new Bill();
            }

            Bill.AddItem(ItemId);
        }

        public void RemoveItem(int ItemId)
        {
            if (BillIsEmpty())
            {
                Bill = new Bill();
            }

            Bill.RemoveItem(ItemId);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}