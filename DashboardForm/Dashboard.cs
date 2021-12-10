using Domain;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DashboardForm
{
    public partial class Dashboard : Form
    {
        private Producer _producer;
        private readonly List<Consumer> _consumers = new List<Consumer>();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            _producer = new Producer(1);

            var consumer1 = new Consumer(1);
            var consumer2 = new Consumer(2);
            var consumer3 = new Consumer(3);

            _consumers.Add(consumer1);
            _consumers.Add(consumer2);
            _consumers.Add(consumer3);

            _producer.Subscribe(consumer1.NotifyCounterUpdate);
            _producer.Subscribe(consumer2.NotifyCounterUpdate);
            _producer.Subscribe(consumer3.NotifyCounterUpdate);

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            _producer.UpdateCounter(int.Parse(addQnTextBox.Text));
            quantityTextBox.Text = _producer.Quantity.ToString();

            var rnd = new Random();
            foreach (var consumer in _consumers)
            {
                MessageBox.Show($@"Consumer {consumer.Id} has {consumer.Quantity * rnd.Next(10)}");
            }
        }
    }
}
