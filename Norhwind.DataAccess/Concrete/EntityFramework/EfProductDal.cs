using Norhwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Norhwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal :EfEntitiyRepositoryBase<Product,NorthwindContext>, IProductDal
    {
      
    }
}
