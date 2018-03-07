using System;

namespace CoffeeMachine.Models
{
    public interface IMachineContainer
    {
        string Content { get; }
        int Quantity { get; }

        event EventHandler<MachineEventArg> Empty;

        int GetDose();
    }
}