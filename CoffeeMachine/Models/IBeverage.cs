using System.Collections.Generic;

namespace CoffeeMachine.Models
{
    public interface IBeverage
    {
        string Name { get; }
        List<IngredientType> Ingredients { get; }

        void AddIngredient(IngredientType ingredient);
    }
}
