﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UESAN.Store.CORE.Interfaces;

namespace UESAN.Store.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryControlers : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryControlers(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _categoryRepository.GetAll();
            return Ok(result);
        }
    }
}
