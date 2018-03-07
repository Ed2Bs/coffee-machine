using CoffeeMachine.Models;
using System;
using System.Windows.Forms;

namespace CoffeeMachine
{
    public partial class Form1 : Form
    {
        Machine machine; 

        public Form1()
        {
            InitializeComponent();

            machine = new Machine(10, 10, 10, 10);

            machine.Dispensed += (sender, e) => statusBox.Text = e.Message;
            machine.CoffeePowderContainer.Empty += (sender, e) => MessageBox.Show(e.Message, "Coffee Machine");
            machine.ChocolatePowderContainer.Empty += (sender, e) => MessageBox.Show(e.Message, "Coffee Machine");
            machine.MilkContainer.Empty += (sender, e) => MessageBox.Show(e.Message, "Coffee Machine");
            machine.SugarContainer.Empty += (sender, e) => MessageBox.Show(e.Message, "Coffee Machine");

            beveragesCombo.DataSource = machine.Menu;
        }

        private void makeButton_Click(object sender, EventArgs e) 
            => machine.MakeBeverage((IBeverage)beveragesCombo.SelectedItem, sugarCheckBox.Checked, milkCheckBox.Checked);

        private void reportButton_Click(object sender, EventArgs e) => statusBox.Text = machine.GetUsageReport();

        private void beveragesCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var selected = (IBeverage)beveragesCombo.SelectedItem;

            if (selected.GetType() != typeof(BrewCoffee))
            {
                milkCheckBox.Enabled = false;
                sugarCheckBox.Enabled = false;
            }
            else
            {
                milkCheckBox.Enabled = true;
                sugarCheckBox.Enabled = true;
            }
        }
    }
}
