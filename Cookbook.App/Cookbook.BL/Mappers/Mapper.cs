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
    public class Mapper : IMapper
    {
        // AmoutUnit models and entity mappings.
        public AmountUnitDetailModel MapAmountUnitEntityToDetailModel(AmountUnitEntity amountUnitEntity)
        {
            return new AmountUnitDetailModel
            {
                Id = amountUnitEntity.Id,
                Name = amountUnitEntity.Name,
                Abbreviation = amountUnitEntity.Abbreviation
            };
        }

        public AmountUnitListModel MapAmountUnitEntityToListModel(AmountUnitEntity amountUnitEntity)
        {
            return new AmountUnitListModel
            {
                Name = amountUnitEntity.Name,
                Abbreviation = amountUnitEntity.Abbreviation
            };
        }

        public AmountUnitEntity MapAmountUnitNewModelToEntity(AmountUnitNewModel amountUnitNewModel)
        {
            return new AmountUnitEntity
            {
                Id = new Guid(),
                Name = amountUnitNewModel.Name,
                Abbreviation = amountUnitNewModel.Abbreviation
            };
        }

        public AmountUnitEntity MapAmountUnitUpdateModelToEntity(AmountUnitUpdateModel amountUnitUpdateModel)
        {
            return new AmountUnitEntity
            {
                Id = amountUnitUpdateModel.Id,
                Name = amountUnitUpdateModel.Name,
                Abbreviation = amountUnitUpdateModel.Abbreviation
            };
        }

        // Author models and entity mappings.
        public AuthorDetailModel MapAuthorEntityToDetailModel(AuthorEntity authorEntity)
        {
            return new AuthorDetailModel
            {
                Id = authorEntity.Id,
                FirstName = authorEntity.FirstName,
                LastName = authorEntity.LastName,
                AboutAuthor = authorEntity.AboutAuthor,
                Recipes = authorEntity.Recipes == null ? null : authorEntity.Recipes.Select(MapRecipeEntityToListModel).ToList()
            };
        }

        public AuthorEntity MapAuthorDetailModelToEntity(AuthorDetailModel authorDetailModel)
        {
            return new AuthorEntity
            {
                Id = authorDetailModel.Id,
                FirstName = authorDetailModel.FirstName,
                LastName = authorDetailModel.LastName,
                AboutAuthor = authorDetailModel.AboutAuthor,
                Recipes = authorDetailModel.Recipes == null ? null : authorDetailModel.Recipes.Select(MapRecipeListModelToEntity).ToList()
            };
        }

        public AuthorEntity MapAuthorNewModelToEntity(AuthorNewModel authorNewModel)
        {
            return new AuthorEntity
            {
                Id = new Guid(),
                FirstName = authorNewModel.FirstName,
                LastName = authorNewModel.LastName,
                AboutAuthor = authorNewModel.AboutAuthor
            };
        }

        public AuthorEntity MapAuthorUpdateModelToEntity(AuthorUpdateModel authorUpdateModel)
        {
            return new AuthorEntity
            {
                Id = authorUpdateModel.Id,
                FirstName = authorUpdateModel.FirstName,
                LastName = authorUpdateModel.LastName,
                AboutAuthor = authorUpdateModel.AboutAuthor
            };
        }

        // Ingredient models and entity mappings.
        public IngredientDetailModel MapIngredientEntityToDetailModel(IngredientEntity ingredientEntity)
        {
            return new IngredientDetailModel
            {
                Id = ingredientEntity.Id,
                Name = ingredientEntity.Name,
                Description = ingredientEntity.Description
            };
        }

        public IngredientListModel MapIngredientEntityToListModel(IngredientEntity ingredientEntity)
        {
            return new IngredientListModel
            {
                Name = ingredientEntity.Name
            };
        }

        public IngredientEntity MapIngredientNewModelToEntity(IngredientNewModel ingredientNewModel)
        {
            return new IngredientEntity
            {
                Id = new Guid(),
                Name = ingredientNewModel.Name,
                Description = ingredientNewModel.Description
            };
        }

        public IngredientEntity MapIngredientUpdateModelToEntity(IngredientUpdateModel ingredientUpdateModel)
        {
            return new IngredientEntity
            {
                Id = ingredientUpdateModel.Id,
                Name = ingredientUpdateModel.Name,
                Description = ingredientUpdateModel.Description
            };
        }

        // NutritionInfo models and entity mappings.
        public NutritionInfoDetailModel MapNutritionInfoEntityToDetailModel(NutritionInfoEntity nutritionInfoEntity)
        {
            return new NutritionInfoDetailModel
            {
                Id = nutritionInfoEntity.Id,
                PortionSize = nutritionInfoEntity.PortionSize,
                Calories = nutritionInfoEntity.Calories,
                Carbohydrates = nutritionInfoEntity.Carbohydrates,
                Fat = nutritionInfoEntity.Fat,
                Protein = nutritionInfoEntity.Protein
            };
        }

        public NutritionInfoEntity MapNutritionInfoNewModelToEntity(NutritionInfoNewModel nutritionInfoNewModel)
        {
            return new NutritionInfoEntity
            {
                Id = new Guid(),
                PortionSize = nutritionInfoNewModel.PortionSize,
                Calories = nutritionInfoNewModel.Calories,
                Carbohydrates = nutritionInfoNewModel.Carbohydrates,
                Fat = nutritionInfoNewModel.Fat,
                Protein = nutritionInfoNewModel.Protein
            };
        }

        public NutritionInfoEntity MapNutritionInfoUpdateModelToEntity(NutritionInfoUpdateModel nutritionInfoUpdateModel)
        {
            return new NutritionInfoEntity
            {
                Id = nutritionInfoUpdateModel.Id,
                PortionSize = nutritionInfoUpdateModel.PortionSize,
                Calories = nutritionInfoUpdateModel.Calories,
                Carbohydrates = nutritionInfoUpdateModel.Carbohydrates,
                Fat = nutritionInfoUpdateModel.Fat,
                Protein = nutritionInfoUpdateModel.Protein
            };
        }

        // Recipe models and entity mappings.
        public RecipeDetailModel MapRecipeEntityToDetailModel(RecipeEntity recipeEntity)
        {
            return new RecipeDetailModel
            {
                Id = recipeEntity.Id,
                Name = recipeEntity.Name,
                Directions = recipeEntity.Directions,
                Servings = recipeEntity.Servings,
                RecipeWasAdded = recipeEntity.RecipeWasAdded,
                PrepTime = recipeEntity.PrepTime,
                CookTime = recipeEntity.CookTime,
                AdditionalTime = recipeEntity.AdditionalTime,
                TotalTime = recipeEntity.TotalTime,
                FoodCategory = recipeEntity.FoodCategory,
                FoodSpecialDiet = recipeEntity.FoodSpecialDiet,
                DegreeOfDifficulty = recipeEntity.DegreeOfDifficulty,
                Author = MapAuthorEntityToDetailModel(recipeEntity.Author),
                NutritionInfo = MapNutritionInfoEntityToDetailModel(recipeEntity.NutritionInfo),
                Ingredients = recipeEntity.RecipeIngredients == null ? null : recipeEntity.RecipeIngredients.Select(MapRecipeIngredientEntityToListModel).ToList()
            };
        }

        public RecipeListModel MapRecipeEntityToListModel(RecipeEntity recipeEntity)
        {
            return new RecipeListModel
            {
                Name = recipeEntity.Name,
                TotalTime = recipeEntity.TotalTime,
                FoodCategory = recipeEntity.FoodCategory,
                FoodSpecialDiet = recipeEntity.FoodSpecialDiet,
                DegreeOfDifficulty = recipeEntity.DegreeOfDifficulty
            };
        }

        public RecipeEntity MapRecipeListModelToEntity(RecipeListModel recipeListModel)
        {
            return new RecipeEntity
            {
                Name = recipeListModel.Name,
                FoodCategory = recipeListModel.FoodCategory,
                FoodSpecialDiet = recipeListModel.FoodSpecialDiet,
                DegreeOfDifficulty = recipeListModel.DegreeOfDifficulty
            };
        }

        public RecipeEntity MapRecipeNewModelToEntity(RecipeNewModel recipeNewModel)
        {
            return new RecipeEntity
            {
                Id = new Guid(),
                Name = recipeNewModel.Name,
                Directions = recipeNewModel.Directions,
                Servings = recipeNewModel.Servings,
                RecipeWasAdded = DateTime.Today,
                PrepTime = recipeNewModel.PrepTime,
                CookTime = recipeNewModel.CookTime,
                AdditionalTime = recipeNewModel.AdditionalTime,
                FoodCategory = recipeNewModel.FoodCategory,
                FoodSpecialDiet = recipeNewModel.FoodSpecialDiet,
                DegreeOfDifficulty = recipeNewModel.DegreeOfDifficulty,
                Author = MapAuthorDetailModelToEntity(recipeNewModel.Author),
                NutritionInfo = MapNutritionInfoNewModelToEntity(recipeNewModel.NutritionInfo),
                RecipeIngredients = recipeNewModel.Ingredients == null ? null : recipeNewModel.Ingredients.Select(MapRecipeIngredientNewModelToEntity).ToList()
            };
        }

        public RecipeEntity MapRecipeUpdateModelToEntity(RecipeUpdateModel recipeUpdateModel)
        {
            return new RecipeEntity
            {
                Id = recipeUpdateModel.Id,
                Name = recipeUpdateModel.Name,
                Directions = recipeUpdateModel.Directions,
                Servings = recipeUpdateModel.Servings,
                PrepTime = recipeUpdateModel.PrepTime,
                CookTime = recipeUpdateModel.CookTime,
                AdditionalTime = recipeUpdateModel.AdditionalTime,
                FoodCategory = recipeUpdateModel.FoodCategory,
                FoodSpecialDiet = recipeUpdateModel.FoodSpecialDiet,
                DegreeOfDifficulty = recipeUpdateModel.DegreeOfDifficulty,
                Author = MapAuthorDetailModelToEntity(recipeUpdateModel.Author),
                NutritionInfo = MapNutritionInfoUpdateModelToEntity(recipeUpdateModel.NutritionInfo),
                RecipeIngredients = recipeUpdateModel.RecipeIngredients == null ? null : recipeUpdateModel.RecipeIngredients.Select(MapRecipeIngredientUpdateModelToEntity).ToList()
            };
        }

        // RecipeIngredient models and entity mappings.
        public RecipeIngredientDetailModel MapRecipeIngredientEntityToDetailModel(RecipeIngredientEntity recipeIngredientEntity)
        {
            return new RecipeIngredientDetailModel
            {
                Id = recipeIngredientEntity.Id,
                Amount = recipeIngredientEntity.Amount,
                AmountUnit = MapAmountUnitEntityToDetailModel(recipeIngredientEntity.AmountUnit),
                Ingredient = MapIngredientEntityToDetailModel(recipeIngredientEntity.Ingredient)
            };
        }

        public RecipeIngredientListModel MapRecipeIngredientEntityToListModel(RecipeIngredientEntity recipeIngredientEntity)
        {
            return new RecipeIngredientListModel
            {
                Id = recipeIngredientEntity.Id,
                Amount = recipeIngredientEntity.Amount,
                AmountUnitAbbreviation = recipeIngredientEntity.AmountUnit.Abbreviation,
                IngredientName = recipeIngredientEntity.Ingredient.Name
            };
        }

        public RecipeIngredientEntity MapRecipeIngredientNewModelToEntity(RecipeIngredientNewModel recipeIngredientNewModel)
        {
            return new RecipeIngredientEntity
            {
                Id = new Guid(),
                Amount = recipeIngredientNewModel.Amount,
                AmountUnitId = recipeIngredientNewModel.AmountUnitId,
                IngredientId = recipeIngredientNewModel.IngredientId
            };
        }

        public RecipeIngredientEntity MapRecipeIngredientUpdateModelToEntity(RecipeIngredientUpdateModel recipeIngredientUpdateModel)
        {
            return new RecipeIngredientEntity
            {
                Id = recipeIngredientUpdateModel.Id,
                Amount = recipeIngredientUpdateModel.Amount,
                AmountUnitId = recipeIngredientUpdateModel.AmountUnitId,
                IngredientId = recipeIngredientUpdateModel.IngredientId
            };
        }
    }
}
