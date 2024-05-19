using Business.Abstracts;
using Core.Entities.Concrete;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellersController : ControllerBase
    {
        ISellerService _sellerService;
        public SellersController(ISellerService sellerService)
        {
            _sellerService = sellerService;            
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _sellerService.GetAll();
            if (result.Success)
            {
                return Ok(result);//200 OK
            }
            return BadRequest(result);//400 Bad Request
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _sellerService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Seller seller)
        {
            var result = _sellerService.Add(seller);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}