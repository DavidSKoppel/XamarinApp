﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoListAPI.Dtos;
using ToDoListAPI.Services;
using ToDoListClassLibrary.Models;

namespace ToDoListAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingListItemsController : ControllerBase
    {
        private IShoppingListItemRepository _shoppingListItemRepository;
        public ShoppingListItemsController(IShoppingListItemRepository ShoppingListItemRepository)
        {
            _shoppingListItemRepository = ShoppingListItemRepository;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetShoppingListItem(int id)
        {
            if (!await _shoppingListItemRepository.entityExists(id))
                return NotFound();
            var product = await _shoppingListItemRepository.GetById(id);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(product);
        }

        [HttpGet]
        [ProducesResponseType(400)]
        public async Task<IActionResult> GetShoppingListItemLists()
        {
            var shoppinglistItems = await _shoppingListItemRepository.GetAllAsync();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var shoppingListItemDto = new List<ShoppingListItemDto>();

            foreach (var shoppinglistitem in shoppinglistItems)
            {
                shoppingListItemDto.Add(new ShoppingListItemDto
                {
                    Id = shoppinglistitem.Id,
                    Title = shoppinglistitem.Title,
                    Checked = shoppinglistitem.Checked
                });
            }
            return Ok(shoppingListItemDto);
        }

        [HttpPost]
        public async Task<IActionResult> CreateShoppingListItem([FromBody] ShoppingListItem shoppingListItemToCreate)
        {
            if (shoppingListItemToCreate == null)
            {
                return BadRequest(ModelState);
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _shoppingListItemRepository.Insert(shoppingListItemToCreate);
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.GetBaseException().Message);
                return StatusCode(500, ModelState);
            }

            return CreatedAtAction("GetShoppingListItem", new { id = shoppingListItemToCreate.Id }, shoppingListItemToCreate);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateShoppingListItem(int id, [FromBody] ShoppingListItem updateShoppingListItem)
        {
            if (updateShoppingListItem == null)
            {
                return BadRequest(ModelState);
            }
            if (id != updateShoppingListItem.Id)
            {
                return BadRequest(ModelState);
            }
            if (!await _shoppingListItemRepository.entityExists(id))
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _shoppingListItemRepository.Update(updateShoppingListItem);
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.GetBaseException().Message);
                return StatusCode(500, ModelState);
            }

            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteShoppingListItem(int id)
        {
            if (!await _shoppingListItemRepository.entityExists(id))
                return NotFound();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                await _shoppingListItemRepository.Delete(id);
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.GetBaseException().Message);
                return StatusCode(500, ModelState);
            }

            return NoContent();
        }
    }
}