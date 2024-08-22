using Shoper.Application.Dtos.OrderDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoper.Application.Usecases.OrderServices
{
    public interface IOrderServices
    {
        Task<List<ResultOrderDto>> GetAllOrderAsync();
        Task<GetByIdOrderDto> GetByIdOrderAsync(int id); //biz id gönderiyoruz bize GetByIdOrderDto dönüyo
        Task CreateOrderAsync(CreateOrderDto model); //bir şey döndürmeyecek sadece oluşturacak
        Task UpdateOrderAsync(UpdateOrderDto model);
        Task DeleteOrderAsync(int id);
    }
}
