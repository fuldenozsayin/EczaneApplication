//using DataAccess.Abstracts;
//using Entities.Concretes;
//using Entities.DTOs;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataAccess.Concretes.InMemory
//{
//    public class InMemoryProductDal : IProductDal
//    {
//        List<Product> _products;//Global Değişken
//        public InMemoryProductDal()
//        {
//            _products = new List<Product>
//            {
//                new Product{ProductId=1,CategoryId=2,ProductName="smfjksfn",UnitPrice=988},
//                new Product{ProductId=2,CategoryId=1,ProductName="smfjksfn",UnitPrice=99886},
//                new Product{ProductId=3,CategoryId=1,ProductName="smfjksfn",UnitPrice=78},
//                new Product{ProductId=4,CategoryId=3, ProductName="smfjksfn",UnitPrice=96},

//            };
            
//        }
//        public void Add(Product product)
//        {
//            _products.Add(product);
//            Console.WriteLine("Yeni ürün eklendi.");
//            Console.WriteLine(_products);
//        }

//        public void Delete(Product product)
//        {
//            _products.Remove(_products.SingleOrDefault(p => p.ProductId == product.ProductId)); 

//            Console.WriteLine("Ürün Silindi");
//            Console.WriteLine(_products);
//        }

//        public Product Get(Expression<Func<Product, bool>> filter)
//        {
//            throw new NotImplementedException();
//        }

//        public List<Product> GetAll()
//        {
//            return _products;
//        }

//        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
//        {
//            throw new NotImplementedException();
//        }

//        public List<Product> GetById(int productId)
//        {
           
//            return _products.Where(p => p.ProductId == productId).ToList();
//        }

//        public List<ProductDetailDto> GetProductDetails()
//        {
//            throw new NotImplementedException();
//        }

//        public void Update(Product product)
//        {
//            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
//            productToUpdate.UnitPrice = product.UnitPrice;
//            Console.WriteLine("Ürünler güncellendi.");
//            Console.WriteLine(_products);



//        }
//    }
//}
