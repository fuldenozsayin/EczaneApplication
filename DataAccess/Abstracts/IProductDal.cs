using Core.DataAccess;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface IProductDal:IEntityRepository<Product>
    {
        //Buraya ürüne ait özel operasyonları koyacağız
        //Örneğin ürünün detaylarını getirmek için, ürün category tablolarına joina tmak için...
        List<ProductDetailDto> GetProductDetails();


    }
}
