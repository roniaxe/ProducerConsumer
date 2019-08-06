using System;

namespace Domain
{
    public class Consumer
    {
        private readonly int _id;

        public Consumer(int id)
        {
            _id = id;
        }

        public void NotifyCounterUpdate(int quantity)
        {
            Console.WriteLine($"Consumer Id {_id}: Producer updated quantity with {quantity}");
        }
    }
}
