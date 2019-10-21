using EShop.Enums;

namespace EShop.Products.Headphones.Connectivity
{
    public class WirelessHeadphones:HeadphonesDecorator
    {
        public WirelessHeadphones(IHeadphones decoratedHeadphones) : base(decoratedHeadphones)
        {
            decoratedHeadphones.Connectivity = EConnectivity.Wireless;
            SetPrice();
        }

        public sealed override void SetPrice()
        {
            DecoratedHeadphones.Price += 40;
        }
    }
}