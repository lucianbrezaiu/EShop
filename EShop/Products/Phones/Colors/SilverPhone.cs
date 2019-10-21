using EShop.Enums;

namespace EShop.Products.Phones.Colors
{
    public class SilverPhone: PhoneDecorator
    {
        public SilverPhone(IPhone decoratedPhone) : base(decoratedPhone)
        {
            decoratedPhone.Color = EColor.Silver;
            SetPrice();
        }

        public sealed override void SetPrice()
        {
            DecoratedPhone.Price += 70;
        }
    }
}