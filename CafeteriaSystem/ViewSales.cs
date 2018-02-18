using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeteriaSystem
{
    public partial class ViewSales : Form
    {
        public ViewSales()
        {
            InitializeComponent();
        }

        private void ViewSales_Load(object sender, EventArgs e)
        {
            DataAccess _DataAccess = new DataAccess();

            foreach (Bill bill in _DataAccess.RetreiveAllBills())
            {
                salesGridView1.Rows.Add(bill.Id, bill.TableId, bill.Date, bill.Shpenzimet);
            }
        }
    }
}
