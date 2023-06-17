using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderDB
    {
        private PerfumeStoreEntities db;

        public OrderDB()
        {
            db = new PerfumeStoreEntities();
        }

        public IEnumerable<tbl_Orders> GetAll()
        {
            return db.tbl_Orders.ToList();
        }

        public tbl_Orders GetbyCredentials(int id)
        {

            if (db.tbl_Orders.Find(id) == null)
            {
                return null;
            }
            else
            {
                return db.tbl_Orders.Find(id);
            }
        }

        public void Insert(tbl_Orders tblAdmins)
        {
            db.tbl_Orders.Add(tblAdmins);
            Save();
        }

        public void Update(tbl_Orders tblAdmins)
        {
            db.Entry(tblAdmins).State = System.Data.Entity.EntityState.Modified;
            Save();
        }

        public void Delete(int id)
        {
            tbl_Orders admin = db.tbl_Orders.Find(id);
            db.tbl_Orders.Remove(admin);
            Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }

    }
}
