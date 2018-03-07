using System.Collections.Generic;
using System.Linq;

namespace CoffeeMachine.Models
{
    public class BrewCoffee : Beverage
    {
        public override string Name => GetName();

        public BrewCoffee()
                : base("Brew Coffee")
        {
            ingredients = new List<IngredientType>
            {
                IngredientType.CoffeePowder,
                IngredientType.HotWater
            };
        }

        public override void AddIngredient(IngredientType ingredient) => ingredients.Add(ingredient);

        private string GetName()
        {
            if (ingredients.Any(x => x == IngredientType.Sugar) && ingredients.Any(x => x == IngredientType.Milk))
                return name + " with milk and sugar";

            if (ingredients.Any(x => x == IngredientType.Milk))
                return name + " with milk";

            if (ingredients.Any(x => x == IngredientType.Sugar))
                return name + " with sugar";

            return name;
        }
    }
}
