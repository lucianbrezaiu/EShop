using EShop.Enums;

namespace EShop.Products.Headphones.Style
{
    public class SportHeadphones: HeadphonesDecorator
    {
        public SportHeadphones(IHeadphones decoratedHeadphones) : base(decoratedHeadphones)
        {
            decoratedHeadphones.Style = EStyle.Sport;
            SetPrice();
        }

        public sealed override void SetPrice()
        {
            DecoratedHeadphones.Price += 20;
        }
    }
}