using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductDB
    {

        private PerfumeStoreEntities db;

        public ProductDB()
        {
            db = new PerfumeStoreEntities();
        }

        public IEnumerable<tbl_Products> GetAdmins()
        {
            return db.tbl_Products.ToList();
        }

        public tbl_Products GetbyId(int id)
        {

            if (db.tbl_Products.Find(id) == null)
            {
                return null;
            }
            else
            {
                return db.tbl_Products.Find(id);
            }
        }

        public tbl_Products GetbyName(string name)
        {
            if (db.tbl_Products.Find(name) == null)
            {
                return null;
            }
            else
            {
                return db.tbl_Products.Find(name);
            }
        }

        public void Insert(tbl_Products tblAdmins)
        {
            db.tbl_Products.Add(tblAdmins);
            Save();
        }

        public void Update(tbl_Products tblAdmins)
        {
            db.Entry(tblAdmins).State = System.Data.Entity.EntityState.Modified;
            Save();
        }

        public void Delete(int id)
        {
            tbl_Products admin = db.tbl_Products.Find(id);
            db.tbl_Products.Remove(admin);
            Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
