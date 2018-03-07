using System.Collections.Generic;

namespace CoffeeMachine.Models
{
    public class TeeWater : Beverage
    {
        public TeeWater()
            : base("Tee water")
        {
            ingredients = new List<IngredientType> { IngredientType.HotWater };
        }
    }
}
