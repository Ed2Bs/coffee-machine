using System.Collections.Generic;

namespace CoffeeMachine.Models
{
    public abstract class Beverage : IBeverage
    {
        protected string name;
        public virtual string Name => name;

        protected List<IngredientType> ingredients;
        public virtual List<IngredientType> Ingredients => ingredients;

        public Beverage(string name) => this.name = name;

        public virtual void AddIngredient(IngredientType ingredient) { return; }
        public override string ToString() => Name;
    }
}
