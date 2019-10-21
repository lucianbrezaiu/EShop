using EShop.Enums;

namespace EShop.Products.Headphones.Style
{
    public class OverTheEarHeadphones: HeadphonesDecorator
    {
        public OverTheEarHeadphones(IHeadphones decoratedHeadphones) : base(decoratedHeadphones)
        {
            decoratedHeadphones.Style = EStyle.OverTheEar;
            SetPrice();
        }

        public sealed override void SetPrice()
        {
            DecoratedHeadphones.Price += 15;
        }
    }
}