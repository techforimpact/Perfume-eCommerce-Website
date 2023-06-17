using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerDB
    {
        private PerfumeStoreEntities db;

        public CustomerDB()
        {
            db = new PerfumeStoreEntities();
        }

        public IEnumerable<tbl_Customers> GetAll()
        {
            return db.tbl_Customers.ToList();
        }

        public tbl_Customers GetbyCredentials(string email, string password)
        {

            if (db.tbl_Customers.Find(email, password) == null)
            {
                return null;
            }
            else
            {
                return db.tbl_Customers.Find(email, password);
            }
        }

        public void Insert(tbl_Customers tblAdmins)
        {
            db.tbl_Customers.Add(tblAdmins);
            Save();
        }

        public void Update(tbl_Customers tblAdmins)
        {
            db.Entry(tblAdmins).State = System.Data.Entity.EntityState.Modified;
            Save();
        }

        public void Delete(int id)
        {
            tbl_Customers admin = db.tbl_Customers.Find(id);
            db.tbl_Customers.Remove(admin);
            Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }

    }
}
