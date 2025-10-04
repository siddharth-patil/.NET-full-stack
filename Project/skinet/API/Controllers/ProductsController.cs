using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController(IGenericRepository<Product> repo) : ControllerBase
    {
        //private StoreContext context;

        //public ProductsController(StoreContext context)
        //{
        //    this.context = context;
        //}

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<Product>>> GetProducts(string? brand, string? type, string? sort)
        {
            //return await context.Products.ToListAsync();
            return Ok(await repo.ListAllAsync());
        }

        [HttpGet("{id:int}")] //api/products/2
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            //var product = await context.Products.FindAsync(id);
            var product = await repo.GetByIdAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

        [HttpPost]
        public async Task<ActionResult<Product>> CreateProduct(Product product)
        {
            //context.Products.Add(product);
            //await context.SaveChangesAsync();
            repo.Add(product);
            if (await repo.SaveAllAsync())
            {
                return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
            }

            return BadRequest("Problem creating product");
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> UpdateProduct(int id, Product product)
        {
            if (product.Id != id || !ProductExists(id))
            {
                return BadRequest("Can't update this product!");
            }

            //context.Entry(product).State = EntityState.Modified;

            //await context.SaveChangesAsync();

            repo.Update(product);
            if (await repo.SaveAllAsync()) 
            {
                return NoContent();
            }

            return BadRequest("Problem in updating the product!");

        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteProduct(int id)
        {
            //var product = await context.Products.FindAsync(id);
            var product = await repo.GetByIdAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            //context.Products.Remove(product);
            //await context.SaveChangesAsync();

            repo.Remove(product);    
            if (await repo.SaveAllAsync())
            {
                return NoContent();
            }

            return BadRequest("Problem in deleting the product!");

        }

        [HttpGet("brands")]
        public async Task<ActionResult<IReadOnlyList<string>>> GetBrands()
        {
            //return await context.ProductBrands.ToListAsync();
            //TODO - implement in GenericRepository
            return Ok();
        }

        [HttpGet("types")]
        public async Task<ActionResult<IReadOnlyList<string>>> GetTypes()
        {
            //return await context.ProductBrands.ToListAsync();
            //TODO - implement in GenericRepository
            return Ok();
        }

        private bool ProductExists(int id)
        {
            //return context.Products.Any(x => x.Id == id);
            return repo.Exists(id);
        }
    }
}
