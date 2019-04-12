namespace SplitStrings.Decorator
{
    public class JalapenoTopping : ToppingsDecorator
    {
        public JalapenoTopping(BasePizza pizzaToDecorate)
            : base(pizzaToDecorate)
        {
            myPrice = 1.49;
        }
    }
}