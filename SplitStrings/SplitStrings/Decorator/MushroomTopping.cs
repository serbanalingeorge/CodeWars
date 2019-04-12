namespace SplitStrings.Decorator
{
    public class MushroomTopping : ToppingsDecorator
    {
        public MushroomTopping(BasePizza pizzaToDecorate)
            : base(pizzaToDecorate)
        {
            myPrice = 1.49;
        }
    }
}