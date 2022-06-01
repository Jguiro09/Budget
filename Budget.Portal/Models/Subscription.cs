using System;

namespace Budget.Portal.Models
{
    public class Subscription
    {
        public int SubscriptionId { get; set; }
        public string SubscriptionName { get; set; }
        public string SubscriptionPrice { get; set; }
        public DateTime DayOfPayment { get; set; }
    }
}