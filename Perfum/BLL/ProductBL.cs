using BOL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductBL
    {
        private ProductDB obj;

        public ProductBL()
        {
            obj = new ProductDB();

        }

        public IEnumerable<tbl_Products> GetAll()
        {
            return obj.GetAdmins();
        }

        public tbl_Products GetbyId(int id)
        {

            return obj.GetbyId(id);
        }

        public tbl_Products GetbyName(string name)
        {
            return obj.GetbyName(name);
        }

        public void Insert(tbl_Products tblAdmins)
        {
            obj.Insert(tblAdmins); 
        }

        public void Update(tbl_Products tblAdmins)
        {
            obj.Update(tblAdmins);
        }

        public void Delete(int id)
        {
            obj.Delete(id);
        }
    }
}
