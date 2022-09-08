using Norhwind.Business.Abstract;
using Norhwind.Business.Utilies;
using Norhwind.Business.ValidationRules.FluentValidation;
using Norhwind.DataAccess.Abstract;
using Norhwind.DataAccess.Concrete;
using Norhwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norhwind.Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            try
            {
                _productDal.Delete(product);
            }
            catch (DbUpdateException exception)
            {
                throw new Exception("deletion failed");
            }
        }

        public List<Product> GetAll()
        {
            //Business code. =>Bu kişi datayı çekiyor ama bu datayı çekebilirmi ? //Kurallar ve yetkiler
            return _productDal.GetAll();
        }

        public List<Product> GetProductsByCategory(int cateogryId)
        {
            return _productDal.GetAll(p => p.CategoryId == cateogryId);
        }

        public List<Product> GetProductsByProductName(string productName, int categoryId)
        {
            return _productDal.GetAll(p => p.ProductName.ToLower().Contains(productName.ToLower()) && p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
