
using Service.DTO_s.Category;
using Service.DTO_s.Product;

namespace Service.Services.Interfaces
{
    public interface ICategoryService
    {
        Task CreateAsync(CategoryCreateDTO category);
        Task<List<ProductListDTO>> GetAllAsync();
        Task DeleteAsync(int id);
        Task SoftDeleteAsync(int id);
        Task UpdateAsync(int id, ProductUpdateDTO product);
        Task<ProductFindDTO> GetByIdAsync(int id);
        Task<List<ProductListDTO>> SearchAsync(string? searchText);
    }
}
