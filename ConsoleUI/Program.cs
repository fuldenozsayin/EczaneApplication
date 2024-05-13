using Business.Concretes;
using DataAccess.Concretes.EntityFramework;

namespace ConsoleUI;
class Program
{
    static void Main(string[] args)
    {
        ProductTest();
        //Console.WriteLine("\n---------------------------------------------");
        //foreach (var product in productManager.GetAllByCategoryId(2))
        //{
        //    Console.WriteLine(product.ProductName);
        //}
        //Console.WriteLine("\n----------------------------------------------");
        //foreach (var product in productManager.GetByUnitPrice(50, 100))
        //{
        //    Console.WriteLine(product.ProductName);
        //}

        Console.WriteLine("\n----------------------------------------------");
       // CategoryTest();
    }

    private static void CategoryTest()
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

        foreach (var category in categoryManager.GetAll().Data)
        {
            Console.WriteLine(category.CategoryName);
        }
    }

    private static void ProductTest()
    {
        ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));
        var result = productManager.GetProductDetails();
        if (result.Success == true)
        {
            foreach (var product in result.Data)
            {
                Console.WriteLine(product.ProductName + "/" + product.CategoryName);
            }

        }
        else
        {
            Console.WriteLine(result.Message);
        }
    }
}