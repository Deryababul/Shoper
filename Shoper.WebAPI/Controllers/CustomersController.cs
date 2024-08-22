using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shoper.Application.Dtos.CustomerDtos;
using Shoper.Application.Usecases.CustomerServices;

namespace Shoper.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerServices _services;

        public CustomersController(ICustomerServices services)
        {
            _services = services;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCustomer()
        {
            var values = await _services.GetAllCustomerAsync();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdCustomer(int id)
        {
            var values = await _services.GetByIdCustomerAsync(id);
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCustomer(CreateCustomerDto dto)
        {
            await _services.CreateCustomerAsync(dto);
            return Ok("musteri basarili bir sekilde oluşturuldu");

        }
        [HttpPut]
        public async Task<IActionResult> UpdateCustomer(UpdateCustomerDto dto)
        {
            await _services.UpdateCustomerAsync(dto);
            return Ok("musteri basarili bir sekilde güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            await _services.DeleteCustomerAsync(id);
            return Ok("musteri basarili bir sekilde silindi");
        }
    }
}
