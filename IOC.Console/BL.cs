using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOC.console
{
    public class BL
    {
        public IDAL _dal { get; set; }

        public BL()
        {
            _dal = DALFactory.GetDal();
            // _dal.CalculateTotal() can't be reached until implementing on IDAL interface.
        }

        public List<Product> GetProducts()
        {
            return _dal.GetProducts();
        }
    }
}