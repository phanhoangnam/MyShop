﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyShop.Application.Categories;
using MyShop.ViewModels.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CategoriesController : ControllerBase
    {
        private readonly IManageCategoryService _manageCategoryService;

        public CategoriesController(IManageCategoryService manageCategoryService)
        {
            _manageCategoryService = manageCategoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categories = await _manageCategoryService.GetAll();
            return Ok(categories);
        }

        [HttpGet("{categoryId}")]
        public async Task<IActionResult> GetById(int categoryId)
        {
            var category = await _manageCategoryService.GetById(categoryId);
            if (category == null)
            {
                return BadRequest("Cannot find category");
            }
            return Ok(category);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] CategoryCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var categoryId = await _manageCategoryService.Create(request);

            if (categoryId == 0)
            {
                return BadRequest();
            }

            var category = await _manageCategoryService.GetById(categoryId);
            return CreatedAtAction(nameof(GetById), new { id = categoryId }, category);

        }

        [HttpPut]
        public async Task<IActionResult> Update([FromForm] CategoryUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var affectedRequest = await _manageCategoryService.Update(request);
            if (affectedRequest == 0)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpDelete("{categoryId}")]
        public async Task<IActionResult> Delete(int categoryId)
        {
            var affectedRequest = await _manageCategoryService.Delete(categoryId);
            if (affectedRequest == 0)
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}
