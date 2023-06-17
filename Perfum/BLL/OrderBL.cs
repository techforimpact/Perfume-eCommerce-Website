using BOL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OrderBL
    {

        private OrderDB obj;

        public OrderBL()
        {
            obj = new OrderDB();
        }

        public IEnumerable<tbl_Orders> GetAll()
        {
            return obj.GetAll();
        }

        public tbl_Orders GetbyCredentials(int id)
        {
            return obj.GetbyCredentials(id);
        }

        public void Insert(tbl_Orders orders)
        {
            obj.Insert(orders);
        }

        public void Update(tbl_Orders orders)
        {
            obj.Update(orders);
        }

        public void Delete(int id)
        {
            obj.Delete(id);
        }
    }
}
