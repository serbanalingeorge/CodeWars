namespace SplitStrings.Decorator
{
    public class ExtraCheeseTopping : ToppingsDecorator
    {
        public ExtraCheeseTopping(BasePizza pizzaToDecorate)
            : base(pizzaToDecorate)
        {
            myPrice = 0.99;
        }
    }
}