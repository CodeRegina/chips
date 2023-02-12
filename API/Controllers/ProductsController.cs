using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controller

{

    [ApiController]
    [Route("api/[controller]")]

    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _context;
        public ProductsController(StoreContext context)
        {
            _context = context;

        }

        [HttpGet]

        public async Task<ActionResult<List<Products>>> GetProdcutsAsync()
        {
            return await _context.Products.ToListAsync();

         
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Products>> GetProdcut(int id)
        {
            return await _context.Products.FindAsync(id);
        }

    }
}