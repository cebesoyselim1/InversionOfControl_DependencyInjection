using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOC.console
{
    public class BL
    {
        public DAL _dal { get; set; }

        public BL()
        {
            _dal = DALFactory.GetDal();
        }

        public List<Product> GetProducts()
        {
            return _dal.GetProducts();
        }
    }
}