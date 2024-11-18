using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    internal class Recipe
    {
        private string recipeName;
        List<string> recipeInstructions = new List<string>();
        List<string> recipeIngredients = new List<string>();
        private string recipePrepTime;
        private string recipeCookTime;
        private string recipePeople;
        private bool veggie;

        string RecipeName(string name)
        {
            recipeName = name;
            return recipeName;
        }
        void Instrucions(string listItem)
        {
            recipeInstructions.Add(listItem);
        }
        void Ingredients(string listItem)
        {
            recipeIngredients.Add(listItem);
        }
        
    }
}
