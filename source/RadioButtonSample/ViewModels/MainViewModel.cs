namespace RadioButtonSample;

public class MainViewModel
{
    public Subscription[] Subscriptions { get; set; } = 
    {
        new Subscription { Discount = 0, Months = 1, Name = "Basic", Price = 9.99 },
        new Subscription { Discount = 10, Months = 3, Name = "Pro", Price = 26.97 },
        new Subscription { Discount = 20, Months = 9, Name = "Enterprise", Price = 71.93 },        
    };
}
