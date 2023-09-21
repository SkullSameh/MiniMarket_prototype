using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject_190209998.Models;
using SQLite;

namespace FinalProject_190209998.DataTrans
{
    public class MarketDB
    {
        public string Path;
        private SQLiteConnection conn;

        public MarketDB(string dbPAth)
        {
            Path = dbPAth;
        }

        #region Customer
        public void Init()
        {
            conn = new SQLiteConnection(Path);
            conn.CreateTable<Customer>();
            conn.CreateTable<Peoduct>();
            conn.CreateTable<Order>();
            conn.CreateTable<Payment>();
        }

        public void Add(Customer customer)
        {
            conn = new SQLiteConnection(Path);
            conn.Insert(customer);
        }

	//Get Specific thing
        public string GetName()
        {
            conn = new SQLiteConnection(Path);
            List<Customer> list = conn.Table<Customer>().ToList();
            if(list.Count > 0)
            {
                return list.LastOrDefault().Cust_Name;
            }
            else
            {
                return null;
            }


        }

        public string GetEmail()
        {
            conn = new SQLiteConnection(Path);
            List<Customer> list = conn.Table<Customer>().ToList();

            if (list.Count > 0)
            {
                return list.LastOrDefault().Cust_Email;
            }
            else
            {
                return null;
            }
            
        }

        public string GetPhone()
        {
            conn = new SQLiteConnection(Path);
            List<Customer> list = conn.Table<Customer>().ToList();

            if (list.Count > 0)
            {
                return list.LastOrDefault().Cust_Phone;
            }
            else
            {
                return null;
            }
            
        }

        public string GetAddress()
        {
            conn = new SQLiteConnection(Path);
            List<Customer> list = conn.Table<Customer>().ToList();

            if (list.Count > 0)
            {
                return list.LastOrDefault().Cust_Address;
            }
            else
            {
                return null;
            }
            
        }

        public void Delete()
        {
            conn = new SQLiteConnection(Path);
            List<Customer> list = conn.Table<Customer>().ToList();
            if (list.Count > 0)
            {
                conn.Delete(list.LastOrDefault());
            }
            
        }

        #endregion

        #region Product

        public void AddPro(Peoduct Pro)
        {
            conn = new SQLiteConnection(Path);
            conn.Insert(Pro);
        }

        public List<Peoduct> GetProList()
        {
            return conn.Table<Peoduct>().ToList();

        }

        public void DeletePro()
        {
            conn = new SQLiteConnection(Path);
            conn.DeleteAll(conn.Table<Peoduct>().Table);
        }

        public int DeleteOnePro(int num)
        {
            int res = 0;
            res = conn.Delete<Peoduct>(num);
            return res;
        }

        #endregion

        public void AddOrder(Order or)
        {
            conn = new SQLiteConnection(Path);
            conn.Insert(or);
        }

        public List<Order> getALLorder()
        {
            return conn.Table<Order>().ToList();
        }
        public int GetOrdPrice()
        {
            conn = new SQLiteConnection(Path);
            List<Order> list = conn.Table<Order>().ToList();

            if (list.Count > 0)
            {
                return list.LastOrDefault().Ord_Price;
            }
            else
            {
                return 0;
            }

        }

        public void DeleteOrd()
        {
            conn = new SQLiteConnection(Path);
            conn.DeleteAll(conn.Table<Order>().Table);

        }



        public void AddPay(Payment PaY)
        {
            conn = new SQLiteConnection(Path);
            conn.Insert(PaY);
        }


        public List<Payment> GetPayList()
        {
            return conn.Table<Payment>().ToList();

        }

        public void DeletePay()
        {
            conn = new SQLiteConnection(Path);
            conn.DeleteAll(conn.Table<Payment>().Table);


        }
    }
}
