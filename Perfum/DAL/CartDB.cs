using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CartDB
    {

        private PerfumeStoreEntities db;

        public CartDB()
        {
            db = new PerfumeStoreEntities();
        }

        public IEnumerable<tbl_Cart> GetAll()
        {
            return db.tbl_Cart.ToList();
        }

        public tbl_Cart GetbyId(int id)
        {

            if (db.tbl_Cart.Find(id) == null)
            {
                return null;
            }
            else
            {
                return db.tbl_Cart.Find(id);
            }
        }

        public void Insert(tbl_Cart tblAdmins)
        {
            db.tbl_Cart.Add(tblAdmins);
            Save();
        }

        public void Update(tbl_Cart tblAdmins)
        {
            db.Entry(tblAdmins).State = System.Data.Entity.EntityState.Modified;
            Save();
        }

        public void Delete(int id)
        {
            tbl_Cart admin = db.tbl_Cart.Find(id);
            db.tbl_Cart.Remove(admin);
            Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
