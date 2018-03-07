using System.Collections.Generic;

namespace CoffeeMachine.Models
{
    public class CafeAuLait : Beverage
    {
        public CafeAuLait()
            : base("Cafe Au Lait")
        {
            ingredients = new List<IngredientType>
            {
                IngredientType.CoffeePowder,
                IngredientType.HotWater,
                IngredientType.HotMilk
            };
        }
    }
}
