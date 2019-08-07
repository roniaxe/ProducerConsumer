using System;

namespace Domain
{
    public class Consumer
    {
        public int Quantity { get; set; }
        public int Id { get; set; }

        public Consumer(int id)
        {
            Id = id;
        }

        public void NotifyCounterUpdate(int quantity)
        {
            Quantity += quantity;
        }
    }
}
