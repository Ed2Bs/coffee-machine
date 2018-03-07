using System;

namespace CoffeeMachine.Models
{
    public abstract class MachineContainer : IMachineContainer
    {
        protected string content;
        public string Content => content;

        public int Quantity { get; private set; }
        public event EventHandler<MachineEventArg> Empty;

        public MachineContainer(int quantity, string content)
        {
            Quantity = quantity;
            this.content = content;
        }

        public int GetDose()
        {
            if (Quantity > 0)
            {
                Quantity--;
                return 1;
            }

            OnEmpty();
            return -1;
        }

        private void OnEmpty() => Empty?.Invoke(this, new MachineEventArg { Message = $"Out of {Content}" });
    }
}
