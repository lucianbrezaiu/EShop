using EShop.Enums;

namespace EShop.Products.Headphones.Style
{
    public class OnTheEarHeadphones : HeadphonesDecorator
    {
        public OnTheEarHeadphones(IHeadphones decoratedHeadphones) : base(decoratedHeadphones)
        {
            decoratedHeadphones.Style = EStyle.OnTheEar;
            SetPrice();
        }

        public sealed override void SetPrice()
        {
            DecoratedHeadphones.Price += 10;
        }
    }
}