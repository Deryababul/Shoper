using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shoper.Application.Dtos.OrderDtos;
using Shoper.Application.Usecases.OrderServices;

namespace Shoper.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderServices _services;
        public OrderController(IOrderServices services)
        {
            _services = services;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllOrder()
        {
            var values = await _services.GetAllOrderAsync();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdOrder(int id)
        {
            var values = await _services.GetByIdOrderAsync(id);
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateOrder(CreateOrderDto dto)
        {
            await _services.CreateOrderAsync(dto);
            return Ok("Siparisiniz basarili bir sekilde oluşturuldu");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateOrder(UpdateOrderDto dto)
        {
            await _services.UpdateOrderAsync(dto);
            return Ok("Siparisiniz basarili bir şekilde güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            await _services.DeleteOrderAsync(id);
            return Ok("Siparisiniz basarili bir sekilde silindi");
        }
        
    }

}
