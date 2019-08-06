using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace DashboardForm
{
    public partial class Dashboard : Form
    {
        private Producer producer;
        private List<Consumer> consumers = new List<Consumer>();
        private BindingList<int> bindingList = new BindingList<int>();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            producer = new Producer(1);

            Consumer consumer1 = new Consumer(1);
            Consumer consumer2 = new Consumer(2);
            Consumer consumer3 = new Consumer(3);

            producer.OnCounterUpdate += consumer1.NotifyCounterUpdate;
            producer.OnCounterUpdate += consumer2.NotifyCounterUpdate;
            producer.OnCounterUpdate += consumer3.NotifyCounterUpdate;

            consumers.Add(consumer1);
            consumers.Add(consumer2);
            consumers.Add(consumer3);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            producer.UpdateCounter(int.Parse(addQnTextBox.Text));
            quantityTextBox.Text = producer.Quantity.ToString();
        }
    }
}
