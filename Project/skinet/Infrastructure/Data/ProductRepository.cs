﻿using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class ProductRepository(StoreContext context) : IProductRepository
    {
        public void AddProduct(Product product)
        {
            context.Products.Add(product);
        }

        public void DeleteProduct(Product product)
        {
            context.Products.Remove(product);
        }

        public async Task<IReadOnlyList<string>> GetBrandsAsync()
        {
            return await context.Products.Select(x=>x.Brand).Distinct().ToListAsync();
        }

        public async Task<Product?> GetProductByIdAsync(int id)
        {
            return await context.Products.FindAsync(id);
        }

        public async Task<IReadOnlyList<Product>> GetProductsAsync(string? brand,string? type, string? sort)
        {
            var query = context.Products.AsQueryable();

            if (!string.IsNullOrWhiteSpace(brand))
            {
                query = query.Where(p => p.Brand == brand);
            }

            if (!string.IsNullOrWhiteSpace(type))
            {
                query = query.Where(p => p.Type == type);
            }

            
                query = sort switch
                {
                    "priceAsc" => query.OrderBy(p => p.Price),
                    "priceDesc" => query.OrderByDescending(p => p.Price),
                    _ => query.OrderBy(p => p.Name)
                };
            

            //return await context.Products.ToListAsync();
            return await query.Skip(5).Take(5).ToListAsync(); // pagination example
        }

        public async Task<IReadOnlyList<string>> GetTypesAsync()
        {
           return await context.Products.Select(x => x.Type).Distinct().ToListAsync();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await context.SaveChangesAsync() > 0;
        }

        public void UpdateProduct(Product product)
        {
            context.Entry(product).State = EntityState.Modified;
        }


        public bool ProductExists(int id)
        {
            return context.Products.Any(p => p.Id == id);
        }
    }
}
