﻿using BlogEngine.Shared.DTOs.Category;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogEngine.ClientServices.Services.Abstractions
{
    public interface ICategoryClient
    {
        Task<CategoryDTO> GetAsync(int id);
        Task<CategoryEditPageDTO> GetEditPageDTOAsync(int id);
        Task<List<CategoryDTO>> GetAllAsync();
        Task<List<CategoryDTO>> SearchAsync(CategorySearchDTO categorySearchDTO);
        Task<CategoryDTO> CreateAsync(CategoryCreationDTO categoryCreationDTO);
        Task<CategoryDTO> UpdateAsync(int id, CategoryUpdateDTO categoryUpdateDTO);
        Task<bool> DeleteAsync(int id);
    }
}