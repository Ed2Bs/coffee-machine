using System.Collections.Generic;

namespace CoffeeMachine.Models
{
    class ColdWater : Beverage
    {
        public ColdWater()
            : base("Cold Water")
        {
            ingredients = new List<IngredientType> { IngredientType.Water };
        }
    }
}
