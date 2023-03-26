using Dapper;
using Repository.Database;
using Repository.Entities;
using Repository.Interface;
using Repository.Models;

namespace Repository.Implement
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly IDatabaseHelper _databaseHelper;

        public RecipeRepository(IDatabaseHelper databaseHelper)
        {
            _databaseHelper = databaseHelper;
        }

        public async Task<int> AddAsync(Recipe recipe)
        {
            // 資料庫實作
            using var conn = _databaseHelper.GetConnection();
            string sql = @"INSERT INTO recipe VALUES (:uuid, :name);";
            var count = await conn.ExecuteAsync(sql, new 
            {
                recipe.UUID,
                recipe.Name
            });
            return count;
        }

        public async Task<IEnumerable<Recipe>> GetAllAsync(RecipeQuery recipeQuery)
        {
            using var conn = _databaseHelper.GetConnection();
            string sql = @"SELECT uuid, name FROM recipe WHERE uuid = :uuid OR name = :name";
            var recipes = await conn.QueryAsync<Recipe>(sql, new
            {
                recipeQuery.UUID,
                recipeQuery.Name
            });
            return recipes;
        }

        public async Task<int> RemoveAsync(Recipe recipe)
        {
            using var conn = _databaseHelper.GetConnection();
            string sql = @"DELETE FROM recipe WHERE uuid = :uuid";
            var count = await conn.ExecuteAsync(sql, new
            {
                recipe.UUID
            });
            return count;
        }

        public async Task<int> UpdateAsync(Recipe recipe)
        {
            using var conn = _databaseHelper.GetConnection();
            string sql = @"UPDATE recipe SET uuid = :uuid, name = :name";
            var count = await conn.ExecuteAsync(sql, new
            {
                recipe.UUID,
                recipe.Name
            });
            return count;
        }
    }
}
