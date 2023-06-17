using BOL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CartBL
    {

        private CartDB obj;

        public CartBL()
        {
            obj = new CartDB();
        }

        public IEnumerable<tbl_Cart> GetAll()
        {
            return obj.GetAll();
        }

        public tbl_Cart GetbyId(int id)
        {
            return obj.GetbyId(id);
        }

        public void Insert(tbl_Cart cart)
        {
            obj.Insert(cart);
        }

        public void Update(tbl_Cart cart)
        {
            obj.Update(cart);
        }

        public void Delete(int id)
        {
            obj.Delete(id);
        }

    }
}
