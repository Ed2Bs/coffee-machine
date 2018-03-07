using System;
using System.Collections.Generic;
using System.Linq;
using CoffeeMachine.Models;

namespace CoffeeMachine
{
    public class Machine
    {
        public string Name => "Coffee Machine";
        private List<IBeverage> dispensedBeverages = new List<IBeverage>();

        public List<IBeverage> Menu
        {
            get
            {
                return new List<IBeverage>()
                {
                    new BrewCoffee(),
                    new CafeAuLait(),
                    new ColdWater(),
                    new HotChocolate(),
                    new TeeWater()
                };
            }
        }

        public IMachineContainer CoffeePowderContainer { get; private set; }
        public IMachineContainer ChocolatePowderContainer { get; private set; }
        public IMachineContainer MilkContainer { get; private set; }
        public IMachineContainer SugarContainer { get; private set; }

        public event EventHandler<MachineEventArg> Dispensed;

        public Machine(int coffee, int chocolate, int milk, int sugar)
        {
            CoffeePowderContainer = new CoffeePowderContainer(coffee);
            ChocolatePowderContainer = new ChocolatePowderContainer(chocolate);
            MilkContainer = new MilkContainer(milk);
            SugarContainer = new SugarContainer(sugar);
        }

        public void MakeBeverage(IBeverage selectedBeverage, bool sugarAdded = false, bool milkAdded = false)
        {
            IBeverage beverage = (IBeverage)Activator.CreateInstance(selectedBeverage.GetType());

            if (sugarAdded)
                beverage.AddIngredient(IngredientType.Sugar);

            if (milkAdded)
                beverage.AddIngredient(IngredientType.Milk);

            int status = -1;
            foreach (var item in beverage.Ingredients)
            {
                switch (item)
                {
                    case IngredientType.CoffeePowder:
                        status = CoffeePowderContainer.GetDose();
                        break;
                    case IngredientType.ChocolatePowder:
                        status = ChocolatePowderContainer.GetDose();
                        break;
                    case IngredientType.Milk:
                        status = MilkContainer.GetDose();
                        break;
                    case IngredientType.HotMilk:
                        status = MilkContainer.GetDose();
                        break;
                    case IngredientType.Sugar:
                        status = SugarContainer.GetDose();
                        break;
                    default:
                        break;
                }
            }

            if (status != -1)
            {
                dispensedBeverages.Add(beverage);
                OnDispensed($"Drink: {beverage.ToString()}");
            }
        }

        public string GetUsageReport()
        {
            var report = "Full report " + System.Environment.NewLine;
            report += "--------------------------" + System.Environment.NewLine;

            var grouped = dispensedBeverages.GroupBy(x => x.Name).Select(c => new { Name = c.Key, Quantity = c.Count() });

            foreach (var item in grouped)
            {
                report += $"Beverage: {item.Name}  Quantity: {item.Quantity}" + System.Environment.NewLine;
            }

            return report;
        }

        private void OnDispensed(string report) => Dispensed?.Invoke(this, new MachineEventArg { Message = report });
    }

    public class MachineEventArg : EventArgs
    {
        public string Message { get; set; }
    }
}
