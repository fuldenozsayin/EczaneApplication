using Business.Abstracts;
using Business.Concretes;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    //Bir controller ın controller olavbilmesi için
    //ControllerBase den inhertance edilmesi ve
    //[ApiController] yani attribute (java da annotation) -> sınıf hakkında bilgi veriyor. Bu sınıf bir controller dır diyor
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService; //defaultu private
        //Soyut bağımlılığı olduğu için zayıf (loosely coupled)

        //IoC Container (Inversion of Control) -> Bellekteki bi yere liste gibi düşün new yazayım, onun içine referanslar koyayım ondan sonra kim ihtiyaç duyuyorsa ben senin için newledim l kullan diyor. 
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result);//200 OK
            }
            return BadRequest(result);//400 Bad Request
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
