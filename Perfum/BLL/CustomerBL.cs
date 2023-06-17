using BOL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CustomerBL
    {
        private CustomerDB obj;

        public CustomerBL()
        {
            obj = new CustomerDB();
        }

        public IEnumerable<tbl_Customers> GetAll()
        {
            return obj.GetAll();
        }

        public tbl_Customers GetbyCredentials(string email, string password)
        {
            return obj.GetbyCredentials(email, password);
        }

        public void Insert(tbl_Customers customer)
        {
            obj.Insert(customer);
        }

        public void Update(tbl_Customers customer)
        {
            obj.Update(customer);
        }

        public void Delete(int id)
        {
            obj.Delete(id);
        }

    }
}
