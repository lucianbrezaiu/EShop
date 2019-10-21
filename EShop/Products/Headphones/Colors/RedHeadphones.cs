using EShop.Enums;

namespace EShop.Products.Headphones.Colors
{
    public class RedHeadphones:HeadphonesDecorator
    {
        public RedHeadphones(IHeadphones decoratedHeadphones) : base(decoratedHeadphones)
        {
            decoratedHeadphones.Color = EColor.Red;
            SetPrice();
        }

        public sealed override void SetPrice()
        {
            DecoratedHeadphones.Price += 10;
        }
    }
}