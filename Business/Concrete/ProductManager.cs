using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        //EfProductDal Kullanacam
        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
