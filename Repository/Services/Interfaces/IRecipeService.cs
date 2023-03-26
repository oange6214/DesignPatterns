using Repository.Entities;
using Repository.Services.Dtos;

namespace Repository.Services.Interfaces;

public interface IRecipeService
{
    /// <summary>
    /// 新增 Recipe
    /// </summary>
    /// <param name="recipe">Recipe 實體</param>
    /// <returns></returns>
    Task<int> AddAsync(RecipeDto recipe);

    /// <summary>
    /// 取得所有 Recipe
    /// </summary>
    /// <param name="recipeQuery"></param>
    /// <returns></returns>
    Task<IEnumerable<RecipeDto>> GetAllAsync(RecipeQueryDto recipeQuery);

    /// <summary>
    /// 刪除 Recipe
    /// </summary>
    /// <param name="recipe"></param>
    /// <returns></returns>
    Task<int> RemoveAsync(RecipeDto recipe);

    /// <summary>
    /// 更新 Recipe
    /// </summary>
    /// <param name="recipe"></param>
    /// <returns></returns>
    Task<int> UpdateAsync(RecipeDto recipe);
}
