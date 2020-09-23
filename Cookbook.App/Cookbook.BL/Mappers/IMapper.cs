using System;
using System.Linq;
using Cookbook.BL.Models.AmountUnit;
using Cookbook.BL.Models.Author;
using Cookbook.BL.Models.Ingredient;
using Cookbook.BL.Models.Recipe;
using Cookbook.BL.Models.Recipe.NutritionInfo;
using Cookbook.BL.Models.Recipe.RecipeIngredient;
using Cookbook.DAL.Entities;

namespace Cookbook.BL.Mappers
{
    public interface IMapper
    {
        // AmoutUnit models and entity mappings.
        AmountUnitEntity MapAmountUnitNewModelToEntity(AmountUnitNewModel amountUnitNewModel);
        AmountUnitEntity MapAmountUnitUpdateModelToEntity(AmountUnitUpdateModel amountUnitUpdateModel);
        AmountUnitDetailModel MapAmountUnitEntityToDetailModel(AmountUnitEntity amountUnitEntity);
        AmountUnitListModel MapAmountUnitEntityToListModel(AmountUnitEntity amountUnitEntity);

        // Author models and entity mappings.
        AuthorEntity MapAuthorNewModelToEntity(AuthorNewModel authorNewModel);
        AuthorEntity MapAuthorUpdateModelToEntity(AuthorUpdateModel authorUpdateModel);
        AuthorEntity MapAuthorDetailModelToEntity(AuthorDetailModel authorDetailModel);
        AuthorDetailModel MapAuthorEntityToDetailModel(AuthorEntity authorEntity);

        // Ingredient models and entity mappings.
        IngredientEntity MapIngredientNewModelToEntity(IngredientNewModel ingredientNewModel);
        IngredientEntity MapIngredientUpdateModelToEntity(IngredientUpdateModel ingredientUpdateModel);
        IngredientDetailModel MapIngredientEntityToDetailModel(IngredientEntity ingredientEntity);
        IngredientListModel MapIngredientEntityToListModel(IngredientEntity ingredientEntity);

        // Recipe models and entity mappings.
        RecipeEntity MapRecipeNewModelToEntity(RecipeNewModel recipeNewModel);
        RecipeEntity MapRecipeUpdateModelToEntity(RecipeUpdateModel recipeUpdateModel);
        RecipeDetailModel MapRecipeEntityToDetailModel(RecipeEntity recipeEntity);
        RecipeListModel MapRecipeEntityToListModel(RecipeEntity recipeEntity);
        RecipeEntity MapRecipeListModelToEntity(RecipeListModel recipeListModel);

        // RecipeIngredient models and entity mappings.
        RecipeIngredientEntity MapRecipeIngredientNewModelToEntity(RecipeIngredientNewModel recipeIngredientNewModel);
        RecipeIngredientEntity MapRecipeIngredientUpdateModelToEntity(RecipeIngredientUpdateModel recipeIngredientUpdateModel);
        RecipeIngredientDetailModel MapRecipeIngredientEntityToDetailModel(RecipeIngredientEntity recipeIngredientEntity);
        RecipeIngredientListModel MapRecipeIngredientEntityToListModel(RecipeIngredientEntity recipeIngredientEntity);

        // NutritionInfo models and entity mappings.
        NutritionInfoEntity MapNutritionInfoNewModelToEntity(NutritionInfoNewModel nutritionInfoNewModel);
        NutritionInfoEntity MapNutritionInfoUpdateModelToEntity(NutritionInfoUpdateModel nutritionInfoUpdateModel);
        NutritionInfoDetailModel MapNutritionInfoEntityToDetailModel(NutritionInfoEntity nutritionInfoEntity);

    }
}
