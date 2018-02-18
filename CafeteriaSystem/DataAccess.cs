using System;
using System.Collections;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Configuration;
using CafeteriaSystem.models;
using System.Globalization;

namespace CafeteriaSystem
{
    class DataAccess
    {
        string ConnectionString;
        int currentUser;
        public DataAccess()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["CafeteriaDBConnectionString"].ConnectionString;
        }

        /** Add New Category **/
        public bool AddNewCategoryToDatabase(string CategoryName)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                /*Start a local transaction*/
                SqlTransaction sqlTran = connection.BeginTransaction();

                /*Enlist a command in the current transaction*/
                SqlCommand command = connection.CreateCommand();
                command.Transaction = sqlTran;

                /*now we will save this array into our database*/

                try
                {
                    // Execute separate commands. -------------------------------
                    command.Parameters.AddWithValue("@CategoryName", CategoryName);

                    command.CommandText =
                       "Insert into Categories (Name) values (@CategoryName)";
                    command.ExecuteNonQuery();

                    // Commit the transaction.
                    sqlTran.Commit();

                    connection.Close();

                    return true;
                }
                catch (Exception ee)
                {
                    connection.Close();
                    return false;
                }
            }
        }

        /** Add New Supplier **/
        public bool AddNewSupplierToDatabase(string SupplierName, string PhoneNumber)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                /*Start a local transaction*/
                SqlTransaction sqlTran = connection.BeginTransaction();

                /*Enlist a command in the current transaction*/
                SqlCommand command = connection.CreateCommand();
                command.Transaction = sqlTran;

                /*now we will save this array into our database*/

                try
                {
                    // Execute separate commands. -------------------------------
                    command.Parameters.AddWithValue("@SupplierName", SupplierName);
                    command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);


                    command.CommandText =
                       "Insert into Suppliers (Name,PhoneNumber) values (@SupplierName,@PhoneNumber)";
                    command.ExecuteNonQuery();

                    // Commit the transaction.
                    sqlTran.Commit();

                    connection.Close();

                    return true;
                }
                catch (Exception ee)
                {
                    connection.Close();
                    return false;
                }
            }
        }


        /** Add New Unit **/
        public bool AddNewUnitToDatabase(string UnitName)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                /*Start a local transaction*/
                SqlTransaction sqlTran = connection.BeginTransaction();

                /*Enlist a command in the current transaction*/
                SqlCommand command = connection.CreateCommand();
                command.Transaction = sqlTran;

                /*now we will save this array into our database*/

                try
                {
                    // Execute separate commands. -------------------------------
                    command.Parameters.AddWithValue("@UnitName", UnitName);

                    command.CommandText =
                       "Insert into Quantity_Units (Name) values (@UnitName)";
                    command.ExecuteNonQuery();

                    // Commit the transaction.
                    sqlTran.Commit();

                    connection.Close();

                    return true;
                }
                catch (Exception ee)
                {
                    connection.Close();
                    return false;
                }
            }
        }

        /** Add New Table **/
        public bool AddNewTableToDatabase(string TableName, int OwnerId)
        {
            /* ne kete menyre, nuk kemi pse ta mbyllim connection*/
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                /*Start a local transaction*/
                SqlTransaction sqlTran = connection.BeginTransaction();

                /*Enlist a command in the current transaction*/
                SqlCommand command = connection.CreateCommand();
                command.Transaction = sqlTran;

                /*now we will save this array into our database*/

                try
                {
                    // Execute separate commands. -------------------------------
                    command.Parameters.AddWithValue("@TableName", TableName);
                    command.Parameters.AddWithValue("@OwnerId", OwnerId);


                    command.CommandText =
                       "Insert into Tables (Name,Owner) values (@TableName,@OwnerId)";
                    command.ExecuteNonQuery();

                    // Commit the transaction.
                    sqlTran.Commit();

                    connection.Close();

                    return true;
                }
                catch (Exception ee)
                {
                    connection.Close();
                    return false;
                }
            }
        }


        public ApplicationState GetState()
        {
            ApplicationState state = new ApplicationState();


            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Tables", connection);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int TableId = reader.GetInt32(0);
                        string TableName = reader.GetString(1);
                        int OwnerId = reader.GetInt32(2);
                        Table currentTable = new Table() { Id = TableId, Name = TableName, Owner = OwnerId };

                        // SELECT* FROM Items LEFT JOIN Bill_Items ON Items.Id = Bill_Items.ItemId LEFT JOIN Bills ON Bills.Id = Bill_Items.BillId;
                        currentTable.Bill = GetBillForTable(TableId);
                        state.Tables.Add(currentTable);
                    }
                }
            }
            return state;
        }

        public ArrayList GetItemsForBill(int UserId, int TableId, int BillId, int StatusId)
        {
            ArrayList items = new ArrayList();


            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                // Items of the Bill
                SqlCommand selectItems = new SqlCommand("SELECT* FROM Items LEFT JOIN Bill_Items ON Items.Id = Bill_Items.ItemId LEFT JOIN Bills ON Bills.Id = Bill_Items.BillId WHERE StatusId = '" + StatusId + "' AND TableId = '" + TableId + "' AND UserId = '" + UserId + "' AND BillId = '" + BillId + "'", connection);
                SqlDataReader itemsReader = selectItems.ExecuteReader();


                if (itemsReader.HasRows)
                {
                    while (itemsReader.Read())
                    {
                        int ItemId = itemsReader.GetInt32(0);
                        string ItemName = itemsReader.GetString(1);
                        //int ItemUnitId = itemsReader.GetInt32(3);
                        int ItemCategoryId = itemsReader.GetInt32(4);
                        int ItemQuantity = itemsReader.GetInt32(8);
                        double ItemPrice = (double)itemsReader.GetDecimal(5);

                        Item currentItem = new Item()
                        {
                            Id = ItemId,
                            Name = ItemName,
                            UnitId = 1,
                            CategoryId = ItemCategoryId,
                            Quantity = ItemQuantity,
                            Price = ItemPrice,
                        };


                        items.Add(currentItem);
                    }
                }
            }

            return items;
        }

        public Item GetItemsWithId(int ItemId)
        {
            Item item = new Item();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                // Items of the Bill
                SqlCommand selectItems = new SqlCommand("SELECT Id,Name,UnitId,CategoryId,Price FROM Items WHERE Id = '" + ItemId + "'", connection);
                SqlDataReader itemsReader = selectItems.ExecuteReader();


                if (itemsReader.HasRows)
                {
                    while (itemsReader.Read())
                    {
                        item.Id = itemsReader.GetInt32(0);
                        item.Name = itemsReader.GetString(1);
                        item.UnitId = 1;// itemsReader.GetInt32(2);
                        item.CategoryId = itemsReader.GetInt32(3);
                        item.Quantity = 1;
                        item.Price = (double)itemsReader.GetDecimal(4);
                    }
                }
            }

            return item;
        }


        public Bill GetBillForTable(int TableId)
        {
            Bill bills = new Bill();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                // Saved Bills
                SqlCommand selectBills = new SqlCommand("SELECT * FROM Bills WHERE StatusId = 1 AND TableId = '" + TableId + "'", connection);
                SqlDataReader billsReader = selectBills.ExecuteReader();


                if (billsReader.HasRows)
                {
                    while (billsReader.Read())
                    {
                        int BillId = billsReader.GetInt32(0);
                        int UserId = billsReader.GetInt32(1);
                        int StatusId = billsReader.GetInt32(4);

                        Bill currentBill = new Bill() { Id = BillId, UserId = UserId, StatusId = StatusId, TableId = TableId };

                        currentBill.Items = GetItemsForBill(6, TableId, BillId, 1);

                        bills = currentBill;
                    }
                }
            }

            return bills;
        }

        /** Retreive Suppliers **/
        public ArrayList RetreiveAllSuppliersFromDatabase()
        {
            ArrayList SuppliersList = new ArrayList();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Suppliers;", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int SupplierID = reader.GetInt32(0);
                        string SupplierPhone = reader.GetString(1);
                        string SupplierName = reader.GetString(2);

                        SuppliersList.Add(new Supplier() { ID = SupplierID, PhoneNumber = SupplierPhone, Name = SupplierName });
                    }
                }
                reader.Close();

                return SuppliersList;
            }
        }

        public ArrayList RetreiveAllItemsFromDatabase()
        {
            ArrayList ItemList = new ArrayList();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Items;", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int ItemId = reader.GetInt32(0);
                        string ItemName = reader.GetString(1);
                        int ItemQuantity = reader.GetInt32(5);

                        ItemList.Add(new Item() { Id = ItemId, Name = ItemName, Quantity = ItemQuantity });
                    }
                }
                reader.Close();

                return ItemList;
            }
        }
        public ArrayList RetreiveAllCategoriesFromDatabase()
        {
            ArrayList CategoriesList = new ArrayList();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT ID,Name FROM Categories;", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int CategoryID = reader.GetInt32(0);
                        string CategoryName = reader.GetString(1);

                        CategoriesList.Add(new Category() { ID = CategoryID, Name = CategoryName });
                    }
                }
                reader.Close();

                return CategoriesList;
            }
        }
        /** Retreive Units **/
        public ArrayList RetreiveAllUnitsFromDatabase()
        {
            ArrayList UnitsList = new ArrayList();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT ID,Name FROM Quantity_Units;", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int UnitID = reader.GetInt32(0);
                        string UnitName = reader.GetString(1);

                        UnitsList.Add(new Unit() { ID = UnitID, Name = UnitName });
                    }
                }
                reader.Close();

                return UnitsList;
            }
        }

        /** Retreive Roles **/
        public ArrayList RetreiveAllRoles()
        {
            ArrayList RolesList = new ArrayList();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT Id,Name FROM Roles;", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int UnitID = reader.GetInt32(0);
                        string UnitName = reader.GetString(1);

                        RolesList.Add(new Role() { ID = UnitID, Name = UnitName });
                    }
                }
                reader.Close();

                return RolesList;
            }
        }

        public ArrayList RetreiveAllSupplier()
        {
            ArrayList SuppliersList = new ArrayList();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT Id,PhoneNumber,Name FROM Suppliers;", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int SupplierID = reader.GetInt32(0);
                        string SupplierPhone = reader.GetString(1);
                        string SupplierName = reader.GetString(2);

                        SuppliersList.Add(new Supplier() { ID = SupplierID, PhoneNumber = SupplierPhone, Name = SupplierName });
                    }
                }
                reader.Close();

                return SuppliersList;
            }
        }

        /** Retreive Tables **/
        public ArrayList RetreiveAllTables()
        {
            ArrayList TablesList = new ArrayList();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT Id,Name,Owner FROM Tables;", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int TableId = reader.GetInt32(0);
                        string TableName = reader.GetString(1);
                        int TableOwner = reader.GetInt32(2);

                        TablesList.Add(new Table() { Id = TableId, Name = TableName, Owner = TableOwner });
                    }
                }
                reader.Close();

                return TablesList;
            }
        }

        /** Retreive SupplyId **/
        public ArrayList RetreiveAllSupplyId()
        {
            ArrayList SupplyIdList = new ArrayList();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT s.Id FROM FROM Items as i LEFT JOIN Supply_Items as si ON i.Id = si.ItemId LEFT JOIN Supplies as s ON s.Id = si.SupplyId LEFT JOIN Suppliers as srs ON s.SupplierId = srs.Id GROUP BY s.Id; ", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int SupplyId = reader.GetInt32(0);

                        SupplyIdList.Add(new Supply() { Id = SupplyId });
                    }
                }
                reader.Close();

                return SupplyIdList;
            }
        }



        /** Add New Product **/
        public bool AddNewProductToDatabase(string ProductName, decimal ProductPrice, int ProductCategoryID, int ProductUnitID)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                /*Start a local transaction*/
                SqlTransaction sqlTran = connection.BeginTransaction();

                /*Enlist a command in the current transaction*/
                SqlCommand command = connection.CreateCommand();
                command.Transaction = sqlTran;

                try
                {
                    // Execute separate commands.
                    command.Parameters.AddWithValue("@ProductName", ProductName);
                    command.Parameters.AddWithValue("@ProductPrice", ProductPrice);
                    command.Parameters.AddWithValue("@ProductCategoryID", ProductCategoryID);
                    command.Parameters.AddWithValue("@ProductUnitID", ProductUnitID);


                    command.CommandText =
                       "Insert into Items (Name, Price, CategoryId,UnitId) values (@ProductName, @ProductPrice, @ProductCategoryID, @ProductUnitID)";
                    command.ExecuteNonQuery();

                    // Commit the transaction.
                    sqlTran.Commit();

                    connection.Close();

                    return true;
                }
                catch (Exception ee)
                {
                    connection.Close();
                    return false;
                }
            }
        }

        /** Retreive Products **/
        public ArrayList RetreiveAllProducts()
        {
            ArrayList ProductsList = new ArrayList();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT Id, Name, Price, CategoryId,UnitId,Quantity from Items", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int ProductID = reader.GetInt32(0);
                        string ProductName = reader.GetString(1);
                        decimal ProductPrice = reader.GetDecimal(2);
                        int ProductCategoryID = reader.GetInt32(3);
                        string ProductCategoryName = ReturnCategoryName(ProductCategoryID);
                        int ProductUnitID = reader.GetInt32(4);
                        string ProductUnitName = ReturnUnitName(ProductUnitID);
                        int ProductQuantity = reader.GetInt32(5);


                        ProductsList.Add(new Details() { Name = ProductName, Price = ProductPrice, Category = ProductCategoryName, Unit = ProductUnitName, ID = ProductID, Quantity = ProductQuantity });
                    }
                }
                reader.Close();

                return ProductsList;
            }
        }

        /** Retreive Supplies **/
        public ArrayList RetreiveAllSupplies()
        {
            ArrayList SuppliesList = new ArrayList();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT s.Id, i.Name, si.Quantity, srs.Name, s.Date FROM Items as i LEFT JOIN Supply_Items as si ON i.Id = si.ItemId LEFT JOIN Supplies as s ON s.Id = si.SupplyId LEFT JOIN Suppliers as srs ON s.SupplierId = srs.Id; ", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string SupplyProductName = reader.GetString(1);
                        int SupplyQuantity = reader.GetInt32(2);
                        string SupplySupplier = reader.GetString(3);
                        DateTime SupplyDate = reader.GetDateTime(4);
                        int SupplyID = reader.GetInt32(0);

                        SuppliesList.Add(new Supply() { Id = SupplyID, Item = SupplyProductName, Quantity = SupplyQuantity, Supplier = SupplySupplier, Date = SupplyDate });
                    }
                }
                reader.Close();

                return SuppliesList;
            }
        }

        public ArrayList RetreiveAllBills()
        {
            ArrayList BillList = new ArrayList();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Bills;", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int billId = reader.GetInt32(0);
                        int tableId = reader.GetInt32(2);
                        DateTime date = reader.GetDateTime(3);
                        int Shpenzime = reader.GetInt32(5);

                        BillList.Add(new Bill() { Id = billId, TableId = tableId, Date = date, Shpenzimet = Shpenzime });
                    }
                }
                reader.Close();

                return BillList;
            }
        }

        /** Retreive Products From Category **/
        public ArrayList RetreiveProductsFromCategory(int CategoryID)
        {
            ArrayList ProductsList = new ArrayList();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT ID,Name,Price,UnitId FROM Items where CategoryId = '" + CategoryID + "';", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int ProductID = reader.GetInt32(0);
                        string ProductName = reader.GetString(1);
                        decimal ProductPrice = reader.GetDecimal(2);
                        //int ProductUnitID = reader.GetInt32(3);
                        //string ProductUnitName = ReturnUnitName(ProductUnitID);

                        ProductsList.Add(new Details() { ID = ProductID, Name = ProductName, Price = ProductPrice, Unit = "cope" });
                    }
                }
                reader.Close();

                return ProductsList;
            }
        }

        /** Return Category ID from Name **/
        public int ReturnCategoryID(string CategoryName)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT Id FROM Categories where Name = '" + CategoryName + "';", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                int CategoryID = 0;


                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        CategoryID = reader.GetInt32(0);
                    }
                }

                reader.Close();
                return CategoryID;
            }

        }

        /** Return Unit ID from Name **/
        public int ReturnUnitID(string UnitName)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT Id FROM Quantity_Units where Name = '" + UnitName + "';", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                int UnitID = 0;

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UnitID = reader.GetInt32(0);
                    }
                }
                reader.Close();

                return UnitID;
            }
        }

        /** Return Category Name from ID **/
        public string ReturnCategoryName(int CategoryID)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT Name FROM Categories where ID = '" + CategoryID + "';", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                string CategoryName = string.Empty;

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        CategoryName = reader.GetString(0);
                    }
                }
                reader.Close();

                return CategoryName;
            }
        }

        /** Return Unit Name from Id **/
        public string ReturnUnitName(int CategoryID)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT Name FROM Quantity_Units where ID = '" + CategoryID + "';", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                string UnitName = string.Empty;

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UnitName = reader.GetString(0);
                    }
                }
                reader.Close();

                return UnitName;
            }
        }

        /** Retreive Product Details From ID**/
        public Details RetreiveProductDetails(int ProductID)
        {
            Details ProductDetails = new Details();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT Name,Price,CategoryId,UnitId,Quantity FROM Items where ID = '" + ProductID + "';", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ProductDetails.Name = reader.GetString(0);
                        ProductDetails.Price = reader.GetDecimal(1);
                        int ProductCategoryID = reader.GetInt32(2);
                        ProductDetails.Category = ReturnCategoryName(ProductCategoryID);
                        int ProductUnitID = reader.GetInt32(3);
                        ProductDetails.Unit = ReturnUnitName(ProductUnitID);
                        ProductDetails.Quantity = reader.GetInt32(4);
                    }
                }
                reader.Close();

                return ProductDetails;
            }
        }

        /** Retreive Table Details From ID**/
        public Details RetreiveTableDetails(int TableID)
        {
            Details TableDetails = new Details();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT Name FROM Tables where ID = '" + TableID + "';", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        TableDetails.Name = reader.GetString(0);
                    }
                }
                reader.Close();

                return TableDetails;
            }
        }
        /** Delete Table **/
        public bool DeleteTable(int TableID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    SqlCommand command = new SqlCommand("Delete from Tables where ID = '" + TableID + "'", connection);
                    connection.Open();

                    if (command.ExecuteNonQuery() > 0)
                    {
                        connection.Close();
                        return true;
                    }
                    else return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }


        public Details RetreiveUnitDetails(int UnitID)
        {
            Details UnitDetails = new Details();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT Name FROM Quantity_Units where ID = '" + UnitID + "';", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UnitDetails.Name = reader.GetString(0);
                    }
                }
                reader.Close();

                return UnitDetails;
            }
        }
        public bool DeleteUnit(int UnitID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    SqlCommand command = new SqlCommand("Delete from Quantity_Units where ID = '" + UnitID + "'", connection);
                    connection.Open();

                    if (command.ExecuteNonQuery() > 0)
                    {
                        connection.Close();
                        return true;
                    }
                    else return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteCategory(int CategoryID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    SqlCommand command = new SqlCommand("Delete from Categories where ID = '" + CategoryID + "'", connection);
                    connection.Open();

                    if (command.ExecuteNonQuery() > 0)
                    {
                        connection.Close();
                        return true;
                    }
                    else return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteSupplier(int SupplierID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    SqlCommand command = new SqlCommand("Delete from Suppliers where ID = '" + SupplierID + "'", connection);
                    connection.Open();

                    if (command.ExecuteNonQuery() > 0)
                    {
                        connection.Close();
                        return true;
                    }
                    else return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteItemsInBill(int BillId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    SqlCommand command = new SqlCommand("Delete from Bill_Items where BillId = '" + BillId + "'", connection);
                    connection.Open();

                    if (command.ExecuteNonQuery() > 0)
                    {
                        connection.Close();
                        return true;
                    }
                    else return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }


        public int RetreiveItemQuantity(int itemId)
        {
            int quantity = 0;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {

                SqlCommand command = new SqlCommand("SELECT Quantity FROM Items where Id = '" + itemId + "';", connection);
                command.Parameters.AddWithValue("@itemid", itemId);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                
             
                if (reader.HasRows)
                        {
                        while (reader.Read())
                            {
                             quantity = reader.GetInt32(0);
                               }
                             }
              reader.Close();
                              


              
                connection.Close();

                return quantity;
            }

        }

        public bool UpdateItemQuantity(int itemId, int itemQuantity)
        {

            int currentQuantity = RetreiveItemQuantity(itemId);
            if(currentQuantity < itemQuantity)
            {
                return false;
            }
            if((currentQuantity - itemQuantity) < 30)
            {
                MessageBox.Show("Alert per sasi nen minimalen te produktit me ID: " + itemId);
            }
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                /*Start a local transaction*/
                SqlTransaction sqlTran = connection.BeginTransaction();

                /*Enlist a command in the current transaction*/
                SqlCommand command = connection.CreateCommand();
                command.Transaction = sqlTran;

                try
                {
                    // Execute separate commands.
                    command.Parameters.AddWithValue("@itemId", itemId);
                    command.Parameters.AddWithValue("@delta", itemQuantity);


                    command.CommandText =
                       "Update Items set Quantity = Quantity - @delta where Id = @itemId";
                   
                    command.ExecuteNonQuery();

                    // Commit the transaction.
                    sqlTran.Commit();

                    connection.Close();

                    return true;
                }
                catch (Exception ee)
                {
                    Console.Write(ee);
                    connection.Close();
                    return false;
                   
                }
            }
        }

        /** Delete Product **/
        public bool DeleteProduct(int ProductID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    SqlCommand command = new SqlCommand("Delete from Items where ID = '" + ProductID + "'", connection);
                    connection.Open();

                    if (command.ExecuteNonQuery() > 0)
                    {
                        connection.Close();
                        return true;
                    }
                    else return false;
                }
            }
            catch (Exception ee)
            {
                Console.Write(ee);
                return false;
            }
        }

        /** Update Table **/
        public bool UpdateTable(int TableID, string TableName)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                /*Start a local transaction*/
                SqlTransaction sqlTran = connection.BeginTransaction();

                /*Enlist a command in the current transaction*/
                SqlCommand command = connection.CreateCommand();
                command.Transaction = sqlTran;

                try
                {
                    // Execute separate commands.
                    command.Parameters.AddWithValue("@TableID", TableID);
                    command.Parameters.AddWithValue("@TableName", TableName);

                    command.CommandText =
                       "Update Tables set Name = @TableName where ID = @TableID";
                    command.ExecuteNonQuery();

                    // Commit the transaction.
                    sqlTran.Commit();

                    connection.Close();

                    return true;
                }
                catch (Exception ee)
                {
                    Console.Write(ee);
                    connection.Close();
                    return false;
                }
            }
        }

        public bool UpdateUnit(int UnitID, string UnitName)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                /*Start a local transaction*/
                SqlTransaction sqlTran = connection.BeginTransaction();

                /*Enlist a command in the current transaction*/
                SqlCommand command = connection.CreateCommand();
                command.Transaction = sqlTran;

                try
                {
                    // Execute separate commands.
                    command.Parameters.AddWithValue("@UnitID", UnitID);
                    command.Parameters.AddWithValue("@UnitName", UnitName);

                    command.CommandText =
                       "Update Quantity_Units set Name = @UnitName where ID = @UnitID";
                    command.ExecuteNonQuery();

                    // Commit the transaction.
                    sqlTran.Commit();

                    connection.Close();

                    return true;
                }
                catch (Exception ee)
                {
                    connection.Close();
                    return false;
                }
            }
        }


        public bool UpdateCategory(int CategoryID, string CategoryName)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                /*Start a local transaction*/
                SqlTransaction sqlTran = connection.BeginTransaction();

                /*Enlist a command in the current transaction*/
                SqlCommand command = connection.CreateCommand();
                command.Transaction = sqlTran;

                try
                {
                    // Execute separate commands.
                    command.Parameters.AddWithValue("@CategoryID", CategoryID);
                    command.Parameters.AddWithValue("@CategoryName", CategoryName);

                    command.CommandText =
                       "Update Categories set Name = @CategoryName where ID = @CategoryID";
                    command.ExecuteNonQuery();

                    // Commit the transaction.
                    sqlTran.Commit();

                    connection.Close();

                    return true;
                }
                catch (Exception ee)
                {
                    connection.Close();
                    return false;
                }
            }
        }

        public bool UpdateSuppliers(int SupplierID, string SupplierName, string PhoneNumber)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                /*Start a local transaction*/
                SqlTransaction sqlTran = connection.BeginTransaction();

                /*Enlist a command in the current transaction*/
                SqlCommand command = connection.CreateCommand();
                command.Transaction = sqlTran;

                try
                {
                    // Execute separate commands.
                    command.Parameters.AddWithValue("@SupplierID", SupplierID);
                    command.Parameters.AddWithValue("@SupplierName", SupplierName);
                    command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);


                    command.CommandText =
                       "Update Suppliers set Name = @SupplierName, PhoneNumber = @PhoneNumber where ID = @SupplierID";
                    command.ExecuteNonQuery();

                    // Commit the transaction.
                    sqlTran.Commit();

                    connection.Close();

                    return true;
                }
                catch (Exception ee)
                {
                    connection.Close();
                    return false;
                }
            }
        }


        /** Update Product **/
        public bool UpdateProduct(int ProductID, string ProductName, decimal ProductPrice, int ProductCategoryID, int unitId, int Quantity)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                /*Start a local transaction*/
                SqlTransaction sqlTran = connection.BeginTransaction();

                /*Enlist a command in the current transaction*/
                SqlCommand command = connection.CreateCommand();
                command.Transaction = sqlTran;

                try
                {
                    // Execute separate commands.
                    command.Parameters.AddWithValue("@ProductID", ProductID);
                    command.Parameters.AddWithValue("@ProductName", ProductName);
                    command.Parameters.AddWithValue("@ProductPrice", ProductPrice);
                    command.Parameters.AddWithValue("@ProductCategoryID", ProductCategoryID);
                    command.Parameters.AddWithValue("@unitId", unitId);
                    command.Parameters.AddWithValue("@ProductQuantity", Quantity);


                    command.CommandText =
                       "Update Items set Name = @ProductName, Price = @ProductPrice, CategoryId = @ProductCategoryID, UnitId = @unitId, Quantity = @ProductQuantity  where Id = @ProductID";
                    command.ExecuteNonQuery();

                    // Commit the transaction.
                    sqlTran.Commit();

                    connection.Close();

                    return true;
                }
                catch (Exception ee)
                {
                    connection.Close();
                    return false;
                }
            }
        }

        public bool UpdateBill(int BillId, int StatusId)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                /*Start a local transaction*/
                SqlTransaction sqlTran = connection.BeginTransaction();

                /*Enlist a command in the current transaction*/
                SqlCommand command = connection.CreateCommand();
                command.Transaction = sqlTran;

                try
                {
                    // Execute separate commands.
                    command.Parameters.AddWithValue("@BillId", BillId);
                    command.Parameters.AddWithValue("@StatusId", StatusId);

                    command.CommandText =
                       "Update Bills set StatusId = @StatusId where Id = @BillId";
                    command.ExecuteNonQuery();

                    // Commit the transaction.
                    sqlTran.Commit();

                    connection.Close();

                    return true;
                }
                catch (Exception ee)
                {
                    connection.Close();
                    return false;
                }
            }
        }



        /** Return Username from User ID **/
        public string ReturnUserName(int UserID)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT Name FROM Users where ID = '" + UserID + "';", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                string UserName = string.Empty;

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UserName = reader.GetString(0);
                    }
                }
                reader.Close();

                return UserName;
            }
        }

        /** Return User ID from Username **/
        public int ReturnUserID(string UserEmail)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT ID FROM Users where Username = '" + UserEmail + "';", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                int UserID = 0;

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UserID = reader.GetInt32(0);
                    }
                }
                reader.Close();

                return UserID;
            }
        }

        /** Return User ID from Username **/
        public int ReturnUserRole(string UserEmail)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT RoleId FROM Users where Username = '" + UserEmail + "';", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                int RoleID = 0;

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        RoleID = reader.GetInt32(0);
                    }
                }
                reader.Close();

                return RoleID;
            }
        }

        /** Confirm Users Password **/
        public bool ConfirmUser(string UserEmail, string UserPassword)
        {
            string PasswordFromDatabase = string.Empty;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT Password FROM Users where Username = '" + UserEmail + "';", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        PasswordFromDatabase = reader.GetString(0);
                    }
                }
                reader.Close();
            }

            if (SimpleHash.VerifyHash(UserPassword, PasswordFromDatabase))
            {
                return true;
            }
            else return false;
        }

        /** Register User **/
        public bool RegisterUser(string UserName, string UserEmail, string UserPassword, int UserRole)
        {
            UserPassword = SimpleHash.ComputeHash(UserPassword);

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("Insert into Users (Name, RoleId, Username, Password) values ('" + UserName + "', '" + UserRole + "', '" + UserEmail + "', '" + UserPassword + "');", connection);
                connection.Open();

                int RowsAffected = command.ExecuteNonQuery();

                if (RowsAffected > 0)
                {
                    return true;
                }
                else return false;
            }
        }

        public bool InsertItem(int BillId, int ItemId, int Quantity)
        {

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("Insert into Bill_Items (BillId, ItemId, Quantity) values ('" + BillId + "', '" + ItemId + "', '" + Quantity + "');", connection);
                connection.Open();

                int RowsAffected = command.ExecuteNonQuery();

                if (RowsAffected > 0)
                {
                    return true;
                }
                else return false;
            }
        }

        public int CreateBill(int UserId, int TableId, int StatusId, string expenses)
        {
            DateTime dt = DateTime.Now;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("Insert into Bills (UserId, TableId, StatusId, DateTime, Shpenzime) values ('" + UserId + "', '" + TableId + "', '" + StatusId + "',  '" + dt + "',  '" + expenses + "'); SELECT SCOPE_IDENTITY()", connection);
                connection.Open();

                //int RowsAffected = command.ExecuteNonQuery();

                int id = Convert.ToInt32(command.ExecuteScalar());

                return id;
            }
        }



        /**Sales**/

        public bool RecordASale(ArrayList ProductsList, DateTime SaleTime, int SalesmanID, decimal CashGiven, decimal TotalBill, decimal CashReturn)
        {
            int SaleID = ReturnSaleID();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                /*Start a local transaction*/
                SqlTransaction sqlTran = connection.BeginTransaction();

                /*Enlist a command in the current transaction*/
                SqlCommand command = connection.CreateCommand();
                command.Transaction = sqlTran;

                try
                {
                    // Execute separate commands.
                    command.Parameters.AddWithValue("@SaleTime", SaleTime);
                    command.Parameters.AddWithValue("@SalesmanID", SalesmanID);
                    command.Parameters.AddWithValue("@CashGiven", CashGiven);
                    command.Parameters.AddWithValue("@TotalBill", TotalBill);
                    command.Parameters.AddWithValue("@CashReturn", CashReturn);

                    command.CommandText =
                       "Insert into Sales (SaleTime, SalesmanID, CashGiven, TotalBill, CashReturn) values (@SaleTime, @SalesmanID, @CashGiven, @TotalBill, @CashReturn)";
                    command.ExecuteNonQuery();

                    foreach (Details ProductDetail in ProductsList)
                    {
                        //// Execute separate commands.
                        //command.Parameters.AddWithValue("@ProductName", ProductDetail.Name);
                        //command.Parameters.AddWithValue("@ProductPrice", ProductDetail.Price);
                        //command.Parameters.AddWithValue("@ProductQuantity", ProductDetail.Quantity);
                        //command.Parameters.AddWithValue("@ProductTotal", ProductDetail.Total);
                        //command.Parameters.AddWithValue("@SaleID", SaleID);

                        command.CommandText =
                           "Insert into SaleItems (ProductName, ProductPrice, ProductQuantity, ProductTotal, SaleID) values ('" + ProductDetail.Name + "', '" + ProductDetail.Price + "', '" + ProductDetail.Quantity + "', '" + ProductDetail.Total + "', '" + SaleID + "')";
                        command.ExecuteNonQuery();
                    }

                    // Commit the transaction.
                    sqlTran.Commit();

                    connection.Close();

                    return true;
                }
                catch (Exception ee)
                {
                    connection.Close();
                    return false;
                }
            }
        }

        public int ReturnSaleID()
        {
            int SaleID = 1;
            try
            {

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    SqlCommand command = new SqlCommand("SELECT MAX(ID) FROM Sales;", connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            SaleID = reader.GetInt32(0);
                        }
                    }
                    reader.Close();

                    SaleID = SaleID + 1;

                    return SaleID;
                }
            }
            catch (Exception)
            {
                return SaleID;
            }
        }

        public ArrayList RetreiveAllSales(int UserId)
        {
            ArrayList SalesList = new ArrayList();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Bills WHERE Bills.StatusId = 2;", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int SaleID = reader.GetInt32(0);
                        int TableID = reader.GetInt32(2);

                        SalesList.Add(new Details() { SaleID = SaleID, Quantity = TableID });
                    }
                }
                reader.Close();

                return SalesList;
            }
        }


        public ArrayList retreiveKamarieret()
        {
            ArrayList kamarieret = new ArrayList();


            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE RoleId = 2", connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        int KamarierId = reader.GetInt32(0);
                        string KamarierName = reader.GetString(1);

                        kamarieret.Add(new User() { Id = KamarierId, Name = KamarierName });
                    }
                }
                reader.Close();

                return kamarieret;
            }


        }

        public bool DeleteRole(int TableID)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {

                connection.Open();

                /*Start a local transaction*/
                SqlTransaction sqlTran = connection.BeginTransaction();

                /*Enlist a command in the current transaction*/
                SqlCommand command = connection.CreateCommand();
                command.Transaction = sqlTran;

                try
                {
                    int RoleId = 2;

                    // Execute separate commands.
                    command.Parameters.AddWithValue("@TableID", TableID);
                    command.Parameters.AddWithValue("@RoleId", RoleId);


                    command.CommandText =
                       "Update Tables set Owner = @RoleId where ID = @TableID";
                    command.ExecuteNonQuery();

                    // Commit the transaction.
                    sqlTran.Commit();

                    connection.Close();

                    return true;
                }
                catch (Exception ee)
                {
                    Console.Write(ee);
                    connection.Close();
                    return false;
                }
            }
        }

        public bool EditRole(int TableID, int owner)
        {
            int newOwner = owner;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {

                connection.Open();

                /*Start a local transaction*/
                SqlTransaction sqlTran = connection.BeginTransaction();

                /*Enlist a command in the current transaction*/
                SqlCommand command = connection.CreateCommand();
                command.Transaction = sqlTran;

                try
                {
                    int RoleId = 10;

                    // Execute separate commands.
                    command.Parameters.AddWithValue("@TableID", TableID);
                    command.Parameters.AddWithValue("@newOwner", newOwner);


                    command.CommandText =
                       "Update Tables set Owner = @newOwner where ID = @TableID";
                    command.ExecuteNonQuery();

                    // Commit the transaction.
                    sqlTran.Commit();

                    connection.Close();

                    return true;
                }
                catch (Exception ee)
                {
                    Console.Write(ee);
                    connection.Close();
                    return false;
                }
            }
        }


        public ArrayList RetreiveDailySales()
        {
            ArrayList DailySales = new ArrayList();
            DateTime today = DateTime.Today;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Bills WHERE DateTime>=@date AND DateTime < DATEADD(d,1,@date)", connection);
                command.Parameters.AddWithValue("@date", today);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        int xhiro = reader.GetInt32(5);

                        DailySales.Add(new Bill() { Shpenzimet = xhiro });
                    }
                }
                reader.Close();

                return DailySales;
            }

        }

        public ArrayList retreiveTables(int userId)
        {
            ArrayList tableList = new ArrayList();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Tables WHERE Owner = '" + userId + "';", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int TableId = reader.GetInt32(0);
                        string TableName = reader.GetString(1);
                        int TableOwner = reader.GetInt32(2);

                        tableList.Add(new Table() { Id = TableId, Name = TableName, Owner = TableOwner });
                    }
                }
                reader.Close();

                return tableList;

            }
        }

        public bool AddSupply(string SupplierId, DateTime thisDay, string ItemId, int itemQuantity, int itemPrice)
        {
            int supplierId = Convert.ToInt32(SupplierId);
            int itemId = Convert.ToInt32(ItemId);
            DateTime today = thisDay;
            int productQuant = itemQuantity;
            int Price = itemPrice;
            int lastSupplyId;
            string q1 = "Insert into Supplies (SupplierId,Date) values (@supplierId,@Date);"+
            "Select Scope_Identity()";


            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(q1, connection);

                try
                {
                    // Execute separate commands.
                    command.Parameters.AddWithValue("@supplierId", supplierId);
                    command.Parameters.AddWithValue("@Date", today);


                    connection.Open();
                    lastSupplyId = Convert.ToInt32(command.ExecuteScalar());

                    connection.Close();

                    if (query(lastSupplyId, itemId, productQuant)) {
                        return true;
                    }
                    return false;

                }
                catch (Exception ee)
                {
                    Console.Write(ee);
                    connection.Close();
                    return false;
                }
            }
         
        }


        public ArrayList RetreiveSaleItems(int SaleID)
        {
            ArrayList ProductsList = new ArrayList();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("Select Bills.Id, Items.Name, Items.Price, Bill_Items.Quantity FROM Bills JOIN Bill_Items ON Bills.Id = Bill_Items.BillId JOIN Items ON Bill_Items.ItemId = Items.Id WHERE Bills.Id = '" + SaleID + "';", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string ProductName = reader.GetString(1);
                        decimal ProductPrice = (int)reader.GetDecimal(2);
                        int ProductQuantity = reader.GetInt32(3);


                        ProductsList.Add(new Details() { Name = ProductName, Price = ProductPrice, Quantity = ProductQuantity, Total = ProductQuantity * ProductPrice });
                    }
                }
                reader.Close();

                return ProductsList;
            }
        }

        private bool query(int supplyId, int itemID, int itemquant)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {

                int lastSupplyId = supplyId;
                int productQuant = itemquant;
                int itemId = itemID;
                connection.Open();

                /*Start a local transaction*/
                SqlTransaction sqlTran = connection.BeginTransaction();

                /*Enlist a command in the current transaction*/
                SqlCommand command = connection.CreateCommand();
                command.Transaction = sqlTran;

                try
                {
                    // Execute separate commands.
                    command.Parameters.AddWithValue("@SupplyId", lastSupplyId);
                    command.Parameters.AddWithValue("@productQuant", productQuant);
                    command.Parameters.AddWithValue("@itemId", itemId);

                    command.CommandText =
                    "Insert into Supply_Items (Quantity,SupplyId,ItemId) values (@productQuant,@SupplyId,@itemId); Update Items set Quantity = Quantity + @productQuant where Id = @itemId";
                    command.ExecuteNonQuery();

                    // Commit the transaction.
                    sqlTran.Commit();

                    connection.Close();

                    return true;
                }
                catch (Exception ee)
                {
                    Console.Write(ee);
                    connection.Close();
                    return false;
                }
            }
        }
    }

}
