using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AdminDB
    {
        private PerfumeStoreEntities db;

        public AdminDB() { 
            db = new PerfumeStoreEntities();
        }

        public IEnumerable<tbl_Admins> GetAdmins()
        {
            return db.tbl_Admins.ToList();
        }

        public bool GetbyCredentials(string username, string password)
        {
            
            if(db.tbl_Admins.Find(username, password) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Insert(tbl_Admins tblAdmins)
        {
            db.tbl_Admins.Add(tblAdmins);
            Save();
        }

        public void Update(tbl_Admins tblAdmins)
        {
            db.Entry(tblAdmins).State = System.Data.Entity.EntityState.Modified;
            Save();
        }

        public void Delete(int id)
        {
            tbl_Admins admin = db.tbl_Admins.Find(id);
            db.tbl_Admins.Remove(admin);
            Save();
        }
        

        public void Save()
        {
            db.SaveChanges();
        }


    }
}
