using Demo_MVC_API.Model;
using Demo_MVC_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Demo_MVC_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductServices _prodservice;
        public ProductController(IProductServices prodservice)
        {
            _prodservice = prodservice;
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/Product/GetProducts")]
        public IActionResult GetProducts()
        {
            return new ObjectResult(_prodservice.GetAllProducts());
        }
        [HttpPost]
        [Route("AddProduct")]
        public IActionResult AddProduct(Product prod)
        {
            return new ObjectResult(_prodservice.AddProduct(prod));
        }

        [HttpPost]
        [Route("ModifyProduct")]
        public IActionResult ModifyProduct(Product prod)
        {
            return new ObjectResult(_prodservice.ModifyProduct(prod));
        }

        [HttpGet]
        [Route("DeleteBatch/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            return new ObjectResult(_prodservice.DeleteProduct(id));
        }





        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
