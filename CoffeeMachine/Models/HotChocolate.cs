using System.Collections.Generic;

namespace CoffeeMachine.Models
{
    class HotChocolate : Beverage
    {
        public HotChocolate()
            : base("Hot Chocolate")
        {
            ingredients = new List<IngredientType>
            {
                IngredientType.ChocolatePowder,
                IngredientType.HotWater
            };
        }
    }
}
