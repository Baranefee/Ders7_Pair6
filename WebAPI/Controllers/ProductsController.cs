﻿using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_productService.GetAll());
        }

        [HttpGet]

        public IActionResult GetById(int id)
        {
            return Ok(_productService.GetById(id));
        }

        [HttpPost]

        public IActionResult Add([FromBody]Product product)
        {
            _productService.Add(product);
			return Ok("Ekleme işlemi başarılı!");
        }

        [HttpPut]

        public IActionResult Update([FromBody] Product product)
        {
            _productService.Update(product);
			return Ok("Günceleme işlemi başarılı!");
        }

        [HttpDelete]

        public IActionResult Delete(int id)
        {
            _productService.Delete(id);
            return Ok("Urun silme basarili");
        }

    }
}
