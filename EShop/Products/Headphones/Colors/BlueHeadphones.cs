using EShop.Enums;

namespace EShop.Products.Headphones.Colors
{
    public class BlueHeadphones:HeadphonesDecorator
    {
        public BlueHeadphones(IHeadphones decoratedHeadphones) : base(decoratedHeadphones)
        {
            decoratedHeadphones.Color = EColor.Blue;
            SetPrice();
        }

        public sealed override void SetPrice()
        {
            DecoratedHeadphones.Price += 10;
        }
    }
}