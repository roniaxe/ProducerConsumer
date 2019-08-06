using System;

namespace Domain
{
    public class Producer
    {
        public event Action<int> OnCounterUpdate;

        private readonly int _id;
        public int Quantity { get; set; }

        public Producer(int id)
        {
            _id = id;
        }

        public void UpdateCounter(int quantity)
        {
            Quantity += quantity;

            Console.WriteLine($"Producer Id {_id}: Updating Total with {quantity}. Total quantity now is {Quantity}");

            OnCounterUpdate?.Invoke(quantity);
        }
    }
}
