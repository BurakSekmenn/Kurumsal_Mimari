using Core.DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductDal: IEntityRepository<Product>
    {
        // Repository Pattern
        // Listeleme 
        // Ekleme
        // Silme
        // Güncelleme
    }
    //public interface IPorductDal : Product
    //{
     // aslında burada ekleme güncelleme vb yapılır implet edilib ama biz Bir tan IEntityRepository oluşturduk burada hıızlıca yapmak çiin
    //}
}
