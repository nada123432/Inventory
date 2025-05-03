using Inventory.Domain.Entites;
using Inventory.Services.DTOs.InventoryTransaction;
using Inventory.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.API.Controllers
{
    [Route("api/inventory-transactions")]
    [ApiController]
    public class InventoryTransactionsController : ControllerBase
    {
        private readonly IInventoryTransactionService _transactionService;

        public InventoryTransactionsController(IInventoryTransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<InventoryTransactionDto>>> GetAllTransactions()
        {
            var transactions = await _transactionService.GetAllTransactionsAsync();
            return Ok(transactions);
        }

        [HttpGet("product/{productId}")]
        public async Task<ActionResult<IEnumerable<InventoryTransactionDto>>> GetTransactionsByProductId(int productId)
        {
            var transactions = await _transactionService.GetTransactionsByProductIdAsync(productId);
            return Ok(transactions);
        }

        [HttpGet("date-range")]
        public async Task<ActionResult<IEnumerable<InventoryTransactionDto>>> GetTransactionsByDateRange(
            [FromQuery] DateTime startDate,
            [FromQuery] DateTime endDate)
        {
            var transactions = await _transactionService.GetTransactionsByDateRangeAsync(startDate, endDate);
            return Ok(transactions);
        }

        [HttpPost("create")]
        [Authorize(Roles ="Admin")]
        public async Task<ActionResult<InventoryTransactionDto>> CreateTransaction(InventoryTransactionForCreationDto transaction)
        {
            try
            {
                var result = await _transactionService.CreateTransactionAsync(transaction);
                return CreatedAtAction("GetAllTransactions", result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("add-stock")]
        public async Task<ActionResult<InventoryTransactionDto>> AddStock(InventoryTransactionForCreationDto transaction)
        {
            try
            {
                var result = await _transactionService.AddStockAsync(transaction);
                return CreatedAtAction("GetAllTransactions", result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("remove-stock")]
        public async Task<ActionResult<InventoryTransactionDto>> RemoveStock(InventoryTransactionForCreationDto transaction)
        {
            try
            {
                var result = await _transactionService.RemoveStockAsync(transaction);
                return CreatedAtAction("GetAllTransactions", result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("transfer-stock")]
        public async Task<ActionResult> TransferStock(
            [FromQuery] int productId,
            [FromQuery] int fromWarehouseId,
            [FromQuery] int toWarehouseId,
            [FromQuery] int quantity,
            [FromQuery] string userId)
        {
            var result = await _transactionService.TransferStockAsync(productId, fromWarehouseId, toWarehouseId, quantity, userId);
            if (!result)
                return BadRequest("Failed to transfer stock");

            return Ok("Stock transferred successfully");
        }
    }
}
