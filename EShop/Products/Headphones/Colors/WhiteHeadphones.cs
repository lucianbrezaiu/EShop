using EShop.Enums;

namespace EShop.Products.Headphones.Colors
{
    public class WhiteHeadphones:HeadphonesDecorator
    {
        public WhiteHeadphones(IHeadphones decoratedHeadphones) : base(decoratedHeadphones)
        {
            decoratedHeadphones.Color = EColor.White;
            SetPrice();
        }

        public sealed override void SetPrice()
        {
            DecoratedHeadphones.Price += 5;
        }
    }
}