using accessing_db.Interfaces;
using accessing_db.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace deploy_sample.Controllers
{
    // http://localhost:5226/api/products
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProduct _productRepository { get; set; }

        public ProductsController()
        {
            _productRepository = new ProductRepository();
        }

        // CRUD - Create,   Read,   Update,             Delete
        //      - HttpPost, HttGet, HttpPut/HttpPatch,  HttpDelete
        [HttpGet]
        public string Get()
        {
            return "oi";

        }
    }
}