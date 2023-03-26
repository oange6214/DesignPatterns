using AutoMapper;
using Repository.Entities;
using Repository.Models;
using Repository.Repos.Interfaces;
using Repository.Services.Dtos;
using Repository.Services.Interfaces;

namespace Repository.Services.Implements;

public class RecipeService : IRecipeService
{
    private IRecipeRepository _recipeRepository;
    private IMapper _mapper;

    public RecipeService(
        IRecipeRepository recipeRepository,
        IMapper mapper)
    {
        _recipeRepository = recipeRepository;
        _mapper = mapper;
    }


    public async Task<int> AddAsync(RecipeDto recipeDto)
    {
        // Convert RecipeDto to Blog
        var blog = _mapper.Map<Recipe>(recipeDto);
        return await _recipeRepository.AddAsync(blog);
    }

    public async Task<IEnumerable<RecipeDto>> GetAllAsync(RecipeQueryDto recipeQueryDto)
    {
        // Convert RecipeQueryDto to RecipeQuery
        var recipeQuery = _mapper.Map<RecipeQuery>(recipeQueryDto);

        var recips = await _recipeRepository.GetAllAsync(recipeQuery);

        // Convert Recipe to RecipeDto
        var recipeDtos = _mapper.Map<IEnumerable<RecipeDto>>(recips);

        return recipeDtos;
    }

    public async Task<int> RemoveAsync(RecipeDto recipeDto)
    {
        return await _recipeRepository.RemoveAsync(new Recipe
        {
            UUID = recipeDto.UUID
        });
    }

    public async Task<int> UpdateAsync(RecipeDto recipeDto)
    {
        // Convert RecipeDto to Recipe
        var recipe = _mapper.Map<Recipe>(recipeDto);
        return await _recipeRepository.UpdateAsync(recipe);
    }
}
