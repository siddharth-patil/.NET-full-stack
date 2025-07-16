using GenericRepositoryPatternDemo.DataAccess.Repositories.ProductRepository;
using GenericRepositoryPatternDemo.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GenericRepositoryPatternDemo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductRepositpry prod_repo_ref;

        public ProductController(IProductRepositpry repositpry) 
        {
            prod_repo_ref = repositpry;
        }

        // GET: <ProductController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET <ProductController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST <ProductController>
        [HttpPost]
        public IActionResult Post([FromBody] ProductViewModel receivedProduct)
        {
            try
            {
                if (receivedProduct != null)
                {
                    Products products = new Products
                    {
                        Id = receivedProduct.Id,
                        Name = receivedProduct.Name,
                        Description = receivedProduct.Description,
                        Price = receivedProduct.Price,
                        CategoryId = Convert.ToInt32(receivedProduct.CatagoryName)
                    };

                    if (prod_repo_ref.Add(products))
                    {
                        return Ok("Product added successfully...");
                    }
                    else
                    {
                        return BadRequest("Problem in adding a product..");
                    }
                }
                else
                {
                    return BadRequest("Valid product is not received..");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Problem in insertion"+ex.Message);
            }
            
        }

        // PUT <ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE <ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
