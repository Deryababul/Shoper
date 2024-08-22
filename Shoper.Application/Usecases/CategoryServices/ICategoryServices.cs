using Shoper.Application.Dtos.CategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoper.Application.Usecases.CategoryServices
{
    public interface ICategoryServices
    {
        Task<List<ResultCategoyDto>> GetAllCategoryAsync();
        Task<GetByIdCategoryDto> GetByIdCategoryAsync(int id); //biz id gönderiyoruz bize GetByIdCategoryDto dönüyo
        Task CreateCategoryAsync(CreateCategoryDto model); //bir şey döndürmeyecek sadece oluşturacak
        Task UpdateCategoryAsync(UpdateCategoryDto model);
        Task DeleteCategoryAsync(int id);
    }
}
