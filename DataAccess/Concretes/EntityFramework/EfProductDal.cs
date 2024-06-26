﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    //EFEntityRepositoryBase, IProductDal a diyor ki implement etmek istediklerin bende var EFProductDal da ondan impelement edildiğinii söylüyor
    public class EfProductDal : EfEntityRepositoryBase<Product, EczAppContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (EczAppContext context = new EczAppContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailDto
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName,
                                 UnitsInStock = p.UnitsInStock
                             };
                return result.ToList();
            }
        }
    }
}
