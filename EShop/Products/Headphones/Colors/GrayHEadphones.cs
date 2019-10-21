using EShop.Enums;

namespace EShop.Products.Headphones.Colors
{
    public class GrayHeadphones:HeadphonesDecorator
    {
        public GrayHeadphones(IHeadphones decoratedHeadphones) : base(decoratedHeadphones)
        {
            decoratedHeadphones.Color = EColor.Gray;
            SetPrice();
        }

        public sealed override void SetPrice()
        {
            DecoratedHeadphones.Price += 5;
        }
    }
}