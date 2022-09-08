using Norhwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norhwind.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal:EfEntitiyRepositoryBase<Category,NorthwindContext>,ICategoryDal
    {
    }
}
