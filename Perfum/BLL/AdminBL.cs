using BOL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AdminBL
    {
        private AdminDB obj;

        public AdminBL() 
        {
            obj= new AdminDB();
        }

        public IEnumerable<tbl_Admins> GetAll()
        {
            return obj.GetAdmins();
        }

        public bool GetbyCredentials(string username , string password)
        {
            return obj.GetbyCredentials(username, password);
        }

        public void Insert(tbl_Admins admin)
        {
            obj.Insert(admin);
        }

        public void Update(tbl_Admins admin)
        {
            obj.Update(admin);
        }

        public void Delete(int id)
        {
            obj.Delete(id);
        }

    }
}
