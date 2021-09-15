using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAllByCategoryId(int id);
        List<Product> GetAll();
        List<Product> GetAllUnitPrice(decimal min, decimal max);
        List<ProductDetailDto> GetProductDetails();
    }
}
