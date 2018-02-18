using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeteriaSystem
{
    public class ApplicationState
    {
        public ArrayList Tables = new ArrayList();

        public void SetActiveTable(int Id)
        {
            foreach(Table table in Tables)
            {
                if(table.Id == Id)
                {
                    table.IsSelected = true;
                } else
                {
                    table.IsSelected = false;
                }
            }
        }

        public Table GetSelectedTable()
        {
            Table selectedTable = new Table();

            foreach (Table table in Tables)
            {
                if (table.IsSelected)
                {
                    selectedTable = table;
                }
            }

            return selectedTable;
        }

        public int GetTotal()
        {
            return GetSelectedTable().GetTotal();
        }

        public void AddItem(int ItemId)
        {
            Table selectedTable = GetSelectedTable();
            selectedTable.AddItem(ItemId);

        }

        public bool PersistBill(int UserId, int StatusId, string expenses)
        {
            
            Table selectedTable = GetSelectedTable();
            Bill bill = GetSelectedTable().Bill;
            DataAccess _DA = new DataAccess();
           

            if (bill != null)
            {
                if (bill.Id > 0)
                {
                    // Update items
                    if (StatusId == 1)
                    {
                        _DA.DeleteItemsInBill(bill.Id);

                        foreach (Item item in bill.Items)
                        {
                            _DA.InsertItem(bill.Id, item.Id, item.Quantity);
                        }
                    } else if (StatusId == 2)
                    {
                        _DA.UpdateBill(bill.Id, StatusId);
                    }

                } else
                {
                    // create 
                    int billId = _DA.CreateBill(UserId, selectedTable.Id, StatusId, expenses);
                    foreach (Item item in bill.Items)
                    {
                        _DA.InsertItem(billId, item.Id, item.Quantity);
                        if (!_DA.UpdateItemQuantity(item.Id, item.Quantity)) {
                            MessageBox.Show("Nuk ka mjaftueshem sasi!");
                            return false;
                        };
                    }
                }
            }
            return true;
        }

        public void RemoveItem(int ItemId)
        {
            Table selectedTable = GetSelectedTable();
            selectedTable.RemoveItem(ItemId);

        }



    }
}
