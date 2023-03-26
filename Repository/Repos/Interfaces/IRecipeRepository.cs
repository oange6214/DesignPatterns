using Repository.Entities;
using Repository.Models;

namespace Repository.Repos.Interfaces;

public interface IRecipeRepository
{
    /// <summary>
    /// 新增 Recipe
    /// </summary>
    /// <param name="recipe">Recipe 實體</param>
    /// <returns></returns>
    Task<int> AddAsync(Recipe recipe);

    /// <summary>
    /// 取得所有 Recipe
    /// </summary>
    /// <param name="recipeQuery"></param>
    /// <returns></returns>
    Task<IEnumerable<Recipe>> GetAllAsync(RecipeQuery recipeQuery);

    /// <summary>
    /// 刪除 Recipe
    /// </summary>
    /// <param name="recipe"></param>
    /// <returns></returns>
    Task<int> RemoveAsync(Recipe recipe);

    /// <summary>
    /// 更新 Recipe
    /// </summary>
    /// <param name="recipe"></param>
    /// <returns></returns>
    Task<int> UpdateAsync(Recipe recipe);
}
