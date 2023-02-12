using System;
using System.Collections.Generic;
using System.Linq;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

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

        public ActionResult<List<Products>> GetProdcuts()
        {
            var products = _context.Products.ToList();

            return Ok(products);
        }

        [HttpGet("{id}")]

        public ActionResult<Products> GetProduct(int id)
        {
            return _context.Products.Find(id);
        }

    }
}